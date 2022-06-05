using Stok_Takip_Otomasyonu_Business.Yonetim;
using Stok_Takip_Otomasyonu_Data.DAL.Tables;
using Stok_Takip_Otomasyonu_DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Otomasyonu
{
    public partial class SatisForm : Form
    {
        DatabaseEntities db = new DatabaseEntities();
        UrunYonetimi _urun = new UrunYonetimi();
        public string kullaniciadi;
        public SatisForm()
        {
            InitializeComponent();
        }
        
        private void SatisForm_Load(object sender, EventArgs e)
        {
            kullaniciadi = FormGiris.Info.UserName;
            PersonelTablosu kb = (from nesne in db.personelTablosu where nesne.KullaniciAdi == kullaniciadi select nesne).FirstOrDefault();
            if (kb.Yetki == 2)
            {
                lblGeri.Visible = false;
            }

            var personelLİste = db.personelTablosu.ToList();
            var urunListe = db.urunTablosu.ToList();
            ComboBoxDoldur(personelLİste, urunListe);
        }
        private void ComboBoxDoldur(List<PersonelTablosu> personelLİste, List<UrunTablosu> urunListe)
        {
            cbxPersonel.DataSource = personelLİste;
            cbxUrun.DataSource = urunListe;
            cbxPersonel.DisplayMember = "Ad";
            cbxUrun.DisplayMember = "Ad";
            cbxPersonel.ValueMember = "PersonelId";
            cbxUrun.ValueMember = "UrunId";
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            UrunTablosu ub = (from nesne in db.urunTablosu where nesne.Ad == cbxUrun.Text select nesne).FirstOrDefault();
            ub.Adet -= int.Parse(tbxAdet.Text);
            var urun = db.urunTablosu.Find(ub.UrunId);
            urun.Adet = ub.Adet;
            urun.Ad = ub.Ad;
            urun.EklemeTarihi = ub.EklemeTarihi;
            urun.EkleyenKisi = ub.EkleyenKisi;
            _urun.Update(urun);
            MessageBox.Show("Satış Başarılı.");
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            AdminIslemForm adminForm = new AdminIslemForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void lblOturumKapat_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void lblOturumKapat_MouseEnter(object sender, EventArgs e)
        {
            lblOturumKapat.ForeColor = Color.Red;
        }

        private void lblOturumKapat_MouseLeave(object sender, EventArgs e)
        {
            lblOturumKapat.ForeColor = Color.Black;
        }

        private void lblGeri_Click_1(object sender, EventArgs e)
        {
           AdminIslemForm AdminForm = new AdminIslemForm();
            this.Hide();
            AdminForm.ShowDialog();
        }

        private void SatisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
