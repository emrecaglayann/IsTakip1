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
    public class IsDosyaService : IIsDosyaService
    {
        readonly private IIsDosyaRepository _ısDosyaRepository;
        public IsDosyaService(IIsDosyaRepository ısDosyaRepository)
        {
            _ısDosyaRepository = ısDosyaRepository;
        }
        public IsDosya CreateIsDosya(IsDosya ısDosya)
        {
            return _ısDosyaRepository.CreateIsDosya(ısDosya);
        }

        public void DeleteIsDosya(int id)
        {
            _ısDosyaRepository.DeleteIsDosya(id);
        }

        public List<IsDosya> GetAllIsDosya()
        {
            return _ısDosyaRepository.GetAllIsDosya();
        }

        public IsDosya GetIsDosyaById(int id)
        {
            return (_ısDosyaRepository.GetIsDosyaById(id));

        }

        public IsDosya UpdateIsDosya(IsDosya ısDosya)
        {
            return (_ısDosyaRepository.UpdateIsDosya(ısDosya));
        }
    }
}
