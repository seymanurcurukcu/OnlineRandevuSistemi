using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRandevuSistemi
{
    class IsYeriYetkiliBilgileri: KullaniciBilgileri
    {
        public string dogumTarihi { get; set; }
        public string tcKimlik { get; set; }
        public int IsYeriYetkilisiID { get; set; }
        public byte TanimlamaDurum { get; set; }
    }
}
