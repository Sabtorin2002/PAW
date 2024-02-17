using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciclete
{
    [Serializable]
    public class Bicicleta
    {
        private int codB;
        private string statie_parcare;
        private int km_parcursi;

        public Bicicleta(int codB, string statie_parcare, int km_parcursi)
        {
            this.codB = codB;
            this.statie_parcare = statie_parcare;
            this.km_parcursi = km_parcursi;
        }

        public int CodB
        {
            get { return codB; }
            set { codB = value; }
        }

        public string Statie_parcare
        {
            get { return statie_parcare; }
            set { statie_parcare = value; }
        }

        public int KM_parcursi
        {
            get { return km_parcursi; }
            set { km_parcursi=value;}
        }

        public override string ToString()
        {
            string mesajAfisare = "Bicicleta cu codul " + codB + " in statia " + statie_parcare + " are " + km_parcursi;
            return mesajAfisare;
        }
    }
}
