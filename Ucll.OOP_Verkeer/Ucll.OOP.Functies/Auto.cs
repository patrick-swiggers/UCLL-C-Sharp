using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.OOP.Functies2
{
    class Auto
    {
        public string Nummerplaat { get; set; }
        public int Kilometriek { get; set; }
        public double Schade { get; set; }

        //Constructor
        public Auto(string nummerplaat)
        {
            Nummerplaat = nummerplaat;
            Kilometriek = 0;
            Schade = 0;
        }

        public string GeefOmschrijving()
        {
            return ("\n Wagen info:" +
            "\n - Nummerplaat: " + Nummerplaat +
            "\n - Teller: " + Kilometriek +
            "\n - Schade: " + Schade + "\n");
        }
    }
}
