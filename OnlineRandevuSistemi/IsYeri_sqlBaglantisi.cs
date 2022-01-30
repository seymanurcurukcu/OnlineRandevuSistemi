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
    class IsYeri_sqlBaglantisi
    {
        public List<IsYeri> isYerleri { get; private set; }
        public sqlBaglantisi myDatabase { get; set; }

        public IsYeri_sqlBaglantisi()
        {
            isYerleri = new List<IsYeri>();
            myDatabase = new sqlBaglantisi();
        }

        public void Ekle(IsYeri isyeri)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.Sorgu=("Insert Into tblIsYeri (IsYeriAdi, IsYeriTuru,IsYeriTelefonNo,IsYeriAdres,YetkiliTanimlamaDurum) values (@IsYeriAdi, @IsYeriTuru,@IsYeriTelefonNo,@IsYeriAdres,@YetkiliTanimlamaDurum)");
                myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
                myDatabase.komut.Parameters.AddWithValue("@IsYeriAdi", isyeri.IsYeriAdi);
                myDatabase.komut.Parameters.AddWithValue("@IsYeriTuru", isyeri.IsYeriTuru);
                myDatabase.komut.Parameters.AddWithValue("@IsYeriTelefonNo", isyeri.IsYeriTelefonNo);
                myDatabase.komut.Parameters.AddWithValue("@IsYeriAdres", isyeri.IsYeriAdres);
                myDatabase.komut.Parameters.AddWithValue("@YetkiliTanimlamaDurum",0);
                myDatabase.komut.ExecuteNonQuery();
                myDatabase.baglanti.Close();
                isYerleri.Add(isyeri);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IsYeriGuncelle(IsYeri isyeri)
        {
            myDatabase.Sorgu = "Update tblIsYeri Set IsYeriAdi=@IsYeriAdi,IsYeriTuru=@IsYeriTuru,IsYeriTelefonNo=@IsYeriTelefonNo,IsYeriAdres=@IsYeriAdres Where IsYeriID=@IsYeriID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriID", Convert.ToInt32(isyeri.IsYeriID));
            myDatabase.komut.Parameters.AddWithValue("@IsYeriAdi", isyeri.IsYeriAdi);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriTuru", isyeri.IsYeriTuru);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriTelefonNo", isyeri.IsYeriTelefonNo);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriAdres", isyeri.IsYeriAdres);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();

            //todo database listeye bilgi gecişi
        }

        public void IsYeriSilme(IsYeri isyeri)
        {
            myDatabase.Sorgu = "Delete from tblIsYeri Where IsYeriID=@IsYeriID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@IsYeriID", isyeri.IsYeriID);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();

        }
        public void Listele(DataGridView dgv)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.Sorgu = "Select * from tblIsYeri";
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
        public void IsYeriAra(DataGridView dgv,string Arama)
        {
            try
            {
                myDatabase.baglanti.Open();
                DataTable tbl = new DataTable();
                myDatabase.Sorgu = "Select * " + "From tblIsYeri" +
                                                       " Where IsYeriAdi like '%" + Arama + "%' " +
                                                       "Or IsYeriAdres like '%" + Arama + "%' " +
                                                       " Or IsYeriTelefonNo like '%" + Arama + "%'";
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

    }
}
