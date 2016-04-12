using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Canis
{
    class Canis : Genus
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
            this.url = "https://en.wikipedia.org/wiki/Canis";
            this.trait = "Barks at cars, probably";
            this.commonName = "PUPPYYYYY";
            this.scientificName = "Canis";
        }

        public Canis()
        {
            this.init();
        }

        public Canis(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
