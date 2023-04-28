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
    public class KalinlikIdRepository : IKalinlikIdRepository
    {
        public KalinlikId CreateKalinlikId(KalinlikId kalinlikId)
        {
            using (var _context = new DataContext())
            {
                _context.KalinlikId.Add(kalinlikId);
                _context.SaveChanges();
                return kalinlikId;
            }
        }

        public void DeleteDepo(int id)
        {
            using (var _context = new DataContext())
            {
                var silinecekP = GetKalinlikIdById(id);

                _context.KalinlikId.Remove(silinecekP);
                _context.SaveChanges();
            }
        }

        public List<KalinlikId> GetAllKalinlikId()
        {
            using (var _context = new DataContext())
            {
                return _context.KalinlikId.ToList();
            }
        }

        public KalinlikId GetKalinlikIdById(int id)
        {
            using (var _context = new DataContext())
            {
                return _context.KalinlikId.Find(id);
            }
        }

        public KalinlikId UpdateKalinlikId(KalinlikId kalinlikId)
        {
            using (var _context = new DataContext())
            {
                _context.KalinlikId.Update(kalinlikId);
                _context.SaveChanges();

                return kalinlikId;
            }
        }
    }
}
