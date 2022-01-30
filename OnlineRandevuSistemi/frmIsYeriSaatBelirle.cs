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
    public partial class frmIsYeriSaatBelirle : Form
    {
        public string yetkiliId = "";
        public frmIsYeriSaatBelirle(string yetkiliid)
        {
            InitializeComponent();
            this.yetkiliId = yetkiliid;
        }
       
        sqlBaglantisi myDatabase = new sqlBaglantisi();
        UygunOlmayanZaman zaman;
        UygunOlmayanZamanIslemler UygunOlmayanZaman = new UygunOlmayanZamanIslemler();

        void IsYeriIDCekme()
        {
            lblYetkiliID.Text = this.yetkiliId;
            myDatabase.baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblIsYeri where IsYeriYetkiliID='" + lblYetkiliID.Text + "'", myDatabase.baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbIsYerId.ValueMember = "IsYeriID";
            cmbIsYerId.DataSource = dt;
            myDatabase.baglanti.Close();
        }

   
        private void frmIsYeriSaatBelirle_Load(object sender, EventArgs e)
        {
            IsYeriIDCekme();
            UygunOlmayanZaman.Listele(dgvUygunOlmayanZaman, cmbIsYerId.Text);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {   
                    zaman = new UygunOlmayanZaman();
                    zaman.Tarih = mskTarih.Text;
                    zaman.BaslangicSaati = Convert.ToInt32(mskBaslangicSaat.Text);
                    zaman.BitisSaati = Convert.ToInt32(mskBitisSaat.Text);
                    zaman.ZamanIsYeriID = Convert.ToInt32(cmbIsYerId.Text);
                    UygunOlmayanZaman.Ekle(zaman);
                   UygunOlmayanZaman.Listele(dgvUygunOlmayanZaman, cmbIsYerId.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dgvUygunOlmayanZaman_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtZamanId.Text= dgvUygunOlmayanZaman.CurrentRow.Cells[0].Value.ToString();
                mskTarih.Text = dgvUygunOlmayanZaman.CurrentRow.Cells[1].Value.ToString();
                mskBaslangicSaat.Text = dgvUygunOlmayanZaman.CurrentRow.Cells[2].Value.ToString();
                mskBitisSaat.Text = dgvUygunOlmayanZaman.CurrentRow.Cells[3].Value.ToString();
                cmbIsYerId.Text = dgvUygunOlmayanZaman.CurrentRow.Cells[4].Value.ToString();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                zaman = new UygunOlmayanZaman();
                zaman.UygunOlmayanZamanId = Convert.ToInt32(txtZamanId.Text);
                zaman.Tarih = mskTarih.Text;
                zaman.BaslangicSaati = Convert.ToInt32(mskBaslangicSaat.Text);
                zaman.BitisSaati = Convert.ToInt32(mskBitisSaat.Text);
                UygunOlmayanZaman.ZamanGuncelle(zaman);
                UygunOlmayanZaman.Listele(dgvUygunOlmayanZaman, cmbIsYerId.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                zaman = new UygunOlmayanZaman();
                zaman.UygunOlmayanZamanId = Convert.ToInt32(txtZamanId.Text);
                UygunOlmayanZaman.ZamanSilme(zaman);
                UygunOlmayanZaman.Listele(dgvUygunOlmayanZaman, cmbIsYerId.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtZamanId.Text = "";
            mskBaslangicSaat.Text = "";
            mskBitisSaat.Text = "";
            mskTarih.Text = "";
        }

       
    }
}
