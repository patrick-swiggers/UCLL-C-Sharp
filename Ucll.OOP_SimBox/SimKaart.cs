using System;
namespace OOP
{
    public class SimKaart
    {
        public string Telefoonnummer { get; set; }
        public DateTime CreatieDatum { get; private set; }

        public SimKaart(string telefoonnumer)
        {
            Telefoonnummer = telefoonnumer;
            CreatieDatum = DateTime.Now;
        }
    }
}

