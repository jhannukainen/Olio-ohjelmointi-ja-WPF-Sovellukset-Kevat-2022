﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira();
            koira1.nimi = "Rekku";
            koira1.ikä = 4;
            koira1.rotu = "Saksanpaimenkoira";

            koira1.Hauku();
            koira1.TulostaData();

            Koira koira2 = new Koira();
            koira2.nimi = "Musti";
            koira2.ikä = 2;
            koira2.rotu = "Mopsi";

            koira2.TulostaData();
          
        }
    }
}
