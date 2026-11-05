using System;
using System.Collections.Generic;
using System.Text;

namespace Notatnik
{
    internal class Notatka
    {
        public string TytulNotatki { get; set; }
        public string TrescNotatki { get; set; }
        public bool CzyPriorytetowa {  get; set; }
        public DateTime DataDodaniaNotatki { get; set; }

        public Notatka(string tytulNotatki, string trescNotatki, bool czyPriorytetowa)
        {
            TytulNotatki = tytulNotatki;
            TrescNotatki = trescNotatki;
            CzyPriorytetowa = czyPriorytetowa;
            DataDodaniaNotatki = DateTime.Now;
        }

        public Notatka(string tytulNotatki) 
        {
            TytulNotatki = tytulNotatki;
            tytulNotatki = "";
            CzyPriorytetowa = false;
            DataDodaniaNotatki = DateTime.Now;
        }

        public string WypiszNotatke()
        {
            Console.WriteLine("________________");
            if (CzyPriorytetowa == true)
            {
                Console.WriteLine($"Notatka WAŻNA! {TytulNotatki}");
            } else
            {
                Console.WriteLine($"Notatka {TytulNotatki}");
            }
            Console.WriteLine($"Treść notatki: {TrescNotatki}");
            Console.WriteLine($"Data: {DataDodaniaNotatki}");
            Console.WriteLine("________________");

            return WypiszNotatke();
        }

    }
}
