using ServisTakip;
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

namespace ServisTakipEF
{
    public partial class FormMusteri : Form
    {
        DBServisTakip Database = new DBServisTakip();

        public FormMusteri()
        {
            InitializeComponent();
        }


       




        private void FormMusteri_Load(object sender, EventArgs e)
        {
            Getir(Database.Musteri.ToList());

        }

        private void btnGöster_Click(object sender, EventArgs e)
        {

            List<Musteri> Musteriler = Database.Musteri.ToList();
            if (!string.IsNullOrEmpty(txtAra.Text))
            {
                switch (cmbAra.Text)
                {
                    case "Müşteri Adına Göre":
                        Musteriler = Musteriler.Where(x => x.Ad.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;
                    case "Gsm Numarasına Göre":
                        Musteriler = Musteriler.Where(x => x.GsmNo.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;
                    case "Telefon Numarasına Göre":
                        Musteriler = Musteriler.Where(x => x.TelefonNo.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;
                }
            }
            Getir(Musteriler);
        }

        void Getir(List<Musteri> Musteriler)
        {
            dgvMusteri.DataSource = Musteriler.Select(s => new { s.Id, s.Ad, s.Adres, s.GsmNo, s.TelefonNo,s.Mail,s.TCNo }).ToList();
            dgvMusteri.Columns["Id"].Visible = false;
            dgvMusteri.Columns["Ad"].HeaderText = "MÜŞTERİ ADI";
            dgvMusteri.Columns["Adres"].HeaderText = "ADRESİ";
            dgvMusteri.Columns["GsmNo"].HeaderText = "GSM NO";
            dgvMusteri.Columns["TelefonNo"].HeaderText = "TELEFON NO";
            dgvMusteri.Columns["Mail"].HeaderText = "E-MAIL";
            dgvMusteri.Columns["TCNo"].HeaderText = "T.C.NO";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Database.Musteri.Add(new Musteri
            {
                Ad = txtAd.Text,
                Adres = txtAdres.Text,
                GsmNo = txtGsmNo.Text,
                TelefonNo = txtTelefonNo.Text,
                Mail = txtMail.Text,
               TCNo= txtKimlikNo.Text
            });
            Database.SaveChanges();
            Getir(Database.Musteri.ToList());
    }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(dgvMusteri.CurrentRow.Cells["Id"].Value);
            Musteri m = Database.Musteri.Single(f => f.Id == seciliId);
            m.Ad = txtAd.Text;
            m.Adres = txtAdres.Text;
            m.GsmNo = txtGsmNo.Text;
            m.TelefonNo = txtTelefonNo.Text;
            m.Mail = txtMail.Text;
            m.TCNo = txtKimlikNo.Text;
            Database.SaveChanges();
           


        }




        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(dgvMusteri.CurrentRow.Cells["Id"].Value);
            Musteri m = Database.Musteri.Single(f => f.Id == seciliId);
            txtAd.Text = m.Ad;
            txtAdres.Text = m.Adres;
            txtGsmNo.Text = m.GsmNo;
            txtTelefonNo.Text = m.TelefonNo;
            txtMail.Text = m.Mail;
            txtKimlikNo.Text = m.TCNo;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinizden emin misiniz?", "DİKKAT!..", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int seciliId = Convert.ToInt32(dgvMusteri.CurrentRow.Cells["Id"].Value);
                Database.Musteri.Remove(Database.Musteri.First(f => f.Id == seciliId));
                Database.SaveChanges();
                Getir(Database.Musteri.ToList());
            }

        }

        private void dgwMusteri_DoubleClick(object sender, EventArgs e)
        {

            FormCihazKayit FrmCihazKayit = new FormCihazKayit();

            int seciliId = Convert.ToInt32(dgvMusteri.CurrentRow.Cells["Id"].Value);
           Musteri m = Database.Musteri.Single(f => f.Id == seciliId);
            FrmCihazKayit.txtAd.Text = m.Ad;
            FrmCihazKayit.txtAdres.Text = m.Adres;
            FrmCihazKayit.txtGsmNo.Text = m.GsmNo;
            FrmCihazKayit.txtTelefonNo.Text = m.TelefonNo;
            FrmCihazKayit.txtMail.Text = m.Mail;
            FrmCihazKayit.txtKimlikNo.Text = m.TCNo;
            FrmCihazKayit.Show();
        }
    }

    }

