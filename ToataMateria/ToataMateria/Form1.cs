using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace ToataMateria
{
    public partial class Form1 : Form
    {
        public static List<Produs>listaProduse=new List<Produs>();
        List<Produs>listaProduseNoi=new List<Produs>();
        List<Supermarket>listaSupermarket=new List<Supermarket>();
        List<Produs> listaProduseTXT=new List<Produs>();
        Produs p;
        Supermarket s;
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=etc;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlDataAdapter adapter = null;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdaugaProdus_Click(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
            //if (tbID.Text == "")
            //    errorProvider1.SetError(tbID, "Incearca din nou");
            //if (tbNume.Text == "")
            //    errorProvider1.SetError(tbNume, "Incearca din nou");
            //if (tbCantitate.Text == "")
            //    errorProvider1.SetError(tbCantitate, "Incearca din nou");
            //if (tbPret.Text == "")
            //    errorProvider1.SetError(tbPret, "Incearca din nou");
            errorProvider1.Clear();
            if (tbID.Text == "")
                errorProvider1.SetError(tbID, "Mai incearca");
            if (tbPret.Text == "")
                errorProvider1.SetError(tbPret, "Mai incearca");
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Mai incearca");
            if (tbCantitate.Text == "")
                errorProvider1.SetError(tbCantitate, "Mai incearca");
            try 
            {
                int id=Convert.ToInt32(tbID.Text);
                string nume=tbNume.Text;
                int cantitate = Convert.ToInt32(tbCantitate.Text);
                float pret = float.Parse(tbPret.Text);

                this.p= new Produs(id,nume, cantitate,pret);
                listaProduse.Add(this.p);

                float valProdus = 0;
                valProdus = p.Valoare();
                tbValoare.Text=valProdus.ToString();

            }catch(Exception ex)
            {
                MessageBox.Show("Eroare");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            foreach(Produs produs in listaProduse)
            {
                tbAfisareTB.Text += produs.ToString() + Environment.NewLine;
            }
        }

        private void btnAdaugaSupermarket_Click(object sender, EventArgs e)
        {
            string numeSupermarket = tbNumeSupermarket.Text;
            string locatie=cbLocatie.Text;
            int id = Convert.ToInt32(tbID.Text);
            string nume = tbNume.Text;
            int cantitate = Convert.ToInt32(tbCantitate.Text);
            float pret = float.Parse(tbPret.Text);

            p = new Produs(id, nume, cantitate, pret);
            foreach(Produs produs in listaProduse)
            {
                listaProduseNoi.Add(produs);
            }
            s = new Supermarket(listaProduseNoi, numeSupermarket, locatie);

            listaSupermarket.Add(s);
        }

        private void btnAfisareSupermarket_Click(object sender, EventArgs e)
        {
            foreach(Supermarket supermarket in listaSupermarket)
            {
                tbAfisareSupermarket.Text += supermarket.ToString()+Environment.NewLine;
            }
        }

        private void btnAfisareLV_Click(object sender, EventArgs e)
        {
            foreach(Produs produs in listaProduse)
            {
                ListViewItem item = new ListViewItem(produs.Id.ToString());
                item.SubItems.Add(produs.Nume.ToString());
                item.SubItems.Add(produs.Pret.ToString());
                item.SubItems.Add(produs.Cantitate.ToString());

                lvProduse.Items.Add(item);
            }
        }

        private void btnStergereLV_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in  lvProduse.Items)
            {
                if (item.Checked)
                    item.Remove();
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvProduse.Items)
            {
                string codString = tbIDCheck.Text;
                if (codString == item.SubItems[0].Text)
                {
                    item.Remove();
                }
            }
        }

        private void btnAdaugareDGV_Click(object sender, EventArgs e)
        {
            DataTable dgvProduse = new DataTable();
            DataColumn c0 = new DataColumn("ID");
            DataColumn c1 = new DataColumn("Nume");
            DataColumn c2 = new DataColumn("Pret");
            DataColumn c3 = new DataColumn("Cantitate");
            dgvProduse.Columns.Add(c0);
            dgvProduse.Columns.Add(c1);
            dgvProduse.Columns.Add(c2);
            dgvProduse.Columns.Add(c3);
            foreach(Produs produs in listaProduse)
            {
                DataRow row= dgvProduse.NewRow();
                row["ID"]=produs.Id.ToString();
                row["Nume"] = produs.Nume.ToString();
                row["Pret"]=produs.Pret.ToString();
                row["Cantitate"] = produs.Pret.ToString();

                dgvProduse.Rows.Add(row);
            }

            DataGridViewProduse.DataSource = dgvProduse;
        }

        private void btnAfisareTv_Click(object sender, EventArgs e)
        {
            tvProduse.Nodes.Add("<10");
            tvProduse.Nodes.Add(">=10");
            foreach(Produs produs in listaProduse)
            {
                if(produs.Pret<10)
                    tvProduse.Nodes[0].Nodes.Add(produs.ToString());
                else
                    tvProduse.Nodes[1].Nodes.Add(produs.ToString());
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("produs.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaProduse);
            fs.Close();
            MessageBox.Show("S-a salvat in fisier binar");
            tbAfisareTB.Clear();
            
        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs= new FileStream("produse.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            listaProduse.Clear();
            listaProduse=(List<Produs>)bf.Deserialize(fs);
            foreach(Produs produs in listaProduse)
            {
                tbAfisareTB.Text = produs.ToString();
            }
            fs.Close();
        }

        private void fisierTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog=new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw= new StreamWriter(saveFileDialog.FileName);
                foreach(Produs produs in listaProduse)
                {
                    sw.WriteLine(produs.ToString());
                }
                sw.Close();
            }
            tbAfisareTB.Clear();
        }

        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog=new OpenFileDialog();
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr= new StreamReader(openFileDialog.FileName);
                tbAfisareTB.Text += sr.ReadToEnd();
                sr.Close();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexiune.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Produse", conexiune);
            DataSet dataSet=new DataSet();
            adapter.Fill(dataSet);
            DataTable dt= dataSet.Tables[0];
            dataGridViewBD.DataSource = dt;
            conexiune.Close();

            ControlExtension.Draggable(label1, true);
            ControlExtension.Draggable(tbID, true);
            ControlExtension.Draggable(label2, true);

            this.KeyPreview = true;
            
        }

        private void citireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("D:\\Facultate\\!Anu 2 Sem II\\Programarea aplicatiilor Windows\\!EXAMEN pregatire\\ToataMateria\\ToataMateria\\bin\\Debug\\fisier.txt");
            string linie;
            while((linie=sr.ReadLine())!= null)
            {
                int id = Convert.ToInt32(linie.Split(',')[0]);
                string nume = linie.Split(',')[1];
                int cantitate = Convert.ToInt32(linie.Split(',')[2]);
                float pret = float.Parse(linie.Split(',')[3]);

                p = new Produs(id, nume, cantitate, pret);
                listaProduseTXT.Add(p);
            }

            foreach(Produs produs in listaProduseTXT)
            {
                tbProduseTXT.Text += produs.ToString();
            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbAfisareTB.Text);
        }

        private void btnImprimare_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Black);
            Font font = new Font("Times New Roman", 14);
            PointF pointF = new PointF(100, 100);

            foreach(Produs produs in listaProduse)
            {
                g.DrawString(produs.ToString(), font, brush, pointF);
                pointF.Y += 30;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control==true && e.KeyCode==Keys.X)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            if(e.Control==true && e.KeyCode==Keys.Z)
            {
                this.Close();
            }
            if(e.Alt==true)
            {
                afisareToolStripMenuItem.PerformClick();
            }
        }

        private void afisareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut");
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            string text1 = "Marcel";
            string text2 = "piramida";
            if(text1==tbUsername.Text && text2==tbParola.Text)
            {
                Form f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Username sau parola gresita");
            }
        }

        private void btnAfisareListBox_Click(object sender, EventArgs e)
        {   
            listBox1.Items.Clear();
            foreach(Produs produs in listaProduse)
            {
                listBox1.Items.Add(produs);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex != -1)
            //{ listBox1.Items.RemoveAt(listBox1.SelectedIndex); }

            if(listBox1.SelectedIndex!=-1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Produs produs in listaProduse)
            {
                ListViewItem item = new ListViewItem(produs.Id.ToString());
                item.SubItems.Add(produs.Nume.ToString());
                item.SubItems.Add(produs.Cantitate.ToString());
                item.SubItems.Add(produs.Pret.ToString());

                lvProduse.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dgvProduse= new DataTable();
            DataColumn c0=new DataColumn("ID");
            DataColumn c1 = new DataColumn("Nume");
            DataColumn c2 = new DataColumn("Cantitate");
            DataColumn c3 = new DataColumn("Pret");
            dgvProduse.Columns.Add(c0);
            dgvProduse.Columns.Add(c1);
            dgvProduse.Columns.Add (c2);
            dgvProduse.Columns.Add(c3);
            
            foreach(Produs produs in listaProduse)
            {
                DataRow row=dgvProduse.NewRow();
                row["ID"]=produs.Id.ToString();
                row["Nume"]=produs.Nume.ToString();
                row["Cantitate"]=produs.Cantitate.ToString();
                row["Pret"]=produs.Pret.ToString();

                dgvProduse.Rows.Add(row);
            }

            DataGridViewProduse.DataSource = dgvProduse;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Produs produs in listaProduse)
            {
                listBox1.Items.Add(produs);
            }
        }
    }
}
