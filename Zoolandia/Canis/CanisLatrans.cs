using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Canis
{
    class CanisLatrans : Species
    {
        public CanisLatrans()
        {
            this.url = "https://en.wikipedia.org/wiki/Canis_latrans";
            this.genus = new Canis("Latrans");
            this.scientificName = "Canis latrans";
            this.commonName = "Coyote";
        }
    }
}
