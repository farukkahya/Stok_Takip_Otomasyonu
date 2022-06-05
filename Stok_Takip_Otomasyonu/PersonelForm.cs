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
    public partial class PersonelForm : Form
    {
        DatabaseEntities db = new DatabaseEntities();
        PersonelYonetimi _personel = new PersonelYonetimi();
        public PersonelForm()
        {
            InitializeComponent();
        }
        private void PersonelIslemForm_Load(object sender, EventArgs e)
        {
            PersonelListele();
            dgwPersonel.Columns[8].Visible = false;
            dgwPersonel.Columns[9].Visible = false;
            var yetkiListe = db.yetkiTablosu.ToList();
            cbxEkleYetki.DataSource = yetkiListe;
            cbxEkleYetki.DisplayMember = "Ad";
            cbxEkleYetki.ValueMember = "YetkiId";
            
        }

        private void PersonelListele()
        {
            dgwPersonel.DataSource = _personel.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PersonelTablosu personel = new PersonelTablosu()
            {
                Ad = tbxEkleAd.Text,
                TcNo = tbxEkleTcNo.Text,
                TelNo = tbxEkleTelNo.Text,
                KullaniciAdi = tbxEkleKullaniciAdi.Text,
                KullaniciSifre = tbxEkleKullaniciSifre.Text,
                BaslamaTarihi = DateTime.Now,
                Yetki = (int)cbxEkleYetki.SelectedValue
            };
            _personel.Add(personel);
            PersonelListele();
        }

        private void dgwPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxGuncelleKaldirAd.Text = dgwPersonel.CurrentRow.Cells[1].Value.ToString();
            tbxGuncelleKaldirTcNo.Text = dgwPersonel.CurrentRow.Cells[2].Value.ToString();
            tbxGuncelleKaldirTelNo.Text = dgwPersonel.CurrentRow.Cells[3].Value.ToString();
            tbxGuncelleKaldirKullaniciAdi.Text = dgwPersonel.CurrentRow.Cells[6].Value.ToString();
            tbxGuncelleKaldirKullaniciSifre.Text = dgwPersonel.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            var personel = db.personelTablosu.Find((int)dgwPersonel.CurrentRow.Cells[0].Value);

            DialogResult sil = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (sil == DialogResult.Yes)
                _personel.Delete(personel);
            PersonelListele();
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            AdminIslemForm adminForm = new AdminIslemForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void lblGeri_MouseEnter(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Red;
        }

        private void lblGeri_MouseLeave(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Black;

        }

        private void lblPersonelIslemleriOturum_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void lblPersonelIslemleriOturum_MouseEnter(object sender, EventArgs e)
        {
            lblPersonelIslemleriOturum.ForeColor = Color.Red;
        }

        private void lblPersonelIslemleriOturum_MouseLeave(object sender, EventArgs e)
        {
            lblPersonelIslemleriOturum.ForeColor = Color.Black;

        }

        private void lblPersonelIslemleriCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblPersonelIslemleriCikis_MouseEnter(object sender, EventArgs e)
        {
            lblPersonelIslemleriCikis.ForeColor = Color.Red;
        }

        private void lblPersonelIslemleriCikis_MouseLeave(object sender, EventArgs e)
        {
            lblPersonelIslemleriCikis.ForeColor = Color.Black;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string ara = tbxAra.Text;
            dgwPersonel.DataSource = _personel.Search(ara);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var personel = db.personelTablosu.Find((int)dgwPersonel.CurrentRow.Cells[0].Value);
            personel.Ad = tbxGuncelleKaldirAd.Text;
            personel.TcNo = tbxGuncelleKaldirTcNo.Text;
            personel.TelNo = tbxGuncelleKaldirTelNo.Text;
            _personel.Update(personel);
            PersonelListele();
        }

        private void PersonelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
