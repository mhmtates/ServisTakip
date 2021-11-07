using ServisTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakipEF
{
    public partial class FormCihazSorgu : Form
    {

        DBServisTakip Db = new DBServisTakip();



        public FormCihazSorgu()
        {
            InitializeComponent();
        }

        private void FormCihazSorgu_Load(object sender, EventArgs e)
        {

            dgvKayit.DataSource = Db.Database.SqlQuery<VKayit>("select * from VKayit").ToList();
            dgvKayit.Columns["Id"].Visible = false;
            dgvKayit.Columns["MusteriAd"].HeaderText = "MÜŞTERİ ADI";
            dgvKayit.Columns["GelisTarih"].HeaderText = "GELİŞ TARİHİ";
            dgvKayit.Columns["CihazTur"].HeaderText = "CİHAZ TÜRÜ";
            dgvKayit.Columns["Marka"].HeaderText = "MARKA";
            dgvKayit.Columns["Model"].HeaderText = "MODEL";
            dgvKayit.Columns["SeriNo"].HeaderText = "SERİ NO";
            dgvKayit.Columns["Aksesuar"].HeaderText = "CİHAZIN AKSESUARLARI";
            dgvKayit.Columns["ServisTur"].HeaderText = "SERVİS TÜRÜ";
            dgvKayit.Columns["ServisDurum"].HeaderText = "SERVİSTEKİ DURUMU";
            dgvKayit.Columns["ToplamUcret"].HeaderText = "TOPLAM ÜCRET";
            cmbTur.DataSource = Db.CihazTur.ToList();
            cmbMarka.DataSource = Db.Marka.ToList();
            cmbServisTur.DataSource = Db.ServisTur.ToList();
            cmbDurum.DataSource = Db.ServisDurum.ToList();
           

        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            List<Kayit> Kayitlar = Db.Kayit.Include(y => y.CihazTur).Include(y => y.Marka).Include(y => y.Model).Include(y => y.ServisDurum).ToList();

            if (!string.IsNullOrEmpty(txtAra.Text))
            {
                switch (cmbAra.Text)
                {
                    case "Müşteri Adına Göre":
                        Kayitlar = Kayitlar.Where(y => y.MusteriAd.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;
                    case "Cihaz Türüne Göre":
                        Kayitlar = Kayitlar.Where(y => y.CihazTur.TurAd.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;
                    case "Markaya Göre":
                        Kayitlar = Kayitlar.Where(y => y.Marka.MarkaAd.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;
                    case "Modele Göre":
                        Kayitlar = Kayitlar.Where(y => y.Model.ModelAd.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;
                    case "Servisteki Durumuna Göre":
                        Kayitlar = Kayitlar.Where(y => y.ServisDurum.ServisDurumAd.ToLower().Contains(txtAra.Text.ToLower())).ToList();
                        break;

                }


               

            }
            Getir(Kayitlar);


        }

        void Getir(List<Kayit> Kayitlar)
        {
            dgvKayit.DataSource = Kayitlar.Select(y => new { y.Id, y.MusteriAd, y.GelisTarih, y.CihazTur.TurAd, y.Marka.MarkaAd, y.Model.ModelAd, y.SeriNo, y.ServisDurum.ServisDurumAd, y.ToplamUcret }).ToList();

        }





     
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SeciliMarkaId = Convert.ToInt32(cmbMarka.SelectedValue);
            List<Model> Modeller = Db.Model.Where(x => x.MarkaId == SeciliMarkaId).ToList();
            cmbModel.DataSource = Modeller;

        }

        private void cmbSırala_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<VKayit> VKayitlar = Db.Database.SqlQuery<VKayit>("select * from VKayit").ToList();
            if (rbArtarakSırala.Checked == true)
            {

                switch (cmbSırala.Text)
                {
                    case "Geliş Tarihine Göre":
                        dgvKayit.DataSource = VKayitlar
                             .OrderBy(x => x.GelisTarih)
                             .Select(y => new { y.Id, y.GelisTarih, y.MusteriAd, y.CihazTur, y.Marka, y.Model, y.SeriNo, y.Aksesuar, y.ToplamUcret }).ToList();
                        break;
                    case "Müşteri Adına Göre":
                        dgvKayit.DataSource = VKayitlar
                             .OrderBy(x => x.MusteriAd)
                             .Select(y => new { y.Id, y.GelisTarih, y.MusteriAd, y.CihazTur, y.Marka, y.Model, y.SeriNo, y.Aksesuar, y.ToplamUcret }).ToList();
                        break;
                    case "Seri Numarasına Göre":
                        dgvKayit.DataSource = VKayitlar
                             .OrderBy(x => x.SeriNo)
                             .Select(y => new { y.Id, y.GelisTarih, y.MusteriAd, y.CihazTur, y.Marka, y.Model, y.SeriNo, y.Aksesuar, y.ToplamUcret }).ToList();
                        break;
                    

                }
            }

            else
            {

                switch (cmbSırala.Text)
                {
                    case "Geliş Tarihine Göre":
                        dgvKayit.DataSource = VKayitlar
                             .OrderByDescending(x => x.GelisTarih)
                             .Select(y => new { y.Id, y.GelisTarih, y.MusteriAd, y.CihazTur, y.Marka, y.Model, y.SeriNo, y.Aksesuar, y.ToplamUcret }).ToList();
                        break;
                    case "Müşteri Adına Göre":
                        dgvKayit.DataSource = VKayitlar
                             .OrderByDescending(x => x.MusteriAd)
                             .Select(y => new { y.Id, y.GelisTarih, y.MusteriAd, y.CihazTur, y.Marka, y.Model, y.SeriNo, y.Aksesuar, y.ToplamUcret }).ToList();
                        break;
                    case "Seri Numarasına Göre":
                        dgvKayit.DataSource = VKayitlar
                             .OrderByDescending(x => x.SeriNo)
                             .Select(y => new { y.Id, y.GelisTarih, y.MusteriAd, y.CihazTur, y.Marka, y.Model, y.SeriNo, y.Aksesuar, y.ToplamUcret }).ToList();
                        break;
                  
                }


            }


        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SecilmisId = Convert.ToInt32(dgvKayit.CurrentRow.Cells["Id"].Value);
            Kayit k = Db.Kayit.First(a => a.Id == SecilmisId);
            txtMusteriAdı.Text = k.MusteriAd;
            dtpGelisTarih.Value = k.GelisTarih;
            cmbTur.SelectedValue = k.CihazTurId;
            cmbMarka.SelectedValue = k.MarkaId;
            cmbModel.SelectedValue = k.ModelId;
            txtSeriNo.Text = k.SeriNo;
            txtAksesuar.Text = k.Aksesuar;
            cmbServisTur.SelectedValue = k.ServisTurId;
            cmbDurum.SelectedValue = k.ServisDurumId;
            txtToplamUcret.Text = k.ToplamUcret.ToString();


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Dialogresult = MessageBox.Show("Bu kaydı silmek mi istiyorsunuz?", " DİKKAT!  ", MessageBoxButtons.YesNo);
            if (Dialogresult == DialogResult.Yes)
            {
                int SecilmisId = Convert.ToInt32(dgvKayit.CurrentRow.Cells["Id"].Value);
                Db.Kayit.Remove(Db.Kayit.First(f => f.Id == SecilmisId));
                Db.SaveChanges();
                Getir(Db.Kayit.ToList());


            }
        }

      

        private void btnkapat_Click(object sender, EventArgs e)
        {

            FormServisTakip FrmServisTakip = new FormServisTakip();
            FrmServisTakip.Show();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            int SecilmisId = Convert.ToInt32(dgvKayit.CurrentRow.Cells["Id"].Value);
            Kayit k = Db.Kayit.First(a => a.Id == SecilmisId);
            k.MusteriAd = txtMusteriAdı.Text;
            k.GelisTarih = dtpGelisTarih.Value;
            k.CihazTurId = Convert.ToInt32(cmbTur.SelectedValue);
            k.MarkaId = Convert.ToInt32(cmbMarka.SelectedValue);
            k.ModelId = Convert.ToInt32(cmbModel.SelectedValue);
            k.SeriNo = txtSeriNo.Text;
            k.Aksesuar = txtAksesuar.Text;
            k.ServisTurId = Convert.ToInt32(cmbServisTur.SelectedValue);
            k.ServisDurumId = Convert.ToInt32(cmbDurum.SelectedValue);
            k.ToplamUcret = Convert.ToDecimal(txtToplamUcret.Text);
            Db.SaveChanges();

        }
    }
}
