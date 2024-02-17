using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToataMateria
{
    [Serializable]
    public class Produs:IValoare,IComparable, ICloneable
    {
        private int id;
        private string nume;
        private int cantitate;
        private float pret;

        public Produs(int id, string nume, int cantitate, float pret)
        {
            this.id = id;
            this.nume = nume;
            this.cantitate = cantitate;
            this.pret = pret;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int Cantitate
        {
            get { return cantitate; }
            set { cantitate = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public override string ToString()
        {
            return nume + " are id-ul " + id + " in cantitate de " + cantitate + " si pretul " + pret;
        }

        //public int CompareTo(object obj)
        //{
        //    Produs produs=(Produs)obj;
        //    if (this.pret != produs.pret)
        //        return 1;
        //    else
        //        return 0;
        //}

        //public object Clone()
        //{
        //    Produs produsClone= new Produs(this.Id, this.nume, this.cantitate, this.pret);
        //    return produsClone;
        //}
        
        public float Valoare()
        {
            float val = 0;
            val = this.pret * this.cantitate;
            return val;
        }

        public static Produs operator++(Produs p)
        {
            if (p.pret > 0)
                p.pret++;
            return p;
        }

        public int CompareTo(object obj)
        {
            Produs produs=(Produs)obj;
            if (this.pret != produs.pret)
                return 1;
            else
                return 0;
        }

        public object Clone()
        {
            Produs produsClone=new Produs(id,nume,cantitate,pret);
            return produsClone;
        }

        public static Produs operator+(Produs p, float marire)
        {
            if (p.pret > 0)
                p.pret += marire;
            return p;
        }

        public static explicit operator float(Produs produs)
        {
            return produs.pret;
        }

        public static explicit operator int(Produs produs)
        {
            return produs.cantitate;
        }

        public static bool operator<(Produs p1, Produs p2)
        {
            if (p1.pret < p2.pret)
                return true;
            return false;
        }
        
        public static bool operator>(Produs p1, Produs p2)
        {
            if (p1.pret >p2.pret)
                return false;
            return true;
        }
    }
}
