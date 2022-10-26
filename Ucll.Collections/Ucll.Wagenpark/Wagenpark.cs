 using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.Wagenpark
{
    class Wagenpark
    {
        public List<Wagen> Wagens;

        public Wagenpark()
        {
            Wagens = new List<Wagen>();
        }

        public bool SchrijfWagenIn(Wagen auto)
        {
            if (string.IsNullOrEmpty(auto.Nummerplaat))
            {
                return false;
            }
            else
            {
                Wagens.Add(auto);
                return true;
            }
          
        }

        public string GeefOverzicht()
        {
            string str = "\n*** Overzicht wagenpark ***";
            foreach (Wagen auto in Wagens)
            {
                str += "\nWagen: " + auto.Nummerplaat + " /" + auto.Merk + " /Shade=" + auto.Schade.ToString();
            }
            return str;

        }

        public Wagen ZoekWagen(string nummerplaat)
        {
            foreach (Wagen auto in Wagens)
            {
                if (auto.Nummerplaat == nummerplaat)
                {
                    return auto;
                }
            }
            return null;
        }

    }
}
