using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;


namespace OpenSaha
{
    public partial class UrunIslemleri : Form
    {
        void GetCafe()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("select Id,Baslik,Fiyat,Adet,Tarih,GuncellemeTarih,Stoklu,(select sh.Baslik as saha from sahas as sh where sh.Id=c.SahaId) as Saha,Barkod,(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=c.YoneticiId limit 1) as Kisi,Act from cafes c where act=1");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Act"].Visible = false;
        }

        void GetEkipman()
        {
            dataGridView2.DataSource = databaseClass.SqlGet("select Id,(select sh.Baslik as saha from sahas as sh where sh.Id=e.SahaId) as Saha,Baslik,Aciklama,Ucret,Adet,(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=e.YoneticiId limit 1) as Kisi,Act from ekipmanlars e where act=1");
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Act"].Visible = false;
        }

        public UrunIslemleri() { InitializeComponent(); }
        

        private void EkipmanCafe_Load(object sender, EventArgs e)
        {
            GetEkipman();
            GetCafe();
            cmbSahaAdi.Items.Add("Lütfen sahayı seçiniz");
            cmbCafeSaha.Items.Add("Lütfen sahayı seçiniz");
            var sahatable = databaseClass.SqlGet("select * from sahas where Act = 1 and YoneticiId='" + databaseClass.yonetici.YoneticiId + "'");
            if (sahatable != null)
            {
                foreach (DataRow item in sahatable.Rows)
                {
                    databaseClass.saha saha = new databaseClass.saha();
                    saha.Baslik = item["Baslik"].ToString();
                    saha.SahaId = int.Parse(item["Id"].ToString());
                    cmbSahaAdi.Items.Add(saha);
                    cmbCafeSaha.Items.Add(saha);
                }
                cmbSahaAdi.SelectedIndex = 0;
                cmbCafeSaha.SelectedIndex = 0;
            }
        }

        void CafeClear()
        {
            txtCafeUrunAdi.ResetText();
            txtCafeUrunFiyat.ResetText();
            txtCafeAdet.ResetText();
            txtBarkod.ResetText();
            cmbCafeSaha.SelectedIndex = 0;
            txtCafeAdet.Enabled = true;
            rbStoklu.Checked = false;
            rbStoksuz.Checked = false;
        }

        void EkipmanClear()
        {
            cmbSahaAdi.SelectedIndex = 0;
            txtEkipman.ResetText();
            rtbEkipmanAciklama.ResetText();
            txtEkipmanFiyat.ResetText();
            txtEkipmanAdet.ResetText();
        }

