using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Service.Abstract;

namespace IsTakip.Service.Concrete
{
	public class KullaniciService : IKullaniciService
	{
		readonly private IKullaniciRepository _kullaniciRepository;

		public KullaniciService(IKullaniciRepository kullaniciRepository)
		{
			_kullaniciRepository = kullaniciRepository;
		}

		public Kullanici CreateKullanici(Kullanici kullanici)
		{
			return _kullaniciRepository.CreateKullanici(kullanici);
		}

		public void DeleteKullanici(int id)
		{
			_kullaniciRepository.DeleteKullanici(id);
		}

		public List<Kullanici> GetAllKullanici()
		{
			return _kullaniciRepository.GetAllKullanici();
		}

		public Kullanici GetKullaniciById(int id)
		{
			return (_kullaniciRepository.GetKullaniciById(id));

		}

		public Kullanici UpdateKullanici(Kullanici kullanici)
		{
			return (_kullaniciRepository.UpdateKullanici(kullanici));
		}
	}
}
