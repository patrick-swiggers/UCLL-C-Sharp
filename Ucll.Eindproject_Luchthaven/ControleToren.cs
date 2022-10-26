using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.Eindproject_Luchthaven
{
    class ControleToren
    {
        public List<Vliegtuig> Vliegtuigen { get; set; }

        public ControleToren()
        {
            Vliegtuigen = new List<Vliegtuig>();
        }

        private Vliegtuig ZoekVliegtuig(string vluchtcode)
        {
            foreach (Vliegtuig vliegtuig in Vliegtuigen)
            {
                if (vliegtuig.VluchtCode == vluchtcode)
                {
                    return vliegtuig;
                }
            }
            return null;
        }

        public string MeldVliegtuigAan(string vluchtcode)
        {
            Vliegtuig vliegtuig = new Vliegtuig(vluchtcode);
            Vliegtuigen.Add(vliegtuig);
            return vluchtcode;
        }

        public string ToestemmingTotLanden(string vluchtcode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtcode);
            if (vliegtuig != null)
            {
                if (vliegtuig.Airborn == true)
                {
                    vliegtuig.Airborn = false;
                }
                return vluchtcode; 
            } else
            {
                return null;
            }
        }

        public string ToestemmingTotOpstijgen(string vluchtcode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtcode);
            if (vliegtuig != null)
            {
                if (vliegtuig.Airborn == false)
                {
                    vliegtuig.Airborn = true;
                }
                return vluchtcode; 
            } else
            {
                return null;
            }
        }

        public string VerwijderUitLuchtruim(string vluchtcode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtcode);
            Vliegtuigen.Remove(vliegtuig);
            return vluchtcode;
        }

        public int RepareerVliegtuig()
        {
            return 0;
        }

    }
}
