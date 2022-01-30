namespace OnlineRandevuSistemi
{
    partial class frmNormalSoruSor
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
            this.btnIsYeriTuruAra = new System.Windows.Forms.Button();
            this.btnIsYeriAra = new System.Windows.Forms.Button();
            this.txtIsYeriTuruAra = new System.Windows.Forms.TextBox();
            this.txtIsYeriAra = new System.Windows.Forms.TextBox();
            this.lblIsYeriTuruAra = new System.Windows.Forms.Label();
            this.lblIsYeriAra = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIsYeriListesi = new System.Windows.Forms.DataGridView();
            this.grpSoruSor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIsYeriId = new System.Windows.Forms.Label();
            this.txtIsYeriYetkiliId = new System.Windows.Forms.TextBox();
            this.txtIsYeriId = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtNormalKullaniciId = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            this.grpIsYeriAra = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).BeginInit();
            this.grpSoruSor.SuspendLayout();
            this.grpIsYeriAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIsYeriTuruAra
            // 
            this.btnIsYeriTuruAra.Location = new System.Drawing.Point(97, 152);
            this.btnIsYeriTuruAra.Name = "btnIsYeriTuruAra";
            this.btnIsYeriTuruAra.Size = new System.Drawing.Size(143, 23);
            this.btnIsYeriTuruAra.TabIndex = 13;
            this.btnIsYeriTuruAra.Text = "Ara";
            this.btnIsYeriTuruAra.UseVisualStyleBackColor = true;
            this.btnIsYeriTuruAra.Click += new System.EventHandler(this.btnIsYeriTuruAra_Click);
            // 
            // btnIsYeriAra
            // 
            this.btnIsYeriAra.Location = new System.Drawing.Point(97, 56);
            this.btnIsYeriAra.Name = "btnIsYeriAra";
            this.btnIsYeriAra.Size = new System.Drawing.Size(143, 26);
            this.btnIsYeriAra.TabIndex = 12;
            this.btnIsYeriAra.Text = "Ara";
            this.btnIsYeriAra.UseVisualStyleBackColor = true;
            this.btnIsYeriAra.Click += new System.EventHandler(this.btnIsYeriAra_Click);
            // 
            // txtIsYeriTuruAra
            // 
            this.txtIsYeriTuruAra.Location = new System.Drawing.Point(97, 126);
            this.txtIsYeriTuruAra.Name = "txtIsYeriTuruAra";
            this.txtIsYeriTuruAra.Size = new System.Drawing.Size(143, 20);
            this.txtIsYeriTuruAra.TabIndex = 6;
            // 
            // txtIsYeriAra
            // 
            this.txtIsYeriAra.Location = new System.Drawing.Point(97, 30);
            this.txtIsYeriAra.Name = "txtIsYeriAra";
            this.txtIsYeriAra.Size = new System.Drawing.Size(143, 20);
            this.txtIsYeriAra.TabIndex = 5;
            // 
            // lblIsYeriTuruAra
            // 
            this.lblIsYeriTuruAra.AutoSize = true;
            this.lblIsYeriTuruAra.Location = new System.Drawing.Point(8, 133);
            this.lblIsYeriTuruAra.Name = "lblIsYeriTuruAra";
            this.lblIsYeriTuruAra.Size = new System.Drawing.Size(83, 13);
            this.lblIsYeriTuruAra.TabIndex = 9;
            this.lblIsYeriTuruAra.Text = "İş Yeri Türü Ara:";
            // 
            // lblIsYeriAra
            // 
            this.lblIsYeriAra.AutoSize = true;
            this.lblIsYeriAra.Location = new System.Drawing.Point(25, 33);
            this.lblIsYeriAra.Name = "lblIsYeriAra";
            this.lblIsYeriAra.Size = new System.Drawing.Size(58, 13);
            this.lblIsYeriAra.TabIndex = 8;
            this.lblIsYeriAra.Text = "İş Yeri Ara:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIsYeriListesi);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 157);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Yeri Listesi";
            // 
            // dgvIsYeriListesi
            // 
            this.dgvIsYeriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsYeriListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvIsYeriListesi.Name = "dgvIsYeriListesi";
            this.dgvIsYeriListesi.Size = new System.Drawing.Size(785, 138);
            this.dgvIsYeriListesi.TabIndex = 0;
            this.dgvIsYeriListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeriListesi_CellEnter);
            // 
            // grpSoruSor
            // 
            this.grpSoruSor.Controls.Add(this.label2);
            this.grpSoruSor.Controls.Add(this.lblIsYeriId);
            this.grpSoruSor.Controls.Add(this.txtIsYeriYetkiliId);
            this.grpSoruSor.Controls.Add(this.txtIsYeriId);
            this.grpSoruSor.Controls.Add(this.btnGonder);
            this.grpSoruSor.Controls.Add(this.txtMesaj);
            this.grpSoruSor.Controls.Add(this.txtNormalKullaniciId);
            this.grpSoruSor.Controls.Add(this.lblMesaj);
            this.grpSoruSor.Controls.Add(this.lblKullaniciId);
            this.grpSoruSor.Location = new System.Drawing.Point(30, 211);
            this.grpSoruSor.Name = "grpSoruSor";
            this.grpSoruSor.Size = new System.Drawing.Size(360, 236);
            this.grpSoruSor.TabIndex = 14;
            this.grpSoruSor.TabStop = false;
            this.grpSoruSor.Text = "İş Yerine Soru Sor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "İş Yeri Yetkili İd:";
            // 
            // lblIsYeriId
            // 
            this.lblIsYeriId.AutoSize = true;
            this.lblIsYeriId.Location = new System.Drawing.Point(86, 52);
            this.lblIsYeriId.Name = "lblIsYeriId";
            this.lblIsYeriId.Size = new System.Drawing.Size(51, 13);
            this.lblIsYeriId.TabIndex = 9;
            this.lblIsYeriId.Text = "İş Yeri İd:";
            // 
            // txtIsYeriYetkiliId
            // 
            this.txtIsYeriYetkiliId.Enabled = false;
            this.txtIsYeriYetkiliId.Location = new System.Drawing.Point(143, 75);
            this.txtIsYeriYetkiliId.Name = "txtIsYeriYetkiliId";
            this.txtIsYeriYetkiliId.Size = new System.Drawing.Size(168, 20);
            this.txtIsYeriYetkiliId.TabIndex = 3;
            // 
            // txtIsYeriId
            // 
            this.txtIsYeriId.Enabled = false;
            this.txtIsYeriId.Location = new System.Drawing.Point(143, 49);
            this.txtIsYeriId.Name = "txtIsYeriId";
            this.txtIsYeriId.Size = new System.Drawing.Size(168, 20);
            this.txtIsYeriId.TabIndex = 2;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(143, 189);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(168, 31);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(143, 101);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(168, 82);
            this.txtMesaj.TabIndex = 4;
            // 
            // txtNormalKullaniciId
            // 
            this.txtNormalKullaniciId.Enabled = false;
            this.txtNormalKullaniciId.Location = new System.Drawing.Point(143, 23);
            this.txtNormalKullaniciId.Name = "txtNormalKullaniciId";
            this.txtNormalKullaniciId.Size = new System.Drawing.Size(168, 20);
            this.txtNormalKullaniciId.TabIndex = 1;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(99, 105);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(38, 13);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Mesaj:";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Location = new System.Drawing.Point(40, 26);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(97, 13);
            this.lblKullaniciId.TabIndex = 1;
            this.lblKullaniciId.Text = "Normal Kullanıcı İd:";
            // 
            // grpIsYeriAra
            // 
            this.grpIsYeriAra.Controls.Add(this.txtIsYeriAra);
            this.grpIsYeriAra.Controls.Add(this.lblIsYeriAra);
            this.grpIsYeriAra.Controls.Add(this.btnIsYeriTuruAra);
            this.grpIsYeriAra.Controls.Add(this.btnIsYeriAra);
            this.grpIsYeriAra.Controls.Add(this.txtIsYeriTuruAra);
            this.grpIsYeriAra.Controls.Add(this.lblIsYeriTuruAra);
            this.grpIsYeriAra.Location = new System.Drawing.Point(438, 211);
            this.grpIsYeriAra.Name = "grpIsYeriAra";
            this.grpIsYeriAra.Size = new System.Drawing.Size(323, 236);
            this.grpIsYeriAra.TabIndex = 15;
            this.grpIsYeriAra.TabStop = false;
            this.grpIsYeriAra.Text = "İş Yeri Ara";
            // 
            // frmNormalSoruSor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 520);
            this.Controls.Add(this.grpIsYeriAra);
            this.Controls.Add(this.grpSoruSor);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNormalSoruSor";
            this.Text = "İş Yerine Soru Sor";
            this.Load += new System.EventHandler(this.frmNormalSoruSor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).EndInit();
            this.grpSoruSor.ResumeLayout(false);
            this.grpSoruSor.PerformLayout();
            this.grpIsYeriAra.ResumeLayout(false);
            this.grpIsYeriAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIsYeriTuruAra;
        private System.Windows.Forms.Button btnIsYeriAra;
        private System.Windows.Forms.TextBox txtIsYeriTuruAra;
        private System.Windows.Forms.TextBox txtIsYeriAra;
        private System.Windows.Forms.Label lblIsYeriTuruAra;
        private System.Windows.Forms.Label lblIsYeriAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIsYeriListesi;
        private System.Windows.Forms.GroupBox grpSoruSor;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.TextBox txtNormalKullaniciId;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblKullaniciId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIsYeriId;
        private System.Windows.Forms.TextBox txtIsYeriYetkiliId;
        private System.Windows.Forms.TextBox txtIsYeriId;
        private System.Windows.Forms.GroupBox grpIsYeriAra;
    }
}