        bool SeciliVar = false;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            var sahaid = cmbCafeSaha.SelectedItem as databaseClass.saha;
            if (sahaid == null) return;
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == 0) return;

            int stok = 0;
            if(rbStoklu.Checked) { stok = 1; }
            else { stok = 0; }
            if (!SeciliVar)
            {
                if (txtCafeUrunAdi.Text == "" || txtCafeUrunFiyat.Text == "" || txtCafeAdet.Text == "" || txtBarkod.Text == "" || cmbCafeSaha.Text == "" || (rbStoklu.Checked == false && rbStoksuz.Checked == false))
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    var ekleme = DateTime.Now.ToString("yyyy-MM-dd : HH-mm");
                    databaseClass.SqlSend("insert into cafes(Baslik,Fiyat,Adet,Tarih,GuncellemeTarih,Stoklu,SahaId,Barkod,YoneticiId) values('" + txtCafeUrunAdi.Text + "','" + Convert.ToDouble(txtCafeUrunFiyat.Text) + "','" + txtCafeAdet.Text + "','" + ekleme + "','" + ekleme + "','" + stok + "','" + sahaid.SahaId + "','" + txtBarkod.Text + "','" + yonetici + "')");
                    MessageBox.Show("Ürün ekleme başarılı...");
                    GetCafe();
                    CafeClear();
                }
                catch { MessageBox.Show("İşlem sırasında hata var..."); }
            }
            else
            {
                if (txtCafeUrunAdi.Text == "" || txtCafeUrunFiyat.Text == "" || txtCafeAdet.Text == "" || txtBarkod.Text == "" || cmbCafeSaha.Text == "" || (rbStoklu.Checked == false && rbStoksuz.Checked == false))
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    var guncelleme = DateTime.Now.ToString("yyyy-MM-dd : HH-mm");
                    databaseClass.SqlSend("update cafes set Baslik='" + txtCafeUrunAdi.Text + "',Fiyat='" + Convert.ToDouble(txtCafeUrunFiyat.Text) + "',Adet='" + txtCafeAdet.Text + "',GuncellemeTarih='" + guncelleme + "',Stoklu='" + stok + "',SahaId='" + sahaid.SahaId + "',Barkod='" + txtBarkod.Text + "',YoneticiId='" + yonetici + "'where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme başarılı...");
                    GetCafe();
                    CafeClear();
                }
                catch { MessageBox.Show("İşlem sırasında hata var..."); }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string stok = dataGridView1.Rows[e.RowIndex].Cells["Stoklu"].Value.ToString();
            if (stok == "True") { rbStoklu.Checked = true; }
            else if (stok == "False") { rbStoksuz.Checked = true; }

            SeciliVar = true;
            txtCafeAdet.Enabled = false;
            txtCafeUrunAdi.Text = dataGridView1.CurrentRow.Cells["Baslik"].Value.ToString();
            txtCafeUrunFiyat.Text = dataGridView1.CurrentRow.Cells["Fiyat"].Value.ToString();
            txtCafeAdet.Text = dataGridView1.CurrentRow.Cells["Adet"].Value.ToString();
            cmbCafeSaha.Text = dataGridView1.CurrentRow.Cells["Saha"].Value.ToString();
            txtBarkod.Text = dataGridView1.CurrentRow.Cells["Barkod"].Value.ToString();
        }

        private void ürünKaldırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                databaseClass.SqlSend("update cafes set act=0 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                MessageBox.Show("Ürün başarıyla silindi...");
                GetCafe();
                CafeClear();
            }
        }

        bool ekleGuncelle = false;
        private void btnEkipmanKaydet_Click(object sender, EventArgs e)
        {
            var sahaid = cmbSahaAdi.SelectedItem as databaseClass.saha;
            if (sahaid == null) return;
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;

            if (!ekleGuncelle)
            {
                if (cmbSahaAdi.Text == "" || txtEkipman.Text == "" || rtbEkipmanAciklama.Text == "" || txtEkipmanAdet.Text == "" || txtEkipmanFiyat.Text == "" )
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    databaseClass.SqlSend("insert into ekipmanlars(SahaId,Baslik,Aciklama,Ucret,Adet,YoneticiId) values('" + sahaid.SahaId + "','" + txtEkipman.Text + "','" + rtbEkipmanAciklama.Text + "','" + txtEkipmanFiyat.Text + "','" + txtEkipmanAdet.Text + "','" + yonetici + "')");
                    MessageBox.Show("Ekipman ekleme başarılı...");
                    GetEkipman();
                    EkipmanClear();
                }
                catch { MessageBox.Show("Lütfen boş alanları doldurunuz..."); }
            }
            else
            {
                if (cmbSahaAdi.Text == "" || txtEkipman.Text == "" || rtbEkipmanAciklama.Text == "" || txtEkipmanAdet.Text == "" || txtEkipmanFiyat.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    databaseClass.SqlSend("update ekipmanlars set SahaId='" + sahaid.SahaId + "',Baslik='" + txtEkipman.Text + "',Aciklama='" + rtbEkipmanAciklama.Text + "',Ucret='" + txtEkipmanFiyat.Text + "',Adet='" + txtEkipmanAdet.Text + "',YoneticiId='" + yonetici + "' where Id='" + dataGridView2.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme başarılı...");
                    GetEkipman();
                    EkipmanClear();
                }
                catch { MessageBox.Show("İşlem sırasında hata var..."); }
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ekleGuncelle = true;
            cmbSahaAdi.Text = dataGridView2.CurrentRow.Cells["Saha"].Value.ToString();
            txtEkipman.Text = dataGridView2.CurrentRow.Cells["Baslik"].Value.ToString();
            rtbEkipmanAciklama.Text = dataGridView2.CurrentRow.Cells["Aciklama"].Value.ToString();
            txtEkipmanFiyat.Text = dataGridView2.CurrentRow.Cells["Ucret"].Value.ToString();
            txtEkipmanAdet.Text = dataGridView2.CurrentRow.Cells["Adet"].Value.ToString();
        }

        private void ekipmanıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Ekipmanı silmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update ekipmanlars set act=0 where Id=" + dataGridView2.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Ekipman silindi...");
                    GetEkipman();
                }
            }
        }

        private void yeniEkipmanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        { EkipmanClear(); ekleGuncelle = false; }

        private void yeniÜrünToolStripMenuItem_Click(object sender, EventArgs e)
        { SeciliVar = false; txtCafeAdet.Enabled = true; }

        private void txtCafeAdet_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }

        private void txtEkipmanAdet_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }

        private void txtBarkod_TextChanged(object sender, EventArgs e)
        {
            string barcodeText = txtBarkod.Text;
            if (string.IsNullOrEmpty(barcodeText))
            { ptBarkod.Image = null; }
            else { databaseClass.GenerateBarcode(txtBarkod.Text,ptBarkod); }
        }
    }
}
