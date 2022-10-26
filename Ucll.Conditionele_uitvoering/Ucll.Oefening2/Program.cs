using System;

namespace Ucll.Oefening2
{
    class Program
    {
        static void Main(string[] args)
        {
            char herhaalLus = 'j';
            do
            {
                Console.Write("Gelieve een reeks positieve gehele getallen in te geven. ");
                Console.WriteLine("Negatief om te stoppen.\n");

                int aantal = 0;
                int totaal = 0;
                int maximum = 0;
                int getal = 0;

                while (getal >= 0)
                {
                    Console.Write(aantal + 1 + ") ");
                    getal = int.Parse(Console.ReadLine());
                    if (getal >= 0)
                    {
                        aantal++;
                        totaal += getal;
                        if (getal > maximum)
                        {
                            maximum = getal;
                        }
                    }
                }
                Console.WriteLine("Het maximum van de ingegeven reeks is: " + maximum);
                Console.WriteLine("Het gemiddelde van de ingegeven getallen is: " + (totaal / aantal));
                Console.Write("Opnieuw het gemiddelde en maximum bepalen? (j/n): ");
                herhaalLus = char.Parse(Console.ReadLine());
            } while (herhaalLus == 'j');
        }
    }
}
