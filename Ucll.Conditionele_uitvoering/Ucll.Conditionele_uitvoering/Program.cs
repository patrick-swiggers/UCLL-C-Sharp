using System;

namespace Ucll.Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaratie (+ initialisatie) van waardes
            const double INCH = 2.54;
            string maatEenheid = string.Empty;
            double maatWaarde = 0;

            Console.WriteLine("*** cm <> inch converter");

            // start lus
            do
            {
                // reset waardes (voor herhaling lus)
                maatEenheid = string.Empty;
                maatWaarde = 0;

                // cm of inches ingeven
                Console.Write("Geef de maateenheid in (cm/inch): " + maatEenheid);
                maatEenheid = Console.ReadLine();
                if (!(maatEenheid == "cm" || maatEenheid == "inch"))
                {
                    Console.WriteLine("Ongeldige invour, het programma zal stoppen.");
                }
                else
                {
                    // waarde ingeven, groter dan 0
                    Console.Write("Geef de waarde in: ");
                    maatWaarde = double.Parse(Console.ReadLine());
                    if (maatWaarde < 0)
                    {
                        Console.WriteLine("De waarde mag niet negatief zijn, het programm zal stoppen.");
                    }
                    else
                    {
                        /*
                         * Berekening
                        */
                        if (maatEenheid == "cm")
                        {
                            Console.WriteLine("De lengte in cm: " + maatWaarde / INCH);
                        }
                        if (maatEenheid == "inch")
                        {
                            Console.WriteLine("De lengte in inch: " + maatWaarde * INCH);
                        }
                    }
                }
            } while ((maatEenheid == "cm" || maatEenheid == "inch") && maatWaarde > 0);
        }
    }
}
