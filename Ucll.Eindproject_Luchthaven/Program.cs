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
            string menuKeuze = string.Empty;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Control Tower Menu ***");
                Console.WriteLine("\t1. Overzicht vliegtuigen");
                Console.WriteLine("\t2. Meld nieuw vliegtuig aan");
                Console.WriteLine("\t3. Clearance for Landing");
                Console.WriteLine("\t4. Clearance for Take-Off");
                Console.WriteLine("\t5. Verwijder vliegtuig uit luchtruim");
                Console.WriteLine("\t6. Onderhoud alle vliegtuigen");
                Console.WriteLine("\t7. Stop");
                Console.Write("Maak uw keuze: ");
                menuKeuze = Console.ReadLine();
                switch (menuKeuze)
                {
                    case "1":
                        int x = toren.Vliegtuigen.Count;
                        Console.WriteLine("Aantal vliegtuigen: " + x);
                        foreach (var item in toren.Vliegtuigen)
                        {
                            string beschrijving = item.GeefOmschrijving();
                            if (item.Airborn == true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(beschrijving);
                                Console.ResetColor();
                            } else
                            {
                                Console.WriteLine(beschrijving);
                            }
                            
                        }
                        break;

                    case "2":
                        Console.Write("Geef de code van het binnenkomende vliegtuig: ");
                        vluchtcode = Console.ReadLine();
                        Vliegtuig vliegtuig = new Vliegtuig(vluchtcode);
                        result = toren.MeldVliegtuigAan(vluchtcode);
                        if (!result.Equals("DUPLICATE"))
                        {
                            Console.WriteLine("Vliegtuig " + result + " werd aangemeld");
                        }
                        else
                        {
                            Console.WriteLine("Vliegtuig " + vluchtcode + " is reeds aangemeld!");
                        }
                        break;


                    case "3":
                        Console.Write("Toestemming voor landen van vliegtuig: ");
                        vluchtcode = Console.ReadLine();
                        result = toren.ToestemmingTotLanden(vluchtcode);
                        if (result != null)
                        {
                            if (result == "-1")
                            {
                                Console.WriteLine("Toestel " + vluchtcode + " is reeds geland!");
                            }
                            else
                            {
                                Console.WriteLine("Toestel " + result + " is geland");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Toestel niet gekend!");
                        }
                        break;

                    case "4":
                        Console.Write("Toestemming voor opstijgen van vliegtuig: ");
                        vluchtcode = Console.ReadLine();
                        var res = toren.ToestemmingTotOpstijgen(vluchtcode);
                        // Toestel onbekend
                        if(res.Item1 == null)
                        {
                            Console.WriteLine("Toestel niet gekend!");
                            break;
                        }
                        // Toestel reeds opgestegen
                        if(res.Item3 == -1)
                        {
                            Console.WriteLine("Toestel " + res.Item1 + " is reeds opgestegen!");
                            break;
                        }
                        // Toestel opgestegen
                        if (res.Item1 != null)
                        {
                            if (res.Item2 == true)
                            {
                                // Onderhoud uitgevoerd
                                Console.WriteLine("Toestel " + res.Item1 + " onderhoud is uitgevoerd");
                            }
                            Console.WriteLine("Toestel " + res.Item1 + " is opgestegen");
                        }
                        break;

                    case "5":
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

                    case "6":
                        int onderhoudsBeurten = toren.RepareerVliegtuigen();
                        Console.WriteLine("Aantal onderhoudsbeurten uitgevoerd: " + onderhoudsBeurten);
                        break;

                    default:
                        break;
                }
                if (menuKeuze != "7")
                {
                    Console.WriteLine("\nDruk op een toets om verder te gaan");
                    Console.ReadKey();
                }

            } while (menuKeuze != "7");


        }
    }
}
