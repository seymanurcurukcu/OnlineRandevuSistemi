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
    public partial class frmIsYeriAnasayfa : Form
    {
        public string yetkiliId = "";
        public frmIsYeriAnasayfa(string yetkiliId)
        {
            
            this.yetkiliId = yetkiliId;
            InitializeComponent();
        }

        private void randevuOnayRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsYeriRandevuOnayRed frm = new frmIsYeriRandevuOnayRed(this.yetkiliId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void uygunOlmayanSaatAralığıToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmIsYeriSaatBelirle frm = new frmIsYeriSaatBelirle(this.yetkiliId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void gelenSorularıCevaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsYeriSoruCevapla frm = new frmIsYeriSoruCevapla(this.yetkiliId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void tümMesajlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsYeriTumMesajlarRapor frm = new frmIsYeriTumMesajlarRapor(this.yetkiliId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void cevaplanmamışMesajlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsYeriCevaplanmamisMesajlarRapor frm = new frmIsYeriCevaplanmamisMesajlarRapor(this.yetkiliId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void randevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIsYeriRandevuListesiRapor frm = new frmIsYeriRandevuListesiRapor(this.yetkiliId);
            frm.MdiParent = this;
            frm.Show();
        }

      
    }
}
