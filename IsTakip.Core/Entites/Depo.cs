namespace IsTakip.Core.Entites
{
    public class Depo : BaseObject
    {
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
        public string Yetkili { get; set; }
        public string YetkiliTelefon { get; set; }

        public List<Musteri> Musteri { get; set; }
        public DepoEnvanter DepoEnvanter { get; set; }
        public List<DepoRaf> DepoRaf { get; set; }
        public List <Tedarikci> Tedarikci { get;set; }
    }
     
   
}
