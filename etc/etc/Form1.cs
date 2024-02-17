using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etc
{
    public partial class Form1 : Form
    {
        SqlConnection conexiune = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=etc;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlDataAdapter SqlDataAdapter = null;
        SqlDataAdapter SqlDataAdapter2 = null;
        Persoana p;
        List<Persoana> listaPersoane=new List<Persoana>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;//shortcut

            conexiune.Open();
            SqlDataAdapter = new SqlDataAdapter("Select * from Persoane", conexiune);
            DataSet dataSet = new DataSet();
            SqlDataAdapter.Fill(dataSet);
            DataTable dt = dataSet.Tables[0];
            dgvPersoane.DataSource = dt;

            conexiune.Close();


          
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode==Keys.S)
            {
               afiseazaToolStripMenuItem.PerformClick();

            }
            if(e.Control== true && e.KeyCode==Keys.X)
            {
                this.Close();
            }
        }

        private void afiseazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Shortcut");
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvPersoane.Rows[e.RowIndex].Cells[0].Value.ToString());
                string nume = dgvPersoane.Rows[e.RowIndex].Cells[1].Value.ToString();
                int varsta = Convert.ToInt32(dgvPersoane.Rows[e.RowIndex].Cells[2].Value.ToString());
                p = new Persoana(id, nume, varsta);
                listaPersoane.Add(p);

            }catch(Exception ex) 
            {
                MessageBox.Show("Eroare");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Persoana persoana in listaPersoane)
            {
                ListViewItem item = new ListViewItem(persoana.ID.ToString());
                item.SubItems.Add(persoana.Nume.ToString());
                item.SubItems.Add(persoana.Varsta.ToString());
                Console.WriteLine("muie");

                lvPersoane.Items.Add(item);
            }
        }

        private void btnDGVTopping_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            foreach(Persoana p in listaPersoane)
            {
                grafic.Series["varsta"].Points.AddXY(p.ID, p.Nume);
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Form f2 = new Form();
                f2.Show();
            }
        }
    }
}
