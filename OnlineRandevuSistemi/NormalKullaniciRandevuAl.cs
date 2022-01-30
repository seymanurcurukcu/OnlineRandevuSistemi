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
    class NormalKullaniciRandevuAl
    {
        public int IsYeriId { get; set; }
        public int YetkiliId { get; set; }
        public int NormalKullaniciId { get; set; }
        public int RandevuSaati { get; set; }
        public string Tarih { get; set; }
        public sqlBaglantisi myDatabase { get; set; }
        public NormalKullaniciRandevuAl()
        {
            myDatabase = new sqlBaglantisi();
        }
        public void IsYeriListele(DataGridView dgv)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from ViewYetkiliTanımlıIsYeriListesi", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        public void UygunZamanBelirleme(DataGridView dgv)
        {
            myDatabase.baglanti.Open();
            myDatabase.Sorgu = ("MusaitZamanlar");
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.CommandType = CommandType.StoredProcedure;
            myDatabase.komut.Parameters.AddWithValue("@ZamanIsYeriID", IsYeriId);
            myDatabase.komut.Parameters.AddWithValue("@tarih", Tarih);
            myDatabase.da = new SqlDataAdapter(myDatabase.komut);
            DataSet ds = new DataSet();
            myDatabase.da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            myDatabase.baglanti.Close();
        }
        public void RandevuAl()
        {
            myDatabase.baglanti.Open();
            myDatabase.Sorgu = ("Insert Into tblRandevu ( randevuTarih,randevuSaat,randevuDurumBilgisi,RandevuNormalKullaniciID,RandevuYetkiliID,RandevuIsYeriID) values (@randevuTarih, @randevuSaat,@randevuDurumBilgisi,@RandevuNormalKullaniciID,@RandevuYetkiliID,@RandevuIsYeriID)");
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@randevuTarih", Tarih);
            myDatabase.komut.Parameters.AddWithValue("@randevuSaat", RandevuSaati);
            myDatabase.komut.Parameters.AddWithValue("@randevuDurumBilgisi", 0);
            myDatabase.komut.Parameters.AddWithValue("@RandevuNormalKullaniciID", NormalKullaniciId);
            myDatabase.komut.Parameters.AddWithValue("@RandevuYetkiliID", YetkiliId);
            myDatabase.komut.Parameters.AddWithValue("@RandevuIsYeriID", IsYeriId);
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
       
        }
        public void IsYeriAra(DataGridView dgv, string Arama)
        {
            try
            {
                myDatabase.baglanti.Open();
                DataTable tbl = new DataTable();
                myDatabase.Sorgu = "Select * from ViewYetkiliTanımlıIsYeriListesi" +
                                                       " Where IsYeriAdi like '%" + Arama + "%' ";                                                          
                myDatabase.da = new SqlDataAdapter(myDatabase.Sorgu, myDatabase.baglanti);
                myDatabase.da.Fill(tbl);
                myDatabase.baglanti.Close();
                dgv.DataSource = tbl;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void IsYerituruAra(DataGridView dgv2, string Arama)
        {
            try
            {
                myDatabase.baglanti.Open();
                DataTable tbl = new DataTable();
                myDatabase.Sorgu = "Select * from ViewYetkiliTanımlıIsYeriListesi" +
                                                       " Where IsYeriTuru like '%" + Arama + "%' ";
                myDatabase.da = new SqlDataAdapter(myDatabase.Sorgu, myDatabase.baglanti);
                myDatabase.da.Fill(tbl);
                myDatabase.baglanti.Close();
                dgv2.DataSource = tbl;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
