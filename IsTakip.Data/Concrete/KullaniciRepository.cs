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
	public class KullaniciRepository : IKullaniciRepository
	{
		public Kullanici CreateKullanici(Kullanici kullanici)
		{
			using (var _context = new DataContext())
			{
				_context.Kullanici.Add(kullanici);
				_context.SaveChanges();
				return kullanici;
			}
		}

		public void DeleteKullanici(int id)
		{
			using (var _context = new DataContext())
			{
				var silinecekP = GetKullaniciById(id);

				_context.Kullanici.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<Kullanici> GetAllKullanici()
		{
			using (var _context = new DataContext())
			{
				return _context.Kullanici.ToList();
			}
		}

		public Kullanici GetKullaniciById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.Kullanici.Find(id);
			}
		}

		public Kullanici UpdateKullanici(Kullanici kullanici)
		{
			using (var _context = new DataContext())
			{
				_context.Kullanici.Update(kullanici);
				_context.SaveChanges();

				return kullanici;
			}
		}
	}
}
