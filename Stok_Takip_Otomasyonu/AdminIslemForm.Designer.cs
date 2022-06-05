namespace Stok_Takip_Otomasyonu
{
    partial class AdminIslemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminIslemForm));
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.lblCikis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSatis
            // 
            this.btnSatis.Font = new System.Drawing.Font("Arial", 18F);
            this.btnSatis.Location = new System.Drawing.Point(401, 58);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(296, 72);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "Satış Yap";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Font = new System.Drawing.Font("Arial", 18F);
            this.btnUrunEkle.Location = new System.Drawing.Point(401, 145);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(296, 72);
            this.btnUrunEkle.TabIndex = 1;
            this.btnUrunEkle.Text = "Ürün İşlemleri";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Font = new System.Drawing.Font("Arial", 18F);
            this.btnPersonelEkle.Location = new System.Drawing.Point(401, 232);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(296, 72);
            this.btnPersonelEkle.TabIndex = 2;
            this.btnPersonelEkle.Text = "Personel İşlemleri";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // lblCikis
            // 
            this.lblCikis.AutoSize = true;
            this.lblCikis.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.Location = new System.Drawing.Point(590, 324);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(107, 26);
            this.lblCikis.TabIndex = 4;
            this.lblCikis.Text = "Çıkış Yap";
            this.lblCikis.Click += new System.EventHandler(this.lblCikis_Click);
            this.lblCikis.MouseEnter += new System.EventHandler(this.lblCikis_MouseEnter);
            this.lblCikis.MouseLeave += new System.EventHandler(this.lblCikis_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(83, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdminIslemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(781, 409);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.btnSatis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminIslemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminIslemForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminIslemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCikis;
    }
}