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

        public Keepertrainer(string voornaam, string familienaam, int leeftijd, List<string> diplomas, double loon, int aantalkeepers, List<string> voorbijeploegen, string huidigeploeg) : base(voornaam, familienaam, leeftijd, diplomas, loon, voorbijeploegen, huidigeploeg)
        {
            AantalKeepers = aantalkeepers;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" en die heeft {AantalKeepers} onder zijn hoede.";
        }
    }
}
