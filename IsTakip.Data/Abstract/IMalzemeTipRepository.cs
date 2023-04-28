﻿using IsTakip.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Data.Abstract
{
    public interface IMalzemeTipRepository
    {
        List<MalzemeTip> GetAllMalzemeTip(); //hepsini al, listele
        MalzemeTip GetMalzemeTipById(int id); //kimliğe göre depo al
        MalzemeTip CreateMalzemeTip(MalzemeTip malzemeTip); //DepoRaf oluşturma metodu 
        MalzemeTip UpdateMalzemeTip(MalzemeTip malzemeTip); //güncelleme işlemi 
        void DeleteMalzemeTip(int id); //silme işlemi 
    }
}
