using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OnlineRandevuSistemi
{
    class YetkiliKayitIslemi
    {
        public List<IsYeriYetkiliBilgileri> Yetkili { get; private set; }
        public sqlBaglantisi myDatabase { get; set; }

        public YetkiliKayitIslemi()
        {
            Yetkili = new List<IsYeriYetkiliBilgileri>();
            myDatabase = new sqlBaglantisi();
        }
        public void YetkiliKayit(IsYeriYetkiliBilgileri IsYeriyetkili)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.Sorgu = ("Insert Into tblIsYeriYetkili (isim, soyisim,dogumTarihi,tcKimlikNo,eposta,adres,telefonNo,kullaniciAdi,sifre,isYeriTanimlamaDurum) values (@isim, @soyisim,@dogumTarihi,@tcKimlikNo,@eposta,@adres,@telefonNo,@kullaniciAdi,@sifre,@isYeriTanimlamaDurum)");
                myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
                myDatabase.komut.Parameters.AddWithValue("@isim", IsYeriyetkili.isim);
                myDatabase.komut.Parameters.AddWithValue("@soyisim", IsYeriyetkili.soyisim);
                myDatabase.komut.Parameters.AddWithValue("@dogumTarihi", IsYeriyetkili.dogumTarihi);
                myDatabase.komut.Parameters.AddWithValue("@tcKimlikNo", IsYeriyetkili.tcKimlik);
                myDatabase.komut.Parameters.AddWithValue("@eposta", IsYeriyetkili.eposta);
                myDatabase.komut.Parameters.AddWithValue("@adres", IsYeriyetkili.adres);
                myDatabase.komut.Parameters.AddWithValue("@telefonNo", IsYeriyetkili.telNo);
                myDatabase.komut.Parameters.AddWithValue("@kullaniciAdi", IsYeriyetkili.kullaniciAdi);
                myDatabase.komut.Parameters.AddWithValue("@sifre", IsYeriyetkili.sifre);
                myDatabase.komut.Parameters.AddWithValue("@isYeriTanimlamaDurum",0);
                myDatabase.komut.ExecuteNonQuery();
                myDatabase.baglanti.Close();
                Yetkili.Add(IsYeriyetkili);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
