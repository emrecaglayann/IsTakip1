using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
    public interface IIsDosyaRepository
    {
        List<IsDosya> GetAllIsDosya(); //hepsini al, listele
        IsDosya GetIsDosyaById(int id); //kimliğe göre depo al
        IsDosya CreateIsDosya(IsDosya ısDosya); //Ajanda oluşturma metodu 
        IsDosya UpdateIsDosya(IsDosya ısDosya); //güncelleme işlemi 
        void DeleteIsDosya(int id); //silme işlemi 
    }
}
