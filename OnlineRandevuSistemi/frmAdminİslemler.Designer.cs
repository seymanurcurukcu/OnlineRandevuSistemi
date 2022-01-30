namespace OnlineRandevuSistemi
{
    partial class frmAdminİslemler
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
            this.dgvIsYeriListesi = new System.Windows.Forms.DataGridView();
            this.grpIsYeriListesi = new System.Windows.Forms.GroupBox();
            this.grpIsYeriBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbIsTuru = new System.Windows.Forms.ComboBox();
            this.mskIsYeriTel = new System.Windows.Forms.MaskedTextBox();
            this.txtIsYeriAdres = new System.Windows.Forms.TextBox();
            this.txtIsYeriAd = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblIsYeriTel = new System.Windows.Forms.Label();
            this.lblIsYeriAdres = new System.Windows.Forms.Label();
            this.lblIsYeriTuru = new System.Windows.Forms.Label();
            this.lblIsYeriIsmi = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnIsYeriGuncelle = new System.Windows.Forms.Button();
            this.btnIsYeriSil = new System.Windows.Forms.Button();
            this.btnIsYeriEkle = new System.Windows.Forms.Button();
            this.btnIsYeriArama = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).BeginInit();
            this.grpIsYeriListesi.SuspendLayout();
            this.grpIsYeriBilgileri.SuspendLayout();
            this.grpIslemler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIsYeriListesi
            // 
            this.dgvIsYeriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsYeriListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvIsYeriListesi.Name = "dgvIsYeriListesi";
            this.dgvIsYeriListesi.Size = new System.Drawing.Size(763, 153);
            this.dgvIsYeriListesi.TabIndex = 16;
            this.dgvIsYeriListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeriListesi_CellEnter);
            // 
            // grpIsYeriListesi
            // 
            this.grpIsYeriListesi.Controls.Add(this.dgvIsYeriListesi);
            this.grpIsYeriListesi.Location = new System.Drawing.Point(30, 357);
            this.grpIsYeriListesi.Name = "grpIsYeriListesi";
            this.grpIsYeriListesi.Size = new System.Drawing.Size(769, 172);
            this.grpIsYeriListesi.TabIndex = 20;
            this.grpIsYeriListesi.TabStop = false;
            this.grpIsYeriListesi.Text = "İş Yeri Listesi";
            // 
            // grpIsYeriBilgileri
            // 
            this.grpIsYeriBilgileri.Controls.Add(this.cmbIsTuru);
            this.grpIsYeriBilgileri.Controls.Add(this.mskIsYeriTel);
            this.grpIsYeriBilgileri.Controls.Add(this.txtIsYeriAdres);
            this.grpIsYeriBilgileri.Controls.Add(this.txtIsYeriAd);
            this.grpIsYeriBilgileri.Controls.Add(this.txtid);
            this.grpIsYeriBilgileri.Controls.Add(this.lblIsYeriTel);
            this.grpIsYeriBilgileri.Controls.Add(this.lblIsYeriAdres);
            this.grpIsYeriBilgileri.Controls.Add(this.lblIsYeriTuru);
            this.grpIsYeriBilgileri.Controls.Add(this.lblIsYeriIsmi);
            this.grpIsYeriBilgileri.Controls.Add(this.lblId);
            this.grpIsYeriBilgileri.Location = new System.Drawing.Point(30, 24);
            this.grpIsYeriBilgileri.Name = "grpIsYeriBilgileri";
            this.grpIsYeriBilgileri.Size = new System.Drawing.Size(289, 316);
            this.grpIsYeriBilgileri.TabIndex = 24;
            this.grpIsYeriBilgileri.TabStop = false;
            this.grpIsYeriBilgileri.Text = "İş Yeri Bilgileri";
            // 
            // cmbIsTuru
            // 
            this.cmbIsTuru.FormattingEnabled = true;
            this.cmbIsTuru.Location = new System.Drawing.Point(118, 84);
            this.cmbIsTuru.Name = "cmbIsTuru";
            this.cmbIsTuru.Size = new System.Drawing.Size(152, 21);
            this.cmbIsTuru.TabIndex = 3;
            // 
            // mskIsYeriTel
            // 
            this.mskIsYeriTel.Location = new System.Drawing.Point(118, 117);
            this.mskIsYeriTel.Mask = "(999) 000-0000";
            this.mskIsYeriTel.Name = "mskIsYeriTel";
            this.mskIsYeriTel.Size = new System.Drawing.Size(152, 20);
            this.mskIsYeriTel.TabIndex = 4;
            // 
            // txtIsYeriAdres
            // 
            this.txtIsYeriAdres.Location = new System.Drawing.Point(118, 156);
            this.txtIsYeriAdres.Multiline = true;
            this.txtIsYeriAdres.Name = "txtIsYeriAdres";
            this.txtIsYeriAdres.Size = new System.Drawing.Size(152, 124);
            this.txtIsYeriAdres.TabIndex = 5;
            // 
            // txtIsYeriAd
            // 
            this.txtIsYeriAd.Location = new System.Drawing.Point(118, 56);
            this.txtIsYeriAd.Name = "txtIsYeriAd";
            this.txtIsYeriAd.Size = new System.Drawing.Size(152, 20);
            this.txtIsYeriAd.TabIndex = 2;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(118, 23);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(152, 20);
            this.txtid.TabIndex = 1;
            // 
            // lblIsYeriTel
            // 
            this.lblIsYeriTel.AutoSize = true;
            this.lblIsYeriTel.Location = new System.Drawing.Point(7, 124);
            this.lblIsYeriTel.Name = "lblIsYeriTel";
            this.lblIsYeriTel.Size = new System.Drawing.Size(95, 13);
            this.lblIsYeriTel.TabIndex = 26;
            this.lblIsYeriTel.Text = "İş Yeri Telefon No:";
            // 
            // lblIsYeriAdres
            // 
            this.lblIsYeriAdres.AutoSize = true;
            this.lblIsYeriAdres.Location = new System.Drawing.Point(31, 163);
            this.lblIsYeriAdres.Name = "lblIsYeriAdres";
            this.lblIsYeriAdres.Size = new System.Drawing.Size(71, 13);
            this.lblIsYeriAdres.TabIndex = 25;
            this.lblIsYeriAdres.Text = "İş Yeri Adresi:";
            // 
            // lblIsYeriTuru
            // 
            this.lblIsYeriTuru.AutoSize = true;
            this.lblIsYeriTuru.Location = new System.Drawing.Point(38, 94);
            this.lblIsYeriTuru.Name = "lblIsYeriTuru";
            this.lblIsYeriTuru.Size = new System.Drawing.Size(64, 13);
            this.lblIsYeriTuru.TabIndex = 24;
            this.lblIsYeriTuru.Text = "İş Yeri Türü:";
            // 
            // lblIsYeriIsmi
            // 
            this.lblIsYeriIsmi.AutoSize = true;
            this.lblIsYeriIsmi.Location = new System.Drawing.Point(42, 63);
            this.lblIsYeriIsmi.Name = "lblIsYeriIsmi";
            this.lblIsYeriIsmi.Size = new System.Drawing.Size(60, 13);
            this.lblIsYeriIsmi.TabIndex = 23;
            this.lblIsYeriIsmi.Text = "İş Yeri İsmi:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Id:";
            // 
            // grpIslemler
            // 
            this.grpIslemler.Controls.Add(this.btnTemizle);
            this.grpIslemler.Controls.Add(this.btnListele);
            this.grpIslemler.Controls.Add(this.btnIsYeriGuncelle);
            this.grpIslemler.Controls.Add(this.btnIsYeriSil);
            this.grpIslemler.Controls.Add(this.btnIsYeriEkle);
            this.grpIslemler.Location = new System.Drawing.Point(336, 24);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(463, 212);
            this.grpIslemler.TabIndex = 17;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(28, 141);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(392, 49);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(245, 82);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(175, 51);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "İş Yeri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click_1);
            // 
            // btnIsYeriGuncelle
            // 
            this.btnIsYeriGuncelle.Location = new System.Drawing.Point(245, 27);
            this.btnIsYeriGuncelle.Name = "btnIsYeriGuncelle";
            this.btnIsYeriGuncelle.Size = new System.Drawing.Size(175, 49);
            this.btnIsYeriGuncelle.TabIndex = 7;
            this.btnIsYeriGuncelle.Text = "İş Yeri Güncelle";
            this.btnIsYeriGuncelle.UseVisualStyleBackColor = true;
            this.btnIsYeriGuncelle.Click += new System.EventHandler(this.btnIsYeriGuncelle_Click_1);
            // 
            // btnIsYeriSil
            // 
            this.btnIsYeriSil.Location = new System.Drawing.Point(28, 82);
            this.btnIsYeriSil.Name = "btnIsYeriSil";
            this.btnIsYeriSil.Size = new System.Drawing.Size(175, 51);
            this.btnIsYeriSil.TabIndex = 8;
            this.btnIsYeriSil.Text = "İş Yeri Sil";
            this.btnIsYeriSil.UseVisualStyleBackColor = true;
            this.btnIsYeriSil.Click += new System.EventHandler(this.btnIsYeriSil_Click);
            // 
            // btnIsYeriEkle
            // 
            this.btnIsYeriEkle.Location = new System.Drawing.Point(28, 27);
            this.btnIsYeriEkle.Name = "btnIsYeriEkle";
            this.btnIsYeriEkle.Size = new System.Drawing.Size(175, 49);
            this.btnIsYeriEkle.TabIndex = 6;
            this.btnIsYeriEkle.Text = "İş Yeri Ekle";
            this.btnIsYeriEkle.UseVisualStyleBackColor = true;
            this.btnIsYeriEkle.Click += new System.EventHandler(this.btnIsYeriEkle_Click_1);
            // 
            // btnIsYeriArama
            // 
            this.btnIsYeriArama.Location = new System.Drawing.Point(245, 30);
            this.btnIsYeriArama.Name = "btnIsYeriArama";
            this.btnIsYeriArama.Size = new System.Drawing.Size(146, 34);
            this.btnIsYeriArama.TabIndex = 12;
            this.btnIsYeriArama.Text = "İş Yeri Ara";
            this.btnIsYeriArama.UseVisualStyleBackColor = true;
            this.btnIsYeriArama.Click += new System.EventHandler(this.btnIsYeriArama_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(77, 38);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(146, 20);
            this.txtArama.TabIndex = 11;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(10, 41);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(61, 13);
            this.lblArama.TabIndex = 27;
            this.lblArama.Text = "İş Yeri  Ara:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.lblArama);
            this.groupBox1.Controls.Add(this.btnIsYeriArama);
            this.groupBox1.Location = new System.Drawing.Point(336, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 89);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İş Yeri Arama İşlemi";
            // 
            // frmAdminİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 590);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpIslemler);
            this.Controls.Add(this.grpIsYeriBilgileri);
            this.Controls.Add(this.grpIsYeriListesi);
            this.Name = "frmAdminİslemler";
            this.Text = "İş Yeri İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).EndInit();
            this.grpIsYeriListesi.ResumeLayout(false);
            this.grpIsYeriBilgileri.ResumeLayout(false);
            this.grpIsYeriBilgileri.PerformLayout();
            this.grpIslemler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvIsYeriListesi;
        private System.Windows.Forms.GroupBox grpIsYeriListesi;
        private System.Windows.Forms.GroupBox grpIsYeriBilgileri;
        private System.Windows.Forms.ComboBox cmbIsTuru;
        private System.Windows.Forms.MaskedTextBox mskIsYeriTel;
        private System.Windows.Forms.TextBox txtIsYeriAdres;
        private System.Windows.Forms.TextBox txtIsYeriAd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblIsYeriTel;
        private System.Windows.Forms.Label lblIsYeriAdres;
        private System.Windows.Forms.Label lblIsYeriTuru;
        private System.Windows.Forms.Label lblIsYeriIsmi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnIsYeriArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Button btnIsYeriGuncelle;
        private System.Windows.Forms.Button btnIsYeriSil;
        private System.Windows.Forms.Button btnIsYeriEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}