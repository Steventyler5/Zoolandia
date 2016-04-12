using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Phacochoerus
{
    class PhacochoerusAfricanus : Species
    {
        public PhacochoerusAfricanus()
        {
            this.url = "https://en.wikipedia.org/wiki/Phacochoerus_africanus";
            this.genus = new Phacochoerus("Africanus");
            this.scientificName = "Phacochoerus africanus";
            this.commonName = "Common Warthog";
        }
    }
}
