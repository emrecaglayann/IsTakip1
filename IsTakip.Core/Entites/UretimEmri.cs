using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class UretimEmri : BaseObject
    {
        public int IsId { get; set; }
        public DateTime IsEmriTarihi { get; set; }
		//public int ToplamDurusSuresi { get; set; } ==> "TimeSpan" sınıfının her yerde kullanılabileceği ve erişilebileceği anlamına gelir. "TimeSpan" sınıfı, iki tarih veya zaman arasındaki farkı ölçmek, zaman aralığına göre işlemler yapmak veya zaman dilimlerini ölçmek gibi işlemler için kullanılabilir.

		public TimeSpan ToplamDurusSuresi { get; set; }
		public DateTime? UretimBaslamaTarihi { get; set; }
        public DateTime? UretimTamamlanmaTarihi { get; set; }
        public bool UretimDurum { get; set; }


		public List<UretimDurus> UretimDurus { get; set; }
		public UretimDurum UretimDurumlari { get; set; }
	}
}
