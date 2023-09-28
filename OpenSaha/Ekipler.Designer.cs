namespace OpenSaha
{
    partial class Ekipler
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
            this.cmbKullanici = new System.Windows.Forms.ComboBox();
            this.cmbSehir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKadro = new System.Windows.Forms.TextBox();
            this.txtTakımAdı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ekibiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniEkipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı:";
            // 
            // cmbKullanici
            // 
            this.cmbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbKullanici.FormattingEnabled = true;
            this.cmbKullanici.Location = new System.Drawing.Point(103, 12);
            this.cmbKullanici.Name = "cmbKullanici";
            this.cmbKullanici.Size = new System.Drawing.Size(183, 28);
            this.cmbKullanici.TabIndex = 1;
            // 
            // cmbSehir
            // 
            this.cmbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSehir.FormattingEnabled = true;
            this.cmbSehir.Location = new System.Drawing.Point(103, 47);
            this.cmbSehir.Name = "cmbSehir";
            this.cmbSehir.Size = new System.Drawing.Size(183, 28);
            this.cmbSehir.TabIndex = 3;
            this.cmbSehir.SelectedIndexChanged += new System.EventHandler(this.cmbSehir_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şehir:";
            // 
            // cmbIlce
            // 
            this.cmbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(103, 81);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(183, 28);
            this.cmbIlce.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "İlçe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oyuncu Sayısı:";
            // 
            // txtKadro
            // 
            this.txtKadro.Location = new System.Drawing.Point(436, 12);
            this.txtKadro.Name = "txtKadro";
            this.txtKadro.Size = new System.Drawing.Size(183, 28);
            this.txtKadro.TabIndex = 7;
            this.txtKadro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKadro_KeyPress);
            // 
            // txtTakımAdı
            // 
            this.txtTakımAdı.Location = new System.Drawing.Point(436, 46);
            this.txtTakımAdı.Name = "txtTakımAdı";
            this.txtTakımAdı.Size = new System.Drawing.Size(183, 28);
            this.txtTakımAdı.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Takım Adı:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(483, 80);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(138, 30);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 504);
            this.groupBox1.TabIndex = 11;
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
            this.dataGridView1.Size = new System.Drawing.Size(608, 477);
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
            // Ekipler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(640, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtTakımAdı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKadro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIlce);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSehir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbKullanici);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ekipler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takım Kaydı";
            this.Load += new System.EventHandler(this.Ekipler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKullanici;
        private System.Windows.Forms.ComboBox cmbSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKadro;
        private System.Windows.Forms.TextBox txtTakımAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekibiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniEkipToolStripMenuItem;
    }
}