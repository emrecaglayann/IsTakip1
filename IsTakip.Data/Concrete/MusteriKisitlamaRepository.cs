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
    public class MusteriKisitlamaRepository : IMusteriKisitlamaRepository
    {
        public MusteriKisitlama CreateMusteriKisitlama(MusteriKisitlama musteriKisitlama)
        {
            using (var _context = new DataContext())
            {
                _context.MusteriKisitlama.Add(musteriKisitlama);
                _context.SaveChanges();
                return musteriKisitlama;
            }
        }

        public void DeleteMusteriKisitlama(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetMusteriKisitlamaById(id);

                _context.MusteriKisitlama.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<MusteriKisitlama> GetAllMusteriKisitlama()
        {
            using (var _context = new DataContext())
            {
                return _context.MusteriKisitlama.ToList();
            }
        }

        public MusteriKisitlama GetMusteriKisitlamaById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.MusteriKisitlama.Find(id);
            }
        }

        public MusteriKisitlama UpdateMusteriKisitlama(MusteriKisitlama musteriKisitlama)
        {
            using (var _context = new DataContext())
            {
                _context.MusteriKisitlama.Update(musteriKisitlama);
                _context.SaveChanges();

                return musteriKisitlama;
            }
        }
    }
}
