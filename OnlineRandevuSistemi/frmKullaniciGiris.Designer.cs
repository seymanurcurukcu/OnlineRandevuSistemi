namespace OnlineRandevuSistemi
{
    partial class frmKullaniciGiris
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.btnIsYeriGiris = new System.Windows.Forms.Button();
            this.btnNormalGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBaslik.Location = new System.Drawing.Point(47, 22);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(546, 33);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "ONLİNE RANDEVU SİSTEMİNE HOŞ GELDİNİZ";
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.Location = new System.Drawing.Point(150, 82);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(305, 75);
            this.btnAdminGiris.TabIndex = 1;
            this.btnAdminGiris.Text = "Genel Admin Kullanıcı Girişi";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // btnIsYeriGiris
            // 
            this.btnIsYeriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsYeriGiris.Location = new System.Drawing.Point(150, 180);
            this.btnIsYeriGiris.Name = "btnIsYeriGiris";
            this.btnIsYeriGiris.Size = new System.Drawing.Size(305, 75);
            this.btnIsYeriGiris.TabIndex = 2;
            this.btnIsYeriGiris.Text = "İş Yeri Yetkili Girişi";
            this.btnIsYeriGiris.UseVisualStyleBackColor = true;
            this.btnIsYeriGiris.Click += new System.EventHandler(this.btnIsYeriGiris_Click);
            // 
            // btnNormalGiris
            // 
            this.btnNormalGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNormalGiris.Location = new System.Drawing.Point(150, 286);
            this.btnNormalGiris.Name = "btnNormalGiris";
            this.btnNormalGiris.Size = new System.Drawing.Size(305, 75);
            this.btnNormalGiris.TabIndex = 3;
            this.btnNormalGiris.Text = "Normal Kullanıcı Girişi";
            this.btnNormalGiris.UseVisualStyleBackColor = true;
            this.btnNormalGiris.Click += new System.EventHandler(this.btnNormalGiris_Click);
            // 
            // frmKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 420);
            this.Controls.Add(this.btnNormalGiris);
            this.Controls.Add(this.btnIsYeriGiris);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.lblBaslik);
            this.Name = "frmKullaniciGiris";
            this.Text = "Kullanıcı Giriş Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Button btnIsYeriGiris;
        private System.Windows.Forms.Button btnNormalGiris;
    }
}