using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
    public interface IDepoRepository
    {
        List<Depo> GetAllDepo(); //hepsini al, listele
        Depo GetDepoById(int id); //kimliğe göre depo al
        Depo CreateDepo(Depo depo); //depo oluşturma metodu 
        Depo UpdateDepo(Depo depo); //güncelleme işlemi 
        void DeleteDepo(int id); //silme işlemi 
    }
}
