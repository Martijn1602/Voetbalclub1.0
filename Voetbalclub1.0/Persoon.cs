using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Persoon
    {
        public string Voornaam { get; set; }

        public string Familienaam { get; set; }
        public int Leeftijd { get; set; }
        public List<string> VoorbijePloegen { get; set; }

        public string HuidigePloeg { get; set; }

        public Persoon(string voornaam, string familienaam, int leeftijd, List<string> voorbijeploegen, string huidigeploeg)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Leeftijd = leeftijd;
            VoorbijePloegen = voorbijeploegen;
            HuidigePloeg = huidigeploeg;
        }

        public Persoon(string voornaam, string familienaam, int leeftijd, string huidigeploeg)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
            Leeftijd = leeftijd;
            HuidigePloeg = huidigeploeg;
        }

        public virtual string Beschrijf()
        {
            string beschrijving;

            if (VoorbijePloegen.Count != 0)
            {
                beschrijving = $"Deze persoon heet {Voornaam} {Familienaam} en is {Leeftijd} jaar oud. Deze persoon speelt nu bij {HuidigePloeg} en voordien bij {VoorbijePloegen}";

                foreach (var item in VoorbijePloegen)
                {
                    beschrijving += " " + item;
                }

                beschrijving += ". ";
            }
            else
            {
                beschrijving = $"Deze persoon heet {Voornaam} {Familienaam} en is {Leeftijd} jaar oud. Deze persoon speelt nu bij {HuidigePloeg}.";
            }

            return beschrijving;
        }

        public override string ToString()
        {
            return Familienaam;
            
        }
    }
}
