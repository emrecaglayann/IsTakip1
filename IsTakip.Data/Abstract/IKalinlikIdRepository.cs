using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
    public interface IKalinlikIdRepository
    {
        List<KalinlikId> GetAllKalinlikId(); //hepsini al, listele
        KalinlikId GetKalinlikIdById(int id); //kimliğe göre depo al
        KalinlikId CreateKalinlikId(KalinlikId kalinlikId); //KalinlikId oluşturma metodu 
        KalinlikId UpdateKalinlikId(KalinlikId kalinlikId); //güncelleme işlemi 
        void DeleteDepo(int id); //silme işlemi 
    }
}
