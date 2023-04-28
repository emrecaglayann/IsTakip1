using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
    public interface IMusteriKisitlamaService
    {
        List<MusteriKisitlama> GetAllMusteriKisitlama(); //hepsini al, listele
        MusteriKisitlama GetMusteriKisitlamaById(int id); //kimliğe göre depo al
        MusteriKisitlama CreateMusteriKisitlama(MusteriKisitlama musteriKisitlama); //depo oluşturma metodu 
        MusteriKisitlama UpdateMusteriKisitlama(MusteriKisitlama musteriKisitlama); //güncelleme işlemi 
        void DeleteMusteriKisitlama(int id); //silme işlemi 
    }
}
