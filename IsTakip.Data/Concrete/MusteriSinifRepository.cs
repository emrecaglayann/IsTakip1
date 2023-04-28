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
    public class MusteriSinifRepository : IMusteriSinifRepository
    {
        public MusteriSinif CreateMusteriSinif(MusteriSinif musteriSinif)
        {
            using (var _context = new DataContext())
            {
                _context.MusteriSinif.Add(musteriSinif);
                _context.SaveChanges();
                return musteriSinif;
            }
        }

        public void DeleteMusteriSinif(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetMusteriSinifById(id);

                _context.MusteriSinif.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<MusteriSinif> GetAllMusteriSinif()
        {
            using (var _context = new DataContext())
            {
                return _context.MusteriSinif.ToList();
            }
        }

        public MusteriSinif GetMusteriSinifById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.MusteriSinif.Find(id);
            }
        }

        public MusteriSinif UpdateMusteriSinif(MusteriSinif musteriSinif)
        {
            using (var _context = new DataContext())
            {
                _context.MusteriSinif.Update(musteriSinif);
                _context.SaveChanges();

                return musteriSinif;
            }
        }
    }
}
