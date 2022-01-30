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
    class AdminRaporlar
    {
        public sqlBaglantisi myDatabase { get; set; }

        public AdminRaporlar()
        {
            myDatabase = new sqlBaglantisi();
        }



        public void IsYeriListele(DataGridView dgv)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from ViewIsYeriListesi", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        public void IsYeriYetkiliListele(DataGridView dgv1)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from ViewIsYeriYetkiliListesi", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv1.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
        public void kullaniciListele(DataGridView dgv2)
        {
            myDatabase.baglanti.Open();
            myDatabase.da = new SqlDataAdapter("select * from ViewKullaniciListeleme", myDatabase.baglanti);
            DataTable tablo = new DataTable();
            myDatabase.da.Fill(tablo);
            dgv2.DataSource = tablo;
            myDatabase.baglanti.Close();
        }
    }
}
