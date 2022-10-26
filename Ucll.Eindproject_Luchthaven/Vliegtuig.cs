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
        public string VluchtCode { get; set; }
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
            Airborn = false;
        }

        public void StijgOp()
        {
            Airborn = true;
        }

        public string GeefOmschrijving()
        {
            return ("Vliegtuigcode: " + VluchtCode + ", Onderhoud: " + OnderhoudNodig + ", Airborn: " + Airborn);
        }
    }
}
 