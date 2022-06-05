namespace Stok_Takip_Otomasyonu
{
    partial class UrunIslemleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunIslemleriForm));
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();
            this.cbxYeniEkleyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxYeniUrunAdet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxYeniUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaldır = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbxGuncelleKaldirKisi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxUrunGuncelleKaldirAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxUrunGuncelleKaldir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblUrunIslemleriCikis = new System.Windows.Forms.Label();
            this.lblUrunIslemleriOturum = new System.Windows.Forms.Label();
            this.tbxAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGeri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Location = new System.Drawing.Point(12, 261);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.RowHeadersWidth = 51;
            this.dgwUrunler.RowTemplate.Height = 24;
            this.dgwUrunler.Size = new System.Drawing.Size(1076, 336);
            this.dgwUrunler.TabIndex = 0;
            this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniUrunEkle);
            this.groupBox1.Controls.Add(this.cbxYeniEkleyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbxYeniUrunAdet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxYeniUrunAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 233);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün";
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(42, 173);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(304, 39);
            this.btnYeniUrunEkle.TabIndex = 18;
            this.btnYeniUrunEkle.Text = "Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;
            this.btnYeniUrunEkle.Click += new System.EventHandler(this.btnYeniUrunEkle_Click);
            // 
            // cbxYeniEkleyen
            // 
            this.cbxYeniEkleyen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxYeniEkleyen.FormattingEnabled = true;
            this.cbxYeniEkleyen.Location = new System.Drawing.Point(168, 123);
            this.cbxYeniEkleyen.Name = "cbxYeniEkleyen";
            this.cbxYeniEkleyen.Size = new System.Drawing.Size(178, 31);
            this.cbxYeniEkleyen.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(46, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ekleyen Kişi";
            // 
            // tbxYeniUrunAdet
            // 
            this.tbxYeniUrunAdet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYeniUrunAdet.Location = new System.Drawing.Point(165, 79);
            this.tbxYeniUrunAdet.Name = "tbxYeniUrunAdet";
            this.tbxYeniUrunAdet.Size = new System.Drawing.Size(178, 30);
            this.tbxYeniUrunAdet.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(55, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ürün Adedi";
            // 
            // tbxYeniUrunAd
            // 
            this.tbxYeniUrunAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxYeniUrunAd.Location = new System.Drawing.Point(168, 39);
            this.tbxYeniUrunAd.Name = "tbxYeniUrunAd";
            this.tbxYeniUrunAd.Size = new System.Drawing.Size(178, 30);
            this.tbxYeniUrunAd.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ürün Adı";
            // 
            // btnKaldır
            // 
            this.btnKaldır.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaldır.Location = new System.Drawing.Point(190, 173);
            this.btnKaldır.Name = "btnKaldır";
            this.btnKaldır.Size = new System.Drawing.Size(156, 39);
            this.btnKaldır.TabIndex = 19;
            this.btnKaldır.Text = "Kaldır";
            this.btnKaldır.UseVisualStyleBackColor = true;
            this.btnKaldır.Click += new System.EventHandler(this.btnKaldır_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaldır);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.cbxGuncelleKaldirKisi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxUrunGuncelleKaldirAdet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxUrunGuncelleKaldir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(710, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 233);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle/Kaldır";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(21, 173);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(156, 39);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbxGuncelleKaldirKisi
            // 
            this.cbxGuncelleKaldirKisi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxGuncelleKaldirKisi.FormattingEnabled = true;
            this.cbxGuncelleKaldirKisi.Location = new System.Drawing.Point(168, 123);
            this.cbxGuncelleKaldirKisi.Name = "cbxGuncelleKaldirKisi";
            this.cbxGuncelleKaldirKisi.Size = new System.Drawing.Size(178, 31);
            this.cbxGuncelleKaldirKisi.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(46, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ekleyen Kişi";
            // 
            // tbxUrunGuncelleKaldirAdet
            // 
            this.tbxUrunGuncelleKaldirAdet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunGuncelleKaldirAdet.Location = new System.Drawing.Point(165, 79);
            this.tbxUrunGuncelleKaldirAdet.Name = "tbxUrunGuncelleKaldirAdet";
            this.tbxUrunGuncelleKaldirAdet.Size = new System.Drawing.Size(178, 30);
            this.tbxUrunGuncelleKaldirAdet.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(55, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ürün Adedi";
            // 
            // tbxUrunGuncelleKaldir
            // 
            this.tbxUrunGuncelleKaldir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUrunGuncelleKaldir.Location = new System.Drawing.Point(168, 39);
            this.tbxUrunGuncelleKaldir.Name = "tbxUrunGuncelleKaldir";
            this.tbxUrunGuncelleKaldir.Size = new System.Drawing.Size(178, 30);
            this.tbxUrunGuncelleKaldir.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(75, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ürün Adı";
            // 
            // lblUrunIslemleriCikis
            // 
            this.lblUrunIslemleriCikis.AutoSize = true;
            this.lblUrunIslemleriCikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunIslemleriCikis.Location = new System.Drawing.Point(990, 607);
            this.lblUrunIslemleriCikis.Name = "lblUrunIslemleriCikis";
            this.lblUrunIslemleriCikis.Size = new System.Drawing.Size(97, 23);
            this.lblUrunIslemleriCikis.TabIndex = 19;
            this.lblUrunIslemleriCikis.Text = "Çıkış Yap";
            this.lblUrunIslemleriCikis.Click += new System.EventHandler(this.lblUrunIslemleriCikis_Click);
            this.lblUrunIslemleriCikis.MouseEnter += new System.EventHandler(this.lblUrunIslemleriCikis_MouseEnter);
            this.lblUrunIslemleriCikis.MouseLeave += new System.EventHandler(this.lblUrunIslemleriCikis_MouseLeave);
            // 
            // lblUrunIslemleriOturum
            // 
            this.lblUrunIslemleriOturum.AutoSize = true;
            this.lblUrunIslemleriOturum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunIslemleriOturum.Location = new System.Drawing.Point(12, 607);
            this.lblUrunIslemleriOturum.Name = "lblUrunIslemleriOturum";
            this.lblUrunIslemleriOturum.Size = new System.Drawing.Size(143, 23);
            this.lblUrunIslemleriOturum.TabIndex = 22;
            this.lblUrunIslemleriOturum.Text = "Oturumu Kapat";
            this.lblUrunIslemleriOturum.Click += new System.EventHandler(this.lblUrunIslemleriOturum_Click);
            this.lblUrunIslemleriOturum.MouseEnter += new System.EventHandler(this.lblUrunIslemleriOturum_MouseEnter);
            this.lblUrunIslemleriOturum.MouseLeave += new System.EventHandler(this.lblUrunIslemleriOturum_MouseLeave);
            // 
            // tbxAra
            // 
            this.tbxAra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAra.Location = new System.Drawing.Point(495, 96);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(178, 30);
            this.tbxAra.TabIndex = 19;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(431, 139);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(242, 31);
            this.btnAra.TabIndex = 20;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(427, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ara";
            // 
            // lblGeri
            // 
            this.lblGeri.AutoSize = true;
            this.lblGeri.Location = new System.Drawing.Point(528, 609);
            this.lblGeri.Name = "lblGeri";
            this.lblGeri.Size = new System.Drawing.Size(89, 23);
            this.lblGeri.TabIndex = 23;
            this.lblGeri.Text = "Geri Dön";
            this.lblGeri.Click += new System.EventHandler(this.lblGeri_Click);
            this.lblGeri.MouseEnter += new System.EventHandler(this.lblGeri_MouseEnter);
            this.lblGeri.MouseLeave += new System.EventHandler(this.lblGeri_MouseLeave);
            // 
            // UrunIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 644);
            this.Controls.Add(this.lblGeri);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.lblUrunIslemleriOturum);
            this.Controls.Add(this.lblUrunIslemleriCikis);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwUrunler);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunIslemleriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UrunIslemleriForm_FormClosed);
            this.Load += new System.EventHandler(this.UrunIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.ComboBox cbxYeniEkleyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxYeniUrunAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxYeniUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaldır;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbxGuncelleKaldirKisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxUrunGuncelleKaldirAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxUrunGuncelleKaldir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUrunIslemleriCikis;
        private System.Windows.Forms.Label lblUrunIslemleriOturum;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGeri;
    }
}