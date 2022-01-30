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
    public partial class frmIsYeriKayıtOl : Form
    {
        public frmIsYeriKayıtOl()
        {
            InitializeComponent();
        }


        IsYeriYetkiliBilgileri yetkili;
        YetkiliKayitIslemi kayit = new YetkiliKayitIslemi();

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            try
            {
                yetkili = new IsYeriYetkiliBilgileri();
                yetkili.isim = txtIsim.Text;
                yetkili.soyisim = txtSoyisim.Text;
                yetkili.dogumTarihi =  mskDogumTarihi.Text;
                yetkili.tcKimlik = mskTcNo.Text;
                yetkili.eposta = txtEposta.Text;
                yetkili.adres = txtAdres.Text;
                yetkili.telNo = mskTelNo.Text;
                yetkili.kullaniciAdi = txtKullaniciAdi.Text;
                yetkili.sifre = txtSifre.Text;
                kayit.YetkiliKayit(yetkili);
                MessageBox.Show("Kayıt işleminiz başarılı. Giriş yapabilmeniz için yönetici onayı gerekmektedir.");
                MessageBox.Show(" Giriş Sayfasına Yönlendiriliyorsunuz");
                frmIsYeriGiris fr = new frmIsYeriGiris();
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
