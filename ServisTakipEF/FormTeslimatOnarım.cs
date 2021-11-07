using ServisTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakipEF
{

    public partial class FormTeslimatOnarım : Form
    {
        DBServisTakip Database = new DBServisTakip();

        public FormTeslimatOnarım()
        {
            InitializeComponent();
        }


        void Kaydet()
        {

            FormKayitDetay FrmKayitDetay = new FormKayitDetay();

            Kayit yeniKayit = new Kayit();

            yeniKayit.MusteriAd = txtAd.Text;
            yeniKayit.Adres = txtAdres.Text;
            yeniKayit.TelNo = txtTelefonNo.Text;
            yeniKayit.GsmNo = txtGsmNo.Text;
            yeniKayit.Mail = txtMail.Text;
            yeniKayit.TCNo = txtKimlikNo.Text;
            yeniKayit.CihazTurId = Convert.ToInt32(cmbTur.SelectedValue);
            yeniKayit.MarkaId = Convert.ToInt32(cmbMarka.SelectedValue);
            yeniKayit.ModelId = Convert.ToInt32(cmbModel.SelectedValue);
            yeniKayit.SeriNo = txtSeriNo.Text;
            yeniKayit.FaturaTarih = dtpFaturaTarih.Value;
            yeniKayit.SaticiFirmaId = Convert.ToInt32(cmbSaticiFirma.SelectedValue);
            yeniKayit.TakipNo = txtTakipNo.Text;
            if (cbGarantili.Checked == true)
            {
                gbGarantiBilgi.Text = labelGarantili.Text;
                yeniKayit.GarantiBilgiId = 1;
            }
            else if (cbGarantisiz.Checked == true)
            {
                gbGarantiBilgi.Text = labelGarantisiz.Text;
                yeniKayit.GarantiBilgiId = 2;
            }
            else
            {
                gbGarantiBilgi.Text = labelServisGarantili.Text;
                yeniKayit.GarantiBilgiId = 3;
            }

            if (cbYeniCihaz.Checked == true)
            {
               gbDurum.Text = labelYeniCihaz.Text;
                yeniKayit.DurumId = 1;
            }
            else if (cbEskiCihaz.Checked == true)
            {
                gbDurum.Text = labelEskiCihaz.Text;
                yeniKayit.DurumId = 2;
            }
            else if (cbKurcalanmısCihaz.Checked == true)
            {
                gbDurum.Text = labelKurcalanmıs.Text;
                yeniKayit.DurumId = 3;
            }

            else
            {

                gbDurum.Text = labelBilgilerYedeklensin.Text;
                yeniKayit.DurumId = 4;
            }

            yeniKayit.ArizaId = Convert.ToInt32(cmbAriza.SelectedValue);
            yeniKayit.Aksesuar = txtAksesuar.Text;
            yeniKayit.HasarGorunumId = Convert.ToInt32(cmbHasarDısGorunum.SelectedValue);
            yeniKayit.ParcaUcret = Convert.ToDecimal(txtParcaUcret.Text);
            yeniKayit.IscılıkUcret = Convert.ToDecimal(txtIscilikUcret.Text);
            yeniKayit.ArizaTespitUcret = Convert.ToDecimal(txtArizaTespitUcret.Text);
            yeniKayit.NakliyeUcret = Convert.ToDecimal(txtNakliyeUcret.Text);
            yeniKayit.IskontoUcret = Convert.ToDecimal(txtIskontoUcret.Text);
            yeniKayit.ToplamUcret = Convert.ToDecimal(txtParcaUcret.Text)
                                   + Convert.ToDecimal(txtIscilikUcret.Text)
                                   + Convert.ToDecimal(txtArizaTespitUcret.Text)
                                   + Convert.ToDecimal(txtNakliyeUcret.Text) 
                                   - Convert.ToDecimal(txtIskontoUcret.Text);
            yeniKayit.ServisTurId = (rbNormalServis.Checked == true) ? 1 : 2;
            yeniKayit.DısServisBolgeId = Convert.ToInt32(cmbBolge.SelectedValue);
            yeniKayit.DısServisGidisTarih = dtpDısServisTarih.Value;
            yeniKayit.GelisTarih = dtpGelisTarih.Value;
            yeniKayit.IslemId = Convert.ToInt32(cmbIslem.SelectedValue);
            yeniKayit.AciklamaId = Convert.ToInt32(cmbAciklama.SelectedValue);
            yeniKayit.ServisDurumId = Convert.ToInt32(cmbServisDurum.SelectedValue);
            yeniKayit.SonucId = Convert.ToInt32(cmbSonuc.SelectedValue);
            yeniKayit.BitisTarih = dtpBitisTarih.Value;
            yeniKayit.TeslimTarih = dtpTeslimTarih.Value;
            yeniKayit.TeslimSekilId = Convert.ToInt32(cmbTeslimSekil.SelectedValue);
            yeniKayit.KargoId = Convert.ToInt32(cmbKargoAd.SelectedValue);
            yeniKayit.KargoTakipNo = txtKargoTakipNo.Text;
            
            Database.Kayit.Add(yeniKayit);
            Database.SaveChanges();


            FrmKayitDetay.dgvKayit.DataSource = null;
            FrmKayitDetay.dgvKayit.DataSource = Database.Kayit.ToList();
            MessageBox.Show("SAYIN" + ' ' + txtAd.Text + "," + ' ' +
                  cmbMarka.Text + ' ' + cmbModel.Text +
                 ' ' + "ADLI CİHAZINIZIN SERVİSİMİZE KAYDI ALINMIŞTIR." + ' '
                  + "ONARIMI EN KISA ZAMANDA GERÇEKLEŞTİRİLİP TARAFINIZA TESLİM EDİLECEKTİR."
                                , "OTOMATİK SMS-SERVİS BİLGİLENDİRME", MessageBoxButtons.OK);


            FrmKayitDetay.Show();



        }

        private void FormTeslimatOnarım_Load(object sender, EventArgs e)
        {
           
            cmbBolge.Enabled = false;
            cmbKargoAd.Enabled = false;
            txtKargoTakipNo.Enabled = false;
           
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();



        }
       

        

    
        

        private void cbKargo_CheckedChanged(object sender, EventArgs e)
        {
            cmbKargoAd.Enabled = true;
            txtKargoTakipNo.Enabled = true;

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliMarkaId = Convert.ToInt32(cmbMarka.SelectedValue);
            List<Model> Modeller = Database.Model.Where(x => x.MarkaId == seciliMarkaId).ToList();
            if (Modeller.Any()) cmbModel.DataSource = Modeller;
            else cmbModel.DataSource = (new List<Model> { new Model { Id = 0, ModelAd = "Model Bulunamadı" } }).ToList();
        }




        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormKayitDetay FrmKayitDetay = new FormKayitDetay();
            FrmKayitDetay.Show();

        }

        private void rbNormalServis_CheckedChanged(object sender, EventArgs e)
        {
            cmbBolge.Enabled = false;
            dtpDısServisTarih.Enabled = false;
        }

        private void rbDısServis_CheckedChanged(object sender, EventArgs e)
        {
            cmbBolge.Enabled = true;
            dtpDısServisTarih.Enabled = true;
        }


        void Yukle(List<Kayit> Kayitlar)
        {
            FormKayitDetay frmKayitDetay = new FormKayitDetay();
            frmKayitDetay.dgvKayit.DataSource = Kayitlar.Select(r => new
            { r.Id,r.MusteriAd,r.GelisTarih,r.Adres, r.TelNo,r.GsmNo, r.Mail,
             r.CihazTur.TurAd,r.Marka.MarkaAd, r.Model.ModelAd, r.SeriNo,
             r.FaturaTarih,r.SaticiFirma.SaticiFirmaAd,r.TakipNo, r.GarantiBilgi.GarantiBilgiAd,
             r.Durum.DurumAd, r.Ariza.ArizaAd, r.Aksesuar, r.HasarGorunum.HasarGorunumAd,r.Islem.IslemAd,
             r.ParcaUcret, r.IscılıkUcret, r.ArizaTespitUcret, r.IskontoUcret,
             r.ToplamUcret,r.ServisTur.ServisTurAd,r.DısServisBolge.BolgeAd, r.DısServisGidisTarih,
             r.ServisDurum.ServisDurumAd, r.Aciklama.AciklamaAd,r.Sonuc.SonucAd, r.BitisTarih, r.TeslimTarih,
             r.TeslimSekil.TeslimSekilAd,r.Kargo.KargoAd,r.KargoTakipNo }).ToList();
            frmKayitDetay.Show();

        }
            private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult Dialogresult = MessageBox.Show("Bu kaydı silmek mi istiyorsunuz?", " DİKKAT!  ", MessageBoxButtons.YesNo);
            if (Dialogresult == DialogResult.Yes)
            {
                FormKayitDetay FrmKayitDetay = new FormKayitDetay();
                int SecilmisId = Convert.ToInt32(labelKayitDetayId.Text);
                Database.Kayit.Remove(Database.Kayit.First(f => f.Id == SecilmisId));
                Database.SaveChanges();
                Yukle(Database.Kayit.ToList());
                this.Close();
                FrmKayitDetay.Show();

            }
        }
    }

     
}

