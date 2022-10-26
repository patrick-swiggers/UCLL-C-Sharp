using System;

namespace Opdracht_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.WriteLine("Gelieve een design karakter te kiezen (b.v. *, # , // ...)");
            string designKarakter = Console.ReadLine(); // Kan meer dan 1 karakter zijn

            Console.WriteLine("Gelieve je coordinaten in te geven:");

            Console.Write("Voornaam: ");
            string voornaam = Console.ReadLine();

            Console.Write("Familienaam: ");
            string familienaam = Console.ReadLine();

            Console.Write("Adres: ");
            string adres = Console.ReadLine();

            Console.Write("Postcode: ");
            string postcode = Console.ReadLine();

            Console.Write("Plaats: ");
            string plaats = Console.ReadLine();

            // Output
            Console.WriteLine("");
            Console.WriteLine(designKarakter + designKarakter + designKarakter);
            Console.WriteLine(designKarakter + "\t Voornaam\t: " + voornaam);
            Console.WriteLine(designKarakter + "\t Familienaam\t: " + familienaam);
            Console.WriteLine(designKarakter + "\t Adres\t\t: " + adres);
            Console.WriteLine(designKarakter + "\t Postcode\t: " + postcode);
            Console.WriteLine(designKarakter + "\t Plaats\t\t: " + plaats);
            Console.WriteLine(designKarakter + designKarakter + designKarakter);
            Console.WriteLine("");
        }
    }
}
