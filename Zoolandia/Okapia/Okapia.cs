using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Okapia
{
    class Okapia : Genus
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
            this.url = "https://en.wikipedia.org/wiki/Okapi";
            this.trait = "amalgamum-ness";
            this.commonName = "Okapi";
            this.scientificName = "Okapia";
        }

        public Okapia()
        {
            this.init();
        }

        public Okapia(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
