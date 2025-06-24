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
        /// <summary>
        /// Generira se kada polaznik predaje ispit. Salje polaznika koji je predao ispit.
        /// </summary>
        public event PredajIspit IspitZavrsen;

        /// <summary>
        /// Ime i prezime polaznika kao jedan string, odnosno komad teksta.
        /// </summary>
        public string ImePrezime { get; set; }

        /// <summary>
        /// Konstruktor za polaznika.
        /// </summary>
        /// <param name="imePrezime">Ime i prezime polaznika kao jedan string.</param>
        public Polaznik(string imePrezime)
        {
            ImePrezime = imePrezime;
        }

        /// <summary>
        /// Polaznik pocne pisati ispit. Ispisu se ime i prezime polaznika, te vrijeme pocetka (ukljucujuci datum).
        /// </summary>
        /// <param name="vrijeme_pocetka">Vrijeme pocetka pisanja ispita</param>
        public void OdgovoriNaPitanja(DateTime vrijeme_pocetka)
        {
            Console.WriteLine($"{ImePrezime}\t\t{vrijeme_pocetka} - Pocnite odgovarati na pitanja");
            Console.WriteLine("=============================================================\n");
        }

        /// <summary>
        /// Ispis da je polaznik predao odgovore na pitanja. Takodjer generira dogadjaj "IspitZavrsen".
        /// </summary>
        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"{ImePrezime} - Odgovor zaprimljen!");
            IspitZavrsen?.Invoke(this);
        }
    }
}
