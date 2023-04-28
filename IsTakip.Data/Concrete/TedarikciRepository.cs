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
	public class TedarikciRepository : ITedarikciRepository
	{
		public Tedarikci CreateTedarikci(Tedarikci tedarikci)
		{
			using (var _context = new DataContext())
			{
				_context.Tedarikci.Add(tedarikci);
				_context.SaveChanges();
				return tedarikci;
			}
		}

		public void DeleteTedarikci(int id)
		{
			using (var _context = new DataContext())
			{
				var silinecekP = GetTedarikciById(id);

				_context.Tedarikci.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<Tedarikci> GetAllTedarikci()
		{
			using (var _context = new DataContext())
			{
				return _context.Tedarikci.ToList();
			}
		}

		public Tedarikci GetTedarikciById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.Tedarikci.Find(id);
			}
		}

		public Tedarikci UpdateTedarikci(Tedarikci tedarikci)
		{
			using (var _context = new DataContext())
			{
				_context.Tedarikci.Update(tedarikci);
				_context.SaveChanges();

				return tedarikci;
			}
		}
	}
}
