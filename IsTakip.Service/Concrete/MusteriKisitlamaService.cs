using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Concrete;
using IsTakip.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Concrete
{
    public class MusteriKisitlamaService : IMusteriKisitlamaService
    {

        readonly private IMusteriKisitlamaRepository _musteriKisitlamaRepository;

        public MusteriKisitlamaService(IMusteriKisitlamaRepository musteriKisitlamaRepository)
        {
            _musteriKisitlamaRepository = musteriKisitlamaRepository;
        }
        public MusteriKisitlama CreateMusteriKisitlama(MusteriKisitlama musteriKisitlama)
        {
            return _musteriKisitlamaRepository.CreateMusteriKisitlama(musteriKisitlama);
        }

        public void DeleteMusteriKisitlama(int id)
        {
            _musteriKisitlamaRepository.DeleteMusteriKisitlama(id);
        }

        public List<MusteriKisitlama> GetAllMusteriKisitlama()
        {
            return _musteriKisitlamaRepository.GetAllMusteriKisitlama();
        }

        public MusteriKisitlama GetMusteriKisitlamaById(int id)
        {
            return (_musteriKisitlamaRepository.GetMusteriKisitlamaById(id));
        }

        public MusteriKisitlama UpdateMusteriKisitlama(MusteriKisitlama musteriKisitlama)
        {
            return (_musteriKisitlamaRepository.UpdateMusteriKisitlama(musteriKisitlama));
        }
    }
}
