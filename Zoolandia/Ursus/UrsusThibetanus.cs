using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Ursus
{
    class UrsusThibetanus : Species
    {
        public UrsusThibetanus()
        {
            this.url = "https://en.wikipedia.org/wiki/Polar_bear";
            this.genus = new Ursus("Thibetanus");
            this.scientificName = "Ursus thibetanus";
            this.commonName = "Asian Black Bear";
        }
    }
}
