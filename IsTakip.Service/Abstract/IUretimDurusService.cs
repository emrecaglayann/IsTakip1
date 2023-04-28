using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
    public interface IUretimDurusService
    {
        List<UretimDurus> GetAllUretimDurus(); //hepsini al, listele
        UretimDurus GetUretimDurusById(int id); //kimliğe göre depo al
        UretimDurus CreateUretimDurus(UretimDurus uretimDurus); //ajanda oluşturma metodu 
        UretimDurus UpdateUretimDurus(UretimDurus uretimDurus); //güncelleme işlemi 
        void DeleteUretimDurus(int id); //silme işlemi 
    }
}
