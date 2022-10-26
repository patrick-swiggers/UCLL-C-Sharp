using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int keuze = 0;
            string telefoonnummer = string.Empty;
            SimBox simBox = new SimBox();
            do
            {
                int sims = simBox.AantalSimKaarten;
                Console.WriteLine("*** SimBox ***");
                Console.WriteLine("1. Simkaart gegevens ingeven");
                Console.WriteLine("2. Overzicht SIM kaart gegevens");
                Console.WriteLine("3. Aantal geinstalleerde SIM kaarten");
                Console.WriteLine("4. Stop");
                keuze = int.Parse(Console.ReadLine());
                switch (keuze)
                {
                    case 1:
                        if (sims == 3)
                        {
                            Console.WriteLine("Er kunnen maar max 3 SIM kaarten geinstalleerd worden.");
                            break;
                        }
                        Console.WriteLine("Geef het telefoonnummer van SIM kaart " + (sims + 1) + " in: ");
                        telefoonnummer = Console.ReadLine();
                        switch (sims)
                        {
                            case 0:
                                SimKaart sim1 = new SimKaart(telefoonnummer);
                                simBox.SimKaart1 = sim1;
                                break;
                            case 1:
                                SimKaart sim2 = new SimKaart(telefoonnummer);
                                simBox.SimKaart2 = sim2;
                                break;
                            case 2:
                                SimKaart sim3 = new SimKaart(telefoonnummer);
                                simBox.SimKaart3 = sim3;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        if (simBox.SimKaart1 != null)
                            Console.WriteLine("SIM Kaart 1: " + simBox.SimKaart1.Telefoonnummer);
                        if (simBox.SimKaart2 != null)
                            Console.WriteLine("SIM Kaart 2: " + simBox.SimKaart2.Telefoonnummer);
                        if (simBox.SimKaart3 != null)
                            Console.WriteLine("SIM Kaart 3: " + simBox.SimKaart3.Telefoonnummer);
                        break;
                    case 3:
                        Console.WriteLine("Aantal geinstalleerde SIM Kaarten: " + sims);
                        break;
                    default:
                        break;
                }

            } while (keuze == 1 || keuze == 2 || keuze == 3);
        }
    }
}

