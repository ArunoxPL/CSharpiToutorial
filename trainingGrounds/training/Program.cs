using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
   class Kursy
    {
        public string Tytul;
        public string Kategoria;
        public void Wartosci(string Tytul, string Kategoria)
        {
            this.Tytul = Tytul;
            this.Kategoria = Kategoria;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Kursy kurs1 = new Kursy();

        }
    }
}
