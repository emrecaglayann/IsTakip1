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
    public class MalzemeTipService : IMalzemeTipService
    {
        readonly private IMalzemeTipRepository _malzemeTipRepository;
        public MalzemeTipService(IMalzemeTipRepository malzemeTipRepository)
        {
            _malzemeTipRepository = malzemeTipRepository;
        }
        public MalzemeTip CreateMalzemeTip(MalzemeTip malzemeTip)
        {
            return _malzemeTipRepository.CreateMalzemeTip(malzemeTip);
        }

        public void DeleteMalzemeTip(int id)
        {
            _malzemeTipRepository.DeleteMalzemeTip(id);
        }

        public List<MalzemeTip> GetAllMalzemeTip()
        {
            return _malzemeTipRepository.GetAllMalzemeTip();

        }

        public MalzemeTip GetMalzemeTipById(int id)
        {
            return (_malzemeTipRepository.GetMalzemeTipById(id));
        }

        public MalzemeTip UpdateMalzemeTip(MalzemeTip malzemeTip)
        {
            return (_malzemeTipRepository.UpdateMalzemeTip(malzemeTip));
        }
    }
}
