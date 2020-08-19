using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Persoon
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public List<string> Ploegen { get; set; }

        public Persoon(string naam, int leeftijd, List<string> ploegen)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Ploegen = ploegen;
        }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Ploegen = new List<string>();
        }

        public virtual string Beschrijf()
        {
            string beschrijving;

            if (Ploegen.Count != 0)
            {
                beschrijving = $"Deze persoon heet {Naam}, wiens leeftijd is {Leeftijd} met de als voorbije ploegen";

                foreach (var item in Ploegen)
                {
                    beschrijving += " " + item;
                }

                beschrijving += ". ";
            }
            else
            {
                beschrijving = $"Deze persoon heet {Naam}. Diens leeftijd is {Leeftijd}. ";
            }

            return beschrijving;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
