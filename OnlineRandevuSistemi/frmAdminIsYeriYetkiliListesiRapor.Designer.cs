namespace OnlineRandevuSistemi
{
    partial class frmAdminIsYeriYetkiliListesiRapor
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
            this.dgvIsYeriYetkiliListesi = new System.Windows.Forms.DataGridView();
            this.grpIsYeriYetkiliListesi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkiliListesi)).BeginInit();
            this.grpIsYeriYetkiliListesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIsYeriYetkiliListesi
            // 
            this.dgvIsYeriYetkiliListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriYetkiliListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsYeriYetkiliListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvIsYeriYetkiliListesi.Name = "dgvIsYeriYetkiliListesi";
            this.dgvIsYeriYetkiliListesi.Size = new System.Drawing.Size(776, 271);
            this.dgvIsYeriYetkiliListesi.TabIndex = 0;
            // 
            // grpIsYeriYetkiliListesi
            // 
            this.grpIsYeriYetkiliListesi.Controls.Add(this.dgvIsYeriYetkiliListesi);
            this.grpIsYeriYetkiliListesi.Location = new System.Drawing.Point(12, 12);
            this.grpIsYeriYetkiliListesi.Name = "grpIsYeriYetkiliListesi";
            this.grpIsYeriYetkiliListesi.Size = new System.Drawing.Size(782, 290);
            this.grpIsYeriYetkiliListesi.TabIndex = 3;
            this.grpIsYeriYetkiliListesi.TabStop = false;
            this.grpIsYeriYetkiliListesi.Text = "İş Yeri Yetkili Listesi";
            // 
            // frmAdminIsYeriYetkiliListesiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 326);
            this.Controls.Add(this.grpIsYeriYetkiliListesi);
            this.Name = "frmAdminIsYeriYetkiliListesiRapor";
            this.Text = "İş Yeri Yetkili Listesi";
            this.Load += new System.EventHandler(this.frmAdminIsYeriYetkiliListesiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriYetkiliListesi)).EndInit();
            this.grpIsYeriYetkiliListesi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsYeriYetkiliListesi;
        private System.Windows.Forms.GroupBox grpIsYeriYetkiliListesi;
    }
}