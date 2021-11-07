namespace ServisTakipEF
{
    partial class FormServisTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServisTakip));
            this.cihazKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cihazSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.detaylıKayıtBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cihazKayıtToolStripMenuItem
            // 
            this.cihazKayıtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cihazKayıtToolStripMenuItem.Name = "cihazKayıtToolStripMenuItem";
            this.cihazKayıtToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.cihazKayıtToolStripMenuItem.Text = "Cihaz Kayıt";
            this.cihazKayıtToolStripMenuItem.Click += new System.EventHandler(this.cihazKayıtToolStripMenuItem_Click);
            // 
            // cihazSorgulaToolStripMenuItem
            // 
            this.cihazSorgulaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cihazSorgulaToolStripMenuItem.Name = "cihazSorgulaToolStripMenuItem";
            this.cihazSorgulaToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.cihazSorgulaToolStripMenuItem.Text = "Cihaz Sorgula";
            this.cihazSorgulaToolStripMenuItem.Click += new System.EventHandler(this.cihazSorgulaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cihazKayıtToolStripMenuItem,
            this.cihazSorgulaToolStripMenuItem,
            this.detaylıKayıtBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1299, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip3";
            // 
            // detaylıKayıtBilgileriToolStripMenuItem
            // 
            this.detaylıKayıtBilgileriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.detaylıKayıtBilgileriToolStripMenuItem.Name = "detaylıKayıtBilgileriToolStripMenuItem";
            this.detaylıKayıtBilgileriToolStripMenuItem.Size = new System.Drawing.Size(151, 21);
            this.detaylıKayıtBilgileriToolStripMenuItem.Text = "Detaylı Kayıt Bilgileri";
            this.detaylıKayıtBilgileriToolStripMenuItem.Click += new System.EventHandler(this.detaylıKayıtBilgileriToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(270, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Servis Takip Plus";
            // 
            // FormServisTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormServisTakip";
            this.Text = "Servis Takip Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem cihazKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cihazSorgulaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem detaylıKayıtBilgileriToolStripMenuItem;
    }
}