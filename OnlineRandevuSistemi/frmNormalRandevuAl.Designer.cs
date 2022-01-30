namespace OnlineRandevuSistemi
{
    partial class frmNormalRandevuAl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIsYeriListesi = new System.Windows.Forms.DataGridView();
            this.lblIsYeriAra = new System.Windows.Forms.Label();
            this.lblIsYeriTuruAra = new System.Windows.Forms.Label();
            this.txtIsYeriAra = new System.Windows.Forms.TextBox();
            this.txtIsYeriTuruAra = new System.Windows.Forms.TextBox();
            this.btnIsYeriAra = new System.Windows.Forms.Button();
            this.btnIsYeriTuruAra = new System.Windows.Forms.Button();
            this.grpRandevuSaati = new System.Windows.Forms.GroupBox();
            this.btnUygunSaatListele = new System.Windows.Forms.Button();
            this.dgvSaatListele = new System.Windows.Forms.DataGridView();
            this.lblRandevuSaati = new System.Windows.Forms.Label();
            this.mskRandevuTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lblRandevuTarihi = new System.Windows.Forms.Label();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.grpRandevuAl = new System.Windows.Forms.GroupBox();
            this.txtRandevuSaati = new System.Windows.Forms.TextBox();
            this.lblRandevuSaat = new System.Windows.Forms.Label();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            this.txtKullaniciId = new System.Windows.Forms.TextBox();
            this.lblIsYeriYetkiliId = new System.Windows.Forms.Label();
            this.txtIsYeriYetkiliId = new System.Windows.Forms.TextBox();
            this.lblIsYeriId = new System.Windows.Forms.Label();
            this.txtIsYeriId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).BeginInit();
            this.grpRandevuSaati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaatListele)).BeginInit();
            this.grpRandevuAl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIsYeriListesi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Yeri Listesi";
            // 
            // dgvIsYeriListesi
            // 
            this.dgvIsYeriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsYeriListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvIsYeriListesi.Name = "dgvIsYeriListesi";
            this.dgvIsYeriListesi.Size = new System.Drawing.Size(759, 138);
            this.dgvIsYeriListesi.TabIndex = 0;
            this.dgvIsYeriListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeriListesi_CellEnter);
            // 
            // lblIsYeriAra
            // 
            this.lblIsYeriAra.AutoSize = true;
            this.lblIsYeriAra.Location = new System.Drawing.Point(35, 210);
            this.lblIsYeriAra.Name = "lblIsYeriAra";
            this.lblIsYeriAra.Size = new System.Drawing.Size(58, 13);
            this.lblIsYeriAra.TabIndex = 1;
            this.lblIsYeriAra.Text = "İş Yeri Ara:";
            // 
            // lblIsYeriTuruAra
            // 
            this.lblIsYeriTuruAra.AutoSize = true;
            this.lblIsYeriTuruAra.Location = new System.Drawing.Point(420, 210);
            this.lblIsYeriTuruAra.Name = "lblIsYeriTuruAra";
            this.lblIsYeriTuruAra.Size = new System.Drawing.Size(83, 13);
            this.lblIsYeriTuruAra.TabIndex = 2;
            this.lblIsYeriTuruAra.Text = "İş Yeri Türü Ara:";
            // 
            // txtIsYeriAra
            // 
            this.txtIsYeriAra.Location = new System.Drawing.Point(97, 203);
            this.txtIsYeriAra.Name = "txtIsYeriAra";
            this.txtIsYeriAra.Size = new System.Drawing.Size(143, 20);
            this.txtIsYeriAra.TabIndex = 1;
            // 
            // txtIsYeriTuruAra
            // 
            this.txtIsYeriTuruAra.Location = new System.Drawing.Point(509, 203);
            this.txtIsYeriTuruAra.Name = "txtIsYeriTuruAra";
            this.txtIsYeriTuruAra.Size = new System.Drawing.Size(143, 20);
            this.txtIsYeriTuruAra.TabIndex = 2;
            // 
            // btnIsYeriAra
            // 
            this.btnIsYeriAra.Location = new System.Drawing.Point(265, 197);
            this.btnIsYeriAra.Name = "btnIsYeriAra";
            this.btnIsYeriAra.Size = new System.Drawing.Size(92, 30);
            this.btnIsYeriAra.TabIndex = 5;
            this.btnIsYeriAra.Text = "Ara";
            this.btnIsYeriAra.UseVisualStyleBackColor = true;
            this.btnIsYeriAra.Click += new System.EventHandler(this.btnIsYeriAra_Click);
            // 
            // btnIsYeriTuruAra
            // 
            this.btnIsYeriTuruAra.Location = new System.Drawing.Point(667, 193);
            this.btnIsYeriTuruAra.Name = "btnIsYeriTuruAra";
            this.btnIsYeriTuruAra.Size = new System.Drawing.Size(92, 30);
            this.btnIsYeriTuruAra.TabIndex = 6;
            this.btnIsYeriTuruAra.Text = "Ara";
            this.btnIsYeriTuruAra.UseVisualStyleBackColor = true;
            this.btnIsYeriTuruAra.Click += new System.EventHandler(this.btnIsYeriTuruAra_Click);
            // 
            // grpRandevuSaati
            // 
            this.grpRandevuSaati.Controls.Add(this.btnUygunSaatListele);
            this.grpRandevuSaati.Controls.Add(this.dgvSaatListele);
            this.grpRandevuSaati.Controls.Add(this.lblRandevuSaati);
            this.grpRandevuSaati.Controls.Add(this.mskRandevuTarihi);
            this.grpRandevuSaati.Controls.Add(this.lblRandevuTarihi);
            this.grpRandevuSaati.Location = new System.Drawing.Point(15, 253);
            this.grpRandevuSaati.Name = "grpRandevuSaati";
            this.grpRandevuSaati.Size = new System.Drawing.Size(362, 269);
            this.grpRandevuSaati.TabIndex = 7;
            this.grpRandevuSaati.TabStop = false;
            this.grpRandevuSaati.Text = "Randevu Saatini Belirle";
            // 
            // btnUygunSaatListele
            // 
            this.btnUygunSaatListele.Location = new System.Drawing.Point(118, 52);
            this.btnUygunSaatListele.Name = "btnUygunSaatListele";
            this.btnUygunSaatListele.Size = new System.Drawing.Size(212, 40);
            this.btnUygunSaatListele.TabIndex = 6;
            this.btnUygunSaatListele.Text = "Uygun Saatleri Listele";
            this.btnUygunSaatListele.UseVisualStyleBackColor = true;
            this.btnUygunSaatListele.Click += new System.EventHandler(this.btnUygunSaatListele_Click);
            // 
            // dgvSaatListele
            // 
            this.dgvSaatListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaatListele.Location = new System.Drawing.Point(32, 115);
            this.dgvSaatListele.Name = "dgvSaatListele";
            this.dgvSaatListele.Size = new System.Drawing.Size(298, 136);
            this.dgvSaatListele.TabIndex = 5;
            this.dgvSaatListele.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaatListele_CellEnter);
            // 
            // lblRandevuSaati
            // 
            this.lblRandevuSaati.AutoSize = true;
            this.lblRandevuSaati.Location = new System.Drawing.Point(29, 93);
            this.lblRandevuSaati.Name = "lblRandevuSaati";
            this.lblRandevuSaati.Size = new System.Drawing.Size(81, 13);
            this.lblRandevuSaati.TabIndex = 1;
            this.lblRandevuSaati.Text = "Randevu Saati:";
            // 
            // mskRandevuTarihi
            // 
            this.mskRandevuTarihi.Location = new System.Drawing.Point(118, 26);
            this.mskRandevuTarihi.Mask = "00/00/0000";
            this.mskRandevuTarihi.Name = "mskRandevuTarihi";
            this.mskRandevuTarihi.Size = new System.Drawing.Size(212, 20);
            this.mskRandevuTarihi.TabIndex = 3;
            this.mskRandevuTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lblRandevuTarihi
            // 
            this.lblRandevuTarihi.AutoSize = true;
            this.lblRandevuTarihi.Location = new System.Drawing.Point(29, 29);
            this.lblRandevuTarihi.Name = "lblRandevuTarihi";
            this.lblRandevuTarihi.Size = new System.Drawing.Size(83, 13);
            this.lblRandevuTarihi.TabIndex = 0;
            this.lblRandevuTarihi.Text = "Randevu Tarihi:";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(114, 150);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(141, 33);
            this.btnRandevuAl.TabIndex = 4;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // grpRandevuAl
            // 
            this.grpRandevuAl.Controls.Add(this.txtRandevuSaati);
            this.grpRandevuAl.Controls.Add(this.lblRandevuSaat);
            this.grpRandevuAl.Controls.Add(this.btnRandevuAl);
            this.grpRandevuAl.Controls.Add(this.lblKullaniciId);
            this.grpRandevuAl.Controls.Add(this.txtKullaniciId);
            this.grpRandevuAl.Controls.Add(this.lblIsYeriYetkiliId);
            this.grpRandevuAl.Controls.Add(this.txtIsYeriYetkiliId);
            this.grpRandevuAl.Controls.Add(this.lblIsYeriId);
            this.grpRandevuAl.Controls.Add(this.txtIsYeriId);
            this.grpRandevuAl.Location = new System.Drawing.Point(415, 253);
            this.grpRandevuAl.Name = "grpRandevuAl";
            this.grpRandevuAl.Size = new System.Drawing.Size(362, 269);
            this.grpRandevuAl.TabIndex = 8;
            this.grpRandevuAl.TabStop = false;
            this.grpRandevuAl.Text = "Randevu Al";
            // 
            // txtRandevuSaati
            // 
            this.txtRandevuSaati.Enabled = false;
            this.txtRandevuSaati.Location = new System.Drawing.Point(114, 106);
            this.txtRandevuSaati.Name = "txtRandevuSaati";
            this.txtRandevuSaati.Size = new System.Drawing.Size(141, 20);
            this.txtRandevuSaati.TabIndex = 7;
            // 
            // lblRandevuSaat
            // 
            this.lblRandevuSaat.AutoSize = true;
            this.lblRandevuSaat.Location = new System.Drawing.Point(26, 109);
            this.lblRandevuSaat.Name = "lblRandevuSaat";
            this.lblRandevuSaat.Size = new System.Drawing.Size(81, 13);
            this.lblRandevuSaat.TabIndex = 7;
            this.lblRandevuSaat.Text = "Randevu Saati:";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Location = new System.Drawing.Point(34, 83);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(61, 13);
            this.lblKullaniciId.TabIndex = 5;
            this.lblKullaniciId.Text = "Kullanıcı İd:";
            // 
            // txtKullaniciId
            // 
            this.txtKullaniciId.Enabled = false;
            this.txtKullaniciId.Location = new System.Drawing.Point(114, 76);
            this.txtKullaniciId.Name = "txtKullaniciId";
            this.txtKullaniciId.Size = new System.Drawing.Size(141, 20);
            this.txtKullaniciId.TabIndex = 6;
            // 
            // lblIsYeriYetkiliId
            // 
            this.lblIsYeriYetkiliId.AutoSize = true;
            this.lblIsYeriYetkiliId.Location = new System.Drawing.Point(26, 56);
            this.lblIsYeriYetkiliId.Name = "lblIsYeriYetkiliId";
            this.lblIsYeriYetkiliId.Size = new System.Drawing.Size(82, 13);
            this.lblIsYeriYetkiliId.TabIndex = 3;
            this.lblIsYeriYetkiliId.Text = "İs Yeri Yetkili İd:";
            // 
            // txtIsYeriYetkiliId
            // 
            this.txtIsYeriYetkiliId.Enabled = false;
            this.txtIsYeriYetkiliId.Location = new System.Drawing.Point(114, 49);
            this.txtIsYeriYetkiliId.Name = "txtIsYeriYetkiliId";
            this.txtIsYeriYetkiliId.Size = new System.Drawing.Size(141, 20);
            this.txtIsYeriYetkiliId.TabIndex = 5;
            // 
            // lblIsYeriId
            // 
            this.lblIsYeriId.AutoSize = true;
            this.lblIsYeriId.Location = new System.Drawing.Point(57, 26);
            this.lblIsYeriId.Name = "lblIsYeriId";
            this.lblIsYeriId.Size = new System.Drawing.Size(51, 13);
            this.lblIsYeriId.TabIndex = 1;
            this.lblIsYeriId.Text = "İş Yeri İd:";
            // 
            // txtIsYeriId
            // 
            this.txtIsYeriId.Enabled = false;
            this.txtIsYeriId.Location = new System.Drawing.Point(114, 23);
            this.txtIsYeriId.Name = "txtIsYeriId";
            this.txtIsYeriId.Size = new System.Drawing.Size(141, 20);
            this.txtIsYeriId.TabIndex = 4;
            // 
            // frmNormalRandevuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 534);
            this.Controls.Add(this.grpRandevuAl);
            this.Controls.Add(this.grpRandevuSaati);
            this.Controls.Add(this.btnIsYeriTuruAra);
            this.Controls.Add(this.btnIsYeriAra);
            this.Controls.Add(this.txtIsYeriTuruAra);
            this.Controls.Add(this.txtIsYeriAra);
            this.Controls.Add(this.lblIsYeriTuruAra);
            this.Controls.Add(this.lblIsYeriAra);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNormalRandevuAl";
            this.Text = "Normal Kullanıcı Randevu Al";
            this.Load += new System.EventHandler(this.frmNormalRandevuAl_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).EndInit();
            this.grpRandevuSaati.ResumeLayout(false);
            this.grpRandevuSaati.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaatListele)).EndInit();
            this.grpRandevuAl.ResumeLayout(false);
            this.grpRandevuAl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIsYeriListesi;
        private System.Windows.Forms.Label lblIsYeriAra;
        private System.Windows.Forms.Label lblIsYeriTuruAra;
        private System.Windows.Forms.TextBox txtIsYeriAra;
        private System.Windows.Forms.TextBox txtIsYeriTuruAra;
        private System.Windows.Forms.Button btnIsYeriAra;
        private System.Windows.Forms.Button btnIsYeriTuruAra;
        private System.Windows.Forms.GroupBox grpRandevuSaati;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.MaskedTextBox mskRandevuTarihi;
        private System.Windows.Forms.Label lblRandevuSaati;
        private System.Windows.Forms.Label lblRandevuTarihi;
        private System.Windows.Forms.DataGridView dgvSaatListele;
        private System.Windows.Forms.GroupBox grpRandevuAl;
        private System.Windows.Forms.Label lblRandevuSaat;
        private System.Windows.Forms.Label lblKullaniciId;
        private System.Windows.Forms.TextBox txtKullaniciId;
        private System.Windows.Forms.Label lblIsYeriYetkiliId;
        private System.Windows.Forms.TextBox txtIsYeriYetkiliId;
        private System.Windows.Forms.Label lblIsYeriId;
        private System.Windows.Forms.TextBox txtIsYeriId;
        private System.Windows.Forms.Button btnUygunSaatListele;
        private System.Windows.Forms.TextBox txtRandevuSaati;
    }
}