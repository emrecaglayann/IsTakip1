namespace IsTakip.Core.Entites
{
    public class IsDosya : BaseObject
    {
        public int IsId { get; set; }
        public string DosyaAdi { get; set; }

        public List<Is> Is { get; set; }
    }
}
