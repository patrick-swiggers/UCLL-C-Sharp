using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.OOP.Functies2
{
    class Verkeer
    {
        Auto car;

        //Constructor
        public Verkeer(Auto auto)
        {
            car = auto;
        }
        public void Rit()
        {
            Random random = new Random();
            car.Kilometriek += random.Next(1, 2000);
            int schadegeval = random.Next(1, 5);
            if (schadegeval == 1)
            {
                car.Schade += random.Next(1, 1500);
            }

        }
    }
}
