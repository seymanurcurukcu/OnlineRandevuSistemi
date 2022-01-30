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
    public partial class frmIsYeriTumMesajlarRapor : Form
    {
        public string yetkiliId = "";
        public frmIsYeriTumMesajlarRapor(string yetkiliid)
        {
            this.yetkiliId = yetkiliid;
            InitializeComponent();
        }

        IsYeriYetkiliRaporlari listele = new IsYeriYetkiliRaporlari();
        private void frmIsYeriTumMesajlarRapor_Load(object sender, EventArgs e)
        {
            lblIsYeriYetkiliId.Text = this.yetkiliId;
            listele.TumMesajListesi(dgvTumMesajlar, lblIsYeriYetkiliId.Text);

        }
    }
}
