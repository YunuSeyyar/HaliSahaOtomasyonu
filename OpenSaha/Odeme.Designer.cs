namespace OpenSaha
{
    partial class Odeme
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
            this.lblSahaUcret = new System.Windows.Forms.Label();
            this.lblEkipmanUcret = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCafeUcret = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRezervasyon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.rbKrediKartı = new System.Windows.Forms.RadioButton();
            this.rbSanalPos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSaha = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saha Ücreti:";
            // 
            // lblSahaUcret
            // 
            this.lblSahaUcret.AutoSize = true;
            this.lblSahaUcret.Location = new System.Drawing.Point(173, 102);
            this.lblSahaUcret.Name = "lblSahaUcret";
            this.lblSahaUcret.Size = new System.Drawing.Size(27, 20);
            this.lblSahaUcret.TabIndex = 1;
            this.lblSahaUcret.Text = "00";
            // 
            // lblEkipmanUcret
            // 
            this.lblEkipmanUcret.AutoSize = true;
            this.lblEkipmanUcret.Location = new System.Drawing.Point(283, 127);
            this.lblEkipmanUcret.Name = "lblEkipmanUcret";
            this.lblEkipmanUcret.Size = new System.Drawing.Size(27, 20);
            this.lblEkipmanUcret.TabIndex = 3;
            this.lblEkipmanUcret.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ekipman Ücreti:";
            // 
            // lblCafeUcret
            // 
            this.lblCafeUcret.AutoSize = true;
            this.lblCafeUcret.Location = new System.Drawing.Point(330, 102);
            this.lblCafeUcret.Name = "lblCafeUcret";
            this.lblCafeUcret.Size = new System.Drawing.Size(27, 20);
            this.lblCafeUcret.TabIndex = 5;
            this.lblCafeUcret.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cafe Ücreti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rezervasyon:";
            // 
            // cmbRezervasyon
            // 
            this.cmbRezervasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRezervasyon.FormattingEnabled = true;
            this.cmbRezervasyon.Location = new System.Drawing.Point(173, 27);
            this.cmbRezervasyon.Name = "cmbRezervasyon";
            this.cmbRezervasyon.Size = new System.Drawing.Size(151, 28);
            this.cmbRezervasyon.TabIndex = 7;
            this.cmbRezervasyon.SelectedIndexChanged += new System.EventHandler(this.cmbRezervasyon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Saha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ödeme Tipi:";
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(475, 35);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(73, 24);
            this.rbNakit.TabIndex = 11;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            // 
            // rbKrediKartı
            // 
            this.rbKrediKartı.AutoSize = true;
            this.rbKrediKartı.Location = new System.Drawing.Point(554, 36);
            this.rbKrediKartı.Name = "rbKrediKartı";
            this.rbKrediKartı.Size = new System.Drawing.Size(120, 24);
            this.rbKrediKartı.TabIndex = 12;
            this.rbKrediKartı.TabStop = true;
            this.rbKrediKartı.Text = "Kredi Kartı";
            this.rbKrediKartı.UseVisualStyleBackColor = true;
            // 
            // rbSanalPos
            // 
            this.rbSanalPos.AutoSize = true;
            this.rbSanalPos.Location = new System.Drawing.Point(509, 62);
            this.rbSanalPos.Name = "rbSanalPos";
            this.rbSanalPos.Size = new System.Drawing.Size(106, 24);
            this.rbSanalPos.TabIndex = 13;
            this.rbSanalPos.TabStop = true;
            this.rbSanalPos.Text = "Sanal Pos";
            this.rbSanalPos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 371);
            this.groupBox1.TabIndex = 14;
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
            this.dataGridView1.Size = new System.Drawing.Size(662, 344);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(475, 92);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 30);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSaha
            // 
            this.txtSaha.Location = new System.Drawing.Point(172, 61);
            this.txtSaha.Name = "txtSaha";
            this.txtSaha.Size = new System.Drawing.Size(152, 28);
            this.txtSaha.TabIndex = 18;
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(692, 557);
            this.Controls.Add(this.txtSaha);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbSanalPos);
            this.Controls.Add(this.rbKrediKartı);
            this.Controls.Add(this.rbNakit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRezervasyon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCafeUcret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEkipmanUcret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSahaUcret);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Odeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödeme";
            this.Load += new System.EventHandler(this.Odeme_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSahaUcret;
        private System.Windows.Forms.Label lblEkipmanUcret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCafeUcret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRezervasyon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.RadioButton rbKrediKartı;
        private System.Windows.Forms.RadioButton rbSanalPos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSaha;
    }
}