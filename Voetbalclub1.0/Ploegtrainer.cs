using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Ploegtrainer : Trainer
    {
        public int LeeftijdPloeg { get; set; }

        public Ploegtrainer(string naam, int leeftijd, double loon, int leeftijdploeg) : base(naam, leeftijd, loon)
        {
            LeeftijdPloeg = leeftijdploeg;
        }

        public Ploegtrainer(string naam, int leeftijd, List<string> diplomas, double loon, int leeftijdploeg) : base(naam, leeftijd, diplomas, loon)
        {
            LeeftijdPloeg = leeftijdploeg;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $", wiens ploeg is de U{LeeftijdPloeg}.";
        }
    }
}

