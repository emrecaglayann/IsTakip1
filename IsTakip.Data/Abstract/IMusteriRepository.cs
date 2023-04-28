using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
	public interface IMusteriRepository
	{
		List<Musteri> GetAllMusteri(); //hepsini al, listele
		Musteri GetMusteriById(int id); //kimliğe göre depo al
		Musteri CreateMusteri(Musteri musteri); //musteri oluşturma metodu 
		Musteri UpdateMusteri(Musteri musteri); //güncelleme işlemi 
		void DeleteMusteri(int id); //silme işlemi 
	}
}
