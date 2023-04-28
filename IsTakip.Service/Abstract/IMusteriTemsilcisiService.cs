using IsTakip.Core.Entites;

namespace IsTakip.Service.Abstract
{
	public interface IMusteriTemsilcisiService
	{
		List<MusteriTemsilcisi> GetAllMusteriTemsilcisi(); //hepsini al, listele
		MusteriTemsilcisi GetMusteriTemsilcisiById(int id); //kimliğe göre depo al
		MusteriTemsilcisi CreateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi); //MusteriTemsilcisi oluşturma metodu 
		MusteriTemsilcisi UpdateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi); //güncelleme işlemi 
		void DeleteMusteriTemsilcisi(int id); //silme işlemi
        Task GetListAsync();
    }
}
