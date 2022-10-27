using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.Eindproject_Luchthaven
{
    enum OnderhoudType
    {
        Geen,
        Klein,
        Groot
    }
    class Vliegtuig
    {
        private string vluchtcode;
        public string VluchtCode
        {
            get { return vluchtcode; }
            set
            {
                if (value.Length > 10)
                {
                    vluchtcode = value.Substring(0, 10);
                }
                else
                {
                    vluchtcode = value;
                }
                
            }
        }
        public bool Airborn { get; set; }
        public OnderhoudType OnderhoudNodig { get; set; }

        public Vliegtuig(string vluchtcode)
        {
            VluchtCode = vluchtcode;
            Airborn = false;
            OnderhoudNodig = OnderhoudType.Geen;
        }

        public void Land()
        {
            int random = new Random().Next(0, 11);
            if (random > 7) { OnderhoudNodig = OnderhoudType.Groot; }
            else if (random > 3 && random <= 7) { OnderhoudNodig = OnderhoudType.Klein; }
            else { OnderhoudNodig = OnderhoudType.Geen; }
            Airborn = false;
        }

        public void StijgOp()
        {
            Airborn = true;
        }

        public string GeefOmschrijving()
        {
            return ("Vliegtuigcode: " + VluchtCode + "\t Onderhoud: " + OnderhoudNodig + "\t Airborn: " + Airborn);
        }
    }
}
