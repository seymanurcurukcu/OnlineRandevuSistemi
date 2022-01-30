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
    class SoruCevapla
    {
        public List<SoruCevapOzellikleri> soruCevapla { get; private set; }
        private sqlBaglantisi myDatabase { get; set; }
        public SoruCevapla()
        {
            soruCevapla = new List<SoruCevapOzellikleri>();
            myDatabase = new sqlBaglantisi();
        }
        public void MesajCevapla(SoruCevapOzellikleri cevap)
        {
            myDatabase.Sorgu = "Update tblSoruCevap Set cevaplanmaDurumu=@cevaplanmaDurumu,cevap=@cevap Where soruCevapID=@soruCevapID";
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@soruCevapID", cevap.SoruCevapID);
            myDatabase.komut.Parameters.AddWithValue("@cevaplanmaDurumu", 1);
            myDatabase.komut.Parameters.AddWithValue("@cevap", cevap.Cevap);
            
            myDatabase.baglanti.Open();
            myDatabase.komut.ExecuteNonQuery();
            myDatabase.baglanti.Close();
        }
        public void mesajListele(DataGridView dgv,string YetkiliId)
        {
            try
            {
                myDatabase.baglanti.Open();
                myDatabase.da = new SqlDataAdapter("select * from tblSoruCevap where SoruCevapIsYeriYetkiliID='" + YetkiliId + "'", myDatabase.baglanti);
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
