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
	public class MailParametreleriRepository : IMailParametreleriRepository
	{
		public MailParametreleri CreateMailParametreleri(MailParametreleri mailParametreleri)
		{
			using (var _context = new DataContext())
			{
				_context.MailParametreleri.Add(mailParametreleri);
				_context.SaveChanges();
				return mailParametreleri;
			}
		}

		public void DeleteMailParametreleri(int id)
		{
			using(var _context = new DataContext())

			{
				var silinecekP = GetMailParametreleriById(id);

				_context.MailParametreleri.Remove(silinecekP);
				_context.SaveChanges();
			}
		}

		public List<MailParametreleri> GetAllMailParametreleri()
		{
			using (var _context = new DataContext())
			{
				return _context.MailParametreleri.ToList();
			}
		}

		public MailParametreleri GetMailParametreleriById(int id)
		{
			using (var _context = new DataContext())
			{
				return _context.MailParametreleri.Find(id);
			}
		}

		public MailParametreleri UpdateMailParametreleri(MailParametreleri mailParametreleri)
		{
			using (var _context = new DataContext())
			{
				_context.MailParametreleri.Update(mailParametreleri);
				_context.SaveChanges();

				return mailParametreleri;
			}
		}
	}
}
