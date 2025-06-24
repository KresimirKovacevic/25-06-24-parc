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
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            Console.WriteLine("brrr brrrr brrr zvono zvoni i ispit zapocinje!\n\n");
            Ispit?.Invoke(DateTime.Now);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine("Zaprimljen ispit od polaznika: " + polaznik.ImePrezime);
        }
    }
}
