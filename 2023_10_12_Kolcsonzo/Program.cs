using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_12_Kolcsonzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();
            Dvd d1 = new Dvd("Star Wars, A klónok háborúja", 140);
            Dvd d2 = new Dvd("Halálos Iramban", 135);
            Dvd d3 = new Dvd("Gran turismo", 130);
            Dvd d4 = new Dvd("Gru", 60);
            Dvd d5 = new Dvd("FEláldozhatók", 150);
            Konyv k1 = new Konyv("Egy ropi naplója", "szerzo", "idbn");
            Konyv k2 = new Konyv("Harry Potter", "szerzo", "idbn");
            Ujsag u1 = new Ujsag("Napilap", 2023, 12);
            Ujsag u2 = new Ujsag("Hetilap", 2023, 34);
            katalogus.Add(d1);
            katalogus.Add(d2);
            katalogus.Add(d3);
            katalogus.Add(k1);
            katalogus.Add(k2);
            katalogus.Add(u1);
            katalogus.Add(u2);
            foreach (var item in katalogus)
            {
                Console.WriteLine($"{item.MegjelenitendoNev()}, kölcsönzési hossz: {item.MeddigKolcsonozheto()}");
            }

            List<Dvd> d = new List<Dvd>();
            d.Add(d1);
            d.Add(d2);
            d.Add(d3);
            d.Add(d4);
            d.Add(d5);
            d.Sort();
            foreach (var item in d)
            {
                Console.WriteLine($"{item.MegjelenitendoNev()}, kölcsönzési hossz: {item.MeddigKolcsonozheto()}");
            }

            Console.ReadKey();
        }
    }
}
