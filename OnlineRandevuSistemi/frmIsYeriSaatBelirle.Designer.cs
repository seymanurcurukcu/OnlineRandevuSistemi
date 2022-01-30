namespace OnlineRandevuSistemi
{
    partial class frmIsYeriSaatBelirle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblBaslangicSaat = new System.Windows.Forms.Label();
            this.lblBitisSaati = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.mskBaslangicSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskBitisSaat = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpZamanBelirleme = new System.Windows.Forms.GroupBox();
            this.txtZamanId = new System.Windows.Forms.TextBox();
            this.lblZamanId = new System.Windows.Forms.Label();
            this.lblIsYeriId = new System.Windows.Forms.Label();
            this.cmbIsYerId = new System.Windows.Forms.ComboBox();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblYetkiliID = new System.Windows.Forms.Label();
            this.dgvUygunOlmayanZaman = new System.Windows.Forms.DataGridView();
            this.grpZamanBelirleme.SuspendLayout();
            this.grpIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUygunOlmayanZaman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(86, 75);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(34, 13);
            this.lblTarih.TabIndex = 0;
            this.lblTarih.Text = "Tarih:";
            // 
            // lblBaslangicSaat
            // 
            this.lblBaslangicSaat.AutoSize = true;
            this.lblBaslangicSaat.Location = new System.Drawing.Point(38, 108);
            this.lblBaslangicSaat.Name = "lblBaslangicSaat";
            this.lblBaslangicSaat.Size = new System.Drawing.Size(83, 13);
            this.lblBaslangicSaat.TabIndex = 1;
            this.lblBaslangicSaat.Text = "Başlangıç Saati:";
            // 
            // lblBitisSaati
            // 
            this.lblBitisSaati.AutoSize = true;
            this.lblBitisSaati.Location = new System.Drawing.Point(64, 142);
            this.lblBitisSaati.Name = "lblBitisSaati";
            this.lblBitisSaati.Size = new System.Drawing.Size(56, 13);
            this.lblBitisSaati.TabIndex = 2;
            this.lblBitisSaati.Text = "Bitiş Saati:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(126, 68);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(100, 20);
            this.mskTarih.TabIndex = 2;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mskBaslangicSaat
            // 
            this.mskBaslangicSaat.Location = new System.Drawing.Point(126, 101);
            this.mskBaslangicSaat.Mask = "00";
            this.mskBaslangicSaat.Name = "mskBaslangicSaat";
            this.mskBaslangicSaat.Size = new System.Drawing.Size(100, 20);
            this.mskBaslangicSaat.TabIndex = 3;
            // 
            // mskBitisSaat
            // 
            this.mskBitisSaat.Location = new System.Drawing.Point(126, 135);
            this.mskBitisSaat.Mask = "00";
            this.mskBitisSaat.Name = "mskBitisSaat";
            this.mskBitisSaat.Size = new System.Drawing.Size(100, 20);
            this.mskBitisSaat.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(19, 23);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(154, 43);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpZamanBelirleme
            // 
            this.grpZamanBelirleme.Controls.Add(this.txtZamanId);
            this.grpZamanBelirleme.Controls.Add(this.lblZamanId);
            this.grpZamanBelirleme.Controls.Add(this.lblIsYeriId);
            this.grpZamanBelirleme.Controls.Add(this.cmbIsYerId);
            this.grpZamanBelirleme.Controls.Add(this.mskTarih);
            this.grpZamanBelirleme.Controls.Add(this.lblTarih);
            this.grpZamanBelirleme.Controls.Add(this.mskBitisSaat);
            this.grpZamanBelirleme.Controls.Add(this.lblBaslangicSaat);
            this.grpZamanBelirleme.Controls.Add(this.mskBaslangicSaat);
            this.grpZamanBelirleme.Controls.Add(this.lblBitisSaati);
            this.grpZamanBelirleme.Location = new System.Drawing.Point(26, 12);
            this.grpZamanBelirleme.Name = "grpZamanBelirleme";
            this.grpZamanBelirleme.Size = new System.Drawing.Size(287, 224);
            this.grpZamanBelirleme.TabIndex = 7;
            this.grpZamanBelirleme.TabStop = false;
            this.grpZamanBelirleme.Text = "Uygun Olmayan Zaman Belirleme";
            // 
            // txtZamanId
            // 
            this.txtZamanId.Enabled = false;
            this.txtZamanId.Location = new System.Drawing.Point(126, 42);
            this.txtZamanId.Name = "txtZamanId";
            this.txtZamanId.Size = new System.Drawing.Size(100, 20);
            this.txtZamanId.TabIndex = 1;
            // 
            // lblZamanId
            // 
            this.lblZamanId.AutoSize = true;
            this.lblZamanId.Location = new System.Drawing.Point(64, 45);
            this.lblZamanId.Name = "lblZamanId";
            this.lblZamanId.Size = new System.Drawing.Size(55, 13);
            this.lblZamanId.TabIndex = 11;
            this.lblZamanId.Text = "Zaman Id:";
            // 
            // lblIsYeriId
            // 
            this.lblIsYeriId.AutoSize = true;
            this.lblIsYeriId.Location = new System.Drawing.Point(68, 177);
            this.lblIsYeriId.Name = "lblIsYeriId";
            this.lblIsYeriId.Size = new System.Drawing.Size(51, 13);
            this.lblIsYeriId.TabIndex = 12;
            this.lblIsYeriId.Text = "İş Yeri İd:";
            // 
            // cmbIsYerId
            // 
            this.cmbIsYerId.Enabled = false;
            this.cmbIsYerId.FormattingEnabled = true;
            this.cmbIsYerId.Location = new System.Drawing.Point(126, 169);
            this.cmbIsYerId.Name = "cmbIsYerId";
            this.cmbIsYerId.Size = new System.Drawing.Size(100, 21);
            this.cmbIsYerId.TabIndex = 5;
            // 
            // grpIslemler
            // 
            this.grpIslemler.Controls.Add(this.btnListele);
            this.grpIslemler.Controls.Add(this.btnTemizle);
            this.grpIslemler.Controls.Add(this.btnSil);
            this.grpIslemler.Controls.Add(this.btnGuncelle);
            this.grpIslemler.Controls.Add(this.btnEkle);
            this.grpIslemler.Location = new System.Drawing.Point(331, 12);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(351, 224);
            this.grpIslemler.TabIndex = 8;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(179, 78);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(154, 43);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(19, 135);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(314, 43);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(19, 78);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 43);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(179, 23);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(154, 43);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblYetkiliID
            // 
            this.lblYetkiliID.AutoSize = true;
            this.lblYetkiliID.Location = new System.Drawing.Point(44, 431);
            this.lblYetkiliID.Name = "lblYetkiliID";
            this.lblYetkiliID.Size = new System.Drawing.Size(0, 13);
            this.lblYetkiliID.TabIndex = 10;
            this.lblYetkiliID.Visible = false;
            // 
            // dgvUygunOlmayanZaman
            // 
            this.dgvUygunOlmayanZaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUygunOlmayanZaman.Location = new System.Drawing.Point(26, 242);
            this.dgvUygunOlmayanZaman.Name = "dgvUygunOlmayanZaman";
            this.dgvUygunOlmayanZaman.Size = new System.Drawing.Size(656, 177);
            this.dgvUygunOlmayanZaman.TabIndex = 9;
            this.dgvUygunOlmayanZaman.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUygunOlmayanZaman_CellEnter);
            // 
            // frmIsYeriSaatBelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 463);
            this.Controls.Add(this.lblYetkiliID);
            this.Controls.Add(this.dgvUygunOlmayanZaman);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpZamanBelirleme);
            this.Name = "frmIsYeriSaatBelirle";
            this.Text = "Belirli Tarihteki Uygun Olmayan Saat Aralığı Belirleme";
            this.Load += new System.EventHandler(this.frmIsYeriSaatBelirle_Load);
            this.grpZamanBelirleme.ResumeLayout(false);
            this.grpZamanBelirleme.PerformLayout();
            this.grpIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUygunOlmayanZaman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblBaslangicSaat;
        private System.Windows.Forms.Label lblBitisSaati;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.MaskedTextBox mskBaslangicSaat;
        private System.Windows.Forms.MaskedTextBox mskBitisSaat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox grpZamanBelirleme;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cmbIsYerId;
        private System.Windows.Forms.Label lblIsYeriId;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtZamanId;
        private System.Windows.Forms.Label lblZamanId;
        private System.Windows.Forms.Label lblYetkiliID;
        private System.Windows.Forms.DataGridView dgvUygunOlmayanZaman;
    }
}