using System;
using Ucll.OOP.Functies2;

namespace Ucll.OOP.Functies2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de gegevens van je wagen in");
            Console.Write(" - Nummerplaat: ");
            string nummerplaat = Console.ReadLine();
            // Create the objects
            Auto auto1 = new Auto(nummerplaat);
            Verkeer drive1 = new Verkeer(auto1);
            Garage garage1 = new Garage(auto1);
            int keuze = 0;
            do
            {
                keuze = 0;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Keuzemenu");
                Console.WriteLine("---------");
                Console.WriteLine("1. Voer rit uit");
                Console.WriteLine("2. Repareer wagen");
                Console.WriteLine("3. Wagen info");
                Console.WriteLine("4. Stop programma");
                Console.ResetColor();
                keuze = int.Parse(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        drive1.Rit();
                        Console.WriteLine(auto1.GeefOmschrijving());
                        break;
                    case 2:
                        double reparatiekost = garage1.Repair();
                        string hline = new string('-', 30);
                        Console.WriteLine("\n" + hline);
                        Console.WriteLine(" Reparatie kosten: " + reparatiekost);
                        Console.WriteLine(hline);
                        Console.WriteLine(auto1.GeefOmschrijving());
                        break;
                    case 3:
                        Console.WriteLine(auto1.GeefOmschrijving());
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (keuze == 1 || keuze == 2 || keuze == 3);
        }
    }
}
