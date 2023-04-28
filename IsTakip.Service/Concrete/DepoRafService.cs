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
    public class DepoRafService : IDepoRafService
    {
        readonly private IDepoRafRepository _depoRafRepository;

        public DepoRafService(IDepoRafRepository depoRafRepository)
        {
            _depoRafRepository = depoRafRepository;
        }
        public DepoRaf CreateDepoRaf(DepoRaf depoRaf)
        {
            return _depoRafRepository.CreateDepoRaf(depoRaf);
        }

        public void DeleteDepoRaf(int id)
        {
            _depoRafRepository.DeleteDepoRaf(id);
        }

        public List<DepoRaf> GetAllDepoRaf()
        {
            return _depoRafRepository.GetAllDepoRaf();
        }

        public DepoRaf GetDepoRafById(int id)
        {
            return (_depoRafRepository.GetDepoRafById(id));
        }

        public DepoRaf UpdateDepoRaf(DepoRaf depoRaf)
        {
            return (_depoRafRepository.UpdateDepoRaf(depoRaf));
        }
    }
}
