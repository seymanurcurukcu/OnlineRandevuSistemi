namespace OnlineRandevuSistemi
{
    partial class frmIsYeriCevaplanmamisMesajlarRapor
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
            this.dgvCevaplanmamısMesaj = new System.Windows.Forms.DataGridView();
            this.lblYetkiliId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCevaplanmamısMesaj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCevaplanmamısMesaj
            // 
            this.dgvCevaplanmamısMesaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCevaplanmamısMesaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCevaplanmamısMesaj.Location = new System.Drawing.Point(0, 0);
            this.dgvCevaplanmamısMesaj.Name = "dgvCevaplanmamısMesaj";
            this.dgvCevaplanmamısMesaj.Size = new System.Drawing.Size(682, 221);
            this.dgvCevaplanmamısMesaj.TabIndex = 0;
            // 
            // lblYetkiliId
            // 
            this.lblYetkiliId.AutoSize = true;
            this.lblYetkiliId.Location = new System.Drawing.Point(608, 204);
            this.lblYetkiliId.Name = "lblYetkiliId";
            this.lblYetkiliId.Size = new System.Drawing.Size(0, 13);
            this.lblYetkiliId.TabIndex = 1;
            this.lblYetkiliId.Visible = false;
            // 
            // frmIsYeriCevaplanmamisMesajlarRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 221);
            this.Controls.Add(this.lblYetkiliId);
            this.Controls.Add(this.dgvCevaplanmamısMesaj);
            this.Name = "frmIsYeriCevaplanmamisMesajlarRapor";
            this.Text = "Cevaplanmamış Mesaj Listesi";
            this.Load += new System.EventHandler(this.frmIsYeriCevaplanmamisMesajlarRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCevaplanmamısMesaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCevaplanmamısMesaj;
        private System.Windows.Forms.Label lblYetkiliId;
    }
}