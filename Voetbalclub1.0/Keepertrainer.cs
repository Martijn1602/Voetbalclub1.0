using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Keepertrainer : Trainer
    {
        public int AantalKeepers { get; set; }

        public Keepertrainer(string naam, int leeftijd, double loon, int aantalkeepers) : base(naam, leeftijd, loon)
        {
            AantalKeepers = aantalkeepers;
        }

        public Keepertrainer(string naam, int leeftijd, List<string> diplomas, double loon, int aantalkeepers) : base(naam, leeftijd, diplomas, loon)
        {
            AantalKeepers = aantalkeepers;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" en die heeft {AantalKeepers} onder zijn hoede.";
        }
    }
}
