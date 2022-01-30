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
    public partial class frmNormalOnaylananRandevu : Form
    {
        public string NormalKullanciId = "";
        public frmNormalOnaylananRandevu(string NormalKullanciId)
        {
            this.NormalKullanciId = NormalKullanciId;
            InitializeComponent();
        }

        NormalKullaniciListeleri listele = new NormalKullaniciListeleri();
        private void frmNormalOnaylananRandevu_Load(object sender, EventArgs e)
        {
            try
            {
               
                lblKullaniciId.Text = this.NormalKullanciId;
                listele.KullaniciId = lblKullaniciId.Text;

                listele.OnaylananRandevular(dgvOnaylananRandevu);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
