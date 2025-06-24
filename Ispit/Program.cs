using Ispit.Proizvodi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    public delegate void PocniPisatiIspit(DateTime vrijeme);    // Nisam mogao dobiti global, ali inace radi
    public class Program
    {
        static void Main(string[] args)
        {
            Predavac Pale = new Predavac(); // Stvaranje predavaca

            List<Polaznik> polaznici = new List<Polaznik>();    // Lista polaznika za jednostavno rukovanje sa svim polaznicima.

            polaznici.Add(new Polaznik("Garry Barret Francois"));   // Dodavanje polaznika
            polaznici.Add(new Polaznik("Sam Kovacic"));
            polaznici.Add(new Polaznik("Antonio Dill"));
            polaznici.Add(new Polaznik("Johnny Guitar"));

            foreach(Polaznik polaznik in polaznici){   // Pretplata za kada polaznik zavrsi ispit
                polaznik.IspitZavrsen += (osoba) => Pale.IspitZaprimljen(polaznik); 
            }

            Pale.Ispit += ( vrijeme ) => { polaznici.ForEach(p => { p.OdgovoriNaPitanja(vrijeme); }); };  // Anonimna metoda za pristup lokalnim varijablama

            Pale.ZvoniZvono();  // Takodjer naznaci polatnicima do pocnu rjesavati ispit

            Random rand = new Random(); // Biranje prvog plaznika koji ce predati odgovore na neodredjen nacin
            polaznici.ElementAt(rand.Next(0, polaznici.Count)).PredajOdgovoreNaPitanja();   // Korist polaznici.Count da se lako mogu dodati/oduzeti polaznici bez potrebe za dodatnom izmjenom koda
        }
    }
}
