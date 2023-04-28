using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
	public interface ITedarikciService
	{
		List<Tedarikci> GetAllTedarikci(); //hepsini al, listele
		Tedarikci GetTedarikciById(int id); //kimliğe göre depo al
		Tedarikci CreateTedarikci(Tedarikci tedarikci); //Tedarikci oluşturma metodu 
		Tedarikci UpdateTedarikci(Tedarikci tedarikci); //güncelleme işlemi 
		void DeleteTedarikci(int id); //silme işlemi 
	}
}
