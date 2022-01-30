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
    public partial class frmAdminYetkiliTanımla : Form
    {
        public frmAdminYetkiliTanımla()
        {
            InitializeComponent();
        }
        IsYeri isYeri = new IsYeri();
        IsYeriYetkiliBilgileri isYeriYetkilisi = new IsYeriYetkiliBilgileri();
        IsYeriYetkiliTanimlama isYeriYetkiliTanimlama = new IsYeriYetkiliTanimlama();
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            

            isYeriYetkiliTanimlama.isYeri= isYeri;
            isYeriYetkiliTanimlama.isYeriYetkilisi = isYeriYetkilisi;
            isYeriYetkiliTanimlama.tanımla();

            
            isYeriYetkiliTanimlama.YetkiliGuncelle();
            isYeriYetkiliTanimlama.IsYeriGuncelle();
            isYeriYetkiliTanimlama.IsYeriGoster(dgvIsYeriListesi);
            isYeriYetkiliTanimlama.YetkiliGoster(dgvYetkiliListesi);
            isYeriYetkiliTanimlama.IsYerininYetkilisiniGoster(dgvYetkiliTanımlama);

        }

        private void dgvIsYeriListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               isYeri.IsYeriID = Convert.ToInt32(dgvIsYeriListesi.CurrentRow.Cells[0].Value);
               txtIsYeriAdi.Text = dgvIsYeriListesi.CurrentRow.Cells[0].Value.ToString() + " ID 'li " + dgvIsYeriListesi.CurrentRow.Cells[1].Value.ToString() + " İsimli İş Yeri ";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvYetkiliListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                isYeriYetkilisi.IsYeriYetkilisiID = Convert.ToInt32(dgvYetkiliListesi.CurrentRow.Cells[0].Value);
                txtYetkiliAdi.Text = dgvYetkiliListesi.CurrentRow.Cells[0].Value.ToString() + " ID 'li " + dgvYetkiliListesi.CurrentRow.Cells[1].Value.ToString() + " İsimli İş Yeri Yetkilisi ";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
      
        private void frmAdminYetkiliTanımla_Load(object sender, EventArgs e)
        {
            isYeriYetkiliTanimlama.IsYeriGoster(dgvIsYeriListesi);
            isYeriYetkiliTanimlama.YetkiliGoster(dgvYetkiliListesi);
            isYeriYetkiliTanimlama.IsYerininYetkilisiniGoster(dgvYetkiliTanımlama);
            
        }

        
    }
}
