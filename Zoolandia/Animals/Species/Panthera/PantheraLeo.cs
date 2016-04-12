using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class PantheraLeo : Species
    {
        public PantheraLeo()
        {
            this.url = "https://en.wikipedia.org/wiki/Leo";
            this.genus = new Panthera("Leo");
            this.scientificName = "Panthera leo";
            this.commonName = "Lion";
        }
    }
}
