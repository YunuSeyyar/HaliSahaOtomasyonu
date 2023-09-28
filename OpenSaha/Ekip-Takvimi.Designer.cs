namespace OpenSaha
{
    partial class Ekip_Takvimi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekibiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniEkipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTarihBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTarihBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEkip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSaha = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(17, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 389);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekibiSilToolStripMenuItem,
            this.yeniEkipToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 52);
            // 
            // ekibiSilToolStripMenuItem
            // 
            this.ekibiSilToolStripMenuItem.Name = "ekibiSilToolStripMenuItem";
            this.ekibiSilToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.ekibiSilToolStripMenuItem.Text = "Ekibi sil";
            this.ekibiSilToolStripMenuItem.Click += new System.EventHandler(this.ekibiSilToolStripMenuItem_Click);
            // 
            // yeniEkipToolStripMenuItem
            // 
            this.yeniEkipToolStripMenuItem.Name = "yeniEkipToolStripMenuItem";
            this.yeniEkipToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.yeniEkipToolStripMenuItem.Text = "Yeni ekip";
            this.yeniEkipToolStripMenuItem.Click += new System.EventHandler(this.yeniEkipToolStripMenuItem_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(241, 186);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 32);
            this.btnKaydet.TabIndex = 18;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bitiş Tarihi:";
            // 
            // dtpTarihBitis
            // 
            this.dtpTarihBitis.CustomFormat = "yyyy.MM.dd - HH:mm";
            this.dtpTarihBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarihBitis.Location = new System.Drawing.Point(196, 152);
            this.dtpTarihBitis.Name = "dtpTarihBitis";
            this.dtpTarihBitis.Size = new System.Drawing.Size(220, 28);
            this.dtpTarihBitis.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Başlangıç Tarihi:";
            // 
            // dtpTarihBaslangic
            // 
            this.dtpTarihBaslangic.CustomFormat = "yyyy.MM.dd - HH:mm";
            this.dtpTarihBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTarihBaslangic.Location = new System.Drawing.Point(196, 112);
            this.dtpTarihBaslangic.Name = "dtpTarihBaslangic";
            this.dtpTarihBaslangic.Size = new System.Drawing.Size(220, 28);
            this.dtpTarihBaslangic.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kullanıcı:";
            // 
            // cmbEkip
            // 
            this.cmbEkip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbEkip.FormattingEnabled = true;
            this.cmbEkip.Location = new System.Drawing.Point(197, 6);
            this.cmbEkip.Name = "cmbEkip";
            this.cmbEkip.Size = new System.Drawing.Size(220, 28);
            this.cmbEkip.TabIndex = 11;
            this.cmbEkip.SelectedIndexChanged += new System.EventHandler(this.cmbEkip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ekip:";
            // 
            // cmbSaha
            // 
            this.cmbSaha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaha.FormattingEnabled = true;
            this.cmbSaha.Location = new System.Drawing.Point(197, 78);
            this.cmbSaha.Name = "cmbSaha";
            this.cmbSaha.Size = new System.Drawing.Size(220, 28);
            this.cmbSaha.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Saha:";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(198, 40);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(219, 28);
            this.txtKullanici.TabIndex = 22;
            // 
            // Ekip_Takvimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(553, 660);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.cmbSaha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpTarihBitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTarihBaslangic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEkip);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ekip_Takvimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takım Takvimi";
            this.Load += new System.EventHandler(this.Ekip_Takvimi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarihBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTarihBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEkip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekibiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniEkipToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbSaha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullanici;
    }
}