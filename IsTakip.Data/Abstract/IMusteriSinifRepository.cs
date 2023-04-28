using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
    

    public interface IMusteriSinifRepository
    {
        List<MusteriSinif> GetAllMusteriSinif(); //hepsini al, listele
        MusteriSinif GetMusteriSinifById(int id); //kimliğe göre depo al
        MusteriSinif CreateMusteriSinif(MusteriSinif musteriSinif); //depo oluşturma metodu 
        MusteriSinif UpdateMusteriSinif(MusteriSinif musteriSinif); //güncelleme işlemi 
        void DeleteMusteriSinif(int id); //silme işlemi 
    }
}
