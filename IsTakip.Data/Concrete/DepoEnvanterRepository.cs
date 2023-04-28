using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Concrete
{
	public class DepoEnvanterRepository : IDepoEnvanterRepository
	{
		public DepoEnvanter CreateDepoEnvanter(DepoEnvanter depoEnvanter)
		{
			using (var _context = new DataContext())
			{
				_context.DepoEnvanter.Add(depoEnvanter);
				_context.SaveChanges();
				return depoEnvanter;
			}
		}

		public void DeleteDepoEnvanter(int id)
		{
			using (var _context = new DataContext())
			{
				var silinecekP = GetDepoEnvanterById(id);

				_context.DepoEnvanter.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<DepoEnvanter> GetAllDepoEnvanter()
		{
			using (var _context = new DataContext())
			{
				return _context.DepoEnvanter.ToList();
			}
		}

		public DepoEnvanter GetDepoEnvanterById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.DepoEnvanter.Find(id);
			}
		}

		public DepoEnvanter UpdateDepoEnvanter(DepoEnvanter depoEnvanter)
		{
			using (var _context = new DataContext())
			{
				_context.DepoEnvanter.Update(depoEnvanter);
				_context.SaveChanges();

				return depoEnvanter;
			}
		}
	}
}
