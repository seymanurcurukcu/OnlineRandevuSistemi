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
    public partial class frmIsYeriGiris : Form
    {
        public frmIsYeriGiris()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmIsYeriKayıtOl fr = new frmIsYeriKayıtOl();
            fr.Show();
            this.Hide();
        }

        
        sqlBaglantisi myDatabase = new sqlBaglantisi();
       
        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            myDatabase.baglanti.Open();
            myDatabase.Sorgu=("select * from tblIsYeriYetkili  where kullaniciAdi=@p1 and sifre=@p2 and isYeriTanimlamaDurum=@p3 ");
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            myDatabase.komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            myDatabase.komut.Parameters.AddWithValue("@p3", 1);
            myDatabase.sqlDataReader= myDatabase.komut.ExecuteReader();
           
            if (myDatabase.sqlDataReader.Read())
            {
             
                frmIsYeriAnasayfa fr = new frmIsYeriAnasayfa(myDatabase.sqlDataReader["YetkiliID"].ToString());
                fr.Show();
                this.Hide(); 
               
               
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            myDatabase.baglanti.Close();
        }

        private void cboxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = txtSifre.PasswordChar == '\0' ? '*' : '\0';
        }
    }
}
