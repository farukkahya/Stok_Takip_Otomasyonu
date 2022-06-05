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
    public partial class AdminIslemForm : Form
    {
        public AdminIslemForm()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            UrunIslemleriForm urunIslemleriForm = new UrunIslemleriForm();
            this.Hide();
            urunIslemleriForm.ShowDialog();
        }

        private void lblCikis_MouseEnter(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.Red;
        }

        private void lblCikis_MouseLeave(object sender, EventArgs e)
        {
            lblCikis.ForeColor = Color.Black;
        }

        private void lblCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            SatisForm satisForm = new SatisForm();
            this.Hide();
            satisForm.ShowDialog();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelForm personelForm = new PersonelForm();
            this.Hide();
            personelForm.ShowDialog();
        }

        private void AdminIslemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminIslemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
