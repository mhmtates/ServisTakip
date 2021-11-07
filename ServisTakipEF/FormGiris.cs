using ServisTakipEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakip
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        DBServisTakip Db = new DBServisTakip();





        private void FormGiris_Load(object sender, EventArgs e)
        {


        }

        private void txtSifre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Giris();
            }
        }


        void Giris()
        {
            Admin admin = Db.Admin.FirstOrDefault(x => x.KullaniciAd== txtKullaniciAd.Text && x.Sifre== txtSifre.Text) ?? null;
            if (admin != null)
            {
                MessageBox.Show("Sayın " +admin.Ad + " " + admin.Soyad+ " " + "Hoşgeldiniz") ;
                FormServisTakip FrmServisTakip = new FormServisTakip();
                FrmServisTakip.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz Kullanıcı Adı Veya Şifre");
                txtSifre.Text = "";
                txtKullaniciAd.Text = "";
            }


        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Giris();
        }
    }

}
