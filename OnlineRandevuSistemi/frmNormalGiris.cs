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
    public partial class frmNormalGiris : Form
    {
        public frmNormalGiris()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            frmNormalKayıtOl fr = new frmNormalKayıtOl();
            fr.Show();
            this.Hide();
        }

        sqlBaglantisi myDatabase = new sqlBaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string KullaniciAdi, Sifre;
            KullaniciAdi = txtKullaniciAdi.Text;
            Sifre = txtSifre.Text;


            myDatabase.baglanti.Open();
            myDatabase.Sorgu = ("select * from tblNormalKullanici  where kullaniciAdi=@p1 and sifre=@p2 ");
            myDatabase.komut = new SqlCommand(myDatabase.Sorgu, myDatabase.baglanti);
            myDatabase.komut.Parameters.AddWithValue("@p1", KullaniciAdi);
            myDatabase.komut.Parameters.AddWithValue("@p2", Sifre);
            myDatabase.sqlDataReader = myDatabase.komut.ExecuteReader();

            if (myDatabase.sqlDataReader.Read())
            {
                frmNormalAnasayfa fr = new frmNormalAnasayfa(myDatabase.sqlDataReader["normalKullaniciID"].ToString());
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
