using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineRandevuSistemi
{
    class NormalKullaniciKayit
    {
        public List<NormalKullaniciBilgileri> kullanici { get; private set; }
        public sqlBaglantisi myDatabase { get; set; }
        public NormalKullaniciKayit()
        {
            kullanici = new List<NormalKullaniciBilgileri>();
            myDatabase = new sqlBaglantisi();
        }
      

       public void KullaniciKayit(NormalKullaniciBilgileri Kullanici)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.Sorgu = ("Insert Into tblNormalKullanici (isim, soyisim,eposta,adres,telefonNo,kullaniciAdi,sifre) values (@isim, @soyisim,@eposta,@adres,@telefonNo,@kullaniciAdi,@sifre)");
                myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
                myDatabase.komut.Parameters.AddWithValue("@isim", Kullanici.isim);
                myDatabase.komut.Parameters.AddWithValue("@soyisim", Kullanici.soyisim);
                myDatabase.komut.Parameters.AddWithValue("@eposta", Kullanici.eposta);
                myDatabase.komut.Parameters.AddWithValue("@adres", Kullanici.adres);
                myDatabase.komut.Parameters.AddWithValue("@telefonNo", Kullanici.telNo);
                myDatabase.komut.Parameters.AddWithValue("@kullaniciAdi", Kullanici.kullaniciAdi);
                myDatabase.komut.Parameters.AddWithValue("@sifre", Kullanici.sifre);
                myDatabase.komut.ExecuteNonQuery();
                myDatabase.baglanti.Close();
                kullanici.Add(Kullanici);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
