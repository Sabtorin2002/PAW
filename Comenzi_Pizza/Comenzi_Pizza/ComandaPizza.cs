using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comenzi_Pizza
{
    internal class ComandaPizza:ExceptieIndex,ICustomizabil, ICloneable
    {
        private string nume;
        private string blat;
        private int durataRealizare;
        private List<Topping> listaTopping;
        private static readonly float pretStandard = 10;

        public string Nume
        {
            get { return nume; }
            set { nume = value;}
        }

        public int Durata
        {
            get
            {
                return durataRealizare;
            }
            set { durataRealizare = value; }
        }
        
        public string Blat
        {
            get { return blat; }
            set { blat = value; }
        }

        public List<Topping> ListaTopping
        {
            get { return listaTopping; }
            set
            {
                listaTopping = value;
            }
        }

        public ComandaPizza(string nume, string blat, int durataRealizare, List<Topping> listaTopping)
        {
            this.nume = nume;
            this.blat = blat;
            this.durataRealizare=durataRealizare;
            this.listaTopping = listaTopping;
        }
        public ComandaPizza()
        {
            this.nume = null;
            this.blat = null;
            this.durataRealizare = 0;
            this.listaTopping = null;
        }

        public Topping this[int index]
        {
            get
            {
                if (index >= 0 && index < listaTopping.Count)
                {
                    return listaTopping[index];
                }
                else
                    throw new ExceptieIndex();
            }

            set
            {
                listaTopping[index] = value;
            }
        }
            

        public float CalculCostPizza()
        {
            float suma = 0;
            foreach(Topping topping in this.listaTopping)
            {
                suma = topping.Pret * topping.Cantitate;
            }

            return suma+pretStandard;
        }

        public static bool operator<(ComandaPizza cp1, ComandaPizza cp2)
        {
            float suma1 = cp1.CalculCostPizza();
            float suma2 = cp2.CalculCostPizza();
            if (suma1 < suma2)
            {
                return true;
            }
            else 
                return false;
        }
        public static bool operator >(ComandaPizza cp1, ComandaPizza cp2)
        {
            float suma1 = cp1.CalculCostPizza();
            float suma2 = cp2.CalculCostPizza();
            if (suma1 > suma2)
            {
                return true;
            }
            else
                return false;
        }

        public object Clone()
        {
            throw new ExceptieIndex();
        }

        public override string ToString()
        {
            string mesajAfisare = "";
            mesajAfisare += "Nume" + nume + " are blatul " + blat + " pregatita in " + durataRealizare;
            if (this.listaTopping.Count > 0)

            {
                foreach (Topping topping in listaTopping)
                {
                    mesajAfisare += " " + topping.ToString();
                }
            }
            return mesajAfisare;
        }

    }
}
