using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class Panthera : Genus
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
            this.url = "https://en.wikipedia.org/wiki/Panthera";
            this.trait = "idk, big kitty stuff";
            this.commonName = "Big Cat";
            this.scientificName = "Pantnera";
        }

        public Panthera()
        {
            this.init();
        }

        public Panthera(string continent)
        {
            this.init();
            this.continent = continent;
        }
    }
}
