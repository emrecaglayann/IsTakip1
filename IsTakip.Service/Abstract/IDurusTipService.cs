using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
    public interface IDurusTipService
    {
        List<DurusTip> GetAllDurusTip(); //hepsini al, listele
        DurusTip GetDurusTipById(int id); //kimliğe göre depo al
        DurusTip CreateDurusTip(DurusTip durusTip); //durusTip oluşturma metodu 
        DurusTip UpdateDurusTip(DurusTip durusTip); //güncelleme işlemi 
        void DeleteDurusTip(int id); //silme işlemi 

    }
}
