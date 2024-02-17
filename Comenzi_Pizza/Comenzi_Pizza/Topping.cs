using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comenzi_Pizza
{
    internal class Topping
    {
        private string denumire;
        private float pret;
        private float cantitate;
        private int cod;

        public Topping(string denumire, float pret, float cantitate, int cod)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
            this.cod = cod;
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public float Cantitate
        {
           get
            { return cantitate; }
            set
            {
                cantitate = value;
            }
        }

        public int Cod
        {
            get { return cod;}
            set { cod = value; }
        }

        public override string ToString()
        {
            return denumire + " are pretul " + pret + " in cantitate de " + cantitate + "cu codul " + cod;
        }
    }
}
