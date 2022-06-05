namespace Stok_Takip_Otomasyonu
{
    partial class SatisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisForm));
            this.cbxUrun = new System.Windows.Forms.ComboBox();
            this.tbxAdet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPersonel = new System.Windows.Forms.ComboBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOturumKapat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGeri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUrun
            // 
            this.cbxUrun.FormattingEnabled = true;
            this.cbxUrun.Location = new System.Drawing.Point(104, 283);
            this.cbxUrun.Name = "cbxUrun";
            this.cbxUrun.Size = new System.Drawing.Size(258, 31);
            this.cbxUrun.TabIndex = 0;
            // 
            // tbxAdet
            // 
            this.tbxAdet.Location = new System.Drawing.Point(104, 332);
            this.tbxAdet.Name = "tbxAdet";
            this.tbxAdet.Size = new System.Drawing.Size(258, 30);
            this.tbxAdet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün";
            // 
            // cbxPersonel
            // 
            this.cbxPersonel.FormattingEnabled = true;
            this.cbxPersonel.Location = new System.Drawing.Point(104, 380);
            this.cbxPersonel.Name = "cbxPersonel";
            this.cbxPersonel.Size = new System.Drawing.Size(258, 31);
            this.cbxPersonel.TabIndex = 3;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(104, 426);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(258, 38);
            this.btnSatisYap.TabIndex = 4;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel";
            // 
            // lblOturumKapat
            // 
            this.lblOturumKapat.AutoSize = true;
            this.lblOturumKapat.Font = new System.Drawing.Font("Arial", 12F);
            this.lblOturumKapat.Location = new System.Drawing.Point(11, 489);
            this.lblOturumKapat.Name = "lblOturumKapat";
            this.lblOturumKapat.Size = new System.Drawing.Size(143, 23);
            this.lblOturumKapat.TabIndex = 8;
            this.lblOturumKapat.Text = "Oturumu Kapat";
            this.lblOturumKapat.Click += new System.EventHandler(this.lblOturumKapat_Click);
            this.lblOturumKapat.MouseEnter += new System.EventHandler(this.lblOturumKapat_MouseEnter);
            this.lblOturumKapat.MouseLeave += new System.EventHandler(this.lblOturumKapat_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_Takip_Otomasyonu.Properties.Resources.sell;
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblGeri
            // 
            this.lblGeri.AutoSize = true;
            this.lblGeri.Font = new System.Drawing.Font("Arial", 12F);
            this.lblGeri.Location = new System.Drawing.Point(287, 489);
            this.lblGeri.Name = "lblGeri";
            this.lblGeri.Size = new System.Drawing.Size(89, 23);
            this.lblGeri.TabIndex = 10;
            this.lblGeri.Text = "Geri Dön";
            this.lblGeri.Click += new System.EventHandler(this.lblGeri_Click_1);
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 530);
            this.Controls.Add(this.lblGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxUrun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOturumKapat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.cbxPersonel);
            this.Controls.Add(this.tbxAdet);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SatisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SatisForm_FormClosed);
            this.Load += new System.EventHandler(this.SatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUrun;
        private System.Windows.Forms.TextBox tbxAdet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPersonel;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOturumKapat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGeri;
    }
}