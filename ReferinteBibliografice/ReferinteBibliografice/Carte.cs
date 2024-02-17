using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReferinteBibliografice
{
    internal class Carte:Publicatie,IComparable, ICloneable
    {
        private const string ISBN="ISBN";
        private string categorie;
        private List<Autor> listaAutori;

        public string Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }

        public List<Autor> ListaAutori
        {
            get { return listaAutori; }
            set { listaAutori = value; }
        }

        public string isbn
        {
            get { return isbn; }
        }

        public override string genereazaReferinta()
        {
            string mesaj="";
            foreach(Autor autor in listaAutori) 
            {
                mesaj += autor.ToString()+" ";
            }
            mesaj += " - " + this.Titlu + " , " + this.isbn;

            return mesaj;
        }

        public Carte(string categorie, List<Autor> listaAutori, string titlu, float pret)
        {
            //fara setteri pentru ca ne referim la clasa curenta
            this.categorie = categorie;
            this.listaAutori = listaAutori;
            //se apeleaza seterii pentru membrii clasei
            this.Titlu = titlu;
            this.Pret = pret;
        }

        public static Carte operator+(Carte carte, Autor autor)
        {
           List<Autor>listaNoua=new List<Autor>(carte.ListaAutori);
           listaNoua.Add(autor);
           carte.listaAutori=listaNoua;

            return carte;
        }

        public static explicit operator float(Carte carte)
        {
            return carte.Pret;
        }
        
        //public int CompareTo(object obj)
        //{
        //    Carte carte = (Carte)obj;

        //    if(this.Pret<carte.Pret)
        //    {
        //        return -1;
        //    }
        //    if(this.Pret==carte.Pret)
        //    {
        //        return 0;
        //    }

        //    return 1;
        //}


        //compareTo returneaza numai int
        public int CompareTo(object obj)
        {
            Carte carte=(Carte)obj;

            if (this.Pret == carte.Pret)
                return 1;
            return 0;
        }

        public object Clone()
        {
            Carte carteClone=new Carte(this.categorie, this.listaAutori, this.Titlu, this.Pret);
            return carteClone;
        }

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string mesaj=base.ToString();
            mesaj += Environment.NewLine + isbn + ", categorie: " + this.categorie;
            mesaj += Environment.NewLine + "Lista de autori: ";
            foreach(Autor autor in listaAutori)
            {
                mesaj += autor.ToString()+",";
            }

            return mesaj;
        }
    }
}
