using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferinteBibliografice
{
    internal class Autor
    {
        private string nume;
        private string grad;
        private readonly int marca;

        public Autor(string nume, string grad, int marca)
        {
            this.nume = nume;
            this.grad = grad;
            this.marca = marca;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Grad
        {
            get { return grad; }
            set { grad = value; }
        }

        public int Marca
        {
            get
            {
                return marca;
            }
        }

        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare = nume + " are gradul " + grad + " cu marca " + marca;
            return mesajAfisare;
        }
    }
}
