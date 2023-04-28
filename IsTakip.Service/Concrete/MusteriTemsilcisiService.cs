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
    public class MusteriTemsilcisiService : IMusteriTemsilcisiService
	{

		readonly private IMusteriTemsilcisiRepository _musteriTemsilcisiRepository;

		public MusteriTemsilcisiService(IMusteriTemsilcisiRepository musteriTemsilcisiRepository)
		{
			_musteriTemsilcisiRepository = musteriTemsilcisiRepository;
		}

		public MusteriTemsilcisi CreateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi)
		{
			return _musteriTemsilcisiRepository.CreateMusteriTemsilcisi(musteriTemsilcisi);
		}

		public void DeleteMusteriTemsilcisi(int id)
		{
			_musteriTemsilcisiRepository.DeleteMusteriTemsilcisi(id);
		}

		public List<MusteriTemsilcisi> GetAllMusteriTemsilcisi()
		{
			return _musteriTemsilcisiRepository.GetAllMusteriTemsilcisi();
		}

        public Task GetListAsync()
        {
            throw new NotImplementedException();
        }

        public MusteriTemsilcisi GetMusteriTemsilcisiById(int id)
		{
			return (_musteriTemsilcisiRepository.GetMusteriTemsilcisiById(id));
		}

		public MusteriTemsilcisi UpdateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi)
		{
			return (_musteriTemsilcisiRepository.UpdateMusteriTemsilcisi(musteriTemsilcisi));
		}
	}
}
