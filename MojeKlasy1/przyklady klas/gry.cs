using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojeKlasy1.przyklady_klas
{
    internal class gry
    {
        private string NazwaGry;
        private string Wydawca;
        private DateTime PierwUruchomienie;

        public IFormatProvider? D { get; private set; }

        public gry(string NazwaGry, string Wydawca, DateTime PierwUruchomienie)
        {
            this.NazwaGry = NazwaGry;
            this.Wydawca = Wydawca;
            this.PierwUruchomienie = PierwUruchomienie;
        }
        public string Wypisz2()
        {
            return this.NazwaGry + " " + this.Wydawca + "\n"
                + this.PierwUruchomienie.ToString(D) + "\n";
        }
        public int IleDni2()
        {
            return (DateTime.Now - PierwUruchomienie).Days;
        }
    }
}

