using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Context;

namespace IsTakip.Data.Concrete
{
    public class DepoRepository : IDepoRepository
    {

        public Depo CreateDepo(Depo depo)
        {
            using (var _context = new DataContext())
            {
                _context.Depo.Add(depo);
                _context.SaveChanges();
                return depo;
            }
        }

        public void DeleteDepo(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetDepoById(id);

                _context.Depo.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<Depo> GetAllDepo()
        {
            using (var _context = new DataContext())
            {
                return _context.Depo.ToList();
            }
        }

        public Depo GetDepoById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.Depo.Find(id);
            }
        }

        public Depo UpdateDepo(Depo depo)
        {
            using (var _context = new DataContext())
            {
                _context.Depo.Update(depo);
                _context.SaveChanges();

                return depo;
            }
        }
    }
}
