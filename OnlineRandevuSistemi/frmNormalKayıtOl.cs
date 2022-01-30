using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRandevuSistemi
{
    public partial class frmNormalKayıtOl : Form
    {
        public frmNormalKayıtOl()
        {
            InitializeComponent();
        }

        NormalKullaniciBilgileri Kullanici;
        NormalKullaniciKayit kayit = new NormalKullaniciKayit();
        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici = new NormalKullaniciBilgileri();
                Kullanici.isim = txtIsim.Text;
                Kullanici.soyisim = txtSoyisim.Text;
                Kullanici.eposta = txtEposta.Text;
                Kullanici.adres = txtAdres.Text;
                Kullanici.telNo = mskTelNo.Text;
                Kullanici.kullaniciAdi = txtKullaniciAdi.Text;
                Kullanici.sifre = txtSifre.Text;
                kayit.KullaniciKayit(Kullanici);
                MessageBox.Show("Kayıt işleminiz başarılı.Giriş ekranına yönlendiriliyorsunuz.");
                frmNormalGiris fr = new frmNormalGiris();
                fr.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
