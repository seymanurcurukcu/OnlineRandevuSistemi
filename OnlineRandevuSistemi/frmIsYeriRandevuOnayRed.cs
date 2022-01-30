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
    public partial class frmIsYeriRandevuOnayRed : Form
    {
        public string yetkiliId = "";
        public frmIsYeriRandevuOnayRed(string yetkiliid)
        {
            this.yetkiliId = yetkiliid;
            InitializeComponent();
        }

        RandevuOnaylaReddet randevu = new RandevuOnaylaReddet();

        private void frmIsYeriRandevuOnayRed_Load(object sender, EventArgs e)
        {
            lblYetkiliid.Text = this.yetkiliId;
            randevu.RandevuListesi(dgvRandevuListesi, lblYetkiliid.Text);
        }

        private void dgvRandevuListesi_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                randevu.RandevuID = Convert.ToInt32(dgvRandevuListesi.CurrentRow.Cells[0].Value);
                randevu.RandevuOnayDurum = Convert.ToByte(dgvRandevuListesi.CurrentRow.Cells[3].Value);
               

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                 randevu.RandevuOnayla();
                 MessageBox.Show(randevu.RandevuID + " ID 'li"  + " "+ " randevu onaylandı...");
                 lblYetkiliid.Text = this.yetkiliId;
                 randevu.RandevuListesi(dgvRandevuListesi, lblYetkiliid.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            try
            {
                randevu.RandevuReddet();
                MessageBox.Show(randevu.RandevuID + " ID 'li" + " " + " randevu reddedildi...");
                lblYetkiliid.Text = this.yetkiliId;
                randevu.RandevuListesi(dgvRandevuListesi, lblYetkiliid.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
