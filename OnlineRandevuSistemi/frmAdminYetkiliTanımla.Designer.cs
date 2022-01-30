namespace OnlineRandevuSistemi
{
    partial class frmAdminYetkiliTanımla
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
            this.grpIsYeriListesi = new System.Windows.Forms.GroupBox();
            this.dgvIsYeriListesi = new System.Windows.Forms.DataGridView();
            this.grpYetkiliListesi = new System.Windows.Forms.GroupBox();
            this.dgvYetkiliListesi = new System.Windows.Forms.DataGridView();
            this.txtIsYeriAdi = new System.Windows.Forms.TextBox();
            this.txtYetkiliAdi = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.grpYetkiliTanımlama = new System.Windows.Forms.GroupBox();
            this.dgvYetkiliTanımlama = new System.Windows.Forms.DataGridView();
            this.grpIsYeriListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).BeginInit();
            this.grpYetkiliListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiliListesi)).BeginInit();
            this.grpYetkiliTanımlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiliTanımlama)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIsYeriListesi
            // 
            this.grpIsYeriListesi.Controls.Add(this.dgvIsYeriListesi);
            this.grpIsYeriListesi.Location = new System.Drawing.Point(30, 38);
            this.grpIsYeriListesi.Name = "grpIsYeriListesi";
            this.grpIsYeriListesi.Size = new System.Drawing.Size(334, 174);
            this.grpIsYeriListesi.TabIndex = 0;
            this.grpIsYeriListesi.TabStop = false;
            this.grpIsYeriListesi.Text = "İş Yeri Listesi";
            // 
            // dgvIsYeriListesi
            // 
            this.dgvIsYeriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsYeriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIsYeriListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvIsYeriListesi.Name = "dgvIsYeriListesi";
            this.dgvIsYeriListesi.Size = new System.Drawing.Size(328, 155);
            this.dgvIsYeriListesi.TabIndex = 0;
            this.dgvIsYeriListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsYeriListesi_CellEnter);
            // 
            // grpYetkiliListesi
            // 
            this.grpYetkiliListesi.Controls.Add(this.dgvYetkiliListesi);
            this.grpYetkiliListesi.Location = new System.Drawing.Point(429, 38);
            this.grpYetkiliListesi.Name = "grpYetkiliListesi";
            this.grpYetkiliListesi.Size = new System.Drawing.Size(332, 174);
            this.grpYetkiliListesi.TabIndex = 1;
            this.grpYetkiliListesi.TabStop = false;
            this.grpYetkiliListesi.Text = "İş Yeri Yetkili Listesi";
            // 
            // dgvYetkiliListesi
            // 
            this.dgvYetkiliListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYetkiliListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYetkiliListesi.Location = new System.Drawing.Point(3, 16);
            this.dgvYetkiliListesi.Name = "dgvYetkiliListesi";
            this.dgvYetkiliListesi.Size = new System.Drawing.Size(326, 155);
            this.dgvYetkiliListesi.TabIndex = 0;
            this.dgvYetkiliListesi.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYetkiliListesi_CellEnter);
            // 
            // txtIsYeriAdi
            // 
            this.txtIsYeriAdi.Location = new System.Drawing.Point(33, 244);
            this.txtIsYeriAdi.Name = "txtIsYeriAdi";
            this.txtIsYeriAdi.Size = new System.Drawing.Size(328, 20);
            this.txtIsYeriAdi.TabIndex = 1;
            // 
            // txtYetkiliAdi
            // 
            this.txtYetkiliAdi.Location = new System.Drawing.Point(432, 244);
            this.txtYetkiliAdi.Name = "txtYetkiliAdi";
            this.txtYetkiliAdi.Size = new System.Drawing.Size(326, 20);
            this.txtYetkiliAdi.TabIndex = 2;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(324, 299);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(146, 42);
            this.btnOnayla.TabIndex = 4;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // grpYetkiliTanımlama
            // 
            this.grpYetkiliTanımlama.Controls.Add(this.dgvYetkiliTanımlama);
            this.grpYetkiliTanımlama.Location = new System.Drawing.Point(33, 356);
            this.grpYetkiliTanımlama.Name = "grpYetkiliTanımlama";
            this.grpYetkiliTanımlama.Size = new System.Drawing.Size(725, 171);
            this.grpYetkiliTanımlama.TabIndex = 5;
            this.grpYetkiliTanımlama.TabStop = false;
            this.grpYetkiliTanımlama.Text = "İş Yeri Yetkilisi Tanımlama";
            // 
            // dgvYetkiliTanımlama
            // 
            this.dgvYetkiliTanımlama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYetkiliTanımlama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvYetkiliTanımlama.Location = new System.Drawing.Point(3, 16);
            this.dgvYetkiliTanımlama.Name = "dgvYetkiliTanımlama";
            this.dgvYetkiliTanımlama.Size = new System.Drawing.Size(719, 152);
            this.dgvYetkiliTanımlama.TabIndex = 0;
            // 
            // frmAdminYetkiliTanımla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.grpYetkiliTanımlama);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtYetkiliAdi);
            this.Controls.Add(this.txtIsYeriAdi);
            this.Controls.Add(this.grpYetkiliListesi);
            this.Controls.Add(this.grpIsYeriListesi);
            this.Name = "frmAdminYetkiliTanımla";
            this.Text = "İş Yeri Yetkilisi Tanımlama";
            this.Load += new System.EventHandler(this.frmAdminYetkiliTanımla_Load);
            this.grpIsYeriListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsYeriListesi)).EndInit();
            this.grpYetkiliListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiliListesi)).EndInit();
            this.grpYetkiliTanımlama.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYetkiliTanımlama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIsYeriListesi;
        private System.Windows.Forms.GroupBox grpYetkiliListesi;
        private System.Windows.Forms.DataGridView dgvYetkiliListesi;
        private System.Windows.Forms.DataGridView dgvIsYeriListesi;
        private System.Windows.Forms.TextBox txtIsYeriAdi;
        private System.Windows.Forms.TextBox txtYetkiliAdi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.GroupBox grpYetkiliTanımlama;
        private System.Windows.Forms.DataGridView dgvYetkiliTanımlama;
    }
}