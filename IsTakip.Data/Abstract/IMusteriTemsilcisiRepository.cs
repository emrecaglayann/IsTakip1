using IsTakip.Core.Entites;

namespace IsTakip.Data.Abstract
{
	public interface IMusteriTemsilcisiRepository
	{
		List<MusteriTemsilcisi> GetAllMusteriTemsilcisi(); //hepsini al, listele
		MusteriTemsilcisi GetMusteriTemsilcisiById(int id); //kimliğe göre depo al
		MusteriTemsilcisi CreateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi); //depo oluşturma metodu 
		MusteriTemsilcisi UpdateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi); //güncelleme işlemi 
		void DeleteMusteriTemsilcisi(int id); //silme işlemi 
	}
}
