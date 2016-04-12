using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class OkapiaJohnstoni : Species
    {
        public OkapiaJohnstoni()
        {
            this.url = "https://en.wikipedia.org/wiki/Canis_latrans";
            this.genus = new Okapia("Johnstoni");
            this.scientificName = "Okapia johnstoni";
            this.commonName = "Okapi";
        }
    }
}
