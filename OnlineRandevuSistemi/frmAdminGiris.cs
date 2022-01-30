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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

      
        AdminGiris admin = new AdminGiris();
        frmAdminAnasayfa anasayfa = new frmAdminAnasayfa();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {

                if (admin.KullaniciAdi == txtKullaniciAdi.Text && admin.Sifre == txtSifre.Text)
                { 
                    anasayfa.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız. Lütfen Kontrol Ediniz");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void cboxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = txtSifre.PasswordChar == '\0' ? '*' : '\0';
        }
    }
}
