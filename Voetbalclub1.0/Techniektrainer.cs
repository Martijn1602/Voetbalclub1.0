using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Techniektrainer : Trainer
    {
        public List<string> GekendeBewegingen { get; set; }

        public Techniektrainer(string naam, int leeftijd, double loon, List<string> gekendebewegingen) : base(naam, leeftijd, loon)
        {
            GekendeBewegingen = gekendebewegingen;
        }

        public Techniektrainer(string naam, int leeftijd, List<string> diplomas, double loon, List<string> gekendebewegingen) : base(naam, leeftijd, diplomas, loon)
        {
            GekendeBewegingen = gekendebewegingen;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" en hij kan volgende schijnbewegingen: {GekendeBewegingen}.";
        }
    }
}
