using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class Is : BaseObject
    {
        public int MusteriId { get; set; }
        public bool Teklifli { get; set; }
        public int TeklifNo { get; set; }
        public int Fiyat { get; set; }
        public bool IsBitimindeBildir { get; set; }
        public string Termin { get; set; }
        public string IsOnceliği { get; set; }
        public int MusteriSiparisNo { get; set; }
        public int IsNotu { get; set; }
        public int MalzemeTipId { get; set; }
        public int KalinlikId { get; set; }
        public bool Iscilik { get; set; }
        public string MalzemeNotu { get; set; }


        public Musteri Musteri { get; set; }    
		public IsOnceligi IsOnceligi{ get; set; }
		public UretimEmri UretimEmri { get; set; }
		public List<IsDosya> IsDosyalar { get; set; }
		public KalinlikId KalinliklarId { get; set; }
        public List <MalzemeTip> MalzemeTip {get; set; }
        public Depo Depo { get; set; }


	}
}
