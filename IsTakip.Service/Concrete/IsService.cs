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
    public class IsService : IIsService
	{
		readonly private IIsRepository _ısRepository;
		public IsService(IIsRepository ısRepository)
		{
			_ısRepository = ısRepository;
		}
		public Is CreateIs(Is ıs)
		{
			return _ısRepository.CreateIs(ıs);
		}

		public void DeleteIs(int id)
		{
			_ısRepository.DeleteIs(id);
		}

		public List<Is> GetAllIs()
		{
			return _ısRepository.GetAllIs();
		}

		public Is GetIsById(int id)
		{
			return (_ısRepository.GetIsById(id));
		}

		public Is UpdateIs(Is ıs)
		{
			return (_ısRepository.UpdateIs(ıs));
		}
	}
}
