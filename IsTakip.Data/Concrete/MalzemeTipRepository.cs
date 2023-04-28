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
    public class MalzemeTipRepository : IMalzemeTipRepository
    {
        public MalzemeTip CreateMalzemeTip(MalzemeTip malzemeTip)
        {
            using (var _context = new DataContext())
            {
                _context.MalzemeTip.Add(malzemeTip);
                _context.SaveChanges();
                return malzemeTip;
            }
        }

        public void DeleteMalzemeTip(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetMalzemeTipById(id);

                _context.MalzemeTip.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<MalzemeTip> GetAllMalzemeTip()
        {
            using (var _context = new DataContext())
            {
                return _context.MalzemeTip.ToList();
            }
        }

        public MalzemeTip GetMalzemeTipById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.MalzemeTip.Find(id);
            }
        }

        public MalzemeTip UpdateMalzemeTip(MalzemeTip malzemeTip)
        {
            using (var _context = new DataContext())
            {
                _context.MalzemeTip.Update(malzemeTip);
                _context.SaveChanges();

                return malzemeTip;
            }
        }
    }
}
