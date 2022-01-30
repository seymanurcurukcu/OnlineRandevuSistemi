namespace OnlineRandevuSistemi
{
    partial class frmAdminAnasayfa
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
            this.mstriptAdmin = new System.Windows.Forms.MenuStrip();
            this.işYeriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriYetkilisiTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yetkiliTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işYeriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstriptAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstriptAdmin
            // 
            this.mstriptAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işYeriİşlemleriToolStripMenuItem,
            this.işYeriYetkilisiTanımlaToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.mstriptAdmin.Location = new System.Drawing.Point(0, 0);
            this.mstriptAdmin.Name = "mstriptAdmin";
            this.mstriptAdmin.Size = new System.Drawing.Size(910, 24);
            this.mstriptAdmin.TabIndex = 0;
            this.mstriptAdmin.Text = "menuStrip1";
            // 
            // işYeriİşlemleriToolStripMenuItem
            // 
            this.işYeriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işYeriİşlemleriToolStripMenuItem1});
            this.işYeriİşlemleriToolStripMenuItem.Name = "işYeriİşlemleriToolStripMenuItem";
            this.işYeriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.işYeriİşlemleriToolStripMenuItem.Text = " İş Yeri İşlemleri";
            // 
            // işYeriİşlemleriToolStripMenuItem1
            // 
            this.işYeriİşlemleriToolStripMenuItem1.Name = "işYeriİşlemleriToolStripMenuItem1";
            this.işYeriİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.işYeriİşlemleriToolStripMenuItem1.Text = "İş Yeri İşlemleri";
            this.işYeriİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.işYeriİşlemleriToolStripMenuItem1_Click);
            // 
            // işYeriYetkilisiTanımlaToolStripMenuItem
            // 
            this.işYeriYetkilisiTanımlaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yetkiliTanımlaToolStripMenuItem});
            this.işYeriYetkilisiTanımlaToolStripMenuItem.Name = "işYeriYetkilisiTanımlaToolStripMenuItem";
            this.işYeriYetkilisiTanımlaToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.işYeriYetkilisiTanımlaToolStripMenuItem.Text = "İş Yeri Yetkilisi Tanımla";
            // 
            // yetkiliTanımlaToolStripMenuItem
            // 
            this.yetkiliTanımlaToolStripMenuItem.Name = "yetkiliTanımlaToolStripMenuItem";
            this.yetkiliTanımlaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.yetkiliTanımlaToolStripMenuItem.Text = "Yetkili Tanımla";
            this.yetkiliTanımlaToolStripMenuItem.Click += new System.EventHandler(this.yetkiliTanımlaToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.randevuListesiToolStripMenuItem,
            this.işYeriListesiToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı Listesi";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // randevuListesiToolStripMenuItem
            // 
            this.randevuListesiToolStripMenuItem.Name = "randevuListesiToolStripMenuItem";
            this.randevuListesiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.randevuListesiToolStripMenuItem.Text = "Yetkili Listesi";
            this.randevuListesiToolStripMenuItem.Click += new System.EventHandler(this.randevuListesiToolStripMenuItem_Click);
            // 
            // işYeriListesiToolStripMenuItem
            // 
            this.işYeriListesiToolStripMenuItem.Name = "işYeriListesiToolStripMenuItem";
            this.işYeriListesiToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.işYeriListesiToolStripMenuItem.Text = "İş Yeri Listesi";
            this.işYeriListesiToolStripMenuItem.Click += new System.EventHandler(this.işYeriListesiToolStripMenuItem_Click);
            // 
            // frmAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(910, 465);
            this.Controls.Add(this.mstriptAdmin);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstriptAdmin;
            this.Name = "frmAdminAnasayfa";
            this.Text = "Genel Admin Anasayfa";
            this.mstriptAdmin.ResumeLayout(false);
            this.mstriptAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstriptAdmin;
        private System.Windows.Forms.ToolStripMenuItem işYeriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işYeriİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem işYeriYetkilisiTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yetkiliTanımlaToolStripMenuItem;
    }
}