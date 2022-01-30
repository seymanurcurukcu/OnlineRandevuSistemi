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
    public partial class frmIsYeriRandevuListesiRapor : Form
    {
        public string yetkiliId = "";
        public frmIsYeriRandevuListesiRapor(string yetkiliid)
        {
            this.yetkiliId = yetkiliid;
            InitializeComponent();
        }
        IsYeriYetkiliRaporlari listele = new IsYeriYetkiliRaporlari();
        private void frmIsYeriRandevuListesiRapor_Load(object sender, EventArgs e)
        {
            lblYetkiliId.Text = this.yetkiliId;
            listele.OnaylananRandevlariListele(dgvRandevuListesi, lblYetkiliId.Text);
        }
    }
}
