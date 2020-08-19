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

        public Trainer(string naam, int leeftijd, List<string> diplomas, double loon) : base(naam, leeftijd)
        {
            Loon = loon;
            Diplomas = diplomas;
        }

        public Trainer(string naam, int leeftijd, double loon) : base(naam, leeftijd)
        {
            Loon = loon;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Die heeft een loon van €{Loon} en heeft volgende diploma's: {Diplomas}";
        }
    }
}