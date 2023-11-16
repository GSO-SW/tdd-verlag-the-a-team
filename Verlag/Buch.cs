using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{


    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public Buch(string Autor, string Titel, int Auflage)
        {
            this.autor = Autor;
            this.titel = Titel;
            this.auflage = Auflage;
        }
        public string Autor { get; set; }
        public string Titel { get; set; }
        public int Auflage { get; set; }

    }

} 
