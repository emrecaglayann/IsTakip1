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
    public class IsDosyaRepository : IIsDosyaRepository
    {
        public IsDosya CreateIsDosya(IsDosya ısDosya)
        {
            using (var _context = new DataContext())
            {
                _context.IsDosya.Add(ısDosya);
                _context.SaveChanges();
                return ısDosya;
            }
        }

        public void DeleteIsDosya(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetIsDosyaById(id);

                _context.IsDosya.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<IsDosya> GetAllIsDosya()
        {
            using (var _context = new DataContext())
            {
                return _context.IsDosya.ToList();
            }
        }

        public IsDosya GetIsDosyaById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.IsDosya.Find(id);
            }
        }

        public IsDosya UpdateIsDosya(IsDosya ısDosya)
        {
            using (var _context = new DataContext())
            {
                _context.IsDosya.Update(ısDosya);
                _context.SaveChanges();

                return ısDosya;
            }
        }
    }
}
