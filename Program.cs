using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racun
{
    class Program
    {
        static void Main(string[] args)
        {
            Racun r1 = new Racun("123123123", "Jovan Jovic", 1000, -200);

            Console.WriteLine("Trenutno stanje na racunu je {0}", r1.SredstvaNaRacunu);
            r1.DodajPareNaRacun(200);
            Console.WriteLine("Trenutno stanje na racunu je {0}", r1.SredstvaNaRacunu);

            if (r1.SkiniPareSaRacuna(1000))
                Console.WriteLine("Trenutno stanje na racunu je {0}", r1.SredstvaNaRacunu);
            else
                Console.WriteLine("Nije moguce skinuti pare sa racuna");


            if (r1.SkiniPareSaRacuna(250))
                Console.WriteLine("Trenutno stanje na racunu je {0}", r1.SredstvaNaRacunu);
            else
                Console.WriteLine("Nije moguce skinuti pare sa racuna");


            if (r1.SkiniPareSaRacuna(10000))
                Console.WriteLine("Trenutno stanje na racunu je {0}", r1.SredstvaNaRacunu);
            else
                Console.WriteLine("Nije moguce skinuti pare sa racuna");
        }
    }
}
