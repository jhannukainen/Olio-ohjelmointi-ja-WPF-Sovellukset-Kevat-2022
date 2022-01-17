using System;

namespace henkilö
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö("Matti" 20, 192385);
            Opiskelija opiskelija = new Opiskelija("Pekka" 16, 12345, "Careeria");

            henkilö.TulostaTiedot();
            opiskelija.TulostaTiedot();

            henkilö.Syö();
            henkilö.Juo();

            Console.WriteLine();

            opiskelija.Opiskele();
            opiskelija.Juo();
            opiskelija.Syö(),
        }
    }
}
