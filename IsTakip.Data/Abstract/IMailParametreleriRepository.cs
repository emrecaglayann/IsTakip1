using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
	public interface IMailParametreleriRepository
	{
		List<MailParametreleri> GetAllMailParametreleri(); //hepsini al, listele
		MailParametreleri GetMailParametreleriById(int id); //kimliğe göre depo al
		MailParametreleri CreateMailParametreleri(MailParametreleri mailParametreleri); //mailParametreleri oluşturma metodu 
		MailParametreleri UpdateMailParametreleri(MailParametreleri mailParametreleri); //güncelleme işlemi 
		void DeleteMailParametreleri(int id); //silme işlemi
	}
}

