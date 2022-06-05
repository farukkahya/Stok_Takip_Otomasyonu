using Stok_Takip_Otomasyonu_Business.Yonetim;
using Stok_Takip_Otomasyonu_Data.DAL.Tables;
using Stok_Takip_Otomasyonu_DataAccess.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Otomasyonu
{
    public partial class UrunIslemleriForm : Form
    {
        DatabaseEntities db = new DatabaseEntities();
        UrunYonetimi _urun = new UrunYonetimi();
        public UrunIslemleriForm()
        {
            InitializeComponent();
        }
        public void UrunListele()
        {
            dgwUrunler.DataSource = db.urunTablosu.ToList();
        }
        private void UrunIslemleriForm_Load(object sender, EventArgs e)
        {
            UrunListele();
            dgwUrunler.Columns[5].Visible = false;
            var personelListe = db.personelTablosu.ToList();
            ComboBoxDoldur(personelListe);
        }
        private void ComboBoxDoldur(List<PersonelTablosu> personelListe)
        {
            cbxYeniEkleyen.DataSource = personelListe;
            cbxYeniEkleyen.DisplayMember = "Ad";
            cbxYeniEkleyen.ValueMember = "PersonelId";
            cbxGuncelleKaldirKisi.DataSource = personelListe;
            cbxGuncelleKaldirKisi.DisplayMember = "Ad";
            cbxGuncelleKaldirKisi.ValueMember = "PersonelId";

        }
        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            UrunTablosu yeniUrun = new UrunTablosu();
            yeniUrun.Ad = tbxYeniUrunAd.Text;
            yeniUrun.Adet = int.Parse(tbxYeniUrunAdet.Text);
            yeniUrun.EkleyenKisi = (int)cbxYeniEkleyen.SelectedValue;
            yeniUrun.EklemeTarihi = DateTime.Now;
            UrunTablosu urunTablosu = _urun.Add(yeniUrun);
            UrunListele();
        }
        private void lblUrunIslemleriCikis_MouseEnter(object sender, EventArgs e)
        {
            lblUrunIslemleriCikis.ForeColor = Color.Red;
        }

        private void lblUrunIslemleriCikis_MouseLeave(object sender, EventArgs e)
        {
            lblUrunIslemleriCikis.ForeColor = Color.Black;
        }

        private void lblUrunIslemleriCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblUrunIslemleriOturum_Click(object sender, EventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            this.Hide();
            formGiris.ShowDialog();
        }

        private void lblUrunIslemleriOturum_MouseEnter(object sender, EventArgs e)
        {
            lblUrunIslemleriOturum.ForeColor = Color.Red;
        }

        private void lblUrunIslemleriOturum_MouseLeave(object sender, EventArgs e)
        {
            lblUrunIslemleriOturum.ForeColor = Color.Black;
        }

        private void dgwUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tbxUrunGuncelleKaldir.Text = dgwUrunler.CurrentRow.Cells[1].Value.ToString();
            tbxUrunGuncelleKaldirAdet.Text = dgwUrunler.CurrentRow.Cells[2].Value.ToString();
        }
        private void btnKaldır_Click(object sender, EventArgs e)
        {
            UrunTablosu urun = new UrunTablosu()
            {
                UrunId = (int)dgwUrunler.CurrentRow.Cells[0].Value
            };

            DialogResult sil = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (sil == DialogResult.Yes)
                _urun.Delete(urun);
            UrunListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var urun = db.urunTablosu.Find((int)dgwUrunler.CurrentRow.Cells[0].Value);
            urun.Ad = tbxUrunGuncelleKaldir.Text;
            urun.Adet = int.Parse(tbxUrunGuncelleKaldirAdet.Text);
            urun.EkleyenKisi = (int)cbxGuncelleKaldirKisi.SelectedValue;
            urun.EklemeTarihi = DateTime.Now;
            _urun.Update(urun);
            UrunListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string ara = tbxAra.Text;
            dgwUrunler.DataSource = _urun.Search(ara);
        }

        private void lblGeri_MouseEnter(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Red;
        }

        private void lblGeri_MouseLeave(object sender, EventArgs e)
        {
            lblGeri.ForeColor = Color.Black;
        }

        private void lblGeri_Click(object sender, EventArgs e)
        {
            AdminIslemForm adminForm = new AdminIslemForm();
            this.Hide();
            adminForm.ShowDialog();
        }

        private void UrunIslemleriForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
