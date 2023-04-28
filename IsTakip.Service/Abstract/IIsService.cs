using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
	public interface IIsService
	{
		List<Is> GetAllIs(); //hepsini al, listele
		Is GetIsById(int id); //kimliğe göre depo al
		Is CreateIs(Is ıs); //ıs oluşturma metodu 
		Is UpdateIs(Is ıs); //güncelleme işlemi 
		void DeleteIs(int id); //silme işlemi 
	}
}
