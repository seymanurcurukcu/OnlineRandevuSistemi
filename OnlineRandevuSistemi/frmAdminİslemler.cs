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
    public partial class frmAdminİslemler : Form
    {
        public frmAdminİslemler()
        {
            InitializeComponent();
        }

       
        IsYeri isyeri;
        IsYeri_sqlBaglantisi Rapor = new IsYeri_sqlBaglantisi();
      

        private void dgvIsYeriListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = dgvIsYeriListesi.CurrentRow.Cells[0].Value.ToString();
                txtIsYeriAd.Text = dgvIsYeriListesi.CurrentRow.Cells[1].Value.ToString();
                cmbIsTuru.Text = dgvIsYeriListesi.CurrentRow.Cells[2].Value.ToString();
                mskIsYeriTel.Text = dgvIsYeriListesi.CurrentRow.Cells[3].Value.ToString();
                txtIsYeriAdres.Text = dgvIsYeriListesi.CurrentRow.Cells[4].Value.ToString();
               
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

 

        private void btnIsYeriEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                isyeri = new IsYeri();
                isyeri.IsYeriAdi = txtIsYeriAd.Text;
                isyeri.IsYeriTuru = cmbIsTuru.Text;
                isyeri.IsYeriTelefonNo = mskIsYeriTel.Text;
                isyeri.IsYeriAdres = txtIsYeriAdres.Text;
                Rapor.Ekle(isyeri);
                Rapor.Listele(dgvIsYeriListesi);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnIsYeriGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                isyeri = new IsYeri();
                isyeri.IsYeriID = Convert.ToInt32(txtid.Text);
                isyeri.IsYeriAdi = txtIsYeriAd.Text;
                isyeri.IsYeriTuru = cmbIsTuru.Text;
                isyeri.IsYeriTelefonNo = mskIsYeriTel.Text;
                isyeri.IsYeriAdres = txtIsYeriAdres.Text;

                Rapor.IsYeriGuncelle(isyeri);
                Rapor.Listele(dgvIsYeriListesi);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            Rapor.Listele(dgvIsYeriListesi);
        }

        private void btnIsYeriSil_Click(object sender, EventArgs e)
        {
            try
            {
                isyeri = new IsYeri();
                isyeri.IsYeriID = Convert.ToInt32(txtid.Text);
                Rapor.IsYeriSilme(isyeri);
                Rapor.Listele(dgvIsYeriListesi);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtIsYeriAd.Text = "";
            cmbIsTuru.Text = "";
            mskIsYeriTel.Text = "";
            txtIsYeriAdres.Text = "";
        }

        private void btnIsYeriArama_Click(object sender, EventArgs e)
        {
         
            Rapor.IsYeriAra(dgvIsYeriListesi, txtArama.Text);
        }

      
    }
}
