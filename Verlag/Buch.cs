using System;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        List<char> verboteneZeichen = new List<char> {'#', ';', '§', '%'};
        


        public Buch(string autor, string titel)
        {

            this.autor = autor; 
            this.titel = titel;
            this.auflage = 1;

            foreach(char a in autor)
            {
                if (verboteneZeichen.Contains(a) == true || a == null)
                {
                    throw new ArgumentException("Du hast verbotene Zeichen benutzt!");
                }

            }

            if(autor == "")
            {
                throw new ArgumentException("Du hast verbotene Zeichen benutzt!");
            }




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
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Auflage darf nicht kleiner als eins sein!");
                }
                else
                this.auflage = value;
               
            }

            get { return this.auflage; }

            
         }
        }
            
          

























}