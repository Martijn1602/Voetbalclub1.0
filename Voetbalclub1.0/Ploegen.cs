using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Ploegen
    {
        public string Naam { get; set; }
        public int AantalSpelers { get; set; }
        public string Reeks { get; set; }


        public Ploegen (string naam, int aantalspel, string reeks)
        {
            Naam = naam;
            AantalSpelers = aantalspel;
            Reeks = reeks;
        }


        public virtual string Beschrijf()
        {
            string beschrijving;

            {
                beschrijving = $"Dit is de {Naam}. Er spelen {AantalSpelers} spelers in deze ploeg. Deze ploeg speelt in de reeks: {Reeks}.";
            }

            return beschrijving;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}

