using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
    public interface IMusteriKisitlamaRepository
    {
        List<MusteriKisitlama> GetAllMusteriKisitlama(); //hepsini al, listele
        MusteriKisitlama GetMusteriKisitlamaById(int id); //kimliğe göre depo al
        MusteriKisitlama CreateMusteriKisitlama(MusteriKisitlama musteriKisitlama); //musteriKisitlama oluşturma metodu 
        MusteriKisitlama UpdateMusteriKisitlama(MusteriKisitlama musteriKisitlama); //güncelleme işlemi 
        void DeleteMusteriKisitlama(int id); //silme işlemi 
    }
}
