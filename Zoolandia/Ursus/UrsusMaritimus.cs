using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Ursus
{
    class UrsusMaritimus : Species
    {
        public UrsusMaritimus()
        {
            this.url = "https://en.wikipedia.org/wiki/Polar_bear";
            this.genus = new Ursus("Maritimus");
            this.scientificName = "Ursus maritimus";
            this.commonName = "Polar Bear";
        }
    }
}
