using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Context;

namespace IsTakip.Data.Concrete
{
    public class DurusTipRepository : IDurusTipRepository
    {
        public DurusTip CreateDurusTip(DurusTip durusTip)
        {
            using (var _context = new DataContext())
            {
                _context.DurusTip.Add(durusTip);
                _context.SaveChanges();
                return durusTip;
            }
        }

        public void DeleteDurusTip(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetDurusTipById(id);

                _context.DurusTip.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<DurusTip> GetAllDurusTip()
        {
            using (var _context = new DataContext())
            {
                return _context.DurusTip.ToList();
            }
        }

        public DurusTip GetDurusTipById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.DurusTip.Find(id);
            }
        }

        public DurusTip UpdateDurusTip(DurusTip durusTip)
        {
            using (var _context = new DataContext())
            {
                _context.DurusTip.Update(durusTip);
                _context.SaveChanges();

                return durusTip;
            }
        }
    }
}
