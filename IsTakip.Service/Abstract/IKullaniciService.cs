using IsTakip.Core.Entites;

namespace IsTakip.Service.Abstract
{
	public interface IKullaniciService
	{
		List<Kullanici> GetAllKullanici(); //hepsini al, listele
		Kullanici GetKullaniciById(int id); //kimliğe göre depo al
		Kullanici CreateKullanici(Kullanici kullanici); //kullanici oluşturma metodu 
		Kullanici UpdateKullanici(Kullanici kullanici); //güncelleme işlemi 
		void DeleteKullanici(int id); //silme işlemi 
	}
}
