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

        public Ploegtrainer(string voornaam, string familienaam, int leeftijd, List<string> diplomas, double loon, List<string> voorbijeploegen, string huidigeploeg, int leeftijdploeg) : base(voornaam, familienaam, leeftijd, diplomas, loon, voorbijeploegen, huidigeploeg)
        {
            LeeftijdPloeg = leeftijdploeg;
        }

        public Ploegtrainer(string voornaam, string familienaam, int leeftijd, List<string> diplomas, double loon, int leeftijdploeg, List<string> voorbijeploegen, string huidigeploeg) : base(voornaam, familienaam, leeftijd, diplomas, loon, voorbijeploegen, huidigeploeg)
        {
            LeeftijdPloeg = leeftijdploeg;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $", wiens ploeg is de U{LeeftijdPloeg}.";
        }
    }
}

