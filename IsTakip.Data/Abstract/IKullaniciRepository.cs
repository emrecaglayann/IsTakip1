using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
	public interface IKullaniciRepository
	{
		List<Kullanici> GetAllKullanici(); //hepsini al, listele
		Kullanici GetKullaniciById(int id); //kimliğe göre depo al
		Kullanici CreateKullanici(Kullanici kullanici); //Kullanici oluşturma metodu 
		Kullanici UpdateKullanici(Kullanici kullanici); //güncelleme işlemi 
		void DeleteKullanici(int id); //silme işlemi 
	}
}
