using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class KalinlikId : BaseObject
    {
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
    
        public List<Is> Is { get; set; }
        public List<DepoEnvanter> DepoEnvanter { get; set;}
    }
}
