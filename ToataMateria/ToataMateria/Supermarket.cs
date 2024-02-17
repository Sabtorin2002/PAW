using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToataMateria
{
    [Serializable]
    public class Supermarket :IComparable, ICloneable
    {
        private List<Produs> listaProduse;
        private string numeSupermarket;
        private string locatie;

        public Supermarket(List<Produs> listaProduse, string numeSupermarket, string locatie)
        {
            this.listaProduse = listaProduse;
            this.numeSupermarket = numeSupermarket;
            this.locatie = locatie;
        }

        public string NumeSupermarket
        {
            get { return numeSupermarket; }
            set { numeSupermarket = value; }
        }

        public string Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        public List<Produs> ListaProduse
        { 
            get { return listaProduse; } 
            set { listaProduse = value; } 
        }

        public Produs this[int index]
        {
            get
            {
                if (index >= 0 && index < listaProduse.Count)
                {
                    return listaProduse[index];
                }
                else
                    throw new ExceptieIndex();
            }
            set
            {
                listaProduse[index] = value;
            }
        }

        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare+=numeSupermarket+" localizat in "+ locatie+" are urmatoare produse :";
            foreach(Produs p in listaProduse)
            {
                mesajAfisare+= p.ToString()+" ";
            }

            return mesajAfisare;
        }

        public int ComparteTo(object obj)
        {
            Supermarket supermarket=(Supermarket)obj;
            if (this.numeSupermarket.Equals(supermarket.NumeSupermarket))
                return 1;
            else
                return 0;
        }

        public object Clone()
        {
            Supermarket supermarketClone= new Supermarket(ListaProduse,numeSupermarket,locatie);
            return supermarketClone;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    } 
}
