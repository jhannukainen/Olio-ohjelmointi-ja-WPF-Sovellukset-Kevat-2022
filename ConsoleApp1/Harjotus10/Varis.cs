using System;
using System.Collections.Generic;
using System.Text;

namespace Harjotus10
{
    class Varis : Animal, ICanFly
    {
        public Varis(float wIngSize)
        {
            WIngSize = wIngSize;
        }

        public float WIngSize { get; set; }

        public void Fly()
        {
            Console.WriteLine("Varis lentää. Variksen siipien koko on " + WIngSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw Kakaaw");
        }
    }
}
