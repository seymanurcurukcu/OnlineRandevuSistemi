namespace OnlineRandevuSistemi
{
    partial class frmNormalOnaylananRandevu
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
            this.dgvOnaylananRandevu = new System.Windows.Forms.DataGridView();
            this.grpOnaylananRandevular = new System.Windows.Forms.GroupBox();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnaylananRandevu)).BeginInit();
            this.grpOnaylananRandevular.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOnaylananRandevu
            // 
            this.dgvOnaylananRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnaylananRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOnaylananRandevu.Location = new System.Drawing.Point(3, 16);
            this.dgvOnaylananRandevu.Name = "dgvOnaylananRandevu";
            this.dgvOnaylananRandevu.Size = new System.Drawing.Size(640, 218);
            this.dgvOnaylananRandevu.TabIndex = 0;
            // 
            // grpOnaylananRandevular
            // 
            this.grpOnaylananRandevular.Controls.Add(this.dgvOnaylananRandevu);
            this.grpOnaylananRandevular.Location = new System.Drawing.Point(12, 12);
            this.grpOnaylananRandevular.Name = "grpOnaylananRandevular";
            this.grpOnaylananRandevular.Size = new System.Drawing.Size(646, 237);
            this.grpOnaylananRandevular.TabIndex = 1;
            this.grpOnaylananRandevular.TabStop = false;
            this.grpOnaylananRandevular.Text = "Onaylanan Randevularınız";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Location = new System.Drawing.Point(387, 252);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciId.TabIndex = 2;
            this.lblKullaniciId.Visible = false;
            // 
            // frmNormalOnaylananRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 271);
            this.Controls.Add(this.lblKullaniciId);
            this.Controls.Add(this.grpOnaylananRandevular);
            this.Name = "frmNormalOnaylananRandevu";
            this.Text = "Onaylanan Randevular";
            this.Load += new System.EventHandler(this.frmNormalOnaylananRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnaylananRandevu)).EndInit();
            this.grpOnaylananRandevular.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOnaylananRandevu;
        private System.Windows.Forms.GroupBox grpOnaylananRandevular;
        private System.Windows.Forms.Label lblKullaniciId;
    }
}