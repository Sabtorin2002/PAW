using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    internal class Produs
    {
        private int id;
        private string nume;
        private int pret;
        private int cantitate;

        public Produs(int id, string nume, int pret, int cantitate)
        {
            this.id = id;
            this.nume = nume;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }

        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare += nume + " are id-ul " + id + "cu pretul " + pret + " in cantitate de " + cantitate;
            return mesajAfisare;
        }

        public int valoare()
        {
            int val = 0;
            val = this.cantitate * this.pret;
            return val;
        }
    }
}
