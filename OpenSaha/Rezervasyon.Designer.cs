namespace OpenSaha
{
    partial class Rezervasyon
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSahaIsmi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKullaniciAdi = new System.Windows.Forms.ComboBox();
            this.cmbEslesme = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpbRezervasyonOlustur = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezervasyonuİptalEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniRezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRezervasyonOlustur = new System.Windows.Forms.Button();
            this.rbOnay = new System.Windows.Forms.RadioButton();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbRezervasyonOlustur.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saha İsmi:";
            // 
            // cmbSahaIsmi
            // 
            this.cmbSahaIsmi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahaIsmi.FormattingEnabled = true;
            this.cmbSahaIsmi.Location = new System.Drawing.Point(129, 19);
            this.cmbSahaIsmi.Name = "cmbSahaIsmi";
            this.cmbSahaIsmi.Size = new System.Drawing.Size(243, 28);
            this.cmbSahaIsmi.TabIndex = 0;
            this.cmbSahaIsmi.SelectedIndexChanged += new System.EventHandler(this.cmbSahaIsmi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // cmbKullaniciAdi
            // 
            this.cmbKullaniciAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbKullaniciAdi.FormattingEnabled = true;
            this.cmbKullaniciAdi.Location = new System.Drawing.Point(129, 57);
            this.cmbKullaniciAdi.Name = "cmbKullaniciAdi";
            this.cmbKullaniciAdi.Size = new System.Drawing.Size(243, 28);
            this.cmbKullaniciAdi.TabIndex = 1;
            // 
            // cmbEslesme
            // 
            this.cmbEslesme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEslesme.FormattingEnabled = true;
            this.cmbEslesme.Location = new System.Drawing.Point(129, 95);
            this.cmbEslesme.Name = "cmbEslesme";
            this.cmbEslesme.Size = new System.Drawing.Size(243, 28);
            this.cmbEslesme.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Eşleşme:";
            // 
            // grpbRezervasyonOlustur
            // 
            this.grpbRezervasyonOlustur.Controls.Add(this.rbOnay);
            this.grpbRezervasyonOlustur.Controls.Add(this.label3);
            this.grpbRezervasyonOlustur.Controls.Add(this.btnRezervasyonOlustur);
            this.grpbRezervasyonOlustur.Controls.Add(this.label1);
            this.grpbRezervasyonOlustur.Controls.Add(this.label2);
            this.grpbRezervasyonOlustur.Controls.Add(this.dtpBaslangic);
            this.grpbRezervasyonOlustur.Controls.Add(this.dtpBitis);
            this.grpbRezervasyonOlustur.Controls.Add(this.cmbSahaIsmi);
            this.grpbRezervasyonOlustur.Controls.Add(this.label4);
            this.grpbRezervasyonOlustur.Controls.Add(this.cmbKullaniciAdi);
            this.grpbRezervasyonOlustur.Controls.Add(this.label5);
            this.grpbRezervasyonOlustur.Controls.Add(this.cmbEslesme);
            this.grpbRezervasyonOlustur.Location = new System.Drawing.Point(24, 12);
            this.grpbRezervasyonOlustur.Name = "grpbRezervasyonOlustur";
            this.grpbRezervasyonOlustur.Size = new System.Drawing.Size(985, 144);
            this.grpbRezervasyonOlustur.TabIndex = 26;
            this.grpbRezervasyonOlustur.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonuİptalEtToolStripMenuItem,
            this.yeniRezervasyonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 52);
            // 
            // rezervasyonuİptalEtToolStripMenuItem
            // 
            this.rezervasyonuİptalEtToolStripMenuItem.Name = "rezervasyonuİptalEtToolStripMenuItem";
            this.rezervasyonuİptalEtToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.rezervasyonuİptalEtToolStripMenuItem.Text = "Rezervasyonu iptal et...";
            // 
            // yeniRezervasyonToolStripMenuItem
            // 
            this.yeniRezervasyonToolStripMenuItem.Name = "yeniRezervasyonToolStripMenuItem";
            this.yeniRezervasyonToolStripMenuItem.Size = new System.Drawing.Size(228, 24);
            this.yeniRezervasyonToolStripMenuItem.Text = "Yeni rezervasyon";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 162);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(985, 531);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // btnRezervasyonOlustur
            // 
            this.btnRezervasyonOlustur.ForeColor = System.Drawing.Color.Black;
            this.btnRezervasyonOlustur.Location = new System.Drawing.Point(781, 24);
            this.btnRezervasyonOlustur.Name = "btnRezervasyonOlustur";
            this.btnRezervasyonOlustur.Size = new System.Drawing.Size(196, 40);
            this.btnRezervasyonOlustur.TabIndex = 8;
            this.btnRezervasyonOlustur.Text = "Rezervasyon Oluştur";
            this.btnRezervasyonOlustur.UseVisualStyleBackColor = true;
            // 
            // rbOnay
            // 
            this.rbOnay.AutoSize = true;
            this.rbOnay.Location = new System.Drawing.Point(837, 70);
            this.rbOnay.Name = "rbOnay";
            this.rbOnay.Size = new System.Drawing.Size(86, 24);
            this.rbOnay.TabIndex = 28;
            this.rbOnay.TabStop = true;
            this.rbOnay.Text = "Onayla";
            this.rbOnay.UseVisualStyleBackColor = true;
            // 
            // dtpBitis
            // 
            this.dtpBitis.CustomFormat = "yyyy-MM-dd";
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBitis.Location = new System.Drawing.Point(528, 54);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(244, 28);
            this.dtpBitis.TabIndex = 3;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CustomFormat = "yyyy-MM-dd";
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBaslangic.Location = new System.Drawing.Point(528, 16);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(244, 28);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bitiş Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi:";
            // 
            // Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1030, 709);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grpbRezervasyonOlustur);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Rezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.Rezervasyon_Load);
            this.grpbRezervasyonOlustur.ResumeLayout(false);
            this.grpbRezervasyonOlustur.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSahaIsmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKullaniciAdi;
        private System.Windows.Forms.ComboBox cmbEslesme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpbRezervasyonOlustur;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonuİptalEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniRezervasyonToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbOnay;
        private System.Windows.Forms.Button btnRezervasyonOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
    }
}