using System;
using System.Collections.Generic;
using System.Text;

namespace Harjotus10
{
    class Sorsa : Animal, ICanFly, ICanSwim
    {
        public Sorsa(float wIngSize, float swimSpeed)
        {
            WIngSize = wIngSize;
            SwimSpeed = swimSpeed;
        }

        public float WIngSize { get; set; }
        public float SwimSpeed { get; set ; }

        public void Fly()
        {
            Console.WriteLine("Sorsa lentää. Sorsan siipien koko on " + WIngSize);
        }

        public void Swim()
        {
            Console.WriteLine("Sorsa ui. Sorsan uinti nopeus on " + SwimSpeed);
        }
        public override void MakeASound()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
