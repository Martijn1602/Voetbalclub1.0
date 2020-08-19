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

        public Techniektrainer(string voornaam, string familienaam, int leeftijd, List<string> diplomas, double loon, List<string> voorbijeploegen, string huidigeploeg, List<string> gekendebewegingen) : base(voornaam, familienaam, leeftijd, diplomas, loon, voorbijeploegen, huidigeploeg)
        {
            GekendeBewegingen = gekendebewegingen;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" en hij kan volgende schijnbewegingen: {GekendeBewegingen}.";
        }
    }
}
