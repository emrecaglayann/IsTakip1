using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class DurusTip : BaseObject
    {
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
    
    
        public List<UretimDurus> UretimDurus { get; set; }    
    }
}
