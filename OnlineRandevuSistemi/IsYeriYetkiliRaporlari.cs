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
    class IsYeriYetkiliRaporlari
    {
        public sqlBaglantisi myDatabase { get; set; }

        public IsYeriYetkiliRaporlari()
        {
            myDatabase = new sqlBaglantisi();
        }
        public void OnaylananRandevlariListele(DataGridView dgv,string YetkiliId)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from tblRandevu where RandevuYetkiliID='" + YetkiliId +"'and randevuDurumBilgisi ='"+1+"'", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        public void TumMesajListesi(DataGridView dgv, string YetkiliId)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from tblSoruCevap where SoruCevapIsYeriYetkiliID='" + YetkiliId + "'", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        public void CevaplanmamisMesajListesi(DataGridView dgv, string YetkiliId)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from tblSoruCevap where SoruCevapIsYeriYetkiliID='" + YetkiliId + "'and cevaplanmaDurumu ='" + 0 + "'", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
    }
}
