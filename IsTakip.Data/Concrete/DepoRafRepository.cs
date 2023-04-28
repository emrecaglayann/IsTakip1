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
    public class DepoRafRepository : IDepoRafRepository
    {
        public DepoRaf CreateDepoRaf(DepoRaf depoRaf)
        {
            using (var _context = new DataContext())
            {
                _context.DepoRaf.Add(depoRaf);
                _context.SaveChanges();
                return depoRaf;
            }
        }

        public void DeleteDepoRaf(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetDepoRafById(id);

                _context.DepoRaf.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<DepoRaf> GetAllDepoRaf()
        {
            using (var _context = new DataContext())
            {
                return _context.DepoRaf.ToList();
            }
        }

        public DepoRaf GetDepoRafById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.DepoRaf.Find(id);
            }
        }

        public DepoRaf UpdateDepoRaf(DepoRaf depoRaf)
        {
            using (var _context = new DataContext())
            {
                _context.DepoRaf.Update(depoRaf);
                _context.SaveChanges();

                return depoRaf;
            }
        }
    }
}
