using System;
namespace OOP
{
    public class SimBox
    {
        public SimKaart SimKaart1 { get; set; }
        public SimKaart SimKaart2 { get; set; }
        public SimKaart SimKaart3 { get; set; }
        public int AantalSimKaarten
        {
            get
            {
                if (SimKaart3 != null) { return 3; }
                else if (SimKaart2 != null) { return 2; }
                else if (SimKaart1 != null) { return 1; }
                else return 0;
            }
            private set { }
        }

        public SimBox()
        {

        }

    }
}

