using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class MusteriKisitlama : BaseObject
    {
        public string IslemAciklama { get; set; }
        public bool Kisitlama { get; set; }
        public int MusteriId { get; set; } 
 
    

        public List<Musteri>Musteri { get; set; }
    }
}
