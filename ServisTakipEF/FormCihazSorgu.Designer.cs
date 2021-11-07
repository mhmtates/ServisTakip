namespace ServisTakipEF
{
    partial class FormCihazSorgu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbSırala = new System.Windows.Forms.ComboBox();
            this.rbArtarakSırala = new System.Windows.Forms.RadioButton();
            this.label35 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAzalarakSırala = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnkapat = new System.Windows.Forms.Button();
            this.dgvKayit = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbAra = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAksesuar = new System.Windows.Forms.TextBox();
            this.txtToplamUcret = new System.Windows.Forms.TextBox();
            this.cmbServisTur = new System.Windows.Forms.ComboBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtMusteriAdı = new System.Windows.Forms.TextBox();
            this.dtpGelisTarih = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayit)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSırala
            // 
            this.cmbSırala.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbSırala.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSırala.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbSırala.FormattingEnabled = true;
            this.cmbSırala.Items.AddRange(new object[] {
            "Geliş Tarihine Göre",
            "Müşteri Adına Göre",
            "Seri Numarasına Göre"});
            this.cmbSırala.Location = new System.Drawing.Point(516, 86);
            this.cmbSırala.Name = "cmbSırala";
            this.cmbSırala.Size = new System.Drawing.Size(203, 24);
            this.cmbSırala.TabIndex = 0;
            this.cmbSırala.SelectedIndexChanged += new System.EventHandler(this.cmbSırala_SelectedIndexChanged);
            // 
            // rbArtarakSırala
            // 
            this.rbArtarakSırala.AutoSize = true;
            this.rbArtarakSırala.Location = new System.Drawing.Point(493, 40);
            this.rbArtarakSırala.Name = "rbArtarakSırala";
            this.rbArtarakSırala.Size = new System.Drawing.Size(14, 13);
            this.rbArtarakSırala.TabIndex = 10;
            this.rbArtarakSırala.TabStop = true;
            this.rbArtarakSırala.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label35.Location = new System.Drawing.Point(513, 40);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(146, 16);
            this.label35.TabIndex = 11;
            this.label35.Text = "Artan Şekilde Sırala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(476, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 11;
            // 
            // rbAzalarakSırala
            // 
            this.rbAzalarakSırala.AutoSize = true;
            this.rbAzalarakSırala.Location = new System.Drawing.Point(706, 41);
            this.rbAzalarakSırala.Name = "rbAzalarakSırala";
            this.rbAzalarakSırala.Size = new System.Drawing.Size(14, 13);
            this.rbAzalarakSırala.TabIndex = 10;
            this.rbAzalarakSırala.TabStop = true;
            this.rbAzalarakSırala.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(726, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Azalan Şekilde Sırala";
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAra.Location = new System.Drawing.Point(517, 126);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(203, 22);
            this.txtAra.TabIndex = 13;
            this.txtAra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnkapat
            // 
            this.btnkapat.BackColor = System.Drawing.Color.Lavender;
            this.btnkapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapat.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnkapat.ImageIndex = 0;
            this.btnkapat.Location = new System.Drawing.Point(777, 185);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(73, 46);
            this.btnkapat.TabIndex = 15;
            this.btnkapat.Text = " KAPAT";
            this.btnkapat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnkapat.UseVisualStyleBackColor = false;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // dgvKayit
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvKayit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKayit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKayit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKayit.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvKayit.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvKayit.Location = new System.Drawing.Point(506, 292);
            this.dgvKayit.Name = "dgvKayit";
            this.dgvKayit.ReadOnly = true;
            this.dgvKayit.RowHeadersWidth = 46;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvKayit.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKayit.Size = new System.Drawing.Size(766, 180);
            this.dgvKayit.TabIndex = 16;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // cmbAra
            // 
            this.cmbAra.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbAra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbAra.FormattingEnabled = true;
            this.cmbAra.Items.AddRange(new object[] {
            "Müşteri Adına Göre",
            "Cihaz Türüne Göre",
            "Markaya Göre",
            "Modele Göre",
            "Servisteki Durumuna Göre"});
            this.cmbAra.Location = new System.Drawing.Point(788, 126);
            this.cmbAra.Name = "cmbAra";
            this.cmbAra.Size = new System.Drawing.Size(208, 24);
            this.cmbAra.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.txtAksesuar);
            this.groupBox1.Controls.Add(this.txtToplamUcret);
            this.groupBox1.Controls.Add(this.cmbServisTur);
            this.groupBox1.Controls.Add(this.cmbDurum);
            this.groupBox1.Controls.Add(this.txtSeriNo);
            this.groupBox1.Controls.Add(this.cmbModel);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.cmbTur);
            this.groupBox1.Controls.Add(this.txtMusteriAdı);
            this.groupBox1.Controls.Add(this.dtpGelisTarih);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 486);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt Bilgileri";
            // 
            // txtAksesuar
            // 
            this.txtAksesuar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtAksesuar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAksesuar.Location = new System.Drawing.Point(210, 265);
            this.txtAksesuar.Multiline = true;
            this.txtAksesuar.Name = "txtAksesuar";
            this.txtAksesuar.Size = new System.Drawing.Size(225, 40);
            this.txtAksesuar.TabIndex = 58;
            this.txtAksesuar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamUcret
            // 
            this.txtToplamUcret.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamUcret.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtToplamUcret.Location = new System.Drawing.Point(210, 436);
            this.txtToplamUcret.Name = "txtToplamUcret";
            this.txtToplamUcret.Size = new System.Drawing.Size(221, 21);
            this.txtToplamUcret.TabIndex = 57;
            this.txtToplamUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbServisTur
            // 
            this.cmbServisTur.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbServisTur.DisplayMember = "ServisTurAd";
            this.cmbServisTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbServisTur.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbServisTur.FormattingEnabled = true;
            this.cmbServisTur.Items.AddRange(new object[] {
            "NORMAL SERVİS ",
            "DIŞ SERVİS"});
            this.cmbServisTur.Location = new System.Drawing.Point(211, 352);
            this.cmbServisTur.Name = "cmbServisTur";
            this.cmbServisTur.Size = new System.Drawing.Size(225, 21);
            this.cmbServisTur.TabIndex = 56;
            this.cmbServisTur.ValueMember = "Id";
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbDurum.DisplayMember = "ServisDurumAd";
            this.cmbDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDurum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "TEKNİK SERVİSTE",
            "ONARIMI YAPILIYOR",
            "PARÇA BEKLİYOR",
            "SERVİSİNE GÖNDERİLDİ",
            "ÜCRET BİLDİRİLECEK",
            "ONAY BEKLİYOR",
            "ONAY VERİLDİ",
            "DIŞ SERVİS YAPILACAK",
            "İADE EDİLECEK",
            "ÖDEME BEKLİYOR",
            "TESLİM EDİLECEK",
            "TAMAMLANDI"});
            this.cmbDurum.Location = new System.Drawing.Point(211, 394);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(225, 21);
            this.cmbDurum.TabIndex = 56;
            this.cmbDurum.ValueMember = "Id";
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtSeriNo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSeriNo.Location = new System.Drawing.Point(211, 216);
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(220, 22);
            this.txtSeriNo.TabIndex = 8;
            this.txtSeriNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbModel
            // 
            this.cmbModel.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbModel.DisplayMember = "ModelAd";
            this.cmbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbModel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Items.AddRange(new object[] {
            "ACER",
            "APPLE",
            "ASUS",
            "BLUE HOUSE",
            "CANON",
            "CASPER",
            "DELL",
            "FANTOM ",
            "FUJIFILM",
            "HP",
            "KENWOOD",
            "KING",
            "KODAK",
            "LENOVO",
            "LG",
            "NEXT NEXTSTAR",
            "NIKON",
            "NOKIA",
            "PACKARD BELL",
            "PANASONIC",
            "PHILIPS",
            "PIONEER",
            "PREMIER",
            "ROADSTAR",
            "SAMSUNG",
            "SIEMENS",
            "SONY",
            "SUNNY",
            "TOSHIBA",
            "VESTEL"});
            this.cmbModel.Location = new System.Drawing.Point(211, 182);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(220, 21);
            this.cmbModel.TabIndex = 7;
            this.cmbModel.ValueMember = "Id";
            // 
            // cmbMarka
            // 
            this.cmbMarka.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbMarka.DisplayMember = "MarkaAd";
            this.cmbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbMarka.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Items.AddRange(new object[] {
            "ACER",
            "APPLE",
            "ASUS",
            "BLUE HOUSE",
            "CANON",
            "CASPER",
            "DELL",
            "FANTOM ",
            "FUJIFILM",
            "HP",
            "KENWOOD",
            "KING",
            "KODAK",
            "LENOVO",
            "LG",
            "NEXT NEXTSTAR",
            "NIKON",
            "NOKIA",
            "PACKARD BELL",
            "PANASONIC",
            "PHILIPS",
            "PIONEER",
            "PREMIER",
            "ROADSTAR",
            "SAMSUNG",
            "SIEMENS",
            "SONY",
            "SUNNY",
            "TOSHIBA",
            "VESTEL"});
            this.cmbMarka.Location = new System.Drawing.Point(211, 145);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(215, 21);
            this.cmbMarka.TabIndex = 7;
            this.cmbMarka.ValueMember = "Id";
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbTur.DisplayMember = "TurAd";
            this.cmbTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTur.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "      BİLGİSAYAR",
            "     CEP TELEFONU",
            "      KAMERA",
            "      LCD TV",
            "     NOTEBOOK",
            "     PLAZMA",
            "     TABLET",
            "      YAZICI"});
            this.cmbTur.Location = new System.Drawing.Point(211, 105);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(215, 21);
            this.cmbTur.TabIndex = 6;
            this.cmbTur.ValueMember = "Id";
            // 
            // txtMusteriAdı
            // 
            this.txtMusteriAdı.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtMusteriAdı.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMusteriAdı.Location = new System.Drawing.Point(215, 30);
            this.txtMusteriAdı.Name = "txtMusteriAdı";
            this.txtMusteriAdı.Size = new System.Drawing.Size(205, 22);
            this.txtMusteriAdı.TabIndex = 3;
            this.txtMusteriAdı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpGelisTarih
            // 
            this.dtpGelisTarih.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpGelisTarih.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dtpGelisTarih.Location = new System.Drawing.Point(215, 67);
            this.dtpGelisTarih.Name = "dtpGelisTarih";
            this.dtpGelisTarih.Size = new System.Drawing.Size(210, 22);
            this.dtpGelisTarih.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(11, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Toplam Ücret";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(11, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Servis Türü";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(6, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Servisteki Durumu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(11, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = " Aksesuar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(13, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Seri No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(14, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Model";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(13, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cihaz Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(13, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Müşteri Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Geliş Tarihi";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Lavender;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGuncelle.ImageIndex = 0;
            this.btnGuncelle.Location = new System.Drawing.Point(627, 183);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 48);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "KAYIT GÜNCELLE";
            this.btnGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Lavender;
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnGoster.ImageIndex = 0;
            this.btnGoster.Location = new System.Drawing.Point(493, 187);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(111, 44);
            this.btnGoster.TabIndex = 15;
            this.btnGoster.Text = "KAYIT GÖSTER";
            this.btnGoster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // FormCihazSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1284, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKayit);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.rbAzalarakSırala);
            this.Controls.Add(this.rbArtarakSırala);
            this.Controls.Add(this.cmbAra);
            this.Controls.Add(this.cmbSırala);
            this.Name = "FormCihazSorgu";
            this.Text = "Cihaz Sorgusu";
            this.Load += new System.EventHandler(this.FormCihazSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayit)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSırala;
        private System.Windows.Forms.RadioButton rbArtarakSırala;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAzalarakSırala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.ComboBox cmbAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpGelisTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriAdı;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.TextBox txtToplamUcret;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.DataGridView dgvKayit;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtAksesuar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbServisTur;
        private System.Windows.Forms.Label label13;
    }
}