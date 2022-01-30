namespace OnlineRandevuSistemi
{
    partial class frmIsYeriRandevuOnayRed
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
            this.grpRandevuListesi = new System.Windows.Forms.GroupBox();
            this.dgvRandevuListesi = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.lblYetkiliid = new System.Windows.Forms.Label();
            this.grpRandevuListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRandevuListesi
            // 
            this.grpRandevuListesi.Controls.Add(this.dgvRandevuListesi);
            this.grpRandevuListesi.Location = new System.Drawing.Point(12, 31);
            this.grpRandevuListesi.Name = "grpRandevuListesi";
            this.grpRandevuListesi.Size = new System.Drawing.Size(798, 164);
            this.grpRandevuListesi.TabIndex = 0;
            this.grpRandevuListesi.TabStop = false;
            this.grpRandevuListesi.Text = "Randevu Listesi";
            // 
            // dgvRandevuListesi
            // 
            this.dgvRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRandevuListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvRandevuListesi.Name = "dgvRandevuListesi";
            this.dgvRandevuListesi.Size = new System.Drawing.Size(792, 145);
            this.dgvRandevuListesi.TabIndex = 0;
            this.dgvRandevuListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRandevuListesi_CellEnter);
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOnayla.Location = new System.Drawing.Point(111, 256);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(185, 46);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(539, 256);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(185, 46);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "Reddet";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // lblYetkiliid
            // 
            this.lblYetkiliid.AutoSize = true;
            this.lblYetkiliid.Location = new System.Drawing.Point(612, 226);
            this.lblYetkiliid.Name = "lblYetkiliid";
            this.lblYetkiliid.Size = new System.Drawing.Size(0, 13);
            this.lblYetkiliid.TabIndex = 3;
            this.lblYetkiliid.Visible = false;
            // 
            // frmIsYeriRandevuOnayRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 383);
            this.Controls.Add(this.lblYetkiliid);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.grpRandevuListesi);
            this.Name = "frmIsYeriRandevuOnayRed";
            this.Text = "İş Yeri Yetkilisi Onay/Red İşlemleri";
            this.Load += new System.EventHandler(this.frmIsYeriRandevuOnayRed_Load);
            this.grpRandevuListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevuListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRandevuListesi;
        private System.Windows.Forms.DataGridView dgvRandevuListesi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label lblYetkiliid;
    }
}