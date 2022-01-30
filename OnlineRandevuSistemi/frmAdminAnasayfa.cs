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
    public partial class frmAdminAnasayfa : Form
    {
        public frmAdminAnasayfa()
        {
            InitializeComponent();
        }

      

        private void işYeriİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdminİslemler frm = new frmAdminİslemler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void yetkiliTanımlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminYetkiliTanımla frm = new frmAdminYetkiliTanımla();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminKullaniciListesiRapor frm = new frmAdminKullaniciListesiRapor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void randevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminIsYeriYetkiliListesiRapor frm = new frmAdminIsYeriYetkiliListesiRapor();
            frm.MdiParent = this;
            frm.Show();
        }

        private void işYeriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminIsYeriListesiRapor frm = new frmAdminIsYeriListesiRapor();
            frm.MdiParent = this;
            frm.Show();
        }

       
    }
}
