using Ispit.Proizvodi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    public class Program
    {
        public delegate void PocniPisatiIspit(DateTime vrijeme);    // Nisam mogao dobiti global, ali inace radi
        static void Main(string[] args)
        {
            Predavac Pale = new Predavac();
            List<Polaznik> polaznici = new List<Polaznik>();
            polaznici.Add(new Polaznik("Garry Barret Francois"));
            polaznici.Add(new Polaznik("Sam Kovacic"));
            polaznici.Add(new Polaznik("Antonio Dill"));
            polaznici.Add(new Polaznik("Johnny Guitar"));

            foreach(Polaznik p in polaznici){
                p.IspitZavrsen += (o) => Console.WriteLine("Zaprimljen ispit od polaznika: " + o.ImePrezime); 
            }

            Pale.Ispit += ( dt ) => { polaznici.ForEach(p => { p.OdgovoriNaPitanja(dt); }); };  // Za pristup lokalnim varijablama

            Pale.ZvoniZvono();

            //polaznici.ForEach(p => { p.OdgovoriNaPitanja(DateTime.Now); });

            Random rand = new Random();
            polaznici.ElementAt(rand.Next(0, 4)).PredajOdgovoreNaPitanja();
        }
    }
}
