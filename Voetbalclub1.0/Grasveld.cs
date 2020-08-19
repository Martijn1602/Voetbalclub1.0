using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voetbalclub1._0
{
    public class Grasveld : Velden
    {
        public string TypeGras { get; set; }
        public List<string> TypeVeld { get; set; }


        public Grasveld(string naam, int breedte, int lengte, string ligging, string typegras, List<string> typeveld) : base(naam, breedte, lengte, ligging)
        {
            TypeGras = typegras;
            TypeVeld = typeveld;
        }

        public override string Beschrijf()
        {
            return base.Beschrijf() + $" Dit veld is een {TypeVeld} en heeft {TypeGras} als grassoort.";
        }
    }
}
