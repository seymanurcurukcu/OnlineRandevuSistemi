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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void btnIsYeriGiris_Click(object sender, EventArgs e)
        {
            frmIsYeriGiris fr = new frmIsYeriGiris();
            fr.Show();
            this.Hide();
        }

        private void btnNormalGiris_Click(object sender, EventArgs e)
        {
            frmNormalGiris fr = new frmNormalGiris();
            fr.Show();
            this.Hide();
        }
    }
}
