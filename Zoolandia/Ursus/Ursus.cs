using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Ursus
{
    /*
      Genus class
     */
    class Ursus : Genus
    {
        private string _continent;

        public string continent
        {
            get
            {
                return _continent;
            }
            set
            {
                if (value != "")
                {
                    _continent = value;
                }
            }
        }

        private void init()
        {
            this.url = "https://en.wikipedia.org/wiki/Ursus";
            this.trait = "idk, bear stuff";
            this.commonName = "Bear";
            this.scientificName = "Ursus";
        }

        public Ursus()
        {
            this.init();
        }

        public Ursus(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
