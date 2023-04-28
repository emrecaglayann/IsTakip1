using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class Tedarikci : BaseObject
    {
        public string Tanim { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Aciklama { get; set; }

        public List <Depo> Depo { get; set; }  
    }
}
