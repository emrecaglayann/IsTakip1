using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [DisplayName("Kullanıcı Kodu")]
        public string KullaniciKodu { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [DisplayName("Kullanıcı Şifre")]
        public string KullaniciSifre { get; set; }


    }
}
