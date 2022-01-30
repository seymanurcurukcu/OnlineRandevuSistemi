namespace OnlineRandevuSistemi
{
    partial class frmNormalKayıtOl
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
            this.btnKayıtOl = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.mskTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblSoyIsim = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Location = new System.Drawing.Point(146, 307);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(140, 42);
            this.btnKayıtOl.TabIndex = 29;
            this.btnKayıtOl.Text = "Kayıt Ol";
            this.btnKayıtOl.UseVisualStyleBackColor = true;
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(146, 115);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(140, 69);
            this.txtAdres.TabIndex = 4;
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(146, 84);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(140, 20);
            this.txtEposta.TabIndex = 3;
            // 
            // mskTelNo
            // 
            this.mskTelNo.Location = new System.Drawing.Point(146, 190);
            this.mskTelNo.Mask = "(999) 000-0000";
            this.mskTelNo.Name = "mskTelNo";
            this.mskTelNo.Size = new System.Drawing.Size(140, 20);
            this.mskTelNo.TabIndex = 5;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(146, 256);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(140, 20);
            this.txtSifre.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(146, 223);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(140, 20);
            this.txtKullaniciAdi.TabIndex = 6;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(146, 58);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(140, 20);
            this.txtSoyisim.TabIndex = 2;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(146, 28);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(140, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Şifre:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(73, 230);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lblKullaniciAdi.TabIndex = 25;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(77, 197);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(63, 13);
            this.lblTelNo.TabIndex = 23;
            this.lblTelNo.Text = "Telefon No:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(103, 122);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 20;
            this.lblAdres.Text = "Adres:";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(93, 91);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(47, 13);
            this.lblEposta.TabIndex = 19;
            this.lblEposta.Text = "E-Posta:";
            // 
            // lblSoyIsim
            // 
            this.lblSoyIsim.AutoSize = true;
            this.lblSoyIsim.Location = new System.Drawing.Point(95, 65);
            this.lblSoyIsim.Name = "lblSoyIsim";
            this.lblSoyIsim.Size = new System.Drawing.Size(45, 13);
            this.lblSoyIsim.TabIndex = 12;
            this.lblSoyIsim.Text = "Soyisim:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(112, 35);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(28, 13);
            this.lblIsim.TabIndex = 11;
            this.lblIsim.Text = "İsim:";
            // 
            // frmNormalKayıtOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 408);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.mskTelNo);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSoyisim);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblSoyIsim);
            this.Controls.Add(this.lblIsim);
            this.Name = "frmNormalKayıtOl";
            this.Text = "frmNormalKayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKayıtOl;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.MaskedTextBox mskTelNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblSoyIsim;
        private System.Windows.Forms.Label lblIsim;
    }
}