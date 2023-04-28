using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class UretimDurus : BaseObject
    {
        public int UretimEmriId { get; set; }
        public decimal DurusSuresi { get; set; }
        public int DurusTipId { get; set; }


        public DurusTip DurusTip { get;set; }
    }
}
