namespace OnlineRandevuSistemi
{
    partial class frmAdminKullaniciListesiRapor
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
            this.dgvKullaniciListesi = new System.Windows.Forms.DataGridView();
            this.grpKullaniciListesi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciListesi)).BeginInit();
            this.grpKullaniciListesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKullaniciListesi
            // 
            this.dgvKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKullaniciListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvKullaniciListesi.Name = "dgvKullaniciListesi";
            this.dgvKullaniciListesi.Size = new System.Drawing.Size(798, 216);
            this.dgvKullaniciListesi.TabIndex = 1;
            // 
            // grpKullaniciListesi
            // 
            this.grpKullaniciListesi.Controls.Add(this.dgvKullaniciListesi);
            this.grpKullaniciListesi.Location = new System.Drawing.Point(12, 12);
            this.grpKullaniciListesi.Name = "grpKullaniciListesi";
            this.grpKullaniciListesi.Size = new System.Drawing.Size(804, 235);
            this.grpKullaniciListesi.TabIndex = 2;
            this.grpKullaniciListesi.TabStop = false;
            this.grpKullaniciListesi.Text = "Normal Kullanıcı Listesi";
            // 
            // frmAdminKullaniciListesiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 289);
            this.Controls.Add(this.grpKullaniciListesi);
            this.Name = "frmAdminKullaniciListesiRapor";
            this.Text = "Kullanıcı Listesi";
            this.Load += new System.EventHandler(this.frmAdminKullaniciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciListesi)).EndInit();
            this.grpKullaniciListesi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullaniciListesi;
        private System.Windows.Forms.GroupBox grpKullaniciListesi;
    }
}