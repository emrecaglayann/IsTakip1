using IsTakip.Core.Enums;

namespace IsTakip.Core.Entites
{
    public class Kullanici : BaseObject
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? MusteriId   { get; set; }
        public string KullaniciSifre { get; set; }
        public string KullaniciKodu { get; set; }      
        public bool MailBildirim { get; set; }
        public RoleTanim RoleTanim { get; set; }

        

    }
}
