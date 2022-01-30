namespace OnlineRandevuSistemi
{
    partial class frmIsYeriSoruCevapla
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
            this.grpGelenMesaj = new System.Windows.Forms.GroupBox();
            this.dgvGelenMesajListesi = new System.Windows.Forms.DataGridView();
            this.grpCevapla = new System.Windows.Forms.GroupBox();
            this.txtSoruId = new System.Windows.Forms.TextBox();
            this.lblSoruId = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblYetkiliId = new System.Windows.Forms.Label();
            this.grpGelenMesaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelenMesajListesi)).BeginInit();
            this.grpCevapla.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(287, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // grpGelenMesaj
            // 
            this.grpGelenMesaj.Controls.Add(this.dgvGelenMesajListesi);
            this.grpGelenMesaj.Location = new System.Drawing.Point(21, 21);
            this.grpGelenMesaj.Name = "grpGelenMesaj";
            this.grpGelenMesaj.Size = new System.Drawing.Size(681, 166);
            this.grpGelenMesaj.TabIndex = 1;
            this.grpGelenMesaj.TabStop = false;
            this.grpGelenMesaj.Text = "Gelen Mesajlar";
            // 
            // dgvGelenMesajListesi
            // 
            this.dgvGelenMesajListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGelenMesajListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGelenMesajListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvGelenMesajListesi.Name = "dgvGelenMesajListesi";
            this.dgvGelenMesajListesi.Size = new System.Drawing.Size(675, 147);
            this.dgvGelenMesajListesi.TabIndex = 0;
            this.dgvGelenMesajListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGelenMesajListesi_CellEnter);
            // 
            // grpCevapla
            // 
            this.grpCevapla.Controls.Add(this.txtSoruId);
            this.grpCevapla.Controls.Add(this.lblSoruId);
            this.grpCevapla.Controls.Add(this.btnGonder);
            this.grpCevapla.Controls.Add(this.txtMesaj);
            this.grpCevapla.Controls.Add(this.txtAlici);
            this.grpCevapla.Controls.Add(this.lblMesaj);
            this.grpCevapla.Controls.Add(this.lblAlici);
            this.grpCevapla.Location = new System.Drawing.Point(24, 203);
            this.grpCevapla.Name = "grpCevapla";
            this.grpCevapla.Size = new System.Drawing.Size(675, 270);
            this.grpCevapla.TabIndex = 2;
            this.grpCevapla.TabStop = false;
            this.grpCevapla.Text = "Gelen Mesajları Cevapla";
            // 
            // txtSoruId
            // 
            this.txtSoruId.Enabled = false;
            this.txtSoruId.Location = new System.Drawing.Point(122, 26);
            this.txtSoruId.Name = "txtSoruId";
            this.txtSoruId.Size = new System.Drawing.Size(224, 20);
            this.txtSoruId.TabIndex = 1;
            // 
            // lblSoruId
            // 
            this.lblSoruId.AutoSize = true;
            this.lblSoruId.Location = new System.Drawing.Point(72, 29);
            this.lblSoruId.Name = "lblSoruId";
            this.lblSoruId.Size = new System.Drawing.Size(44, 13);
            this.lblSoruId.TabIndex = 7;
            this.lblSoruId.Text = "Soru Id:";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(122, 210);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(224, 42);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(122, 91);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(224, 102);
            this.txtMesaj.TabIndex = 3;
            // 
            // txtAlici
            // 
            this.txtAlici.Enabled = false;
            this.txtAlici.Location = new System.Drawing.Point(122, 52);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(224, 20);
            this.txtAlici.TabIndex = 2;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(78, 91);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(38, 13);
            this.lblMesaj.TabIndex = 2;
            this.lblMesaj.Text = "Mesaj:";
            // 
            // lblAlici
            // 
            this.lblAlici.AutoSize = true;
            this.lblAlici.Location = new System.Drawing.Point(75, 59);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(41, 13);
            this.lblAlici.TabIndex = 0;
            this.lblAlici.Text = "Alıcı Id:";
            // 
            // lblYetkiliId
            // 
            this.lblYetkiliId.AutoSize = true;
            this.lblYetkiliId.Location = new System.Drawing.Point(426, 505);
            this.lblYetkiliId.Name = "lblYetkiliId";
            this.lblYetkiliId.Size = new System.Drawing.Size(0, 13);
            this.lblYetkiliId.TabIndex = 3;
            this.lblYetkiliId.Visible = false;
            // 
            // frmIsYeriSoruCevapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 527);
            this.Controls.Add(this.lblYetkiliId);
            this.Controls.Add(this.grpCevapla);
            this.Controls.Add(this.grpGelenMesaj);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIsYeriSoruCevapla";
            this.Text = "Gelen Soruları Cevapla";
            this.Load += new System.EventHandler(this.frmIsYeriSoruCevapla_Load);
            this.grpGelenMesaj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelenMesajListesi)).EndInit();
            this.grpCevapla.ResumeLayout(false);
            this.grpCevapla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpGelenMesaj;
        private System.Windows.Forms.DataGridView dgvGelenMesajListesi;
        private System.Windows.Forms.GroupBox grpCevapla;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblYetkiliId;
        private System.Windows.Forms.TextBox txtSoruId;
        private System.Windows.Forms.Label lblSoruId;
    }
}