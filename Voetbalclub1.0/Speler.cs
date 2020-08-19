using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Speler : Persoon
    {
        public string Voorkeurvoet { get; set; }
        public string Positie { get; set; }
        public Speler(string voornaam, string familienaam, int leeftijd, List<string> voorbijeploegen, string huidigeploeg, string voorkeurvoet, string positie) : base(voornaam, familienaam, leeftijd, voorbijeploegen, huidigeploeg)
        {
            Voorkeurvoet = voorkeurvoet;
            Positie = positie;
        }

        public Speler(string voornaam, string familienaam, int leeftijd, string huidigeploeg, string voorkeurvoet, string positie) : base(voornaam, familienaam, leeftijd, huidigeploeg)
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