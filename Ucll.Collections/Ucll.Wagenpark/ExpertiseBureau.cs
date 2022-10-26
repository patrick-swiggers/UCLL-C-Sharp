using System;
using System.Collections.Generic;
using System.Text;

namespace Ucll.Wagenpark
{
    class ExpertiseBureau
    {
        Random random = new Random();
        public void VoerExpertiseUit(Wagen auto)
        {
            auto.Schade += random.NextDouble() * 1000;
        }
        public void VoerExpertiseUit(List<Wagen> wagens)
        {
            foreach (Wagen auto in wagens)
            {
                auto.Schade += random.NextDouble() * 1000;
            }
        }
    }
}
