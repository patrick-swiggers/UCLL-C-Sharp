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
            Vliegtuig vliegtuigCode = ZoekVliegtuig(vluchtcode);
            if (vliegtuigCode == null)
            {
                Vliegtuig vliegtuig = new Vliegtuig(vluchtcode);
                Vliegtuigen.Add(vliegtuig);
                return vluchtcode;
            }
            else
            {
                return "DUPLICATE";
            }
        }

        public string ToestemmingTotLanden(string vluchtcode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtcode);
            if (vliegtuig != null)
            {
                if (vliegtuig.Airborn == true)
                {
                    // Landen
                    vliegtuig.Land();
                    return vluchtcode;
                }
                else
                {
                    // Is reeds geland
                    return ("-1");
                }
                
            }
            else
            {
                return null;
            }
        }

        /*
         * Tuple:
         * Item1: String    / Vluchtcode
         * Item2: bool      / Onderhoud uitgevoerd
         * Item3: int       / Is reeds Airborne (value = -1)
         */
        public Tuple<string, bool, int> ToestemmingTotOpstijgen(string vluchtcode)
        {
            bool onderhoud = false;
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtcode);
            if (vliegtuig != null)
            {
                if (vliegtuig.Airborn == false)
                {
                    // Heeft onderhoud nodig?
                    if (vliegtuig.OnderhoudNodig != OnderhoudType.Geen)
                    {
                        TechnischeDienst maintenance = new TechnischeDienst();
                        maintenance.VoerOnderhoudUit(vliegtuig);
                        onderhoud = true;
                    }
                    // Opstijgen
                    vliegtuig.StijgOp();
                    var tuple = new Tuple<string, bool, int>(vluchtcode, onderhoud, 0);
                    return tuple;
                }
                else
                {
                    // Is reeds opgestegen
                    var tuple = new Tuple<string, bool, int>(vluchtcode, onderhoud, -1);
                    return tuple;
                }
            }
            else
            {
                // Is onbekend
                var tuple = new Tuple<string, bool, int>(null, onderhoud, 0);
                return tuple;
            }
        }

        public string VerwijderUitLuchtruim(string vluchtcode)
        {
            Vliegtuig vliegtuig = ZoekVliegtuig(vluchtcode);
            Vliegtuigen.Remove(vliegtuig);
            return vluchtcode;
        }

        public int RepareerVliegtuigen()
        {
            TechnischeDienst technischeDienst = new TechnischeDienst();
            int onderhoudsBeurten = technischeDienst.VoerOnderhoudUit(Vliegtuigen);
            return onderhoudsBeurten;
        }

    }
}
