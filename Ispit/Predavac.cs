using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ispit.Program;

namespace Ispit.Proizvodi
{
    public class Predavac
    {
        /// <summary>
        /// Generira se na pocetku pisanja ispita i salje tren (u obliku datuma i vremena) kada je zapoceo ispit.
        /// </summary>
        public event PocniPisatiIspit Ispit;

        /// <summary>
        /// Ispise tekst koji oznacuje da se poceo pisati ispit. Takodjer salje tren pocetka ispita pomocu dogadjaja "Ispit".
        /// </summary>
        public void ZvoniZvono()
        {
            Console.WriteLine("brrr brrrr brrr zvono zvoni i ispit zapocinje!\n\n");
            Ispit?.Invoke(DateTime.Now);
        }

        /// <summary>
        /// Ispise da je polaznik predao ispit, ukljucujuci njihovo ime i prezime.
        /// </summary>
        /// <param name="polaznik">Polaznik ciji je ispit zaprimljen.</param>
        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine("Zaprimljen ispit od polaznika: " + polaznik.ImePrezime);
        }
    }
}
