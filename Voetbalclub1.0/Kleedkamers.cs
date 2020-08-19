using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Kleedkamers
    {
        public string Naam { get; set; }
        public int AantalPers { get; set; }
        public string Ligging { get; set; }


        public Kleedkamers(string naam, int aantalpers, string ligging)
        {
            Naam = naam;
            AantalPers = aantalpers;
            Ligging = ligging;
        }


        public virtual string Beschrijf()
        {
            string beschrijving;

            {
                beschrijving = $"Dit is kleedkamer {Naam}. Er kunnen maximum {AantalPers} in deze kleedkamer. Het is gelegen bij {Ligging}.";
            }

            return beschrijving;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
