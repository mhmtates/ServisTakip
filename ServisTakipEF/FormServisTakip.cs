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
    public partial class FormServisTakip : Form
    {
        public FormServisTakip()
        {
            InitializeComponent();
        }

        private void cihazKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCihazKayit FrmCihazKayit = new FormCihazKayit();
            FrmCihazKayit.Show();

        }

        private void cihazSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCihazSorgu FrmCihazSorgu = new FormCihazSorgu();
            FrmCihazSorgu.Show();

        }

        private void detaylıKayıtBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKayitDetay FrmKayitDetay = new FormKayitDetay();
            FrmKayitDetay.Show();
        }

    }

}