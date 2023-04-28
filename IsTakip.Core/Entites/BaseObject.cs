using System.ComponentModel.DataAnnotations.Schema;

namespace IsTakip.Core.Entites
{
    public class BaseObject
    {
        public int Id { get; set; }
        public string OlusturanKullanici { get; set; }
        public int OlusturanKullaniciId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime OlusturmaTarihi { get; set;} = DateTime.Now;
        public string GuncelleyenKullanici {  get; set; } 
        public string GuncelleyenKullaniciId {  get; set; }
        public DateTime? GüncellemeTarihi {  get; set; }
        public bool Aktif { get; set; }
        public bool Silindi {  get; set; }

        
    }
}
