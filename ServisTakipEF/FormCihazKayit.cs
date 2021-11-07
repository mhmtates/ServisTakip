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
    public partial class FormCihazKayit : Form
    {
        public FormCihazKayit()
        {
            InitializeComponent();
        }

        DBServisTakip Database = new DBServisTakip();


        void Kaydet()
        {
            FormCihazSorgu FrmCihazSorgu = new FormCihazSorgu();

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
                labelGarantiBilgi.Text = labelGarantili.Text;
                yeniKayit.GarantiBilgiId = 1;
            }
            else if (cbGarantisiz.Checked == true)
            {
                labelGarantiBilgi.Text = labelGarantisiz.Text;
                yeniKayit.GarantiBilgiId = 2;
            }
            else
            {
                labelGarantiBilgi.Text = labelServisGarantili.Text;
                yeniKayit.GarantiBilgiId =3;
            }

            if (cbYeniCihaz.Checked == true)
            {
                labelGenelDurum.Text = labelYeniCihaz.Text;
                yeniKayit.DurumId = 1;
            }
            else if (cbEskiCihaz.Checked == true)
            {
                labelGenelDurum.Text = labelEskiCihaz.Text;
                yeniKayit.DurumId = 2;
            }
            else if (cbKurcalanmısCihaz.Checked == true)
            {
                labelGenelDurum.Text = labelKurcalanmısCihaz.Text;
                yeniKayit.DurumId = 3;
            }

            else
            {

                labelGenelDurum.Text = labelBilgilerYedeklensin.Text;
                yeniKayit.DurumId = 4;
            }

            yeniKayit.ArizaId = Convert.ToInt32(cmbAriza.SelectedValue);
            yeniKayit.Aksesuar = txtAksesuar.Text;
            yeniKayit.HasarGorunumId = Convert.ToInt32(cmbHasarDısGorunum.SelectedValue);
            yeniKayit.ToplamUcret = Convert.ToDecimal(txtToplamUcret.Text);
            yeniKayit.ServisTurId = rbNormalServis.Checked == true ? 1 : 2;
            yeniKayit.GelisTarih = dtpGelisTarih.Value;
            //yeniKayit.KargoId = Convert.ToInt32(cmbKargoAd.SelectedValue);
            yeniKayit.KargoTakipNo = txtKargoTakipNo.Text;
            
            Database.Kayit.Add(yeniKayit);
            Database.SaveChanges();
          

            FrmCihazSorgu.dgvKayit.DataSource = null;
            FrmCihazSorgu.dgvKayit.DataSource = Database.Database.SqlQuery<VKayit>("select * from VKayit").ToList();
           

            MessageBox.Show("SAYIN" +' '+txtAd.Text + "," + ' '+
                  cmbMarka.Text + ' ' + 
                  cmbModel.Text + ' '+ "ADLI CİHAZINIZIN SERVİSİMİZE KAYDI ALINMIŞTIR." + ' '
                  + "ONARIMI EN KISA ZAMANDA GERÇEKLEŞTİRİLİP TARAFINIZA TESLİM EDİLECEKTİR."
                                , "OTOMATİK SMS-SERVİS BİLGİLENDİRME", MessageBoxButtons.OK);


            FrmCihazSorgu.Show();

        }


        private void FormCihazKayit_Load(object sender, EventArgs e)
        {
           
            cmbTur.DataSource = Database.CihazTur.ToList();
            cmbMarka.DataSource = Database.Marka.ToList();
            cmbSaticiFirma.DataSource = Database.SaticiFirma.ToList();
            cmbAriza.DataSource = Database.Ariza.ToList();
            cmbHasarDısGorunum.DataSource = Database.HasarGorunum.ToList();
            cmbBolge.DataSource = Database.DısServisBolge.ToList();
            labelKargoAdı.Enabled = false;
            cmbKargoAd.Enabled = false;
            labelKargoTakipNo.Enabled = false;
            txtKargoTakipNo.Enabled = false;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
            Kaydet();


        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            FormMusteri Musteriler = new FormMusteri();
            Musteriler.Show();

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seciliMarkaId = Convert.ToInt32(cmbMarka.SelectedValue);
            List<Model> Modeller = Database.Model.Where(x => x.MarkaId == seciliMarkaId).ToList();
            if (Modeller.Any()) cmbModel.DataSource = Modeller;
            else cmbModel.DataSource = (new List<Model> { new Model { Id = 0, ModelAd = "Model Bulunamadı" } }).ToList();
        }







       

        private void rbNormalServis_CheckedChanged(object sender, EventArgs e)
        {
            cmbBolge.Enabled = false;
            labelDısServisBolge.Enabled = false;
        }

        private void rbDısServis_CheckedChanged(object sender, EventArgs e)
        {
            cmbBolge.Enabled = true;
            labelDısServisBolge.Enabled = true;

        }

        private void cbKargo_CheckedChanged(object sender, EventArgs e)
        {
            labelKargoAdı.Enabled = true;
            cmbKargoAd.Enabled = true;
            labelKargoTakipNo.Enabled = true;
            txtKargoTakipNo.Enabled = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            FormServisTakip frmServisTakip = new FormServisTakip();
            frmServisTakip.Show();

        }
    }

}
   



