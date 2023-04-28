using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Core.Entites
{
    public class MailParametreleri : BaseObject
    {
        public string SenderName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SmtpAdres { get; set; }
        public string SmtpPort { get; set; }
        public string SSLKullan { get; set; }
    
    
        public List<Kullanici> Kullanici { get; set; }
    }

}
