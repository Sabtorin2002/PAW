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

namespace TestSQL
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=etc;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        SqlDataAdapter adapter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM Laptop",connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable dt = dataSet.Tables[0];
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
