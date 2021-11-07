using ServisTakipEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTakip
{
    public partial class FormKayitDetay : Form
    {
        DBServisTakip Db = new DBServisTakip();

        public FormKayitDetay()
        {
            InitializeComponent();
        }

        private void FormKayitDetay_Load(object sender, EventArgs e)
        {


            Yukle(Db.Kayit.ToList());

        }
        private void dgvKayit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormTeslimatOnarım FrmTeslimatOnarım = new FormTeslimatOnarım();
            int SecilmisId = Convert.ToInt32(dgvKayit.CurrentRow.Cells["Id"].Value);
            Kayit k = Db.Kayit.First(c => c.Id == SecilmisId);
            FrmTeslimatOnarım.labelKayitDetayId.Text = SecilmisId.ToString();
            FrmTeslimatOnarım.txtAd.Text = k.MusteriAd;
            FrmTeslimatOnarım.dtpGelisTarih.Value = k.GelisTarih;
            FrmTeslimatOnarım.txtAdres.Text = k.Adres;
            FrmTeslimatOnarım.txtGsmNo.Text = k.GsmNo;
            FrmTeslimatOnarım.txtTelefonNo.Text = k.TelNo;
            FrmTeslimatOnarım.txtMail.Text = k.Mail;
            FrmTeslimatOnarım.txtKimlikNo.Text = k.TCNo;
            FrmTeslimatOnarım.cmbTur.DataSource = Db.CihazTur.ToList();
            FrmTeslimatOnarım.cmbTur.SelectedValue = k.CihazTurId;
            FrmTeslimatOnarım.cmbMarka.DataSource = Db.Marka.ToList();
            FrmTeslimatOnarım.cmbMarka.SelectedValue = k.MarkaId;
            FrmTeslimatOnarım.cmbModel.SelectedValue = k.ModelId;
            FrmTeslimatOnarım.txtSeriNo.Text = k.SeriNo;
            FrmTeslimatOnarım.dtpFaturaTarih.Value = k.FaturaTarih;
            FrmTeslimatOnarım.cmbSaticiFirma.DataSource = Db.SaticiFirma.ToList();
            FrmTeslimatOnarım.cmbSaticiFirma.SelectedValue = k.SaticiFirmaId;
            FrmTeslimatOnarım.txtTakipNo.Text = k.TakipNo;


            if (k.GarantiBilgiId == 1)
            {
                FrmTeslimatOnarım.cbGarantili.Checked = true;

            }

            if (k.GarantiBilgiId == 2)
            {
                FrmTeslimatOnarım.cbGarantisiz.Checked = true;

            }

            if (k.GarantiBilgiId == 3)
            {
                FrmTeslimatOnarım.cbServisGarantili.Checked = true;

            }



            if (k.DurumId == 1)
            {
                FrmTeslimatOnarım.cbYeniCihaz.Checked = true;

            }

            if (k.DurumId == 2)
            {
                FrmTeslimatOnarım.cbEskiCihaz.Checked = true;

            }

            if (k.DurumId == 3)
            {
                FrmTeslimatOnarım.cbKurcalanmısCihaz.Checked = true;

            }

            if (k.DurumId == 4)
            {
                FrmTeslimatOnarım.cbBilgiYedekle.Checked = true;

            }

            FrmTeslimatOnarım.cmbAriza.DataSource = Db.Ariza.ToList();
            FrmTeslimatOnarım.cmbAriza.SelectedValue = k.ArizaId;
            FrmTeslimatOnarım.txtAksesuar.Text = k.Aksesuar;
            FrmTeslimatOnarım.cmbHasarDısGorunum.DataSource = Db.HasarGorunum.ToList();
            FrmTeslimatOnarım.cmbHasarDısGorunum.SelectedValue = k.HasarGorunumId;
            FrmTeslimatOnarım.cmbIslem.DataSource = Db.Islem.ToList();
            FrmTeslimatOnarım.cmbIslem.SelectedValue = k.IslemId;
            FrmTeslimatOnarım.txtParcaUcret.Text = k.ParcaUcret.ToString();
            FrmTeslimatOnarım.txtIscilikUcret.Text = k.IscılıkUcret.ToString();
            FrmTeslimatOnarım.txtArizaTespitUcret.Text = k.ArizaTespitUcret.ToString();
            FrmTeslimatOnarım.txtNakliyeUcret.Text = k.NakliyeUcret.ToString();
            FrmTeslimatOnarım.txtIskontoUcret.Text = k.IskontoUcret.ToString();
            if (k.ServisTurId == 1)
            {
                FrmTeslimatOnarım.rbNormalServis.Checked = true;
            }
            else
            {
                FrmTeslimatOnarım.rbDısServis.Checked = true;
               
            }
           
            FrmTeslimatOnarım.cmbServisDurum.DataSource = Db.ServisDurum.ToList();
            FrmTeslimatOnarım.cmbServisDurum.SelectedValue = k.ServisDurumId;
            FrmTeslimatOnarım.cmbAciklama.DataSource = Db.Aciklama.ToList();
            FrmTeslimatOnarım.cmbAciklama.SelectedValue = k.AciklamaId;
            FrmTeslimatOnarım.cmbSonuc.DataSource = Db.Sonuc.ToList();
            FrmTeslimatOnarım.cmbSonuc.SelectedValue = k.SonucId;

            if (k.SonucId != 1)
            {
                FrmTeslimatOnarım.dtpBitisTarih.Enabled = false;

            }
            else FrmTeslimatOnarım.dtpBitisTarih.Value = k.BitisTarih;


            if (k.ServisDurumId != 12)
            {
                FrmTeslimatOnarım.dtpTeslimTarih.Enabled = false;


            }

            else FrmTeslimatOnarım.dtpTeslimTarih.Value = k.TeslimTarih;


            FrmTeslimatOnarım.cmbTeslimSekil.DataSource = Db.TeslimSekil.ToList();
            FrmTeslimatOnarım.cmbTeslimSekil.SelectedValue = k.TeslimSekilId;
            FrmTeslimatOnarım.cmbBolge.DataSource = Db.DısServisBolge.ToList();
            FrmTeslimatOnarım.cmbBolge.SelectedValue = k.DısServisBolgeId;
            FrmTeslimatOnarım.dtpDısServisTarih.Value = k.DısServisGidisTarih;
            FrmTeslimatOnarım.txtToplamUcret.Text = k.ToplamUcret.ToString();
            FrmTeslimatOnarım.cmbKargoAd.DataSource = Db.Kargo.ToList();
            FrmTeslimatOnarım.cmbKargoAd.SelectedValue = k.KargoId;
            FrmTeslimatOnarım.Show();
        }

        void Yukle(List<Kayit> Kayitlar)
        {

            dgvKayit.DataSource = Kayitlar.Select(r => new
            {
                r.Id, r.MusteriAd, r.GelisTarih, r.Adres, r.TelNo,
                r.GsmNo, r.Mail,r.TCNo,r.CihazTur.TurAd, r.Marka.MarkaAd,r.Model.ModelAd,r.SeriNo,
                r.FaturaTarih, r.SaticiFirma.SaticiFirmaAd,r.TakipNo, r.GarantiBilgi.GarantiBilgiAd,
                r.Durum.DurumAd, r.Ariza.ArizaAd, r.Aksesuar, r.HasarGorunum.HasarGorunumAd, r.Islem.IslemAd,
                r.ParcaUcret,r.IscılıkUcret, r.ArizaTespitUcret, r.NakliyeUcret,
                r.IskontoUcret, r.ToplamUcret,  r.ServisTur.ServisTurAd, r.DısServisBolge.BolgeAd, r.DısServisGidisTarih,
                r.ServisDurum.ServisDurumAd, r.Aciklama.AciklamaAd,r.Sonuc.SonucAd,r.BitisTarih,
                r.TeslimTarih, r.TeslimSekil.TeslimSekilAd,r.Kargo.KargoAd, r.KargoTakipNo
            }).ToList();


            dgvKayit.Columns["Id"].Visible = false;
            dgvKayit.Columns["MusteriAd"].HeaderText = "MÜŞTERİ ADI";
            dgvKayit.Columns["GelisTarih"].HeaderText = "GELİŞ TARİHİ";
            dgvKayit.Columns["Adres"].HeaderText = "ADRESİ";
            dgvKayit.Columns["TelNo"].HeaderText = "TELEFON NO";
            dgvKayit.Columns["GsmNo"].HeaderText = "GSM NO";
            dgvKayit.Columns["Mail"].HeaderText = "E-MAIL";
            dgvKayit.Columns["TCNO"].HeaderText = "TC NO ";
            dgvKayit.Columns["TurAd"].HeaderText = "CİHAZ TÜRÜ";
            dgvKayit.Columns["MarkaAd"].HeaderText = "MARKA";
            dgvKayit.Columns["ModelAd"].HeaderText = "MODEL";
            dgvKayit.Columns["SeriNo"].HeaderText = "SERİ NO";
            dgvKayit.Columns["FaturaTarih"].Visible = false;
            dgvKayit.Columns["SaticiFirmaAd"].Visible = false;
            dgvKayit.Columns["TakipNo"].Visible = false;
            dgvKayit.Columns["GarantiBilgiAd"].Visible = false;
            dgvKayit.Columns["DurumAd"].Visible = false;
            dgvKayit.Columns["ArizaAd"].HeaderText = "ARIZA";
            dgvKayit.Columns["Aksesuar"].HeaderText = "AKSESUARLAR";
            dgvKayit.Columns["HasarGorunumAd"].HeaderText = "HASAR-GÖRÜNÜM";
            dgvKayit.Columns["IslemAd"].Visible = false;
            dgvKayit.Columns["DurumAd"].Visible = false;
            dgvKayit.Columns["ParcaUcret"].Visible = false;
            dgvKayit.Columns["IscılıkUcret"].Visible = false;
            dgvKayit.Columns["ArizaTespitUcret"].Visible = false;
            dgvKayit.Columns["NakliyeUcret"].Visible = false;
            dgvKayit.Columns["IskontoUcret"].Visible = false;
            dgvKayit.Columns["ToplamUcret"].Visible = false;
            dgvKayit.Columns["ServisTurAd"].Visible = false;
            dgvKayit.Columns["BolgeAd"].Visible = false;
            dgvKayit.Columns["DısServisGidisTarih"].Visible = false;
            dgvKayit.Columns["ServisDurumAd"].HeaderText = "SERVİSTEKİ DURUMU";
            dgvKayit.Columns["AciklamaAd"].HeaderText = "AÇIKLAMA";
            dgvKayit.Columns["SonucAd"].Visible = false;
            dgvKayit.Columns["ServisDurumAd"].HeaderText = "SERVİSTEKİ DURUMU";
            dgvKayit.Columns["BitisTarih"].Visible = false;
            dgvKayit.Columns["TeslimTarih"].Visible = false;
            dgvKayit.Columns["KargoTakipNo"].Visible = false;
            dgvKayit.Columns["TeslimSekilAd"].Visible = false;
            dgvKayit.Columns["KargoAd"].Visible = false;


        }
    }
    }





