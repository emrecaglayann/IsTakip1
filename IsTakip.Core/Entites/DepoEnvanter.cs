namespace IsTakip.Core.Entites
{
	public class DepoEnvanter : BaseObject
    {
		public int DepoId { get; set; }
		public int DepoRafId { get; set; }
		public int MalzemeTipiId { get; set; }
		public int KalinlikId { get; set; }
		public int En { get; set; }
		public int Boy { get; set; }
		public int Adet { get; set; }
		public int Agirlik { get; set; }
		public string Aciklama { get; set; }
		public int? MusteriId { get; set; }

		//public int DepoId { get; set; }
		//public int DepoRafId { get; set; }
		//public int MalzemeTipId { get; set; }
		//public int KalinlikId { get; set; }
		//public decimal En { get; set; }
		//public decimal Boy { get; set; }
		//public int Adet { get; set; }
		//public decimal Agirlik { get; set; }
		//public string Aciklama { get; set; }
		//public int? MusteriId { get; set; }

		public KalinlikId KalinliklarId { get; set; }
		public List<MalzemeTip> MalzemeTip { get; set; }




	}
}
