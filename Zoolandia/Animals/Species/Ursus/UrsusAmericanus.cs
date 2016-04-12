using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    
    class UrsusAmericanus : Species
    {
        public UrsusAmericanus()
        {
            this.url = "https://en.wikipedia.org/wiki/American_black_bear";
            this.genus = new Ursus("Americanus");
            this.scientificName = "Ursus americanus";
            this.commonName = "American Black Bear";
        }
    }
}
