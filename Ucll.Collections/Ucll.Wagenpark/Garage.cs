using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.Wagenpark
{
    class Garage
    {
        public string GarageNaam { get; private set; }

        public Garage()
        {
            GarageNaam = "Onbekend";
        }
        public Garage(string garagenaam)
        {
            GarageNaam = garagenaam; 
        }

        public double RepareerWagen(Wagen auto)
        {
            double reparatiekost = auto.Schade;
            auto.Schade = 0;
            return reparatiekost;
        }
    }
}
