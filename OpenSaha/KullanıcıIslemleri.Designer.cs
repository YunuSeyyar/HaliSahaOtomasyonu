namespace OpenSaha
{
    partial class KullanıcıIslemleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.kullaniciEkleme = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kullaniciEdit = new System.Windows.Forms.GroupBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnclosed = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kullanıcıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKullanici = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.kullaniciEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puan:";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(190, 22);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(307, 34);
            this.txtIsim.TabIndex = 0;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(189, 137);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(308, 34);
            this.txtSoyisim.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 34);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(189, 256);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(308, 34);
            this.txtPuan.TabIndex = 5;
            this.txtPuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPuan_KeyPress);
            // 
            // kullaniciEkleme
            // 
            this.kullaniciEkleme.ForeColor = System.Drawing.Color.Black;
            this.kullaniciEkleme.Location = new System.Drawing.Point(349, 304);
            this.kullaniciEkleme.Name = "kullaniciEkleme";
            this.kullaniciEkleme.Size = new System.Drawing.Size(148, 34);
            this.kullaniciEkleme.TabIndex = 6;
            this.kullaniciEkleme.Text = "Kaydet";
            this.kullaniciEkleme.UseVisualStyleBackColor = true;
            this.kullaniciEkleme.Click += new System.EventHandler(this.kullaniciEkleme_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kullaniciEdit);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 457);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // kullaniciEdit
            // 
            this.kullaniciEdit.Controls.Add(this.dtpDogumTarihi);
            this.kullaniciEdit.Controls.Add(this.label8);
            this.kullaniciEdit.Controls.Add(this.btnclosed);
            this.kullaniciEdit.Controls.Add(this.label7);
            this.kullaniciEdit.Controls.Add(this.mskTelefon);
            this.kullaniciEdit.Controls.Add(this.txtSifre);
            this.kullaniciEdit.Controls.Add(this.kullaniciEkleme);
            this.kullaniciEdit.Controls.Add(this.label6);
            this.kullaniciEdit.Controls.Add(this.label3);
            this.kullaniciEdit.Controls.Add(this.txtPuan);
            this.kullaniciEdit.Controls.Add(this.txtEmail);
            this.kullaniciEdit.Controls.Add(this.txtSoyisim);
            this.kullaniciEdit.Controls.Add(this.txtIsim);
            this.kullaniciEdit.Controls.Add(this.label5);
            this.kullaniciEdit.Controls.Add(this.label4);
            this.kullaniciEdit.Controls.Add(this.label2);
            this.kullaniciEdit.Controls.Add(this.label1);
            this.kullaniciEdit.ForeColor = System.Drawing.Color.White;
            this.kullaniciEdit.Location = new System.Drawing.Point(491, 67);
            this.kullaniciEdit.Name = "kullaniciEdit";
            this.kullaniciEdit.Size = new System.Drawing.Size(508, 384);
            this.kullaniciEdit.TabIndex = 19;
            this.kullaniciEdit.TabStop = false;
            this.kullaniciEdit.Text = "Bilgiler";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.CustomFormat = "yyyy-MM-dd";
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(189, 217);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(307, 34);
            this.dtpDogumTarihi.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // btnclosed
            // 
            this.btnclosed.ForeColor = System.Drawing.Color.Black;
            this.btnclosed.Location = new System.Drawing.Point(6, 23);
            this.btnclosed.Name = "btnclosed";
            this.btnclosed.Size = new System.Drawing.Size(33, 29);
            this.btnclosed.TabIndex = 18;
            this.btnclosed.Text = "X";
            this.btnclosed.UseVisualStyleBackColor = true;
            this.btnclosed.Click += new System.EventHandler(this.btnclosed_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(862, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 16;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(189, 60);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(308, 34);
            this.mskTelefon.TabIndex = 1;
            this.mskTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefon_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(189, 99);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(307, 34);
            this.txtSifre.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Şifre:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1000, 424);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 28);
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            this.kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            this.kullanıcıSilToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.kullanıcıSilToolStripMenuItem.Text = "Kullanıcı Sil";
            this.kullanıcıSilToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilToolStripMenuItem_Click);
            // 
            // yeniKullanici
            // 
            this.yeniKullanici.ForeColor = System.Drawing.Color.Black;
            this.yeniKullanici.Location = new System.Drawing.Point(768, 14);
            this.yeniKullanici.Name = "yeniKullanici";
            this.yeniKullanici.Size = new System.Drawing.Size(248, 37);
            this.yeniKullanici.TabIndex = 18;
            this.yeniKullanici.Text = "Yeni Kullanıcı Ekle";
            this.yeniKullanici.UseVisualStyleBackColor = true;
            this.yeniKullanici.Click += new System.EventHandler(this.yeniKullanici_Click);
            // 
            // KullanıcıIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1025, 522);
            this.Controls.Add(this.yeniKullanici);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "KullanıcıIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.KayitIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.kullaniciEdit.ResumeLayout(false);
            this.kullaniciEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.Button kullaniciEkleme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button yeniKullanici;
        private System.Windows.Forms.GroupBox kullaniciEdit;
        private System.Windows.Forms.Button btnclosed;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label8;
    }
}