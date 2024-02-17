using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biciclete
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAfisareGrafic_Click(object sender, EventArgs e)
        {
            foreach(Bicicleta b in Form1.listaBiciclete)
            {
                grafic.Series["KM"].Points.AddXY(b.CodB, b.KM_parcursi);
            }
            //grafic.DataBind();
        }
    }
}
