using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineRandevuSistemi
{
    class UygunOlmayanZamanIslemler
    {
       
        public sqlBaglantisi myDatabase { get; set; }
        public List<UygunOlmayanZaman> zaman { get; private set; }

        public UygunOlmayanZamanIslemler()
        {
            myDatabase = new sqlBaglantisi();
            zaman = new List<UygunOlmayanZaman>();
        }

        public void Ekle(UygunOlmayanZaman Zaman)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.Sorgu = ("Insert Into tblUygunOlmayanZaman (tarih, baslagicSaati,bitisSaati,ZamanIsYeriID) values (@tarih, @baslagicSaati,@bitisSaati,@ZamanIsYeriID)");
                myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
                myDatabase.komut.Parameters.AddWithValue("@tarih", Zaman.Tarih);
                myDatabase.komut.Parameters.AddWithValue("@baslagicSaati", Zaman.BaslangicSaati);
                myDatabase.komut.Parameters.AddWithValue("@bitisSaati", Zaman.BitisSaati);
                myDatabase.komut.Parameters.AddWithValue("@ZamanIsYeriID", Zaman.ZamanIsYeriID);
                myDatabase.komut.ExecuteNonQuery();
                myDatabase.baglanti.Close();
                zaman.Add(Zaman);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ZamanGuncelle(UygunOlmayanZaman Zaman)
        {
            myDatabase.Sorgu = "Update tblUygunOlmayanZaman Set tarih=@tarih,baslagicSaati=@baslagicSaati,bitisSaati=@bitisSaati Where uygunOlmayanZamanID=@uygunOlmayanZamanID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@uygunOlmayanZamanID", Convert.ToInt32(Zaman.UygunOlmayanZamanId));
            myDatabase.komut.Parameters.AddWithValue("@tarih", Zaman.Tarih);
            myDatabase.komut.Parameters.AddWithValue("@baslagicSaati", Zaman.BaslangicSaati);
            myDatabase.komut.Parameters.AddWithValue("@bitisSaati", Zaman.BitisSaati);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();

            //todo database listeye bilgi gecişi
        }

        public void ZamanSilme(UygunOlmayanZaman Zaman)
        {
            myDatabase.Sorgu = "Delete from tblUygunOlmayanZaman Where uygunOlmayanZamanID=@uygunOlmayanZamanID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@uygunOlmayanZamanID", Zaman.UygunOlmayanZamanId);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();

        }
        public void Listele(DataGridView dgv,string IsYeriId)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.Sorgu = "Select * from tblUygunOlmayanZaman where ZamanIsYeriID='" + IsYeriId + "'";
                myDatabase.da = new SqlDataAdapter(myDatabase.Sorgu, myDatabase.baglanti);
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
    }

}
