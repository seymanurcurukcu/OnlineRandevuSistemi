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
    public partial class frmIsYeriCevaplanmamisMesajlarRapor : Form
    {
        public string yetkiliId = "";
        public frmIsYeriCevaplanmamisMesajlarRapor(string yetkiliid)
        {
            this.yetkiliId = yetkiliid;
            InitializeComponent();
        }

        IsYeriYetkiliRaporlari listele = new IsYeriYetkiliRaporlari();
        private void frmIsYeriCevaplanmamisMesajlarRapor_Load(object sender, EventArgs e)
        {
            lblYetkiliId.Text = this.yetkiliId;
            listele.CevaplanmamisMesajListesi(dgvCevaplanmamısMesaj, lblYetkiliId.Text);
        }
    }
}
