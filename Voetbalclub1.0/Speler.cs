using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Speler : Persoon
    {
        public string Voorkeurvoet { get; set; }
        public string Positie { get; set; }
        public Speler(string naam, int leeftijd, List<string> ploegen, string voorkeurvoet, string positie) : base(naam, leeftijd, ploegen)
        {
            Voorkeurvoet = voorkeurvoet;
            Positie = positie;
        }

        public Speler(string naam, int leeftijd, string voorkeurvoet, string positie) : base(naam, leeftijd)
        {
            Voorkeurvoet = voorkeurvoet;
            Positie = positie;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $"Deze speler is {Voorkeurvoet}-voetig en speelt als {Positie}.";
        }
    }
}