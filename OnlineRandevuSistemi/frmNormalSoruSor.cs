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
    public partial class frmNormalSoruSor : Form
    {
        public string NormalKullanciId = "";
        public frmNormalSoruSor(string NormalKullanciId)
        {
            this.NormalKullanciId = NormalKullanciId;
            InitializeComponent();
        }

        NormalKullaniciRandevuAl listele = new NormalKullaniciRandevuAl();
        NormalKullaniciSoruSor Sorusor = new NormalKullaniciSoruSor();
        private void frmNormalSoruSor_Load(object sender, EventArgs e)
        {
            txtNormalKullaniciId.Text = this.NormalKullanciId;
            listele.IsYeriListele(dgvIsYeriListesi);
        }

        private void btnIsYeriAra_Click(object sender, EventArgs e)
        {
            listele.IsYeriAra(dgvIsYeriListesi, txtIsYeriAra.Text);
        }

        private void btnIsYeriTuruAra_Click(object sender, EventArgs e)
        {
            listele.IsYerituruAra(dgvIsYeriListesi, txtIsYeriTuruAra.Text);
        }

        private void dgvIsYeriListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIsYeriId.Text = dgvIsYeriListesi.CurrentRow.Cells[0].Value.ToString();
                txtIsYeriYetkiliId.Text = dgvIsYeriListesi.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            Sorusor.IsYeriId = Convert.ToInt32( txtIsYeriId.Text);
            Sorusor.YetkiliId = Convert.ToInt32(txtIsYeriYetkiliId.Text);
            Sorusor.NormalKullaniciId = Convert.ToInt32(txtNormalKullaniciId.Text);
            Sorusor.Soru = txtMesaj.Text;
            Sorusor.SoruSor();
            MessageBox.Show("Mesajınız gönderildi.");
        }
    }
}
