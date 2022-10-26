using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.Wagenpark
{
    class Wagen
    {
        public string Nummerplaat { get; set; }
        public string Merk { get; set; }
        public double Schade { get; set; }

        public Wagen(string nummerplaat, string merk)
        {
            Nummerplaat = nummerplaat;
            Merk = merk;
            Schade = 0;
        }

        public string Omschrijving()
        {
            return ("Wagen: " + Nummerplaat + " /" + Merk + " /Schade=" + Schade.ToString());
        }

    }
}
