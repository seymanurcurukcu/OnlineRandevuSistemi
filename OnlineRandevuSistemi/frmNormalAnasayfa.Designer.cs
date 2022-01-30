namespace OnlineRandevuSistemi
{
    partial class frmNormalAnasayfa
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
            this.mstriptNormal = new System.Windows.Forms.MenuStrip();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruSorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onaylananRandevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstriptNormal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstriptNormal
            // 
            this.mstriptNormal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.soruSorToolStripMenuItem,
            this.gelenMesajlarToolStripMenuItem,
            this.onaylananRandevularToolStripMenuItem});
            this.mstriptNormal.Location = new System.Drawing.Point(0, 0);
            this.mstriptNormal.Name = "mstriptNormal";
            this.mstriptNormal.Size = new System.Drawing.Size(783, 24);
            this.mstriptNormal.TabIndex = 0;
            this.mstriptNormal.Text = "mstriptNormal";
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.randevuAlToolStripMenuItem.Text = "Randevu Al";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // soruSorToolStripMenuItem
            // 
            this.soruSorToolStripMenuItem.Name = "soruSorToolStripMenuItem";
            this.soruSorToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.soruSorToolStripMenuItem.Text = "Soru Sor";
            this.soruSorToolStripMenuItem.Click += new System.EventHandler(this.soruSorToolStripMenuItem_Click);
            // 
            // gelenMesajlarToolStripMenuItem
            // 
            this.gelenMesajlarToolStripMenuItem.Name = "gelenMesajlarToolStripMenuItem";
            this.gelenMesajlarToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.gelenMesajlarToolStripMenuItem.Text = "Gelen Mesajlar";
            this.gelenMesajlarToolStripMenuItem.Click += new System.EventHandler(this.gelenMesajlarToolStripMenuItem_Click);
            // 
            // onaylananRandevularToolStripMenuItem
            // 
            this.onaylananRandevularToolStripMenuItem.Name = "onaylananRandevularToolStripMenuItem";
            this.onaylananRandevularToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.onaylananRandevularToolStripMenuItem.Text = "Onaylanan Randevular";
            this.onaylananRandevularToolStripMenuItem.Click += new System.EventHandler(this.onaylananRandevularToolStripMenuItem_Click);
            // 
            // frmNormalAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(783, 350);
            this.Controls.Add(this.mstriptNormal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstriptNormal;
            this.Name = "frmNormalAnasayfa";
            this.Text = "Normal Kullanıcı Anasayfası";
            this.mstriptNormal.ResumeLayout(false);
            this.mstriptNormal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstriptNormal;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruSorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenMesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onaylananRandevularToolStripMenuItem;
    }
}