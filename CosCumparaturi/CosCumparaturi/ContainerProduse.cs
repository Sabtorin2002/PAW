using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosCumparaturi
{
    internal class ContainerProduse
    {
        Produs[] produse;

        public ContainerProduse(Produs[] produse)
        {
            this.produse = produse;
        }

        public Produs[] Produse { get { return produse; }
            set { produse = value; }
        }

        public static ContainerProduse operator+(ContainerProduse cp, Produs p)
        {
            Produs[] vectorCopie = new Produs[cp.produse.Length];
            for(int i=0;i<cp.produse.Length;i++)
                vectorCopie[i]= cp.produse[i];

            cp.Produse = new Produs[vectorCopie.Length + 1];
            for(int i=0;i<vectorCopie.Length;i++)
                cp.produse[i]= vectorCopie[i];

            cp.produse[cp.produse.Length - 1] = p;
            

            return cp;
        }
    }
}
