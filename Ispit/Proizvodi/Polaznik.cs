using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Proizvodi
{
    public delegate void PredajIspit(Polaznik polaznik);
    public class Polaznik
    {
        public event PredajIspit IspitZavrsen;
        public string ImePrezime { get; set; }

        public Polaznik(string imePrezime)
        {
            ImePrezime = imePrezime;
        }

        public void OdgovoriNaPitanja(DateTime vrijeme_pocetka)
        {
            Console.WriteLine($"{ImePrezime}\t\t{vrijeme_pocetka} - Pocnite odgovarati na pitanja");
            Console.WriteLine("=============================================================\n");
        }

        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"{ImePrezime} - Odgovor zaprimljen!");
            IspitZavrsen?.Invoke(this);
        }
    }
}
