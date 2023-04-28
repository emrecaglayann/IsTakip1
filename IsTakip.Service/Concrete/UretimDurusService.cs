using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Service.Abstract;

namespace IsTakip.Service.Concrete
{
    public class UretimDurusService : IUretimDurusService
    {
        readonly private IUretimDurusRepository _uretimDurusRepository;

        public UretimDurusService(IUretimDurusRepository uretimDurusRepository)
        {
            _uretimDurusRepository = uretimDurusRepository;
        }
        public UretimDurus CreateUretimDurus(UretimDurus uretimDurus)
        {

            return _uretimDurusRepository.CreateUretimDurus(uretimDurus);
        }

        public void DeleteUretimDurus(int id)
        {
            _uretimDurusRepository.DeleteUretimDurus(id);
        }

        public List<UretimDurus> GetAllUretimDurus()
        {
            return _uretimDurusRepository.GetAllUretimDurus();
        }

        public UretimDurus GetUretimDurusById(int id)
        {
            return (_uretimDurusRepository.GetUretimDurusById(id));

        }

        public UretimDurus UpdateUretimDurus(UretimDurus uretimDurus)
        {
            return (_uretimDurusRepository.UpdateUretimDurus(uretimDurus));
        }
    }
}
