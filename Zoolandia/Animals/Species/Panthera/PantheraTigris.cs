using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class PantheraTigris : Species
    {
        public PantheraTigris()
        {
            this.url = "https://en.wikipedia.org/wiki/Tiger";
            this.genus = new Panthera("Tigris");
            this.scientificName = "Panthera tigris";
            this.commonName = "Tiger";
        }
    }
}
