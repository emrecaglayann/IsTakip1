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
	public class UretimEmriRepository : IUretimEmriRepository
	{
		public UretimEmri CreateUretimEmri(UretimEmri uretimEmri)
		{
			using (var _context = new DataContext())
			{
				_context.UretimEmri.Add(uretimEmri);
				_context.SaveChanges();
				return uretimEmri;
			}
		}

		public void DeleteUretimEmri(int id)
		{
			using (var _context = new DataContext())
			{
				var silinecekP = GetUretimEmriById(id);

				_context.UretimEmri.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<UretimEmri> GetAllUretimEmri()
		{
			using (var _context = new DataContext())
			{
				return _context.UretimEmri.ToList();
			}
		}

		public UretimEmri GetUretimEmriById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.UretimEmri.Find(id);
			}
		}

		public UretimEmri UpdateUretimEmri(UretimEmri uretimEmri)
		{
			using (var _context = new DataContext())
			{
				_context.UretimEmri.Update(uretimEmri);
				_context.SaveChanges();

				return uretimEmri;
			}
		}
	}
}
