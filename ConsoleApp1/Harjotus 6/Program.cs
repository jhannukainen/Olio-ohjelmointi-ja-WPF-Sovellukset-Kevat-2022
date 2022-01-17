using System;

namespace Harjotus_6
{
    class Koira : Eläin
    {
        public string Rotu;
        public int Ikä;

        public static int instanssit = 0;

        public Koira(string rotu, int ikä)
        {
            Rotu = rotu;
            Ikä = ikä;
        }

        public override void Ääntele()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
