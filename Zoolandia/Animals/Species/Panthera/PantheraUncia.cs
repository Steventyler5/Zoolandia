using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class PantheraUncia : Species 
    {
        public PantheraUncia()
        {
            this.url = "https://en.wikipedia.org/wiki/Snow_leopard";
            this.genus = new Panthera("Uncia");
            this.scientificName = "Panthera uncia";
            this.commonName = "Snow Leopard";
        }
    }
}
