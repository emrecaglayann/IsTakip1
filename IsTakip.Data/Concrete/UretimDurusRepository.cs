using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Concrete
{
    public class UretimDurusRepository : IUretimDurusRepository
    {
        public UretimDurus CreateUretimDurus(UretimDurus uretimDurus)
        {
            using (var _context = new DataContext())
            {
                _context.UretimDurus.Add(uretimDurus);
                _context.SaveChanges();
                return uretimDurus;
            }
        }

        public void DeleteUretimDurus(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetUretimDurusById(id);

                _context.UretimDurus.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<UretimDurus> GetAllUretimDurus()
        {
            using(var _context = new DataContext())
            {
                return _context.UretimDurus.ToList();
            }
        }

        public UretimDurus GetUretimDurusById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.UretimDurus.Find(id);
            }
        }

        public UretimDurus UpdateUretimDurus(UretimDurus uretimDurus)
        {
            using (var _context = new DataContext())
            {
                _context.UretimDurus.Update(uretimDurus);
                _context.SaveChanges();

                return uretimDurus;
            }
        }
    }
}
