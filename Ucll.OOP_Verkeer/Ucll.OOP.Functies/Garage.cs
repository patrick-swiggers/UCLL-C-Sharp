using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.OOP.Functies2
{
    class Garage
    {
        Auto car;

        //Constructor
        public Garage(Auto auto)
        {
            car = auto;
        }
        public double Repair()
        {
            double schadekost = car.Schade;
            car.Schade = 0;
            return schadekost;
        }
    }
}
