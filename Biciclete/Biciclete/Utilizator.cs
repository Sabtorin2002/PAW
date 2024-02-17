using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biciclete
{
    [Serializable]
    public class Utilizator
    {
        private string nume;
        private int codB;
        private int durataUtilizare;

        public Utilizator(string nume, int codB, int durataUtilizare)
        {
            this.nume = nume;
            this.codB = codB;
            this.durataUtilizare = durataUtilizare;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int CodB
        {
            get
            {
                return codB;
            }
            set { codB = value; }
        }

        public int DurataUtilizare
        {
            get { return durataUtilizare; }
            set { durataUtilizare = value; }
        }

        public override string ToString()
        {
            string mesajAfisare = "Utilizatorul " + nume + " are codul " + codB + " si a folosit bicicleta " + durataUtilizare;
            return mesajAfisare;
        }
        public float Calcul()
        {
            float suma=0;
            if(this.durataUtilizare > 30)
            {
                suma = this.durataUtilizare-30;
            }
            else
            {
                suma = 0;
            }
            return suma;
        }

    }

}
