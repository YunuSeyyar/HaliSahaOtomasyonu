namespace OpenSaha
{
    partial class Eslesme
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEvSahibi = new System.Windows.Forms.ComboBox();
            this.cmbDeplasman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSahalar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMacTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpOlusturmaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAktifSure = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eşleşmeyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eşleşmeyionaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eşleşmeyiReddetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniEşleşmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ev Sahibi:";
            // 
            // cmbEvSahibi
            // 
            this.cmbEvSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvSahibi.FormattingEnabled = true;
            this.cmbEvSahibi.Location = new System.Drawing.Point(139, 18);
            this.cmbEvSahibi.Name = "cmbEvSahibi";
            this.cmbEvSahibi.Size = new System.Drawing.Size(239, 28);
            this.cmbEvSahibi.TabIndex = 1;
            // 
            // cmbDeplasman
            // 
            this.cmbDeplasman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeplasman.FormattingEnabled = true;
            this.cmbDeplasman.Location = new System.Drawing.Point(139, 54);
            this.cmbDeplasman.Name = "cmbDeplasman";
            this.cmbDeplasman.Size = new System.Drawing.Size(239, 28);
            this.cmbDeplasman.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deplasman:";
            // 
            // cmbSahalar
            // 
            this.cmbSahalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSahalar.FormattingEnabled = true;
            this.cmbSahalar.Location = new System.Drawing.Point(139, 90);
            this.cmbSahalar.Name = "cmbSahalar";
            this.cmbSahalar.Size = new System.Drawing.Size(239, 28);
            this.cmbSahalar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sahalar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maç Tarihi:";
            // 
            // dtpMacTarihi
            // 
            this.dtpMacTarihi.CustomFormat = "yyyy.MM.dd - HH:mm";
            this.dtpMacTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMacTarihi.Location = new System.Drawing.Point(564, 20);
            this.dtpMacTarihi.Name = "dtpMacTarihi";
            this.dtpMacTarihi.Size = new System.Drawing.Size(220, 28);
            this.dtpMacTarihi.TabIndex = 7;
            // 
            // dtpOlusturmaTarihi
            // 
            this.dtpOlusturmaTarihi.CustomFormat = "yyyy.MM.dd - HH:mm";
            this.dtpOlusturmaTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOlusturmaTarihi.Location = new System.Drawing.Point(564, 56);
            this.dtpOlusturmaTarihi.Name = "dtpOlusturmaTarihi";
            this.dtpOlusturmaTarihi.Size = new System.Drawing.Size(220, 28);
            this.dtpOlusturmaTarihi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oluşturma Tarihi:";
            // 
            // dtpAktifSure
            // 
            this.dtpAktifSure.CustomFormat = "yyyy.MM.dd - HH:mm";
            this.dtpAktifSure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAktifSure.Location = new System.Drawing.Point(564, 92);
            this.dtpAktifSure.Name = "dtpAktifSure";
            this.dtpAktifSure.Size = new System.Drawing.Size(220, 28);
            this.dtpAktifSure.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Aktif Süre:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 449);
            this.groupBox1.TabIndex = 12;
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
            this.dataGridView1.Size = new System.Drawing.Size(855, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eşleşmeyiSilToolStripMenuItem,
            this.eşleşmeyionaylaToolStripMenuItem,
            this.eşleşmeyiReddetToolStripMenuItem,
            this.yeniEşleşmeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 100);
            // 
            // eşleşmeyiSilToolStripMenuItem
            // 
            this.eşleşmeyiSilToolStripMenuItem.Name = "eşleşmeyiSilToolStripMenuItem";
            this.eşleşmeyiSilToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.eşleşmeyiSilToolStripMenuItem.Text = "Eşleşmeyi sil";
            this.eşleşmeyiSilToolStripMenuItem.Click += new System.EventHandler(this.eşleşmeyiSilToolStripMenuItem_Click);
            // 
            // eşleşmeyionaylaToolStripMenuItem
            // 
            this.eşleşmeyionaylaToolStripMenuItem.Name = "eşleşmeyionaylaToolStripMenuItem";
            this.eşleşmeyionaylaToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.eşleşmeyionaylaToolStripMenuItem.Text = "Eşleşmeyi onayla";
            this.eşleşmeyionaylaToolStripMenuItem.Click += new System.EventHandler(this.eşleşmeyionaylaToolStripMenuItem_Click);
            // 
            // eşleşmeyiReddetToolStripMenuItem
            // 
            this.eşleşmeyiReddetToolStripMenuItem.Name = "eşleşmeyiReddetToolStripMenuItem";
            this.eşleşmeyiReddetToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.eşleşmeyiReddetToolStripMenuItem.Text = "Eşleşmeyi reddet";
            this.eşleşmeyiReddetToolStripMenuItem.Click += new System.EventHandler(this.eşleşmeyiReddetToolStripMenuItem_Click);
            // 
            // yeniEşleşmeToolStripMenuItem
            // 
            this.yeniEşleşmeToolStripMenuItem.Name = "yeniEşleşmeToolStripMenuItem";
            this.yeniEşleşmeToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.yeniEşleşmeToolStripMenuItem.Text = "Yeni eşleşme";
            this.yeniEşleşmeToolStripMenuItem.Click += new System.EventHandler(this.yeniEşleşmeToolStripMenuItem_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(605, 126);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 34);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Eslesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(888, 627);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpAktifSure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpOlusturmaTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpMacTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSahalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDeplasman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEvSahibi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Eslesme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eslesme";
            this.Load += new System.EventHandler(this.Eslesme_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEvSahibi;
        private System.Windows.Forms.ComboBox cmbDeplasman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSahalar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMacTarihi;
        private System.Windows.Forms.DateTimePicker dtpOlusturmaTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpAktifSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eşleşmeyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eşleşmeyionaylaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eşleşmeyiReddetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniEşleşmeToolStripMenuItem;
    }
}