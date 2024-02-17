using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etc
{
    internal class Persoana
    {
        private int id;
        private string nume;
        private int varsta;

        public Persoana(int id, string nume, int varsta)
        {
            this.id = id;
            this.nume = nume;
            this.varsta = varsta;
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

        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }

        public override string ToString()
        {
            return "Persoana cu ID-ul "+ id+" are numele "+ nume+ " si varsta"+ varsta;
        }
    } 
}
