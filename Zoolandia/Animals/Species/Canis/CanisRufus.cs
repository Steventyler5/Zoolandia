using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class CanisRufus : Species
    {
        public CanisRufus()
        {
            this.url = "https://en.wikipedia.org/wiki/Canis_rufus";
            this.genus = new Canis("Rufus");
            this.scientificName = "Canis rufus";
            this.commonName = "Red Wolf";
        }
    }
}
