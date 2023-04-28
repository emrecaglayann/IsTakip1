using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Service.Abstract;

namespace IsTakip.Service.Concrete
{
    public class MusteriService : IMusteriService
	{
		readonly private IMusteriRepository _musteriRepository;

		public MusteriService(IMusteriRepository musteriRepository)
		{
			_musteriRepository = musteriRepository;
		}
		public Musteri CreateMusteri(Musteri musteri)
		{
			return _musteriRepository.CreateMusteri(musteri);
		}

		public void DeleteMusteri(int id)
		{
			_musteriRepository.DeleteMusteri(id);
		}

		public List<Musteri> GetAllMusteri()
		{
			return _musteriRepository.GetAllMusteri();
		}

		public Musteri GetMusteriById(int id)
		{
			return (_musteriRepository.GetMusteriById(id));
		}

		public Musteri UpdateMusteri(Musteri musteri)
		{
			return (_musteriRepository.UpdateMusteri(musteri));
		}
	}
}
