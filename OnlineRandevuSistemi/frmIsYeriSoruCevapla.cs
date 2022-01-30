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
    public partial class frmIsYeriSoruCevapla : Form
    {
        public string yetkiliId = "";
        public frmIsYeriSoruCevapla(string yetkiliid)
        {
            this.yetkiliId = yetkiliid;
            InitializeComponent();
        }
       
        SoruCevapOzellikleri sorucevap;
        SoruCevapla cevapla = new SoruCevapla();
      
        private void frmIsYeriSoruCevapla_Load(object sender, EventArgs e)
        {
            lblYetkiliId.Text = this.yetkiliId;
            cevapla.mesajListele(dgvGelenMesajListesi, lblYetkiliId.Text);
        }

        private void dgvGelenMesajListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSoruId.Text = dgvGelenMesajListesi.CurrentRow.Cells[0].Value.ToString() ;
                txtAlici.Text = dgvGelenMesajListesi.CurrentRow.Cells[6].Value.ToString() ;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            try
            {
                
                sorucevap = new SoruCevapOzellikleri();
                sorucevap.SoruCevapID = Convert.ToInt32(txtSoruId.Text);
                sorucevap.Cevap= txtMesaj.Text;
                cevapla.MesajCevapla(sorucevap);
                lblYetkiliId.Text = this.yetkiliId;
                cevapla.mesajListele(dgvGelenMesajListesi, lblYetkiliId.Text);
                MessageBox.Show("Mesaj gönderildi.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
