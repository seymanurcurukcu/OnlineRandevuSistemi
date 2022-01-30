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
    class NormalKullaniciSoruSor
    {
        public int IsYeriId { get; set; }
        public int YetkiliId { get; set; }
        public int NormalKullaniciId { get; set; }
        public string Soru { get; set; }
        public sqlBaglantisi myDatabase { get; set; }
        public NormalKullaniciSoruSor()
        {
            myDatabase = new sqlBaglantisi();
        }
       

        public void SoruSor()
        {
            myDatabase.baglanti.Open();
            myDatabase.Sorgu = ("Insert Into tblSoruCevap ( soru,cevaplanmaDurumu,SoruCevapIsYeriID,SoruCevapIsYeriYetkiliID,SoruCevapNormalKullaniciID) values (@soru, @cevaplanmaDurumu,@SoruCevapIsYeriID,@SoruCevapIsYeriYetkiliID,@SoruCevapNormalKullaniciID)");
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@soru", Soru);
            myDatabase.komut.Parameters.AddWithValue("@cevaplanmaDurumu",0);
            myDatabase.komut.Parameters.AddWithValue("@SoruCevapIsYeriID", IsYeriId);
            myDatabase.komut.Parameters.AddWithValue("@SoruCevapIsYeriYetkiliID", YetkiliId);
            myDatabase.komut.Parameters.AddWithValue("@SoruCevapNormalKullaniciID", NormalKullaniciId);
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();

        }
    }
}
