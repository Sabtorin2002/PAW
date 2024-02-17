using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToataMateria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tbAfisareForm2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            foreach(Produs produs in Form1.listaProduse)
            {
                tbAfisareForm2.Text += produs.ToString() + Environment.NewLine;
            }
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            foreach(Produs produs in Form1.listaProduse)
            {
                grafic.Series["Pret"].Points.AddXY(produs.Nume.ToString(), produs.Id.ToString());
            }
        }
    }
}
