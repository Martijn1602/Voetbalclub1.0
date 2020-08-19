using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Velden
    {
        public string Naam { get; set; }
        public int Breedte { get; set; }
        public int Lengte { get; set; }
        public string Ligging { get; set; }
        

        public Velden(string naam, int breedte, int lengte, string ligging)
        {
            Naam = naam;
            Breedte = breedte;
            Lengte = lengte;
            Ligging = ligging;
        }

      
        public virtual string Beschrijf()
        {
            string beschrijving;

            {
                beschrijving = $"Dit is veld {Naam}. De lengte is {Lengte}m en de breedte is {Breedte}m. Het is gelegen op {Ligging}.";
            }

            return beschrijving;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
