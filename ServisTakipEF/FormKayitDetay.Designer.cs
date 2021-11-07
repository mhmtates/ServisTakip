namespace ServisTakip
{
    partial class FormKayitDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvKayit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayit)).BeginInit();
            this.SuspendLayout();
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
            this.dgvKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKayit.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvKayit.Location = new System.Drawing.Point(0, 0);
            this.dgvKayit.Name = "dgvKayit";
            this.dgvKayit.ReadOnly = true;
            this.dgvKayit.RowHeadersWidth = 46;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvKayit.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKayit.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvKayit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKayit.Size = new System.Drawing.Size(1334, 517);
            this.dgvKayit.TabIndex = 17;
            this.dgvKayit.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKayit_CellContentDoubleClick);
            // 
            // FormKayitDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 517);
            this.Controls.Add(this.dgvKayit);
            this.Name = "FormKayitDetay";
            this.Text = "Detaylı Kayıt Bilgileri";
            this.Load += new System.EventHandler(this.FormKayitDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvKayit;
    }
}