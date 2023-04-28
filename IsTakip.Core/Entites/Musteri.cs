using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class Musteri : BaseObject
    {
        public string Tanim { get; set; }  
        public int MusteriSinifId { get; set; }  
        public string Adres { get; set; }  
        public int Telefon { get; set; }  
        public string Email { get; set; }  
        public string VergiDairesi { get; set; }  
        public int VergiNumarasi { get; set; }
        public string Aciklama { get; set; }

        public List<Is> Is { get; set; }
        public List<MusteriSinif> MusteriSinif { get; set; }
        public List<MusteriTemsilcisi> MusteriTemsilcisi { get; set; }

    }
}
