using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Service.Abstract;

namespace IsTakip.Service.Concrete
{
	public class KalinlikIdService : IKalinlikIdService
    {

        readonly private IKalinlikIdRepository _kalinlikIdRepository;

        public KalinlikIdService(IKalinlikIdRepository kalinlikIdRepository)
        {
            _kalinlikIdRepository = kalinlikIdRepository;
        }
        public KalinlikId CreateKalinlikId(KalinlikId kalinlikId)
        {
            return _kalinlikIdRepository.CreateKalinlikId(kalinlikId);
        }

        public void DeleteKalinlikId(int id)
        {
            _kalinlikIdRepository.DeleteDepo(id);
        }

        public List<KalinlikId> GetAllKalinlikId()
        {
            return _kalinlikIdRepository.GetAllKalinlikId();
        }

        public KalinlikId GetKalinlikIdById(int id)
        {
            return (_kalinlikIdRepository.GetKalinlikIdById(id));
        }

        public KalinlikId UpdateKalinlikId(KalinlikId kalinlikId)
        {
            return (_kalinlikIdRepository.UpdateKalinlikId(kalinlikId));
        }
    }
}
