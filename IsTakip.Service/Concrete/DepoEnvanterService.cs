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
	public class DepoEnvanterService : IDepoEnvanterService
	{
		readonly private IDepoEnvanterRepository _depoEnvanterRepository;

		public DepoEnvanterService(IDepoEnvanterRepository depoEnvanterRepository)
		{
			_depoEnvanterRepository = depoEnvanterRepository;
		}
		public DepoEnvanter CreateDepoEnvanter(DepoEnvanter depoEnvanter)
		{
			return _depoEnvanterRepository.CreateDepoEnvanter(depoEnvanter);
		}

		public void DeleteDepoEnvanter(int id)
		{
			_depoEnvanterRepository.DeleteDepoEnvanter(id);
		}

		public List<DepoEnvanter> GetAllDepoEnvanter()
		{
			return _depoEnvanterRepository.GetAllDepoEnvanter();
		}

		public DepoEnvanter GetDepoEnvanterById(int id)
		{
			return (_depoEnvanterRepository.GetDepoEnvanterById(id));
		}

		public DepoEnvanter UpdateDepoEnvanter(DepoEnvanter depoEnvanter)
		{
			return (_depoEnvanterRepository.UpdateDepoEnvanter(depoEnvanter));
		}
	}
}
