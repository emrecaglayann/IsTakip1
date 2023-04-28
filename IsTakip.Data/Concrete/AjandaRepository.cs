using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Context;

namespace IsTakip.Data.Concrete
{
    public class AjandaRepository : IAjandaRepository
    {
        public Ajanda CreateAjanda(Ajanda ajanda)
        {
            using (var _context = new DataContext())
            {
                _context.Ajanda.Add(ajanda);
                _context.SaveChanges();
                return ajanda;
            }
        }

        public void DeleteAjanda(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetAjandaById(id);

                _context.Ajanda.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public Ajanda GetAjandaById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.Ajanda.Find(id);
            }
        }

        public List<Ajanda> GetAllAjanda()
        {
            using (var _context = new DataContext())
            {
                return _context.Ajanda.ToList();
            }
        }

        public Ajanda UpdateAjanda(Ajanda ajanda)
        {
            using (var _context = new DataContext())
            {
                _context.Ajanda.Update(ajanda);
                _context.SaveChanges();

                return ajanda;
            }
        }
    }
}
