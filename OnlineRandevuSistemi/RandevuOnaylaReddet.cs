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
    class RandevuOnaylaReddet
    {
        public int RandevuID { get; set; }
        public byte RandevuOnayDurum { get; set; }
        private sqlBaglantisi myDatabase { get; set; }

        public RandevuOnaylaReddet()
        {
            myDatabase = new sqlBaglantisi();
        }
    
        public void RandevuOnayla()
        {
            myDatabase.Sorgu = "Update tblRandevu Set randevuDurumBilgisi=@randevuDurumBilgisi Where randevuid=@randevuid";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@randevuid", RandevuID);
            myDatabase.komut.Parameters.AddWithValue("@randevuDurumBilgisi", 1);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
        }
        public void RandevuReddet()
        {
            myDatabase.Sorgu = "Update tblRandevu Set randevuDurumBilgisi=@randevuDurumBilgisi Where randevuid=@randevuid";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@randevuid", RandevuID);
            myDatabase.komut.Parameters.AddWithValue("@randevuDurumBilgisi", 0);
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
        }
        public void RandevuListesi(DataGridView dgv,String YetkiliId)
        {
            try
            {
                
                myDatabase.baglanti.Open();
                myDatabase.da = new SqlDataAdapter("select * from tblRandevu where RandevuYetkiliID='" + YetkiliId + "'", myDatabase.baglanti);
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
