using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferinteBibliografice
{
    internal abstract class Publicatie
    {
        private string titlu;
        private float pret;

        public abstract string genereazaReferinta();

        public string Titlu
        {
            get { return titlu; }
            set { titlu = value; }
        }

        public float Pret
        {
            get { return pret; } 
            set {  pret = value; } 
        }

        public override string ToString()
        {
            return "Titlul " + this.titlu + " are pretul " + this.pret ;
        }
    }
}
