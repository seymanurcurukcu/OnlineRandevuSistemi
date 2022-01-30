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
    public partial class frmNormalAnasayfa : Form
    {
        public string NormalKullaniciId = "";
        public frmNormalAnasayfa(string normalKullaniciID)
        {
            this.NormalKullaniciId = normalKullaniciID;
            InitializeComponent();
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalRandevuAl frm = new frmNormalRandevuAl(this.NormalKullaniciId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void soruSorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalSoruSor frm = new frmNormalSoruSor(this.NormalKullaniciId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void gelenMesajlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalGelenMesajlar frm = new frmNormalGelenMesajlar(this.NormalKullaniciId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void onaylananRandevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNormalOnaylananRandevu frm = new frmNormalOnaylananRandevu(this.NormalKullaniciId);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
