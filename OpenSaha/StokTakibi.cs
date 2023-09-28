using System;
using System.Data;
using System.Windows.Forms;
using ZXing;

namespace OpenSaha
{
    public partial class StokTakibi : Form
    {
        public StokTakibi()
        {
            InitializeComponent();
        }

        private void StokTakibi_Load(object sender, EventArgs e)
        {
            GetStoklar();
            cmbUrun.Items.Add("Lütfen ürünü seçiniz");
            txtBarkod.Enabled = false;

            var urunTables = databaseClass.SqlGet("select * from cafes where Act=1");
            if (urunTables != null)
            {
                foreach (DataRow urunlistesi in urunTables.Rows)
                {
                    databaseClass.urun urun = new databaseClass.urun();
                    urun.Baslik = urunlistesi["Baslik"].ToString();
                    urun.UrunId = int.Parse(urunlistesi["Id"].ToString());
                    cmbUrun.Items.Add(urun);
                    cmbUrun.SelectedIndex = 0;
                }
            }
        }

        void GetStoklar()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("select Id,(SELECT cf.Baslik FROM cafes as cf where cf.Id=st.CafeId) as Urun,(case Islem when 0 then \"Giriş\" else \"Çıkış\" end)as 'İşlem',Adet,Tarih,BirimFiyat,Barkod,(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=st.YoneticiId limit 1)as Kisi from stoktakips as st where st.Act=1");
            dataGridView1.Columns["Id"].Visible = false;
        }

        void Clear()
        {
            txtFiyat.ResetText();
            txtAdet.ResetText();
            cmbUrun.SelectedIndex = 0;
            txtBarkod.ResetText();
            rbCikis.Checked = false;
            rbGiris.Checked = false;
        }
        int urunAdet = 0;
        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urunTables = databaseClass.SqlGet("select * from cafes where Baslik='" + cmbUrun.Text + "'");
            if (urunTables != null)
            {
                foreach (DataRow urun in urunTables.Rows)
                {
                    Convert.ToDouble(txtFiyat.Text = urun["Fiyat"].ToString());
                    txtBarkod.Text = urun["Barkod"].ToString();
                    urunAdet = Convert.ToInt32(urun["Adet"]);
                }
            }
            string barcodeText = txtBarkod.Text;
            if (string.IsNullOrEmpty(barcodeText))
            { ptBarkod.Image = null; }
            else { databaseClass.GenerateBarcode(txtBarkod.Text, ptBarkod); }
        }

        bool SeciliVar = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var urun = cmbUrun.SelectedItem as databaseClass.urun;
            if (urun == null) return;
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;

            int islem = 0;
            if (rbGiris.Checked) { islem = 0; }
            else if (rbCikis.Checked) { islem = 1; }    

            var tarih = DateTime.Now.ToString("yyyy-MM-dd : HH-mm");

            int giris = urunAdet + Convert.ToInt32(txtAdet.Text);
            int cikis = urunAdet - Convert.ToInt32(txtAdet.Text);
            
            if (!SeciliVar)
            {
                if (rbGiris.Checked)
                {
                    if (cmbUrun.Text == "" || txtAdet.Text == "" || txtFiyat.Text == "" || txtBarkod.Text == "" || (rbCikis.Checked == false && rbGiris.Checked == false))
                    { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                    try
                    {
                        databaseClass.SqlSend("update cafes set Adet='" + giris + "',Fiyat='" + txtFiyat.Text + "',GuncellemeTarih='" + tarih + "',Barkod='" + txtBarkod.Text  + "'where Id='" + urun.UrunId + "'");
                        MessageBox.Show("Ürün girişi başarılı...");
                    }
                    catch { MessageBox.Show("İşlem Sırasında Hata Var..!"); }
                }
                else
                {
                    if (cmbUrun.Text == "" || txtAdet.Text == "" || txtFiyat.Text == "" || txtBarkod.Text == "" || (rbCikis.Checked == false && rbGiris.Checked == false))
                    { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                    try
                    {
                        databaseClass.SqlSend("update cafes set Adet='" + cikis + "',Fiyat='" + txtFiyat.Text + "',GuncellemeTarih='" + tarih + "',Barkod='" + txtBarkod.Text + "'where Id='" + urun.UrunId + "'");
                        MessageBox.Show("Ürün çıkışı başarılı...");
                    }
                    catch { MessageBox.Show("İşlem Sırasında Hata Var..."); }
                }
            }
            
            if (!SeciliVar)
            {
                if (rbGiris.Checked)
                {
                    if (cmbUrun.Text == "" || txtAdet.Text == "" || txtFiyat.Text == "" || txtBarkod.Text == "" || (rbCikis.Checked == false && rbGiris.Checked == false))
                    { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                    try
                    {
                        databaseClass.SqlSend("insert into stoktakips (CafeId,BirimFiyat,Islem,Adet,Tarih,YoneticiId,Barkod) values('" + urun.UrunId + "','" + txtFiyat.Text + "','" + islem + "','" + txtAdet.Text + "','" + tarih + "','" + yonetici + "','" + txtBarkod.Text + "')");
                    }
                    catch { MessageBox.Show("Kayıt başarılı..."); }
                }
                else
                {
                    if (cmbUrun.Text == "" || txtAdet.Text == "" || txtFiyat.Text == "" || txtBarkod.Text == "" || (rbCikis.Checked == false && rbGiris.Checked == false))
                    { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                    try
                    {
                        databaseClass.SqlSend("insert into stoktakips (CafeId,BirimFiyat,Islem,Adet,Tarih,YoneticiId,Barkod) values('" + urun.UrunId + "','" + txtFiyat.Text + "','" + islem + "','" + txtAdet.Text + "','" + tarih + "','" + yonetici + "','" + txtBarkod.Text + "')");
                    }
                    catch { MessageBox.Show("Kayıt başarılı..."); }
                }
            }
            else
            {
                if (cmbUrun.Text == "" || txtAdet.Text == "" || txtFiyat.Text == "" || txtBarkod.Text == "" || (rbCikis.Checked == false && rbGiris.Checked == false))
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("update stoktakips set CafeId='" + urun.UrunId + "',BirimFiyat='" + txtFiyat.Text + "',Islem='" + islem + "',Adet='" + txtAdet.Text + "',Tarih='" + tarih + "',Barkod='" + txtBarkod.Text + "'where Id='" + urun.UrunId + "'");
                }
                catch { MessageBox.Show("Güncelleme başarılı..."); }
            }
            GetStoklar();
            Clear();
        }

        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }
    }
}
