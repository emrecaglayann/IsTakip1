using IsTakip.Core.Entites;

namespace IsTakip.Service.Abstract
{
    public interface IAjandaService
    {
        List<Ajanda> GetAllAjanda(); //hepsini al, listele
        Ajanda GetAjandaById(int id); //kimliğe göre depo al
        Ajanda CreateAjanda(Ajanda ajanda); //ajanda oluşturma metodu 
        Ajanda UpdateAjanda(Ajanda ajanda); //güncelleme işlemi 
        void DeleteAjanda(int id); //silme işlemi 
    }
}
