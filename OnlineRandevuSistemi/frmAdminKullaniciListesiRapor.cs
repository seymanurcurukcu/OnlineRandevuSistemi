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
    public partial class frmAdminKullaniciListesiRapor : Form
    {
        public frmAdminKullaniciListesiRapor()
        {
            InitializeComponent();
        }

        sqlBaglantisi myDatabase = new sqlBaglantisi();



        AdminRaporlar rapor = new AdminRaporlar();
        private void frmAdminKullaniciListesi_Load(object sender, EventArgs e)
        {
            rapor.kullaniciListele(dgvKullaniciListesi);
        }
    }
}
