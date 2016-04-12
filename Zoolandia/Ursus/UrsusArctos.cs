using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Ursus
{
    /*
      Species of Tenodera
     */
    class UrsusArctos : Species
    {
        public UrsusArctos()
        {
            this.url = "https://en.wikipedia.org/wiki/American_black_bear";
            this.genus = new Ursus("Arctos");
            this.scientificName = "Ursus arctos";
            this.commonName = "Brown Bear";
        }
    }
}
