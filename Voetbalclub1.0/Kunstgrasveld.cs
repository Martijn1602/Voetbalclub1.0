using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Kunstgrasveld : Velden
    {
        public int Levensduur { get; set; }

        public Kunstgrasveld (string naam, int breedte, int lengte, string ligging, int levensduur) : base(naam, breedte, lengte, ligging)
        {
            Levensduur = levensduur;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" dit veld gaat {Levensduur} jaren mee.";
        }
    }
}
