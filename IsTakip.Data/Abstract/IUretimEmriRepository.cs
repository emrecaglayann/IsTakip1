using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
	public interface IUretimEmriRepository
	{
		List<UretimEmri> GetAllUretimEmri(); //hepsini al, listele
		UretimEmri GetUretimEmriById(int id); //kimliğe göre depo al
		UretimEmri CreateUretimEmri(UretimEmri uretimEmri); //UretimEmri oluşturma metodu 
		UretimEmri UpdateUretimEmri(UretimEmri uretimEmri); //güncelleme işlemi 
		void DeleteUretimEmri(int id); //silme işlemi
	}
}
