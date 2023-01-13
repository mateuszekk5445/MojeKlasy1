using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeKlasy1.przyklady_klas
{   
    internal class Osoba
    {
        private string imie, naziwsko;
        private DateTime dtUrodzenia;
        private char plec;
        //konstruktor

        public Osoba(string imie, string naziwsko, DateTime dtUrodzenia, char plec)
        {
            this.imie = imie;
            this.naziwsko = naziwsko;
            this.dtUrodzenia = dtUrodzenia;
            this.plec = plec;
        }

        public IFormatProvider? D { get; private set; }

        public string Wypisz()
        {
            return this.imie + " " + this.naziwsko + "\n"
                + this.dtUrodzenia.ToString(D) + "\n"
                + "płeć: " + this.plec + "\n";
        }
        public int IleDni()
        {
            return(DateTime.Now - dtUrodzenia).Days;
        }
    }
}
