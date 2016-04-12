using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Phacochoerus : Genus
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
            this.url = "https://en.wikipedia.org/wiki/Phacochoerus";
            this.trait = "Tusks";
            this.commonName = "Warthog";
            this.scientificName = "Phacochoerus";
        }

        public Phacochoerus()
        {
            this.init();
        }

        public Phacochoerus(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}