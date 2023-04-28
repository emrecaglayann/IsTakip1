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
	public class MusteriTemsilcisiRepository : IMusteriTemsilcisiRepository
	{
		public MusteriTemsilcisi CreateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi)
		{
			using (var _context = new DataContext())
			{
				_context.MusteriTemsilcisi.Add(musteriTemsilcisi);
				_context.SaveChanges();
				return musteriTemsilcisi;
			}
		}

		public void DeleteMusteriTemsilcisi(int id)
		{
			using (var _context = new DataContext())
			{
				var silinecekP = GetMusteriTemsilcisiById(id);

				_context.MusteriTemsilcisi.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<MusteriTemsilcisi> GetAllMusteriTemsilcisi()
		{
			using (var _context = new DataContext())
			{
				return _context.MusteriTemsilcisi.ToList();
			}
		}

		public MusteriTemsilcisi GetMusteriTemsilcisiById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.MusteriTemsilcisi.Find(id);
			}
		}

		public MusteriTemsilcisi UpdateMusteriTemsilcisi(MusteriTemsilcisi musteriTemsilcisi)
		{
			using (var _context = new DataContext())
			{
				_context.MusteriTemsilcisi.Update(musteriTemsilcisi);
				_context.SaveChanges();

				return musteriTemsilcisi;
			}
		}
	}
}
