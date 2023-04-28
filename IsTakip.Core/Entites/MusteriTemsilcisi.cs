using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class MusteriTemsilcisi : BaseObject
    {
        public int MusteriId { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string Email { get; set; }
        public int TelefonNumarasi { get; set; }


        public List<Musteri> Musteri { get; set; }
        public List<Ajanda> Ajanda { get; set;}

    }
}
