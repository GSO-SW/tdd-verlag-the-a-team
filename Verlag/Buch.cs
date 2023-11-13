using System;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public Buch(string autor, string titel)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = 1;
        }

        public Buch(string autor, string titel, int auflage)
        {
            this.autor = autor;
            this.titel = titel;
            this.auflage = auflage;

            if (auflage < 1)
            {
                throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner als eins sein!");
            }
        }

        public string Autor
        {
            set { this.autor = value; }
            get { return this.autor; }
        }

        public string Titel
        {
            get { return this.titel; }
        }
     

        public int Auflage
        {
            set { this.auflage = value; }
            get { return this.auflage;  }
        }
            
           








    }

























}