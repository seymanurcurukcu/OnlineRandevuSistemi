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
    class IsYeriYetkiliTanimlama:YetkiliTanimlama
    {
        public IsYeri isYeri { get; set; }
        public IsYeriYetkiliBilgileri isYeriYetkilisi { get; set; }
        private sqlBaglantisi myDatabase { get; set; }

        public IsYeriYetkiliTanimlama()
        {
            myDatabase = new sqlBaglantisi();
        }
        public void tanımla()
        {
            myDatabase.Sorgu = "update tblIsYeri set IsYeriYetkiliID=@IsYeriYetkili,YetkiliTanimlamaDurum=@durum where IsYeriID=@isyeri";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@isyeri", isYeri.IsYeriID);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriYetkili", isYeriYetkilisi.IsYeriYetkilisiID);
            myDatabase.komut.Parameters.AddWithValue("@durum", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();

        }
        public void YetkiliGuncelle()
        {
            myDatabase.Sorgu = "Update tblIsYeriYetkili Set isYeriTanimlamaDurum=@IsYeriDurum Where YetkiliID=@YetkiliID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@YetkiliID", isYeriYetkilisi.IsYeriYetkilisiID);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriDurum", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
        }
        public void IsYeriGuncelle()
        {

            myDatabase.Sorgu = "Update tblIsYeri Set YetkiliTanimlamaDurum=@YetkiliDurum Where IsYeriID=@IsYeriID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriID", isYeri.IsYeriID);
            myDatabase.komut.Parameters.AddWithValue("@YetkiliDurum", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
        }
        public void IsYeriGoster(DataGridView dgv)
        {
            try
            {
                //isyeri gösterir
                myDatabase.baglanti.Open();
                myDatabase.da = new SqlDataAdapter("Select * from tblIsYeri where YetkiliTanimlamaDurum=0", myDatabase.baglanti);
                DataTable tablo = new DataTable();
                myDatabase.da.Fill(tablo);
                dgv.DataSource = tablo;
                myDatabase.baglanti.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void YetkiliGoster(DataGridView dgv1)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.da = new SqlDataAdapter("Select * from tblIsYeriYetkili where isYeriTanimlamaDurum=0", myDatabase.baglanti);
                DataTable tablo = new DataTable();
                myDatabase.da.Fill(tablo);
                dgv1.DataSource = tablo;
                myDatabase.baglanti.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void IsYerininYetkilisiniGoster(DataGridView dgv2)
        {
            //3.dgvyi gösterir
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("Select IsYeriAdi As 'Is Yeri Ismi',isim as 'Is Yeri Yetkili Ismi' from tblIsYeri I inner join tblIsYeriYetkili IY ON I.IsYeriYetkiliID=IY.YetkiliID where isYeriTanimlamaDurum=1", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv2.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
    }
}
