using System;

namespace Ucll.Eindproject_Luchthaven
{
    class Program
    {
        static void Main(string[] args)
        {
            ControleToren toren = new ControleToren();
            string vluchtcode = string.Empty;
            string result = string.Empty;
            int menuKeuze = 0;
            do
            {
                menuKeuze = 0;
                Console.WriteLine("*** Control Tower Menu ***");
                Console.WriteLine("1. Overzicht vliegtuigen");
                Console.WriteLine("2. Meld nieuw vliegtuig aan");
                Console.WriteLine("3. Clearance for Landing");
                Console.WriteLine("4. Clearance for Take-Off");
                Console.WriteLine("5. Verwijder vliegtuig uit luchtruim");
                Console.WriteLine("6. Onderhoud alle vliegtuigen");
                Console.WriteLine("7. Stop");
                menuKeuze = int.Parse(Console.ReadLine());
                switch (menuKeuze)
                {
                    case 1:
                        foreach (var item in toren.Vliegtuigen)
                        {
                            string beschrijving = item.GeefOmschrijving();
                            Console.WriteLine(beschrijving);
                        }
                        break;

                    case 2:
                        Console.Write("Geef de code van het binnenkomende vliegtuig: ");
                        vluchtcode = Console.ReadLine();
                        Vliegtuig vliegtuig = new Vliegtuig(vluchtcode);
                        toren.MeldVliegtuigAan(vluchtcode);
                        break;

                    case 3:
                        Console.Write("Toestemming voor landen van vliegtuig: ");
                        vluchtcode = Console.ReadLine();
                        result = toren.ToestemmingTotLanden(vluchtcode);
                        if (result != null)
                        {
                            Console.WriteLine("Toestel " + result + " is geland");
                        }
                        else
                        {
                            Console.WriteLine("Toestel niet gekend!");
                        }

                        break;

                    case 4:
                        Console.Write("Toestemming voor opstijgen van vliegtuig: ");
                        vluchtcode = Console.ReadLine();
                        result = toren.ToestemmingTotOpstijgen(vluchtcode);
                        if (result != null)
                        {
                            Console.WriteLine("Toestel " + result + " is opgestegen");
                        }
                        else
                        {
                            Console.WriteLine("Toestel niet gekend!");
                        }
                        break;

                    case 5:
                        Console.Write("Geef nummer vliegtuig om te verwijderen: ");
                        vluchtcode = Console.ReadLine();
                        result = toren.VerwijderUitLuchtruim(vluchtcode);
                        if (result != null)
                        {
                            Console.WriteLine("Toestel " + result + " heeft het luchtruim verlaten");
                        }
                        else
                        {
                            Console.WriteLine("Toestel niet gekend!");
                        }
                        break;

                    default:
                        break;
                }

            } while (menuKeuze != 7);


        }
    }
}
