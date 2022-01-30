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
    public partial class frmAdminIsYeriListesiRapor : Form
    {
        public frmAdminIsYeriListesiRapor()
        {
            InitializeComponent();
        }

        AdminRaporlar rapor = new AdminRaporlar();
        private void frmAdminIsYeriListesi_Load(object sender, EventArgs e)
        {
            try
            {
                rapor.IsYeriListele(dgvIsYeriListe);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
