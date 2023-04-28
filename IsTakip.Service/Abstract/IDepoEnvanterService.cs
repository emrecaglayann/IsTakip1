using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
	public interface IDepoEnvanterService
	{
		List<DepoEnvanter> GetAllDepoEnvanter(); //hepsini al, listele
		DepoEnvanter GetDepoEnvanterById(int id); //kimliğe göre depo al
		DepoEnvanter CreateDepoEnvanter(DepoEnvanter depoEnvanter); //DepoEnvanter oluşturma metodu 
		DepoEnvanter UpdateDepoEnvanter(DepoEnvanter depoEnvanter); //güncelleme işlemi 
		void DeleteDepoEnvanter(int id); //silme işlemi
	}
}

