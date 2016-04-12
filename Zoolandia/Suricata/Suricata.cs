using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Suricata
{
    class Suricata : Genus
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
            this.url = "https://en.wikipedia.org/wiki/Suricata";
            this.trait = "They like warthogs?";
            this.commonName = "Meerkat";
            this.scientificName = "Suricata";
        }

        public Suricata()
        {
            this.init();
        }

        public Suricata(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
