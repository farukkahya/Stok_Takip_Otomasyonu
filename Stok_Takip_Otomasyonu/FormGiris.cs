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
    public partial class FormGiris : Form
    {
        public DatabaseEntities db = new DatabaseEntities();
        public FormGiris()
        {
            InitializeComponent();
        }
        public static class Info 
        {
            public static string UserName { get; set; }
        }

        public bool GirisDogrula(string u, string p)
        {
            bool sonuc = false;
            foreach (var info in db.personelTablosu.ToList())
            {
                if (u == info.KullaniciAdi && p == info.KullaniciSifre)
                    sonuc = true;
            }
            return sonuc;
        }
        public void btnGiris_Click(object sender, EventArgs e)
        {
            UserInformations userInfo = new UserInformations();
            userInfo.UserName = tbxUserName.Text;
            userInfo.Password = tbxPassword.Text;
            PersonelTablosu kb = (from nesne in db.personelTablosu where nesne.KullaniciAdi == userInfo.UserName select nesne).FirstOrDefault();
            if (GirisDogrula(userInfo.UserName, userInfo.Password))
            {
                Info.UserName = userInfo.UserName;
                if (kb.Yetki == 1)
                {
                    AdminIslemForm adminForm = new AdminIslemForm();
                    this.Hide();
                    adminForm.ShowDialog();
                }
                else if (kb.Yetki == 2)
                {
                    SatisForm satisForm = new SatisForm();
                    this.Hide();
                    satisForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Geçersiz Yetki.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı.");
            }
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
