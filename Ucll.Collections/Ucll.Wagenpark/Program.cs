using System;

namespace Ucll.Wagenpark
{
    class Program
    {
        static void Main(string[] args)
        {
            string keuze = string.Empty;
            Wagenpark wagenpark = new Wagenpark();
            do
            {
                keuze = "0";
                Console.WriteLine("\n *** Wagenpark beheer ***");
                Console.WriteLine("1. Voeg een wagen toe aan het wagenpark");
                Console.WriteLine("2. Geef overzicht wagenpark");
                Console.WriteLine("3. Voer expertise uit (volledig wagenpark)");
                Console.WriteLine("4. Repareer een wagen");
                Console.WriteLine("5. Stop");
                keuze = Console.ReadLine();
                switch (keuze)
                {
                    case "1":
                        Console.Write("Nummerplaat: ");
                        string lpn = Console.ReadLine();
                        Console.Write("Merk: ");
                        string merk = Console.ReadLine();
                        Wagen auto = new Wagen(lpn, merk);
                        bool registratie = wagenpark.SchrijfWagenIn(auto);
                        Console.WriteLine("\nRegistratie auto: " + registratie + "\n");
                        break;
                    case "2":
                        string wagens = wagenpark.GeefOverzicht();
                        Console.WriteLine("\n" + wagens + "\n");
                        break;
                    case "3":
                        ExpertiseBureau expert = new ExpertiseBureau();
                        expert.VoerExpertiseUit(wagenpark.Wagens);
                        string reparatiewagens = wagenpark.GeefOverzicht();
                        Console.WriteLine("\n" + reparatiewagens + "\n");
                        break;
                    case "4":
                        Console.WriteLine("Geef de nummerplaat van de te repareren wagen:");
                        string schadelpn = Console.ReadLine();
                        Wagen schadeauto = wagenpark.ZoekWagen(schadelpn);
                        if(schadeauto != null)
                        {
                            Garage garage = new Garage();
                            double schadekost = garage.RepareerWagen(schadeauto);
                            Console.WriteLine("Schade aan wagen is hesteld. Kostprijs = " + schadekost);
                        } else
                        {
                            Console.WriteLine("De Auto met nummerplaat "+ schadelpn + " is niet gevonden");
                        }
                        break;
                    default:
                        break;
                }
            } while (keuze != "5");

        }
    }
}
