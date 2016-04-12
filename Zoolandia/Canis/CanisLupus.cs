using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Canis
{
    class CanisLupus : Species
    {
        public CanisLupus()
        {
            this.url = "https://en.wikipedia.org/wiki/Canis_lupus";
            this.genus = new Canis("Lupus");
            this.scientificName = "Canis lupus";
            this.commonName = "Gray Wolf";
        }
    }
}
