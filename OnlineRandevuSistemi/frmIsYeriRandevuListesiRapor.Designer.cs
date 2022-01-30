namespace OnlineRandevuSistemi
{
    partial class frmIsYeriRandevuListesiRapor
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
            this.dgvRandevuListesi = new System.Windows.Forms.DataGridView();
            this.lblYetkiliId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevuListesi
            // 
            this.dgvRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevuListesi.Location = new System.Drawing.Point(0, 0);
            this.dgvRandevuListesi.Name = "dgvRandevuListesi";
            this.dgvRandevuListesi.Size = new System.Drawing.Size(730, 245);
            this.dgvRandevuListesi.TabIndex = 0;
            // 
            // lblYetkiliId
            // 
            this.lblYetkiliId.AutoSize = true;
            this.lblYetkiliId.Location = new System.Drawing.Point(658, 219);
            this.lblYetkiliId.Name = "lblYetkiliId";
            this.lblYetkiliId.Size = new System.Drawing.Size(0, 13);
            this.lblYetkiliId.TabIndex = 1;
            this.lblYetkiliId.Visible = false;
            // 
            // frmIsYeriRandevuListesiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 245);
            this.Controls.Add(this.lblYetkiliId);
            this.Controls.Add(this.dgvRandevuListesi);
            this.Name = "frmIsYeriRandevuListesiRapor";
            this.Text = "Onaylanan Randevu Listesi";
            this.Load += new System.EventHandler(this.frmIsYeriRandevuListesiRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevuListesi;
        private System.Windows.Forms.Label lblYetkiliId;
    }
}