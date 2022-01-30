namespace OnlineRandevuSistemi
{
    partial class frmIsYeriAnasayfa
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
            this.mStripIsYeri = new System.Windows.Forms.MenuStrip();
            this.randevuOnayRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygunOlmayanSaatAralığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelenSorularıCevaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cevaplanmamışMesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStripIsYeri.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStripIsYeri
            // 
            this.mStripIsYeri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuOnayRedToolStripMenuItem,
            this.uygunOlmayanSaatAralığıToolStripMenuItem,
            this.gelenSorularıCevaplaToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.mStripIsYeri.Location = new System.Drawing.Point(0, 0);
            this.mStripIsYeri.Name = "mStripIsYeri";
            this.mStripIsYeri.Size = new System.Drawing.Size(743, 24);
            this.mStripIsYeri.TabIndex = 0;
            this.mStripIsYeri.Text = "mStripIsYeri";
            // 
            // randevuOnayRedToolStripMenuItem
            // 
            this.randevuOnayRedToolStripMenuItem.Name = "randevuOnayRedToolStripMenuItem";
            this.randevuOnayRedToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.randevuOnayRedToolStripMenuItem.Text = "Randevu Onay/Red";
            this.randevuOnayRedToolStripMenuItem.Click += new System.EventHandler(this.randevuOnayRedToolStripMenuItem_Click);
            // 
            // uygunOlmayanSaatAralığıToolStripMenuItem
            // 
            this.uygunOlmayanSaatAralığıToolStripMenuItem.Name = "uygunOlmayanSaatAralığıToolStripMenuItem";
            this.uygunOlmayanSaatAralığıToolStripMenuItem.Size = new System.Drawing.Size(202, 20);
            this.uygunOlmayanSaatAralığıToolStripMenuItem.Text = "Uygun Olmayan Saat Aralığı Belirle";
            this.uygunOlmayanSaatAralığıToolStripMenuItem.Click += new System.EventHandler(this.uygunOlmayanSaatAralığıToolStripMenuItem_Click);
            // 
            // gelenSorularıCevaplaToolStripMenuItem
            // 
            this.gelenSorularıCevaplaToolStripMenuItem.Name = "gelenSorularıCevaplaToolStripMenuItem";
            this.gelenSorularıCevaplaToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.gelenSorularıCevaplaToolStripMenuItem.Text = "Gelen Soruları Cevapla";
            this.gelenSorularıCevaplaToolStripMenuItem.Click += new System.EventHandler(this.gelenSorularıCevaplaToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tümMesajlarToolStripMenuItem,
            this.cevaplanmamışMesajlarToolStripMenuItem,
            this.randevuListesiToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // tümMesajlarToolStripMenuItem
            // 
            this.tümMesajlarToolStripMenuItem.Name = "tümMesajlarToolStripMenuItem";
            this.tümMesajlarToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.tümMesajlarToolStripMenuItem.Text = "Tüm Mesajlar";
            this.tümMesajlarToolStripMenuItem.Click += new System.EventHandler(this.tümMesajlarToolStripMenuItem_Click);
            // 
            // cevaplanmamışMesajlarToolStripMenuItem
            // 
            this.cevaplanmamışMesajlarToolStripMenuItem.Name = "cevaplanmamışMesajlarToolStripMenuItem";
            this.cevaplanmamışMesajlarToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cevaplanmamışMesajlarToolStripMenuItem.Text = "Cevaplanmamış Mesajlar ";
            this.cevaplanmamışMesajlarToolStripMenuItem.Click += new System.EventHandler(this.cevaplanmamışMesajlarToolStripMenuItem_Click);
            // 
            // randevuListesiToolStripMenuItem
            // 
            this.randevuListesiToolStripMenuItem.Name = "randevuListesiToolStripMenuItem";
            this.randevuListesiToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.randevuListesiToolStripMenuItem.Text = "Onaylanan Randevu Listesi";
            this.randevuListesiToolStripMenuItem.Click += new System.EventHandler(this.randevuListesiToolStripMenuItem_Click);
            // 
            // frmIsYeriAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(743, 396);
            this.Controls.Add(this.mStripIsYeri);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStripIsYeri;
            this.Name = "frmIsYeriAnasayfa";
            this.Text = "İş Yeri Yetkilisi Ana Sayfası";
            this.mStripIsYeri.ResumeLayout(false);
            this.mStripIsYeri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStripIsYeri;
        private System.Windows.Forms.ToolStripMenuItem randevuOnayRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygunOlmayanSaatAralığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümMesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cevaplanmamışMesajlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelenSorularıCevaplaToolStripMenuItem;
    }
}