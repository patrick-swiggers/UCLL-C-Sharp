using System;

namespace Opdracht_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit programma zal het nodige aantal kg zaad berekenen.\n");
            Console.WriteLine("Geef de volgende gegevens in: ");
            Console.Write("Lengte veld: ");
            float lengteVeld = float.Parse(Console.ReadLine());
            Console.Write("Breedte veld: ");
            float breedteVeld = float.Parse(Console.ReadLine());
            Console.Write("Aantal kg zaad per m2: ");
            float kilogramZaad = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("De oppervlakte van het veld is: " + (lengteVeld * breedteVeld));
            Console.WriteLine("Het aantal kg zaad nodig is: " + ((lengteVeld * breedteVeld) * kilogramZaad));
            Console.WriteLine("");
        }
    }
}
