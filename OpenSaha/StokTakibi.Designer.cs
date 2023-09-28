namespace OpenSaha
{
    partial class StokTakibi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbGiris = new System.Windows.Forms.RadioButton();
            this.rbCikis = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptBarkod = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBarkod)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün:";
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(124, 22);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(158, 28);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.cmbUrun_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşlem:";
            // 
            // rbGiris
            // 
            this.rbGiris.AutoSize = true;
            this.rbGiris.Location = new System.Drawing.Point(129, 103);
            this.rbGiris.Name = "rbGiris";
            this.rbGiris.Size = new System.Drawing.Size(118, 24);
            this.rbGiris.TabIndex = 3;
            this.rbGiris.TabStop = true;
            this.rbGiris.Text = "Ürün Girişi";
            this.rbGiris.UseVisualStyleBackColor = true;
            // 
            // rbCikis
            // 
            this.rbCikis.AutoSize = true;
            this.rbCikis.Location = new System.Drawing.Point(129, 133);
            this.rbCikis.Name = "rbCikis";
            this.rbCikis.Size = new System.Drawing.Size(120, 24);
            this.rbCikis.TabIndex = 4;
            this.rbCikis.TabStop = true;
            this.rbCikis.Text = "Ürün Çıkışı";
            this.rbCikis.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(125, 58);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(157, 28);
            this.txtAdet.TabIndex = 6;
            this.txtAdet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdet_KeyPress);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(392, 22);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(157, 28);
            this.txtFiyat.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(417, 170);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(113, 29);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 440);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(392, 58);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(157, 28);
            this.txtBarkod.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Barkod:";
            // 
            // ptBarkod
            // 
            this.ptBarkod.Location = new System.Drawing.Point(392, 92);
            this.ptBarkod.Name = "ptBarkod";
            this.ptBarkod.Size = new System.Drawing.Size(157, 65);
            this.ptBarkod.TabIndex = 16;
            this.ptBarkod.TabStop = false;
            // 
            // StokTakibi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(621, 657);
            this.Controls.Add(this.ptBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbCikis);
            this.Controls.Add(this.rbGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StokTakibi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Takibi";
            this.Load += new System.EventHandler(this.StokTakibi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBarkod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbGiris;
        private System.Windows.Forms.RadioButton rbCikis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptBarkod;
    }
}