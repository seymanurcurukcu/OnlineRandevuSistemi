namespace OnlineRandevuSistemi
{
    partial class frmIsYeriTumMesajlarRapor
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
            this.dgvTumMesajlar = new System.Windows.Forms.DataGridView();
            this.lblIsYeriYetkiliId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumMesajlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTumMesajlar
            // 
            this.dgvTumMesajlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumMesajlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTumMesajlar.Location = new System.Drawing.Point(0, 0);
            this.dgvTumMesajlar.Name = "dgvTumMesajlar";
            this.dgvTumMesajlar.Size = new System.Drawing.Size(758, 235);
            this.dgvTumMesajlar.TabIndex = 0;
            // 
            // lblIsYeriYetkiliId
            // 
            this.lblIsYeriYetkiliId.AutoSize = true;
            this.lblIsYeriYetkiliId.Location = new System.Drawing.Point(679, 215);
            this.lblIsYeriYetkiliId.Name = "lblIsYeriYetkiliId";
            this.lblIsYeriYetkiliId.Size = new System.Drawing.Size(0, 13);
            this.lblIsYeriYetkiliId.TabIndex = 1;
            this.lblIsYeriYetkiliId.Visible = false;
            // 
            // frmIsYeriTumMesajlarRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 235);
            this.Controls.Add(this.lblIsYeriYetkiliId);
            this.Controls.Add(this.dgvTumMesajlar);
            this.Name = "frmIsYeriTumMesajlarRapor";
            this.Text = "Gelen Tüm Mesaj Listesi";
            this.Load += new System.EventHandler(this.frmIsYeriTumMesajlarRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumMesajlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTumMesajlar;
        private System.Windows.Forms.Label lblIsYeriYetkiliId;
    }
}