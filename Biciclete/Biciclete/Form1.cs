using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biciclete
{
    public partial class Form1 : Form
    {
        public static List<Bicicleta> listaBiciclete = new List<Bicicleta>();
        public static List<Utilizator> listaUtilizatori = new List<Utilizator>();
        Utilizator u;
        Bicicleta b;
        public Form1()
        {
            InitializeComponent();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(tbCalculTarif,true);
        }

        private void btnAdaugaBiciclete_Click(object sender, EventArgs e)
        {
            int codBicicleta = Convert.ToInt32(tbCodBicicleta.Text);
            string statie_parcare=tbStatieParcare.Text;
            int KM=Convert.ToInt32(tbKM.Text);

            this.b= new Bicicleta(codBicicleta, statie_parcare, KM);
            MessageBox.Show(b.ToString());
            listaBiciclete.Add(this.b);
        }

        private void btnAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            string nume=tbNume.Text; ;
            int codUtilizator = Convert.ToInt32(tbCodUtilizator.Text);
            int durata =Convert.ToInt32(tbDurata.Text);

            this.u = new Utilizator(nume, codUtilizator, durata);
            MessageBox.Show(u.ToString());
            listaUtilizatori.Add(this.u);
        }

        private void btnPreluarelvB_Click(object sender, EventArgs e)
        {
            foreach(Bicicleta b in listaBiciclete)
            {
                ListViewItem item=new ListViewItem(b.CodB.ToString());
                item.SubItems.Add(b.Statie_parcare);
                item.SubItems.Add(b.KM_parcursi.ToString());

                lvBiciclete.Items.Add(item);
            }
        }

        private void btnPreluarelvU_Click(object sender, EventArgs e)
        {
            foreach(Utilizator u in  listaUtilizatori)
            {
                ListViewItem item = new ListViewItem(u.Nume);
                item.SubItems.Add(u.CodB.ToString());
                item.SubItems.Add(u.DurataUtilizare.ToString());

                lvUtilizatori.Items.Add(item);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lvBiciclete.Items)
            {
                string codB = item.SubItems[0].Text;
                foreach(ListViewItem item2 in lvUtilizatori.Items)
                {
                    string codU = item2.SubItems[1].Text;
                    if(item.Checked &&  codB == codU)
                    {
                        item2.Remove();
                    }
                }
            }
        }

        private void btnAfisareBicicleteTB_Click(object sender, EventArgs e)
        {
            foreach(Bicicleta b in listaBiciclete)
            {
                tbAfisareTot.Text+=b.ToString()+ Environment.NewLine;
            }

            foreach(Utilizator u in listaUtilizatori)
            {
                tbAfisareTot.Text +=u.ToString()+ Environment.NewLine;
            }
        }

        private void btnCalculareSuma_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach(ListViewItem item in lvBiciclete.Items)
            {
                if(item.Checked)
                {
                    foreach(Utilizator utilizator in listaUtilizatori)
                    {
                        string codBBicicleta = item.SubItems[0].Text;
                        string codBUtilizator=u.ToString();
                        
                        if(codBBicicleta==codBUtilizator)
                        {
                            if(u.DurataUtilizare>30)
                            {
                                for(int i=40;i<=u.DurataUtilizare;i=i+10)
                                {
                                    suma = suma + 2;
                                }
                            }
                        }
                    }
                }
            }
            tbCalculTarif.Text = Convert.ToString(suma);
        }

        private void bicicleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("biciclete.dat", FileMode.Create,
                FileAccess.Write);
            BinaryFormatter bf= new BinaryFormatter();
            bf.Serialize(fs, listaBiciclete);
            fs.Close();
            //lvBiciclete.Items.Clear();
        }

        private void utilizatoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("utilizatori.dat", FileMode.Create,
                FileAccess.Write);
            BinaryFormatter bf= new BinaryFormatter();
            bf.Serialize(fs, listaUtilizatori);
            fs.Close();
            lvUtilizatori.Items.Clear();
        }

        private void bicicleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("biciclete.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf= new BinaryFormatter();
            listaBiciclete.Clear();
            listaBiciclete = (List<Bicicleta>)bf.Deserialize(fs);
            foreach(Bicicleta b in listaBiciclete)
            {
                tbAfisareTot.Text+=b.ToString()+Environment.NewLine;
            }
            fs.Close();
        }

        private void utilizatoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs= new FileStream("utilizatori.dat", FileMode.Open,
                FileAccess.Read);
            BinaryFormatter bf= new BinaryFormatter();
            listaUtilizatori.Clear();
            listaUtilizatori = (List<Utilizator>)bf.Deserialize(fs);
            foreach(Utilizator u in listaUtilizatori)
            {
                tbAfisareTot.Text+=u.ToString()+Environment.NewLine;
            }
            fs.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Black);
            Font font = new Font("Times New Roman", 14);
            PointF pointF = new PointF(100, 100);

            foreach(Utilizator u in listaUtilizatori)
            {
                g.DrawString(u.ToString(),font, brush, pointF);
                pointF.Y += 30;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Right) 
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void btnAdaugaTv_Click(object sender, EventArgs e)
        {
            tvBiciclete.Nodes.Add("<=30");
            tvBiciclete.Nodes.Add(">30");
            foreach(Bicicleta b in listaBiciclete)
            {
                if (b.KM_parcursi <= 30)
                {
                    tvBiciclete.Nodes[0].Nodes.Add(b.CodB.ToString(), b.Statie_parcare);
                }
                else
                    tvBiciclete.Nodes[1].Nodes.Add(b.CodB.ToString(), b.Statie_parcare);
            }
        }
    }
}
