using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Trainer : Persoon
    {
        public double Loon { get; set; }
        public List<string> Diplomas { get; set; }

        public Trainer(string voornaam, string familienaam, int leeftijd, List<string> diplomas, double loon, List<string> voorbijeploegen, string huidigeploeg) : base(voornaam, familienaam, leeftijd, voorbijeploegen, huidigeploeg)
        {
            Loon = loon;
            Diplomas = diplomas;
        }

        public Trainer(string voornaam, string familienaam, int leeftijd, double loon, string huidigeploeg) : base(voornaam, familienaam, leeftijd, huidigeploeg)
        {
            Loon = loon;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Die heeft een loon van €{Loon} en heeft volgende diploma's: {Diplomas}";
        }
    }
}