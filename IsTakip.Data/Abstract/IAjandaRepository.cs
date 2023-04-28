using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
    public interface IAjandaRepository
    {
        List<Ajanda> GetAllAjanda(); //hepsini al, listele
        Ajanda GetAjandaById(int id); //kimliğe göre depo al
        Ajanda CreateAjanda(Ajanda ajanda); //Ajanda oluşturma metodu 
        Ajanda UpdateAjanda(Ajanda ajanda); //güncelleme işlemi 
        void DeleteAjanda(int id); //silme işlemi 
    }
}
