using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Concrete
{
    public class DepoService : IDepoService
    {
        readonly private IDepoRepository _depoRepository;

        public DepoService(IDepoRepository depoRepository)
        {
            _depoRepository = depoRepository;
        }

        public Depo CreateDepo(Depo depo)
        {
            return _depoRepository.CreateDepo(depo);
        }

        public void DeleteDepo(int id)
        {
            _depoRepository.DeleteDepo(id);
        }

        public List<Depo> GetAllDepo()
        {
            return _depoRepository.GetAllDepo();
        }

        public Depo GetDepoById(int id)
        {
            return (_depoRepository.GetDepoById(id));
        }

        public Depo UpdateDepo(Depo depo)
        {
            return (_depoRepository.UpdateDepo(depo));
        }
    }
}
