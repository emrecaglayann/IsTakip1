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
    public class TedarikciService : ITedarikciService
	{
		readonly private ITedarikciRepository _tedarikciRepository;

		public TedarikciService(ITedarikciRepository tedarikciRepository)
		{
			_tedarikciRepository = tedarikciRepository;
		}


		public Tedarikci CreateTedarikci(Tedarikci tedarikci)
		{
			return _tedarikciRepository.CreateTedarikci(tedarikci);
		}

		public void DeleteTedarikci(int id)
		{
			_tedarikciRepository.DeleteTedarikci(id);
		}

		public List<Tedarikci> GetAllTedarikci()
		{
			return _tedarikciRepository.GetAllTedarikci();
		}

		public Tedarikci GetTedarikciById(int id)
		{
			return (_tedarikciRepository.GetTedarikciById(id));
		}

		public Tedarikci UpdateTedarikci(Tedarikci tedarikci)
		{
			return (_tedarikciRepository.UpdateTedarikci(tedarikci));

		}
	}
}
