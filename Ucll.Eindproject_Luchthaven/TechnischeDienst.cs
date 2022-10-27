using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.Eindproject_Luchthaven
{
    class TechnischeDienst
    {
        public bool VoerOnderhoudUit(Vliegtuig vliegtuig)
        {
            if (vliegtuig.OnderhoudNodig != OnderhoudType.Geen)
            {
                vliegtuig.OnderhoudNodig = OnderhoudType.Geen;
                return true;
            }
            return false;
        }

        public int VoerOnderhoudUit(List<Vliegtuig> vliegtuigen)
        {
            int onderhoudsBeurten = 0;
            foreach (Vliegtuig vliegtuig in vliegtuigen)
            {
                if(vliegtuig.OnderhoudNodig != OnderhoudType.Geen)
                {
                    vliegtuig.OnderhoudNodig = OnderhoudType.Geen;
                    onderhoudsBeurten++;
                }
            }
            return onderhoudsBeurten;
        }
    }
}
