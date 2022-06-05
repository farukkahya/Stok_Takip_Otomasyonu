namespace Stok_Takip_Otomasyonu
{
    partial class PersonelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelForm));
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEkleYetki = new System.Windows.Forms.ComboBox();
            this.tbxEkleKullaniciSifre = new System.Windows.Forms.TextBox();
            this.tbxEkleKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbxEkleTelNo = new System.Windows.Forms.TextBox();
            this.tbxEkleTcNo = new System.Windows.Forms.TextBox();
            this.tbxEkleAd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKaldir = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxGuncelleKaldirKullaniciSifre = new System.Windows.Forms.TextBox();
            this.tbxGuncelleKaldirKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbxGuncelleKaldirTelNo = new System.Windows.Forms.TextBox();
            this.tbxGuncelleKaldirTcNo = new System.Windows.Forms.TextBox();
            this.tbxGuncelleKaldirAd = new System.Windows.Forms.TextBox();
            this.lblGeri = new System.Windows.Forms.Label();
            this.lblPersonelIslemleriOturum = new System.Windows.Forms.Label();
            this.lblPersonelIslemleriCikis = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.tbxAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Location = new System.Drawing.Point(12, 364);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.RowHeadersWidth = 51;
            this.dgwPersonel.RowTemplate.Height = 24;
            this.dgwPersonel.Size = new System.Drawing.Size(1076, 271);
            this.dgwPersonel.TabIndex = 0;
            this.dgwPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonel_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxEkleYetki);
            this.groupBox1.Controls.Add(this.tbxEkleKullaniciSifre);
            this.groupBox1.Controls.Add(this.tbxEkleKullaniciAdi);
            this.groupBox1.Controls.Add(this.tbxEkleTelNo);
            this.groupBox1.Controls.Add(this.tbxEkleTcNo);
            this.groupBox1.Controls.Add(this.tbxEkleAd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kullanıcı Şifre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yetki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC No";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(29, 259);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(365, 34);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad";
            // 
            // cbxEkleYetki
            // 
            this.cbxEkleYetki.FormattingEnabled = true;
            this.cbxEkleYetki.Location = new System.Drawing.Point(194, 151);
            this.cbxEkleYetki.Name = "cbxEkleYetki";
            this.cbxEkleYetki.Size = new System.Drawing.Size(200, 31);
            this.cbxEkleYetki.TabIndex = 6;
            // 
            // tbxEkleKullaniciSifre
            // 
            this.tbxEkleKullaniciSifre.Location = new System.Drawing.Point(194, 226);
            this.tbxEkleKullaniciSifre.Name = "tbxEkleKullaniciSifre";
            this.tbxEkleKullaniciSifre.Size = new System.Drawing.Size(200, 30);
            this.tbxEkleKullaniciSifre.TabIndex = 4;
            // 
            // tbxEkleKullaniciAdi
            // 
            this.tbxEkleKullaniciAdi.Location = new System.Drawing.Point(194, 189);
            this.tbxEkleKullaniciAdi.Name = "tbxEkleKullaniciAdi";
            this.tbxEkleKullaniciAdi.Size = new System.Drawing.Size(200, 30);
            this.tbxEkleKullaniciAdi.TabIndex = 3;
            // 
            // tbxEkleTelNo
            // 
            this.tbxEkleTelNo.Location = new System.Drawing.Point(194, 114);
            this.tbxEkleTelNo.Name = "tbxEkleTelNo";
            this.tbxEkleTelNo.Size = new System.Drawing.Size(200, 30);
            this.tbxEkleTelNo.TabIndex = 2;
            // 
            // tbxEkleTcNo
            // 
            this.tbxEkleTcNo.Location = new System.Drawing.Point(194, 77);
            this.tbxEkleTcNo.Name = "tbxEkleTcNo";
            this.tbxEkleTcNo.Size = new System.Drawing.Size(200, 30);
            this.tbxEkleTcNo.TabIndex = 1;
            // 
            // tbxEkleAd
            // 
            this.tbxEkleAd.Location = new System.Drawing.Point(194, 40);
            this.tbxEkleAd.Name = "tbxEkleAd";
            this.tbxEkleAd.Size = new System.Drawing.Size(200, 30);
            this.tbxEkleAd.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKaldir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbxGuncelleKaldirKullaniciSifre);
            this.groupBox2.Controls.Add(this.tbxGuncelleKaldirKullaniciAdi);
            this.groupBox2.Controls.Add(this.tbxGuncelleKaldirTelNo);
            this.groupBox2.Controls.Add(this.tbxGuncelleKaldirTcNo);
            this.groupBox2.Controls.Add(this.tbxGuncelleKaldirAd);
            this.groupBox2.Location = new System.Drawing.Point(656, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 333);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelleme/Kaldırma";
            // 
            // btnKaldir
            // 
            this.btnKaldir.Location = new System.Drawing.Point(216, 242);
            this.btnKaldir.Name = "btnKaldir";
            this.btnKaldir.Size = new System.Drawing.Size(178, 34);
            this.btnKaldir.TabIndex = 15;
            this.btnKaldir.Text = "Kaldir";
            this.btnKaldir.UseVisualStyleBackColor = true;
            this.btnKaldir.Click += new System.EventHandler(this.btnKaldir_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kullanıcı Şifre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 23);
            this.label12.TabIndex = 10;
            this.label12.Text = "Telefon Numarası";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(122, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "TC No";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(29, 242);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(178, 34);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "Ad";
            // 
            // tbxGuncelleKaldirKullaniciSifre
            // 
            this.tbxGuncelleKaldirKullaniciSifre.Location = new System.Drawing.Point(194, 203);
            this.tbxGuncelleKaldirKullaniciSifre.Name = "tbxGuncelleKaldirKullaniciSifre";
            this.tbxGuncelleKaldirKullaniciSifre.Size = new System.Drawing.Size(200, 30);
            this.tbxGuncelleKaldirKullaniciSifre.TabIndex = 4;
            // 
            // tbxGuncelleKaldirKullaniciAdi
            // 
            this.tbxGuncelleKaldirKullaniciAdi.Location = new System.Drawing.Point(194, 166);
            this.tbxGuncelleKaldirKullaniciAdi.Name = "tbxGuncelleKaldirKullaniciAdi";
            this.tbxGuncelleKaldirKullaniciAdi.Size = new System.Drawing.Size(200, 30);
            this.tbxGuncelleKaldirKullaniciAdi.TabIndex = 3;
            // 
            // tbxGuncelleKaldirTelNo
            // 
            this.tbxGuncelleKaldirTelNo.Location = new System.Drawing.Point(194, 130);
            this.tbxGuncelleKaldirTelNo.Name = "tbxGuncelleKaldirTelNo";
            this.tbxGuncelleKaldirTelNo.Size = new System.Drawing.Size(200, 30);
            this.tbxGuncelleKaldirTelNo.TabIndex = 2;
            // 
            // tbxGuncelleKaldirTcNo
            // 
            this.tbxGuncelleKaldirTcNo.Location = new System.Drawing.Point(194, 93);
            this.tbxGuncelleKaldirTcNo.Name = "tbxGuncelleKaldirTcNo";
            this.tbxGuncelleKaldirTcNo.Size = new System.Drawing.Size(200, 30);
            this.tbxGuncelleKaldirTcNo.TabIndex = 1;
            // 
            // tbxGuncelleKaldirAd
            // 
            this.tbxGuncelleKaldirAd.Location = new System.Drawing.Point(194, 56);
            this.tbxGuncelleKaldirAd.Name = "tbxGuncelleKaldirAd";
            this.tbxGuncelleKaldirAd.Size = new System.Drawing.Size(200, 30);
            this.tbxGuncelleKaldirAd.TabIndex = 0;
            // 
            // lblGeri
            // 
            this.lblGeri.AutoSize = true;
            this.lblGeri.Location = new System.Drawing.Point(516, 650);
            this.lblGeri.Name = "lblGeri";
            this.lblGeri.Size = new System.Drawing.Size(89, 23);
            this.lblGeri.TabIndex = 16;
            this.lblGeri.Text = "Geri Dön";
            this.lblGeri.Click += new System.EventHandler(this.lblGeri_Click);
            this.lblGeri.MouseEnter += new System.EventHandler(this.lblGeri_MouseEnter);
            this.lblGeri.MouseLeave += new System.EventHandler(this.lblGeri_MouseLeave);
            // 
            // lblPersonelIslemleriOturum
            // 
            this.lblPersonelIslemleriOturum.AutoSize = true;
            this.lblPersonelIslemleriOturum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonelIslemleriOturum.Location = new System.Drawing.Point(12, 650);
            this.lblPersonelIslemleriOturum.Name = "lblPersonelIslemleriOturum";
            this.lblPersonelIslemleriOturum.Size = new System.Drawing.Size(143, 23);
            this.lblPersonelIslemleriOturum.TabIndex = 24;
            this.lblPersonelIslemleriOturum.Text = "Oturumu Kapat";
            this.lblPersonelIslemleriOturum.Click += new System.EventHandler(this.lblPersonelIslemleriOturum_Click);
            this.lblPersonelIslemleriOturum.MouseEnter += new System.EventHandler(this.lblPersonelIslemleriOturum_MouseEnter);
            this.lblPersonelIslemleriOturum.MouseLeave += new System.EventHandler(this.lblPersonelIslemleriOturum_MouseLeave);
            // 
            // lblPersonelIslemleriCikis
            // 
            this.lblPersonelIslemleriCikis.AutoSize = true;
            this.lblPersonelIslemleriCikis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonelIslemleriCikis.Location = new System.Drawing.Point(991, 650);
            this.lblPersonelIslemleriCikis.Name = "lblPersonelIslemleriCikis";
            this.lblPersonelIslemleriCikis.Size = new System.Drawing.Size(97, 23);
            this.lblPersonelIslemleriCikis.TabIndex = 23;
            this.lblPersonelIslemleriCikis.Text = "Çıkış Yap";
            this.lblPersonelIslemleriCikis.Click += new System.EventHandler(this.lblPersonelIslemleriCikis_Click);
            this.lblPersonelIslemleriCikis.MouseEnter += new System.EventHandler(this.lblPersonelIslemleriCikis_MouseEnter);
            this.lblPersonelIslemleriCikis.MouseLeave += new System.EventHandler(this.lblPersonelIslemleriCikis_MouseLeave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(433, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 23);
            this.label15.TabIndex = 25;
            this.label15.Text = "Ara";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(437, 191);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(213, 31);
            this.btnAra.TabIndex = 27;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // tbxAra
            // 
            this.tbxAra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAra.Location = new System.Drawing.Point(474, 148);
            this.tbxAra.Name = "tbxAra";
            this.tbxAra.Size = new System.Drawing.Size(178, 30);
            this.tbxAra.TabIndex = 26;
            // 
            // PersonelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 685);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.tbxAra);
            this.Controls.Add(this.lblPersonelIslemleriOturum);
            this.Controls.Add(this.lblPersonelIslemleriCikis);
            this.Controls.Add(this.lblGeri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwPersonel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonelForm_FormClosed);
            this.Load += new System.EventHandler(this.PersonelIslemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPersonel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEkleKullaniciSifre;
        private System.Windows.Forms.TextBox tbxEkleKullaniciAdi;
        private System.Windows.Forms.TextBox tbxEkleTelNo;
        private System.Windows.Forms.TextBox tbxEkleTcNo;
        private System.Windows.Forms.TextBox tbxEkleAd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKaldir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxGuncelleKaldirKullaniciSifre;
        private System.Windows.Forms.TextBox tbxGuncelleKaldirKullaniciAdi;
        private System.Windows.Forms.TextBox tbxGuncelleKaldirTelNo;
        private System.Windows.Forms.TextBox tbxGuncelleKaldirTcNo;
        private System.Windows.Forms.TextBox tbxGuncelleKaldirAd;
        private System.Windows.Forms.Label lblGeri;
        private System.Windows.Forms.Label lblPersonelIslemleriOturum;
        private System.Windows.Forms.Label lblPersonelIslemleriCikis;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox tbxAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxEkleYetki;
    }
}