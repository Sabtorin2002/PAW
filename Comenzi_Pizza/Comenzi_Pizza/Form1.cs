
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comenzi_Pizza
{
    public partial class Form1 : Form
    {
        List<Topping> listaToppinguri = new List<Topping>();
        List<ComandaPizza> listaComenzi = new List<ComandaPizza>();
        ComandaPizza cp;
        Topping t;
        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlDataAdapter adapter = null;
        public Form1()
        {
            cp = new ComandaPizza();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //conn.Open();
            //adapter = new SqlDataAdapter("SELECT * from Topping", conn);
            //DataSet dataset = new DataSet();
            //adapter.Fill(dataset);
            //DataTable dt = dataset.Tables[0];
            //dgvTopping.DataSource = dt;
            //conn.Close();
        }

        private void btnAdaugaTopping_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            float pret = float.Parse(tbPret.Text);
            float cantitate = float.Parse(tbCantitate.Text);
            int cod = Convert.ToInt32(tbCod.Text);
            Topping topping = new Topping(nume, pret, cantitate, cod);

            listaToppinguri.Add(topping);
            MessageBox.Show(topping.ToString());
        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            try
            {
                string nume = tbNumeComanda.Text;
                string blat = cbBlatComanda.Text;
                int durata = Convert.ToInt32(tbDurataComanda.Text);
                string[] codString = tbCodComanda.Text.Split(',');
                int[] cod = new int[codString.Length];
                for (int i = 0; i < codString.Length; i++)
                {
                    cod[i] = Convert.ToInt32(codString[i]);
                }

                List<Topping> provizoriu = new List<Topping>();
                cp = new ComandaPizza(nume, blat, durata, provizoriu);
                foreach (Topping topping in listaToppinguri)
                {
                    for (int i = 0; i < cod.Length; i++)
                    {
                        if (topping.Cod == cod[i])
                        {
                            cp.ListaTopping.Add(topping);
                        }
                    }
                }
                listaComenzi.Add(cp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ComandaPizza comandaPizza in listaComenzi)
            {
                tbAfisareComenzi.Text += comandaPizza.ToString() + Environment.NewLine;
            }
        }

        private void btnPreluareTV_Click(object sender, EventArgs e)
        {
            tvComenzi.Nodes.Add("Gros");
            tvComenzi.Nodes.Add("Subire");
            tvComenzi.Nodes.Add("Italian");
            tvComenzi.Nodes.Add("Barcuta");
            foreach (ComandaPizza cp in listaComenzi)
            {
                if (cp.Blat.Equals("Gros"))
                {
                    tvComenzi.Nodes[0].Nodes.Add(cp.Nume);
                }

                if (cp.Blat.Equals("Subtire"))
                {
                    tvComenzi.Nodes[1].Nodes.Add(cp.Nume);
                }
                if (cp.Blat.Equals("Italian"))
                {
                    tvComenzi.Nodes[2].Nodes.Add(cp.Nume);
                }

                if (cp.Blat.Equals("Barcuta"))
                {
                    tvComenzi.Nodes[3].Nodes.Add(cp.Nume);
                }
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("D:\\Facultate\\!Anu 2 Sem II\\Programarea aplicatiilor Windows\\!EXAMEN pregatire\\Comenzi_Pizza\\Comenzi_Pizza\\fisier.txt");
            string linie;
            while ((linie = sr.ReadLine()) != null)
            {
                try
                {
                    string nume = linie.Split(',')[0];
                    string blat = linie.Split(',')[1];
                    int durata = Convert.ToInt32(linie.Split(',')[2]);
                    List<Topping> toppings = new List<Topping>();

                    ComandaPizza comandaPizza = new ComandaPizza(nume, blat, durata, toppings);
                    listaComenzi.Add(comandaPizza);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            foreach (ComandaPizza cp in listaComenzi)
            {
                tbAfisareComenzi.Text += cp + Environment.NewLine;
            }
        }

        private void citireSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvTopping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAfisareGridView_Click(object sender, EventArgs e)
        {
            //DataTable toppinguri = new DataTable();
            //DataColumn c0 = new DataColumn("Denumire");
            //DataColumn c1 = new DataColumn("Pret");
            //DataColumn c2 = new DataColumn("Cantitate");
            //DataColumn c3 = new DataColumn("Cod");
            //toppinguri.Columns.Add(c0);
            //toppinguri.Columns.Add(c1);
            //toppinguri.Columns.Add(c2);
            //toppinguri.Columns.Add(c3);

            //foreach (Topping topping in listaToppinguri)
            //{
            //    DataRow row = toppinguri.NewRow();
            //    row["Denumire"] = topping.Denumire.ToString();
            //    row["Pret"] = topping.Denumire.ToString();
            //    row["Cantitate"] = topping.Cantitate.ToString();
            //    row["Cod"] = topping.Cantitate.ToString();

            //    toppinguri.Rows.Add(row);
            //}

            //dgvTopping.DataSource = toppinguri;
            //string numeT = dgvTopping.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}