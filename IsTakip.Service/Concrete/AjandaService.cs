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
    public class AjandaService : IAjandaService
    {

        readonly private IAjandaRepository _ajandaRepository;

        public AjandaService(IAjandaRepository ajandaRepository)
        {
            _ajandaRepository = ajandaRepository;
        }

        public Ajanda CreateAjanda(Ajanda ajanda)
        {
            return _ajandaRepository.CreateAjanda(ajanda);
        }

        public void DeleteAjanda(int id)
        {
            _ajandaRepository.DeleteAjanda(id);
        }

        public Ajanda GetAjandaById(int id)
        {
            return (_ajandaRepository.GetAjandaById(id));
        }

        public List<Ajanda> GetAllAjanda()
        {
            return _ajandaRepository.GetAllAjanda();
        }

        public Ajanda UpdateAjanda(Ajanda ajanda)
        {
            return (_ajandaRepository.UpdateAjanda(ajanda));
        }
    }
}
