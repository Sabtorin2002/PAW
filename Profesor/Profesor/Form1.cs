using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace Profesor
{
    public partial class Form1 : Form
    {
        List<Profesor> listaProfesori = new List<Profesor>();
        Profesor p;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            ControlExtension.Draggable(label1, true);
            ControlExtension.Draggable(label2, true);
            ControlExtension.Draggable(label3, true);
            ControlExtension.Draggable(tbMarca, true);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tbMarca.Text == "")
            {
                errorProvider1.SetError(tbMarca, "Mai incearca");
            }
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Mai incearca");
            }
            if (tbSalariu.Text == "")
            {
                errorProvider1.SetError(tbSalariu, "Mai incearca");
            }
            try
            {
                int marca = Convert.ToInt32(tbMarca.Text);
                string nume = tbNume.Text;
                double salariul = Convert.ToDouble(tbSalariu.Text);
                Profesor p = new Profesor(marca, nume, salariul);
                listaProfesori.Add(p);
                double salariuProfesor = 0;
                salariuProfesor = p.Premiere();
                string salariuProf = Convert.ToString(salariuProfesor);
                tbNou.Text = salariuProf;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erorare");
            }

        }

        private void btnAfisareDGV_Click(object sender, EventArgs e)
        {
            DataTable profesoriDGV = new DataTable();
            DataColumn c0 = new DataColumn("Marca");
            DataColumn c1 = new DataColumn("Nume");
            DataColumn c2 = new DataColumn("Salariu");
            profesoriDGV.Columns.Add(c0);
            profesoriDGV.Columns.Add(c1);
            profesoriDGV.Columns.Add(c2);
            foreach (Profesor profesor in listaProfesori)
            {
                DataRow row = profesoriDGV.NewRow();
                row["Marca"] = profesor.Marca.ToString();
                row["Nume"] = profesor.Nume.ToString();
                row["Salariu"] = profesor.Salariu.ToString();

                profesoriDGV.Rows.Add(row);
            }

            DataGridView.DataSource = profesoriDGV;

        }

        private void btnAfiseazaLV_Click(object sender, EventArgs e)
        {
            foreach (Profesor profesor in listaProfesori)
            {
                ListViewItem item = new ListViewItem(profesor.Nume.ToString());
                item.SubItems.Add(profesor.Marca.ToString());
                item.SubItems.Add(profesor.Salariu.ToString());

                lvProfesori.Items.Add(item);

            }
        }

        private void btnAdaugareTV_Click(object sender, EventArgs e)
        {
            profesorTV.Nodes.Add("<5000");
            profesorTV.Nodes.Add(">=5000");

            foreach (Profesor profesor in listaProfesori)
            {
                if (profesor.Salariu < 5000)
                    profesorTV.Nodes[0].Nodes.Add(profesor.Marca.ToString(), profesor.Nume);
                else
                    profesorTV.Nodes[1].Nodes.Add(profesor.Marca.ToString(), profesor.Nume);
            }
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
            PointF pointF = new PointF(10, 10);

            foreach (Profesor profesor in listaProfesori)
            {
                g.DrawString(profesor.ToString(), font, brush, pointF);
                pointF.Y += 30;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAfisareTB_Click(object sender, EventArgs e)
        {
            foreach (Profesor profesor in listaProfesori)
            {
                tbAfisare.Text += profesor.ToString() + Environment.NewLine;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                this.Close();
            }
            if (e.Control == true && e.KeyCode == Keys.K)
            {
                afisareToolStripMenuItem.PerformClick();
            }
        }

        private void afisareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut");
        }

        private void btnCalculare_Click(object sender, EventArgs e)
        {
            double valoare = Convert.ToDouble(tbValoare.Text);
            double suma = 0;
            foreach (Profesor profesor in listaProfesori)
            {
                suma += profesor.Salariu + valoare;
            }

            tbTotal.Text = Convert.ToString(suma);

        }

        private void tbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void binarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("profesori.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaProfesori);
            fs.Close();
            tbAfisare.Clear();

        }

        private void restaurareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("profesori.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            listaProfesori.Clear();
            listaProfesori = (List<Profesor>)bf.Deserialize(fs);
            foreach (Profesor profesor in listaProfesori)
            {
                tbAfisare.Text += profesor.ToString() + Environment.NewLine;
            }
            fs.Close();
        }

        private void salvareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                foreach (Profesor profesor in listaProfesori)
                {
                    sw.WriteLine(profesor.ToString());
                }
                sw.Close();
                tbAfisare.Clear();
            }

        }

        private void restaurareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                tbAfisare.Text += sr.ReadToEnd();
                sr.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable profesoriDGV = new DataTable();
            DataColumn c0 = new DataColumn("Marca");
            DataColumn c1 = new DataColumn("Nume");
            DataColumn c2 = new DataColumn("Salariu");
            profesoriDGV.Columns.Add(c0);
            profesoriDGV.Columns.Add(c1);
            profesoriDGV.Columns.Add(c2);
            foreach (Profesor profesor in listaProfesori)
            {
                DataRow row = profesoriDGV.NewRow();
                row["Marca"] = profesor.Marca.ToString();
                row["Nume"] = profesor.Nume.ToString();
                row["Salariu"] = profesor.Salariu.ToString();

                profesoriDGV.Rows.Add(row);
            }

            DataGridView.DataSource = profesoriDGV;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable profesoriDGV = new DataTable();
            DataColumn c0 = new DataColumn("Marca");
            DataColumn c1 = new DataColumn("Nume");
            DataColumn c2 = new DataColumn("Salariu");
            profesoriDGV.Columns.Add(c0);
            profesoriDGV.Columns.Add(c1);
            profesoriDGV.Columns.Add(c2);
            foreach (Profesor profesor in listaProfesori)
            {
                DataRow row = profesoriDGV.NewRow();
                row["Marca"] = profesor.Marca.ToString();
                row["Nume"] = profesor.Nume.ToString();
                row["Salariu"] = profesor.Salariu.ToString();

                profesoriDGV.Rows.Add(row);
            }

            DataGridView.DataSource = profesoriDGV;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable profesoriDGV = new DataTable();
            DataColumn c0 = new DataColumn("Marca");
            DataColumn c1 = new DataColumn("Nume");
            DataColumn c2 = new DataColumn("Salariu");
            profesoriDGV.Columns.Add(c0);
            profesoriDGV.Columns.Add(c1);
            profesoriDGV.Columns.Add(c2);

            foreach (Profesor profesor in listaProfesori)
            {
                DataRow row = profesoriDGV.NewRow();
                row["Marca"] = profesor.Marca.ToString();
                row["Nume"] = profesor.Nume.ToString();
                row["Salariu"] = profesor.Salariu.ToString();

                profesoriDGV.Rows.Add(row);
            }

            DataGridView.DataSource = profesoriDGV;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Profesor profesor in listaProfesori)
            {
                ListViewItem item = new ListViewItem(profesor.Marca.ToString());
                item.SubItems.Add(profesor.Nume.ToString());
                item.SubItems.Add(profesor.Salariu.ToString());

                lvProfesori.Items.Add(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Profesor profesor in listaProfesori)
            {
                ListViewItem item = new ListViewItem(profesor.Nume.ToString());
                item.SubItems.Add(profesor.Marca.ToString());
                item.SubItems.Add(profesor.Salariu.ToString());

                lvProfesori.Items.Add(item);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Profesor profesor in listaProfesori)
            {
                ListViewItem item = new ListViewItem(profesor.Marca.ToString());
                item.SubItems.Add(profesor.Nume.ToString());
                item.SubItems.Add(profesor.Salariu.ToString());

                lvProfesori.Items.Add(item);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable profesoriDGV = new DataTable();
            DataColumn c0 = new DataColumn("Marca");
            DataColumn c1 = new DataColumn("Nume");
            DataColumn c2 = new DataColumn("Salariu");
            profesoriDGV.Columns.Add(c0);
            profesoriDGV.Columns.Add(c1);
            profesoriDGV.Columns.Add(c2);

            foreach (Profesor profesor in listaProfesori)
            {
                DataRow row = profesoriDGV.NewRow();
                row["Marca"] = profesor.Marca.ToString();
                row["Nume"] = profesor.Nume.ToString();
                row["Salariu"] = profesor.Salariu.ToString();

                profesoriDGV.Rows.Add(row);
            }

            DataGridView.DataSource = profesoriDGV;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Profesor profesor in listaProfesori)
            {
                ListViewItem item = new ListViewItem(profesor.Marca.ToString());
                item.SubItems.Add(profesor.Nume.ToString());
                item.SubItems.Add(profesor.Salariu.ToString());

                lvProfesori.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            profesorTV.Nodes.Add("<10");
            profesorTV.Nodes.Add(">=10");

            foreach (Profesor profesor in listaProfesori)
            {
                if (profesor.Marca < 10)
                    profesorTV.Nodes[0].Nodes.Add(profesor.Nume.ToString());
                else
                    profesorTV.Nodes[1].Nodes.Add(profesor.Nume.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            profesorTV.Nodes.Add("<5000");
            profesorTV.Nodes.Add(">=5000");

            foreach (Profesor profesor in listaProfesori)
            {
                if (profesor.Salariu < 5000)
                    profesorTV.Nodes[0].Nodes.Add(profesor.Nume.ToString());
                else
                    profesorTV.Nodes[1].Nodes.Add(profesor.Nume.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            profesorTV.Nodes.Add("Nume cu T");
            profesorTV.Nodes.Add("Fara T");
            foreach (Profesor profesor in listaProfesori)
            {
                if (profesor.Nume.Contains('T'))
                    profesorTV.Nodes[0].Nodes.Add(profesor.Nume.ToString());
                else
                    profesorTV.Nodes[1].Nodes.Add(profesor.Nume.ToString());
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            printPreviewDialog2.Document = printDocument2;
            printPreviewDialog2.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.Black);
            Font font = new Font("Verdana", 12);
            PointF pointF = new PointF(100, 100);

            foreach (Profesor profesor in listaProfesori)
            {
                g.DrawString(profesor.ToString(), font, brush, pointF);
                pointF.Y += 30;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            printPreviewDialog3.Document = printDocument3;
            printPreviewDialog3.ShowDialog();
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush brush = new SolidBrush(Color.AliceBlue);
            Font font = new Font("Verdana ", 12);
            PointF pointF = new PointF(100, 100);

            foreach(Profesor profesor in listaProfesori)
            {
                g.DrawString(profesor.ToString(), font, brush, pointF);
                pointF.Y += 1500;
            }
        }
    }
}