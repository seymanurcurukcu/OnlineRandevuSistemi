using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRandevuSistemi
{
    class AdminGiris
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public AdminGiris()
        {
            KullaniciAdi = "Admin";
            Sifre = "1234";
        }
    }
}
