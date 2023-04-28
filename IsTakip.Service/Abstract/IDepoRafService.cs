using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Service.Abstract
{
    public interface IDepoRafService
    {
        List<DepoRaf> GetAllDepoRaf(); //hepsini al, listele
        DepoRaf GetDepoRafById(int id); //kimliğe göre depo al
        DepoRaf CreateDepoRaf(DepoRaf depoRaf); //depoRaf oluşturma metodu 
        DepoRaf UpdateDepoRaf(DepoRaf depoRaf); //güncelleme işlemi 
        void DeleteDepoRaf(int id); //silme işlemi 
    }
}
