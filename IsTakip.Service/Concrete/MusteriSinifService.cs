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
    public class MusteriSinifService : IMusteriSinifService
    {
        readonly private IMusteriSinifRepository _musteriSinifRepository;

        public MusteriSinifService(IMusteriSinifRepository musteriSinifRepository)
        {
            _musteriSinifRepository = musteriSinifRepository;
        }
        public MusteriSinif CreateMusteriSinif(MusteriSinif musteriSinif)
        {
            return _musteriSinifRepository.CreateMusteriSinif(musteriSinif);
        }

        public void DeleteMusteriSinif(int id)
        {
            _musteriSinifRepository.DeleteMusteriSinif(id);
        }

        public List<MusteriSinif> GetAllMusteriSinif()
        {
            return _musteriSinifRepository.GetAllMusteriSinif();
        }

        public MusteriSinif GetMusteriSinifById(int id)
        {
            return (_musteriSinifRepository.GetMusteriSinifById(id));
        }

        public MusteriSinif UpdateMusteriSinif(MusteriSinif musteriSinif)
        {
            return (_musteriSinifRepository.UpdateMusteriSinif(musteriSinif));
        }
    }
}
