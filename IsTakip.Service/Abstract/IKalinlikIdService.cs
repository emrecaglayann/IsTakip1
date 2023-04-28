using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
    public interface IKalinlikIdService
    {
        List<KalinlikId> GetAllKalinlikId(); //hepsini al, listele
        KalinlikId GetKalinlikIdById(int id); //kimliğe göre depo al
        KalinlikId CreateKalinlikId(KalinlikId kalinlikId); //kalinlikId oluşturma metodu 
        KalinlikId UpdateKalinlikId(KalinlikId kalinlikId); //güncelleme işlemi 
        void DeleteKalinlikId(int id); //silme işlemi 
    }
}
