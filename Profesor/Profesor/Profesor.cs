using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    [Serializable]
    internal class Profesor:IPremiere
    {
        private int marca;
        private string nume;
        private double salariu;

        public Profesor(int marca,  string nume, double salariu)
        {
            this.marca = marca;
            this.nume = nume;
            this.salariu = salariu;
        }

        public int Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
               nume = value;
            }
        }

        public double Salariu
        {
            get { return salariu; }
            set { salariu = value; }
        }

        public override string ToString()
        {
            return nume + " are marca " + marca + " si salariul " + salariu;
        }

        public static double operator+(Profesor p, double marire)
        {
            if (p.salariu > 0)
                p.salariu += marire;
            return p.salariu;
        }
        
        public double Premiere()
        {
            double salariuP = 0;
            salariuP = this.salariu + (this.salariu * 0.3);
            return salariuP;
        }

        
    }
}
