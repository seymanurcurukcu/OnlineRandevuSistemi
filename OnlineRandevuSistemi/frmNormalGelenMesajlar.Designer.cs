namespace OnlineRandevuSistemi
{
    partial class frmNormalGelenMesajlar
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
            this.dgvGelenMesajListesi = new System.Windows.Forms.DataGridView();
            this.grpGelenMesajlar = new System.Windows.Forms.GroupBox();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelenMesajListesi)).BeginInit();
            this.grpGelenMesajlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGelenMesajListesi
            // 
            this.dgvGelenMesajListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGelenMesajListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGelenMesajListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvGelenMesajListesi.Name = "dgvGelenMesajListesi";
            this.dgvGelenMesajListesi.Size = new System.Drawing.Size(687, 207);
            this.dgvGelenMesajListesi.TabIndex = 0;
            // 
            // grpGelenMesajlar
            // 
            this.grpGelenMesajlar.Controls.Add(this.dgvGelenMesajListesi);
            this.grpGelenMesajlar.Location = new System.Drawing.Point(12, 12);
            this.grpGelenMesajlar.Name = "grpGelenMesajlar";
            this.grpGelenMesajlar.Size = new System.Drawing.Size(693, 226);
            this.grpGelenMesajlar.TabIndex = 1;
            this.grpGelenMesajlar.TabStop = false;
            this.grpGelenMesajlar.Text = "Gelen Mesajlarınız";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Location = new System.Drawing.Point(355, 241);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciId.TabIndex = 2;
            this.lblKullaniciId.Visible = false;
            // 
            // frmNormalGelenMesajlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 261);
            this.Controls.Add(this.lblKullaniciId);
            this.Controls.Add(this.grpGelenMesajlar);
            this.Name = "frmNormalGelenMesajlar";
            this.Text = "Gelen Mesajlar";
            this.Load += new System.EventHandler(this.frmNormalGelenMesajlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGelenMesajListesi)).EndInit();
            this.grpGelenMesajlar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGelenMesajListesi;
        private System.Windows.Forms.GroupBox grpGelenMesajlar;
        private System.Windows.Forms.Label lblKullaniciId;
    }
}