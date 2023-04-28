namespace IsTakip.Core.Entites
{
    public class Ajanda : BaseObject
    {
        public int MusteriId { get; set; }
        public string Aciklama { get; set; }
        public DateTime NotTarihi { get; set; }


        public MusteriTemsilcisi MusteriTemsilcisi { get; set; }
    }
}
