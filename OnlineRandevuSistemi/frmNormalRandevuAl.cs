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
    public partial class frmNormalRandevuAl : Form
    {
        public string NormalKullanciId = "";
        public frmNormalRandevuAl(string NormalKullanciId)
        {
            this.NormalKullanciId = NormalKullanciId;
            InitializeComponent();
        }
       
        NormalKullaniciRandevuAl randevu = new NormalKullaniciRandevuAl();

        private void frmNormalRandevuAl_Load(object sender, EventArgs e)
        {
            txtKullaniciId.Text = this.NormalKullanciId;
            randevu.IsYeriListele(dgvIsYeriListesi);
        }

       

        private void dgvSaatListele_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRandevuSaati.Text = dgvSaatListele.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        private void btnUygunSaatListele_Click(object sender, EventArgs e)
        {
            try
            {
                randevu.IsYeriId = Convert.ToInt32(txtIsYeriId.Text);
                randevu.Tarih = mskRandevuTarihi.Text;
                randevu.UygunZamanBelirleme(dgvSaatListele);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {
                randevu.IsYeriId = Convert.ToInt32(txtIsYeriId.Text);
                randevu.YetkiliId = Convert.ToInt32(txtIsYeriYetkiliId.Text);
                randevu.Tarih = mskRandevuTarihi.Text;
                randevu.NormalKullaniciId = Convert.ToInt32(txtKullaniciId.Text);
                randevu.RandevuSaati = Convert.ToInt32(txtRandevuSaati.Text);
                randevu.RandevuAl();
                MessageBox.Show("Randevu Alındı.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void btnIsYeriAra_Click(object sender, EventArgs e)
        {
            randevu.IsYeriAra(dgvIsYeriListesi, txtIsYeriAra.Text);
        }

        private void btnIsYeriTuruAra_Click(object sender, EventArgs e)
        {
            randevu.IsYerituruAra(dgvIsYeriListesi, txtIsYeriTuruAra.Text);
        }
    }
}
