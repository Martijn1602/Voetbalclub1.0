using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Bestuurder : Persoon
    {
        public double Loon { get; set; }
        public string Functie { get; set; }

        public Bestuurder(string voornaam, string familienaam, int leeftijd, string functie, double loon, List<string> voorbijeploegen, string huidigeploeg) : base(voornaam, familienaam, leeftijd, voorbijeploegen, huidigeploeg)
        {
            Loon = loon;
            Functie = functie;
        }

        public Bestuurder(string voornaam, string familienaam, int leeftijd, string functie, List<string> voorbijeploegen, string huidigeploeg) : base(voornaam, familienaam, leeftijd, voorbijeploegen, huidigeploeg)
        {
            Functie = functie;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Die heeft een loon van €{Loon} en heeft volgende functie: {Functie}";
        }
    }
}
