namespace OnlineRandevuSistemi
{
    partial class frmAdminIsYeriListesiRapor
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
            this.dgvIsYeriListe = new System.Windows.Forms.DataGridView();
            this.grpIsYeriListesi = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListe)).BeginInit();
            this.grpIsYeriListesi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIsYeriListe
            // 
            this.dgvIsYeriListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsYeriListe.Location = new System.Drawing.Point(3, 16);
            this.dgvIsYeriListe.Name = "dgvIsYeriListe";
            this.dgvIsYeriListe.Size = new System.Drawing.Size(700, 257);
            this.dgvIsYeriListe.TabIndex = 0;
            // 
            // grpIsYeriListesi
            // 
            this.grpIsYeriListesi.Controls.Add(this.dgvIsYeriListe);
            this.grpIsYeriListesi.Location = new System.Drawing.Point(12, 12);
            this.grpIsYeriListesi.Name = "grpIsYeriListesi";
            this.grpIsYeriListesi.Size = new System.Drawing.Size(706, 276);
            this.grpIsYeriListesi.TabIndex = 1;
            this.grpIsYeriListesi.TabStop = false;
            this.grpIsYeriListesi.Text = "İş Yeri Listesi";
            // 
            // frmAdminIsYeriListesiRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 300);
            this.Controls.Add(this.grpIsYeriListesi);
            this.Name = "frmAdminIsYeriListesiRapor";
            this.Text = "İş Yeri Listesi";
            this.Load += new System.EventHandler(this.frmAdminIsYeriListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListe)).EndInit();
            this.grpIsYeriListesi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsYeriListe;
        private System.Windows.Forms.GroupBox grpIsYeriListesi;
    }
}