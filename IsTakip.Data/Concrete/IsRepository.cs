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
	public class IsRepository : IIsRepository
	{
		public Is CreateIs(Is ıs)
		{
			using (var _context = new DataContext())
			{
				_context.Is.Add(ıs);
				_context.SaveChanges();
				return ıs;
			}
		}

		public void DeleteIs(int id)
		{
			using (var _context = new DataContext())
			{
				var silinecekP = GetIsById(id);

				_context.Is.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<Is> GetAllIs()
		{
			using (var _context = new DataContext())
			{
				return _context.Is.ToList();
			}
		}

		public Is GetIsById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.Is.Find(id);
			}
		}

		public Is UpdateIs(Is ıs)
		{
			using (var _context = new DataContext())
			{
				_context.Is.Update(ıs);
				_context.SaveChanges();

				return ıs;
			}
		}
	}
}
