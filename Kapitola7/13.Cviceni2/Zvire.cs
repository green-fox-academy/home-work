﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Cviceni2
{
    class Zvire
    {
        public string Nazev { get; set; }
        public int Vek { get; set; }
        public double Vaha { get; set; }

        public Zvire(string nazev, int vek, double vaha)  // Konstruktor třídy Zvíře
        {
            Nazev = nazev;
            Vek = vek;
            Vaha = vaha;
        }

        public void VypisPopis()
        {
            Console.WriteLine("Nazev: {0}", Nazev);
            Console.WriteLine("\tVek: {0}", Vek);
            Console.WriteLine("\tVaha: {0}", Vaha);
        }
    }
}
