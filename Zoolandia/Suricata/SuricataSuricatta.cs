using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Suricata
{
    class SuricataSuricatta : Species
    {
        public SuricataSuricatta()
        {
            this.url = "https://en.wikipedia.org/wiki/Suricata_suricatta";
            this.genus = new Suricata("Suricatta");
            this.scientificName = "Suricata suricatta";
            this.commonName = "Meerkat";
        }
    }
}
