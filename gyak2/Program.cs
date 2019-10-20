using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    static class Program
    {
        public static void Main(string[] args)
        {
            Diak diak = new Diak() { Nev = "Jani" };
            List<Diak> diakok = new List<Diak>()
            {
                new Diak() { Nev = "Jani" },
                new Diak() { Nev = "Béla" },
                new Diak() { Nev = "Pista" },
                new Diak() { Nev = "János" },
                new Diak() { Nev = "ÖcsiBélaPista" },
                new Diak() { Nev = "Zoli" },
                new Diak() { Nev = "Fasz" },
            };
            diakok.Add(diak);
            diakok = diakok.OrderBy(d => d.Nev.Length).ToList();
            foreach (var item in diakok)
            {
                Console.WriteLine(item.Nev);
            }
            foreach (var item in diakok.Where(d => d.Nev.Contains("Pista")))
            {
                Console.WriteLine(item.Nev);
            }
            
            diak.ONChangeEvent += DoStg;
            diak.Nev = "Valami";
            Console.ReadKey();
            }
        static void DoStg(object sender, CustomEventArgs nev)
        {
            Console.WriteLine(sender);
            Console.WriteLine(nev.Elozo_nev);
            Console.WriteLine(nev.Jelen_nev);
        }
    }
}
