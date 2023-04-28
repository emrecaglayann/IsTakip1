using IsTakip.Core.Entites;
using IsTakip.Data.Abstract;
using IsTakip.Data.Concrete;
using IsTakip.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Concrete
{
    public class MailParametreleriService : IMailParametreleriService
	{
		readonly private IMailParametreleriRepository _mailParametreleriRepository ;

		public MailParametreleriService(IMailParametreleriRepository mailParametreleriRepository)
		{
			_mailParametreleriRepository = mailParametreleriRepository;
		}


		public MailParametreleri CreateMailParametreleri(MailParametreleri mailParametreleri)
		{
			return _mailParametreleriRepository.CreateMailParametreleri(mailParametreleri);
		}

		public void DeleteMailParametreleri(int id)
		{
			_mailParametreleriRepository.DeleteMailParametreleri(id);
		}

		public List<MailParametreleri> GetAllMailParametreleri()
		{
			return _mailParametreleriRepository.GetAllMailParametreleri();
		}

		public MailParametreleri GetMailParametreleriById(int id)
		{
			return (_mailParametreleriRepository.GetMailParametreleriById(id));
		}

		public MailParametreleri UpdateMailParametreleri(MailParametreleri mailParametreleri)
		{
			return (_mailParametreleriRepository.UpdateMailParametreleri(mailParametreleri));
		}
	}
}
