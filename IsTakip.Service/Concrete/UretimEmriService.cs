using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Service.Abstract;

namespace IsTakip.Service.Concrete
{
    public class UretimEmriService : IUretimEmriService
	{
		readonly private IUretimEmriRepository _uretimEmriRepository;

		public UretimEmriService(IUretimEmriRepository uretimEmriRepository)
		{
			_uretimEmriRepository = uretimEmriRepository;
		}
		public UretimEmri CreateUretimEmri(UretimEmri uretimEmri)
		{
			return _uretimEmriRepository.CreateUretimEmri(uretimEmri);
		}

		public void DeleteUretimEmri(int id)
		{
			_uretimEmriRepository.DeleteUretimEmri(id);
		}

		public List<UretimEmri> GetAllUretimEmri()
		{
			return _uretimEmriRepository.GetAllUretimEmri();
		}

		public UretimEmri GetUretimEmriById(int id)
		{
			return (_uretimEmriRepository.GetUretimEmriById(id));
		}

		public UretimEmri UpdateUretimEmri(UretimEmri uretimEmri)
		{
			return (_uretimEmriRepository.UpdateUretimEmri(uretimEmri));
		}
	}
}
