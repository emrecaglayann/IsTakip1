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
    public class DurusTipService : IDurusTipService
    {
        readonly private IDurusTipRepository _durusTipRepository;

        public DurusTipService(IDurusTipRepository durusTipRepository)
        {
            _durusTipRepository = durusTipRepository;
        }
        public DurusTip CreateDurusTip(DurusTip durusTip)
        {
            return _durusTipRepository.CreateDurusTip(durusTip);
        }

        public void DeleteDurusTip(int id)
        {
            _durusTipRepository.DeleteDurusTip(id);
        }

        public List<DurusTip> GetAllDurusTip()
        {
            return _durusTipRepository.GetAllDurusTip();
        }

        public DurusTip GetDurusTipById(int id)
        {
            return (_durusTipRepository.GetDurusTipById(id));
        }

        public DurusTip UpdateDurusTip(DurusTip durusTip)
        {
            return (_durusTipRepository.UpdateDurusTip(durusTip));
        }
    }
}
