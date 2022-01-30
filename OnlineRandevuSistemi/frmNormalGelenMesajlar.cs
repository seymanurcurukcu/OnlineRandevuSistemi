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
    public partial class frmNormalGelenMesajlar : Form
    {
        public string NormalKullanciId = "";
        public frmNormalGelenMesajlar(string NormalKullanciId)
        {
            this.NormalKullanciId = NormalKullanciId;
            InitializeComponent();
        }

        NormalKullaniciListeleri listele = new NormalKullaniciListeleri();
        private void frmNormalGelenMesajlar_Load(object sender, EventArgs e)
        {
            try
            {
                lblKullaniciId.Text = this.NormalKullanciId;
                listele.KullaniciId = lblKullaniciId.Text;
                listele.GelenMesajlar(dgvGelenMesajListesi);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
