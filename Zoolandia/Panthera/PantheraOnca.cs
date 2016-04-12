using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Panthera
{
    class PantheraOrca : Species
    {
        public PantheraOrca()
        {
            this.url = "https://en.wikipedia.org/wiki/Jaguar";
            this.genus = new Panthera("Onca");
            this.scientificName = "Panthera onca";
            this.commonName = "Jaguar";
        }
    }
}
