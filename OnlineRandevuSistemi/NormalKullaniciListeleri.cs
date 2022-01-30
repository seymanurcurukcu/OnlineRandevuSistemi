using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSistemi
{
    class NormalKullaniciListeleri
    {
        public string KullaniciId { get; set; }
        public sqlBaglantisi myDatabase { get; set; }

        public NormalKullaniciListeleri()
        {
            myDatabase = new sqlBaglantisi();
        }

        public void OnaylananRandevular(DataGridView dgv)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select tblIsYeri.IsYeriAdi,tblIsYeri.IsYeriTuru,tblIsYeri.IsYeriTelefonNo,tblIsYeri.IsYeriAdres,tblRandevu.randevuTarih,tblRandevu.randevuSaat  from tblRandevu inner join tblIsYeri on tblRandevu.RandevuIsYeriID=tblIsYeri.IsYeriID  where tblRandevu.randevuDurumBilgisi='" 
                + 1+ "'and tblRandevu.RandevuNormalKullaniciID='" + KullaniciId+"'", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        public void GelenMesajlar(DataGridView dgv2)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select tblIsYeri.IsYeriAdi,tblIsYeri.IsYeriTuru, tblSoruCevap.soru, tblSoruCevap.cevap from tblSoruCevap inner join tblIsYeri on tblSoruCevap.SoruCevapIsYeriID=tblIsYeri.IsYeriID  where tblSoruCevap.cevaplanmaDurumu='"
                + 1 + "'and tblSoruCevap.SoruCevapNormalKullaniciID='" + KullaniciId + "'", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv2.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
    }
}
