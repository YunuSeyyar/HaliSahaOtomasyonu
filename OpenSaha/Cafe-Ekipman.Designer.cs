namespace OpenSaha
{
    partial class Cafe_Ekipman
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
            this.cmbCafeRezervasyon = new System.Windows.Forms.ComboBox();
            this.btnCafeKayit = new System.Windows.Forms.Button();
            this.lblToplamFiyat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCafeAdet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCafeUrun = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cafeÜrününüSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCafeBarkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEkipmanFiyat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEkipmanKaydet = new System.Windows.Forms.Button();
            this.txtEkipmanAdet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEkipmanUcret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEkipman = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEkipmanRezervasyon = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekipmanıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ptBarkod = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon:";
            // 
            // cmbCafeRezervasyon
            // 
            this.cmbCafeRezervasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCafeRezervasyon.FormattingEnabled = true;
            this.cmbCafeRezervasyon.Location = new System.Drawing.Point(147, 21);
            this.cmbCafeRezervasyon.Name = "cmbCafeRezervasyon";
            this.cmbCafeRezervasyon.Size = new System.Drawing.Size(171, 30);
            this.cmbCafeRezervasyon.TabIndex = 1;
            // 
            // btnCafeKayit
            // 
            this.btnCafeKayit.ForeColor = System.Drawing.Color.Black;
            this.btnCafeKayit.Location = new System.Drawing.Point(422, 121);
            this.btnCafeKayit.Name = "btnCafeKayit";
            this.btnCafeKayit.Size = new System.Drawing.Size(130, 32);
            this.btnCafeKayit.TabIndex = 6;
            this.btnCafeKayit.Text = "Kayıt";
            this.btnCafeKayit.UseVisualStyleBackColor = true;
            this.btnCafeKayit.Click += new System.EventHandler(this.btnCafeKayit_Click);
            // 
            // lblToplamFiyat
            // 
            this.lblToplamFiyat.AutoSize = true;
            this.lblToplamFiyat.Location = new System.Drawing.Point(533, 21);
            this.lblToplamFiyat.Name = "lblToplamFiyat";
            this.lblToplamFiyat.Size = new System.Drawing.Size(32, 22);
            this.lblToplamFiyat.TabIndex = 12;
            this.lblToplamFiyat.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fiyat:";
            // 
            // txtCafeAdet
            // 
            this.txtCafeAdet.Location = new System.Drawing.Point(147, 92);
            this.txtCafeAdet.Name = "txtCafeAdet";
            this.txtCafeAdet.Size = new System.Drawing.Size(171, 28);
            this.txtCafeAdet.TabIndex = 10;
            this.txtCafeAdet.TextChanged += new System.EventHandler(this.txtCafeAdet_TextChanged);
            this.txtCafeAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCafeAdet_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adet:";
            // 
            // cmbCafeUrun
            // 
            this.cmbCafeUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCafeUrun.FormattingEnabled = true;
            this.cmbCafeUrun.Location = new System.Drawing.Point(147, 57);
            this.cmbCafeUrun.Name = "cmbCafeUrun";
            this.cmbCafeUrun.Size = new System.Drawing.Size(171, 30);
            this.cmbCafeUrun.TabIndex = 8;
            this.cmbCafeUrun.SelectedIndexChanged += new System.EventHandler(this.cmbCafeUrun_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cafe Ürünleri:";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(324, 57);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(32, 22);
            this.lblUrunFiyat.TabIndex = 14;
            this.lblUrunFiyat.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(14, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 451);
            this.groupBox1.TabIndex = 15;
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
            this.dataGridView1.Size = new System.Drawing.Size(593, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cafeÜrününüSilToolStripMenuItem,
            this.yeniKayıtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 52);
            // 
            // cafeÜrününüSilToolStripMenuItem
            // 
            this.cafeÜrününüSilToolStripMenuItem.Name = "cafeÜrününüSilToolStripMenuItem";
            this.cafeÜrününüSilToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.cafeÜrününüSilToolStripMenuItem.Text = "Cafe ürününü sil";
            this.cafeÜrününüSilToolStripMenuItem.Click += new System.EventHandler(this.cafeÜrününüSilToolStripMenuItem_Click);
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rezervasyon:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ptBarkod);
            this.groupBox2.Controls.Add(this.txtCafeBarkod);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbCafeRezervasyon);
            this.groupBox2.Controls.Add(this.lblUrunFiyat);
            this.groupBox2.Controls.Add(this.btnCafeKayit);
            this.groupBox2.Controls.Add(this.lblToplamFiyat);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbCafeUrun);
            this.groupBox2.Controls.Add(this.txtCafeAdet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 164);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cafe";
            // 
            // txtCafeBarkod
            // 
            this.txtCafeBarkod.Location = new System.Drawing.Point(147, 125);
            this.txtCafeBarkod.Name = "txtCafeBarkod";
            this.txtCafeBarkod.Size = new System.Drawing.Size(171, 28);
            this.txtCafeBarkod.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Barkod:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEkipmanFiyat);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnEkipmanKaydet);
            this.groupBox3.Controls.Add(this.txtEkipmanAdet);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtEkipmanUcret);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbEkipman);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cmbEkipmanRezervasyon);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(619, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 164);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekipman";
            // 
            // lblEkipmanFiyat
            // 
            this.lblEkipmanFiyat.AutoSize = true;
            this.lblEkipmanFiyat.Location = new System.Drawing.Point(448, 65);
            this.lblEkipmanFiyat.Name = "lblEkipmanFiyat";
            this.lblEkipmanFiyat.Size = new System.Drawing.Size(32, 22);
            this.lblEkipmanFiyat.TabIndex = 26;
            this.lblEkipmanFiyat.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Fiyat:";
            // 
            // btnEkipmanKaydet
            // 
            this.btnEkipmanKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnEkipmanKaydet.Location = new System.Drawing.Point(498, 57);
            this.btnEkipmanKaydet.Name = "btnEkipmanKaydet";
            this.btnEkipmanKaydet.Size = new System.Drawing.Size(145, 36);
            this.btnEkipmanKaydet.TabIndex = 24;
            this.btnEkipmanKaydet.Text = "Kayıt";
            this.btnEkipmanKaydet.UseVisualStyleBackColor = true;
            this.btnEkipmanKaydet.Click += new System.EventHandler(this.btnEkipmanKaydet_Click);
            // 
            // txtEkipmanAdet
            // 
            this.txtEkipmanAdet.Location = new System.Drawing.Point(450, 18);
            this.txtEkipmanAdet.Name = "txtEkipmanAdet";
            this.txtEkipmanAdet.Size = new System.Drawing.Size(193, 28);
            this.txtEkipmanAdet.TabIndex = 23;
            this.txtEkipmanAdet.TextChanged += new System.EventHandler(this.txtEkipmanAdet_TextChanged);
            this.txtEkipmanAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEkipmanAdet_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Adet:";
            // 
            // txtEkipmanUcret
            // 
            this.txtEkipmanUcret.Location = new System.Drawing.Point(145, 89);
            this.txtEkipmanUcret.Name = "txtEkipmanUcret";
            this.txtEkipmanUcret.Size = new System.Drawing.Size(193, 28);
            this.txtEkipmanUcret.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(74, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ücret:";
            // 
            // cmbEkipman
            // 
            this.cmbEkipman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEkipman.FormattingEnabled = true;
            this.cmbEkipman.Location = new System.Drawing.Point(144, 51);
            this.cmbEkipman.Name = "cmbEkipman";
            this.cmbEkipman.Size = new System.Drawing.Size(194, 30);
            this.cmbEkipman.TabIndex = 19;
            this.cmbEkipman.SelectedIndexChanged += new System.EventHandler(this.cmbEkipman_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ekipman:";
            // 
            // cmbEkipmanRezervasyon
            // 
            this.cmbEkipmanRezervasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEkipmanRezervasyon.FormattingEnabled = true;
            this.cmbEkipmanRezervasyon.Location = new System.Drawing.Point(144, 16);
            this.cmbEkipmanRezervasyon.Name = "cmbEkipmanRezervasyon";
            this.cmbEkipmanRezervasyon.Size = new System.Drawing.Size(194, 30);
            this.cmbEkipmanRezervasyon.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(619, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(659, 451);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 24);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(653, 424);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekipmanıSilToolStripMenuItem,
            this.yeniKayıtToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 52);
            // 
            // ekipmanıSilToolStripMenuItem
            // 
            this.ekipmanıSilToolStripMenuItem.Name = "ekipmanıSilToolStripMenuItem";
            this.ekipmanıSilToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.ekipmanıSilToolStripMenuItem.Text = "Ekipmanı sil.";
            this.ekipmanıSilToolStripMenuItem.Click += new System.EventHandler(this.ekipmanıSilToolStripMenuItem_Click);
            // 
            // yeniKayıtToolStripMenuItem1
            // 
            this.yeniKayıtToolStripMenuItem1.Name = "yeniKayıtToolStripMenuItem1";
            this.yeniKayıtToolStripMenuItem1.Size = new System.Drawing.Size(160, 24);
            this.yeniKayıtToolStripMenuItem1.Text = "Yeni kayıt";
            this.yeniKayıtToolStripMenuItem1.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem1_Click);
            // 
            // ptBarkod
            // 
            this.ptBarkod.Location = new System.Drawing.Point(422, 51);
            this.ptBarkod.Name = "ptBarkod";
            this.ptBarkod.Size = new System.Drawing.Size(172, 61);
            this.ptBarkod.TabIndex = 17;
            this.ptBarkod.TabStop = false;
            // 
            // Cafe_Ekipman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1290, 644);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cafe_Ekipman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İşlemleri";
            this.Load += new System.EventHandler(this.Cafe_Ekipman_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptBarkod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCafeRezervasyon;
        private System.Windows.Forms.Button btnCafeKayit;
        private System.Windows.Forms.Label lblToplamFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCafeAdet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCafeUrun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cafeÜrününüSilToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEkipman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEkipmanRezervasyon;
        private System.Windows.Forms.TextBox txtEkipmanAdet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEkipmanUcret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEkipmanKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblEkipmanFiyat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ekipmanıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem1;
        private System.Windows.Forms.TextBox txtCafeBarkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptBarkod;
    }
}