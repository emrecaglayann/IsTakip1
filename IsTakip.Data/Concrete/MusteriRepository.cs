using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Context;

namespace IsTakip.Data.Concrete
{
	public class MusteriRepository : IMusteriRepository
	{
		public Musteri CreateMusteri(Musteri musteri)
		{
			using (var _context = new DataContext())
			{
				_context.Musteri.Add(musteri);
				_context.SaveChanges();
				return musteri;
			}
		}

		public void DeleteMusteri(int id)
		{
			using (var _context = new DataContext())
			{
				var silinecekP = GetMusteriById(id);

				_context.Musteri.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<Musteri> GetAllMusteri()
		{
			using (var _context = new DataContext())
			{
				return _context.Musteri.ToList();
			}
		}

		public Musteri GetMusteriById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.Musteri.Find(id);
			}
		}

		public Musteri UpdateMusteri(Musteri musteri)
		{
			using (var _context = new DataContext())
			{
				_context.Musteri.Update(musteri);
				_context.SaveChanges();

				return musteri;
			}
		}
	}
}
