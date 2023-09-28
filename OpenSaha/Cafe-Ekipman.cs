using System;
using System.Data;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class Cafe_Ekipman : Form
    {
        public Cafe_Ekipman() { InitializeComponent(); }
        public class rezervasyon
        {
            public int rezervasyonId { get; set; }
            public DateTime baslangicSaat { get; set; }
            public DateTime bitisSaat { get; set; }
            public override string ToString()
            { return baslangicSaat + " - " + bitisSaat; }
        }

        void GetCafe()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("SELECT Id,CONCAT(DATE_FORMAT(CAST((SELECT rz.RandevuBaslangic FROM rezervasyons AS rz WHERE rz.Id=ct.RezervasyonId) AS DATETIME), '%Y-%m-%d : %H-%i'),' - ',DATE_FORMAT(CAST((SELECT rz.RandevuBitis FROM rezervasyons AS rz WHERE rz.Id=ct.RezervasyonId) AS DATETIME), '%Y-%m-%d : %H-%i')) AS Tarih,(SELECT cf.Baslik FROM cafes as cf where cf.Id=ct.CafeId) as Urun,Adet,Ucret,Barkod,(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=ct.YoneticiId limit 1) as Kisi FROM cafetakips as ct where ct.act=1");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Ucret"].DefaultCellStyle.Format = "C2";
        }

        void GetEkipman()
        {
            dataGridView2.DataSource = databaseClass.SqlGet("select Id,CONCAT(DATE_FORMAT(CAST((SELECT rz.RandevuBaslangic FROM rezervasyons AS rz WHERE rz.Id=er.RezervasyonId) AS DATETIME), '%Y-%m-%d : %H-%i'),' - ',DATE_FORMAT(CAST((SELECT rz.RandevuBitis FROM rezervasyons AS rz WHERE rz.Id=er.RezervasyonId) AS DATETIME), '%Y-%m-%d : %H-%i')) AS Tarih,(SELECT ek.Baslik FROM ekipmanlars as ek where ek.Id=er.EkipmanId) as Ekipman,Ucret,Adet,(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=er.YoneticiId limit 1)as Kisi from ekipmanrezervasyons as er where er.act=1");
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Ucret"].DefaultCellStyle.Format = "C2";
        }

        void EkipmanClear()
        {
            cmbEkipmanRezervasyon.ResetText();
            cmbEkipman.ResetText();
            txtEkipmanUcret.ResetText();
            txtEkipmanAdet.ResetText();
            lblEkipmanFiyat.Text = "00";
        }

        void CafeClear()
        {
            cmbCafeRezervasyon.ResetText();
            cmbCafeUrun.ResetText();
            txtCafeAdet.ResetText();
            lblToplamFiyat.Text = "00";
            lblUrunFiyat.Text = "00";
        }

        private void Cafe_Ekipman_Load(object sender, EventArgs e)
        {
            GetEkipman();
            GetCafe();
            cmbEkipmanRezervasyon.Items.Add("Lütfen rezervasyonu seçiniz.");
            cmbEkipman.Items.Add("Lütfen ekipmanı seçiniz.");
            cmbCafeRezervasyon.Items.Add("Lütfen rezervasyonu seçiniz.");
            cmbCafeUrun.Items.Add("Lütfen ürünü seçiniz.");
            txtCafeBarkod.Enabled = false;

            var ekipmanTable = databaseClass.SqlGet("select * from ekipmanlars where Act=1");
            if (ekipmanTable != null)
            {
                foreach (DataRow ekipmanucreti in ekipmanTable.Rows)
                {
                    databaseClass.ekipman ekipman = new databaseClass.ekipman();
                    ekipman.Baslik = ekipmanucreti["Baslik"].ToString();
                    ekipman.EkipmanId = int.Parse(ekipmanucreti["Id"].ToString());
                    cmbEkipman.Items.Add(ekipman);
                }
                cmbEkipman.SelectedIndex = 0;
            }

            var rezervasyonTables = databaseClass.SqlGet("select * from rezervasyons where act=1");
            if (rezervasyonTables != null)
            {
                foreach (DataRow rezerv in rezervasyonTables.Rows)
                {
                    rezervasyon rezervasyon = new rezervasyon();
                    rezervasyon.rezervasyonId = int.Parse(rezerv["Id"].ToString());
                    rezervasyon.baslangicSaat = DateTime.Parse(rezerv["RandevuBaslangic"].ToString());
                    rezervasyon.bitisSaat = DateTime.Parse(rezerv["RandevuBitis"].ToString());
                    cmbCafeRezervasyon.Items.Add(rezervasyon);
                    cmbEkipmanRezervasyon.Items.Add(rezervasyon);
                }
                cmbCafeRezervasyon.SelectedIndex = 0;
                cmbEkipmanRezervasyon.SelectedIndex = 0;
            }

            var cafeTables = databaseClass.SqlGet("select * from cafes where act=1");
            if (cafeTables != null)
            {
                foreach (DataRow cafe in cafeTables.Rows)
                {
                    databaseClass.urun urun = new databaseClass.urun();
                    urun.UrunId = int.Parse(cafe["Id"].ToString());
                    urun.Baslik = cafe["Baslik"].ToString();
                    cmbCafeUrun.Items.Add(urun);
                }
                cmbCafeUrun.SelectedIndex = 0;
            }
        }
        int cikisAdet = 0;
        private void cmbCafeUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            var urunler = cmbCafeUrun.SelectedItem as databaseClass.urun;
            if (urunler == null)
                return;

            var Tables = databaseClass.SqlGet("select * from cafes where Id='" + urunler.UrunId + "'");
            if (Tables != null)
            {
                foreach (DataRow urun in Tables.Rows)
                {
                    Convert.ToDouble(lblUrunFiyat.Text = urun["Fiyat"].ToString());
                    cikisAdet = Convert.ToInt32(urun["Adet"].ToString());
                    txtCafeBarkod.Text = urun["Barkod"].ToString();
                }
            }
            if (Tables.Rows.Count == 0)
                lblUrunFiyat.Text = "0";

            string barcodeText = txtCafeBarkod.Text;
            if (string.IsNullOrEmpty(barcodeText))
            { ptBarkod.Image = null; }
            else { databaseClass.GenerateBarcode(txtCafeBarkod.Text, ptBarkod); }
        }

        bool SeciliVar = false;
        private void btnCafeKayit_Click(object sender, EventArgs e)
        {
            var rezervas = cmbCafeRezervasyon.SelectedItem as rezervasyon;
            if(rezervas == null) return;
            var urun = cmbCafeUrun.SelectedItem as databaseClass.urun;
            if (urun == null) return;
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;

            var tarih = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            int urunCikis = cikisAdet - Convert.ToInt32(txtCafeAdet.Text);

            if (SeciliVar)
            {
                if (cmbCafeRezervasyon.Text == "" || cmbCafeUrun.Text == "" || txtCafeAdet.Text == "" || txtCafeBarkod.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("update cafetakips set RezervasyonId='" + rezervas.rezervasyonId + "',CafeId='" + urun.UrunId + "',Adet='" + txtCafeAdet.Text + "',Barkod='" + txtCafeBarkod.Text + "',YoneticiId='" + yonetici + "',Ucret='" + lblToplamFiyat.Text.Replace(",", ".") + "'where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme başarılı...");
                    GetCafe();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
            else
            {
                if (cmbCafeRezervasyon.Text == "" || cmbCafeUrun.Text == "" || txtCafeAdet.Text == "" || txtCafeBarkod.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("insert into cafetakips (RezervasyonId,CafeId,Barkod,Ucret,Adet,YoneticiId) values('" + rezervas.rezervasyonId + "','" + urun.UrunId + "','" + txtCafeBarkod.Text + "','" + lblToplamFiyat.Text.Replace(",", ".") + "','" + txtCafeAdet.Text + "','" + yonetici + "')");
                    MessageBox.Show("Ekleme başarılı...");
                    GetCafe();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
            if (!SeciliVar)
            {
                if (cmbCafeRezervasyon.Text == "" || cmbCafeUrun.Text == "" || txtCafeAdet.Text == "" || txtCafeBarkod.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try { databaseClass.SqlSend("insert into stoktakips (CafeId,Islem,Barkod,BirimFiyat,Adet,YoneticiId,Tarih) values('" + urun.UrunId + "','" + 1 + "','" + txtCafeBarkod.Text + "','" + lblUrunFiyat.Text + "','" + txtCafeAdet.Text + "','" + yonetici + "','" + tarih + "')"); }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
            if (!SeciliVar)
            {
                if (cmbCafeRezervasyon.Text == "" || cmbCafeUrun.Text == "" || txtCafeAdet.Text == "" || txtCafeBarkod.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try { databaseClass.SqlSend("update cafes set Adet='" + urunCikis + "'where Id='" + cmbCafeUrun.SelectedIndex + "'"); }
                catch { MessageBox.Show("İşlem sırasında hata var..."); }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliVar = true;
            cmbCafeRezervasyon.Text = dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString();
            cmbCafeUrun.Text = dataGridView1.CurrentRow.Cells["Urun"].Value.ToString();
            txtCafeAdet.Text = dataGridView1.CurrentRow.Cells["Adet"].Value.ToString();
            txtCafeBarkod.Text = dataGridView1.CurrentRow.Cells["Barkod"].Value.ToString();
            lblToplamFiyat.Text = dataGridView1.CurrentRow.Cells["Ucret"].Value.ToString();
        }

        private void cafeÜrününüSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Ürünü silmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update cafetakips set act=0 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Ürün başarıyla silindi...");
                    GetCafe();
                    CafeClear();
                }
            }
        }

        private void txtCafeAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtCafeAdet.Text == "")
            {
                lblToplamFiyat.Text = "00";
            }
            try
            {
                double urunFiyat, fiyat, adet;
                urunFiyat = Convert.ToDouble(lblUrunFiyat.Text);
                fiyat = Convert.ToDouble(lblToplamFiyat.Text);
                adet = Convert.ToDouble(txtCafeAdet.Text);

                fiyat = adet * urunFiyat;
                lblToplamFiyat.Text = fiyat.ToString("N2");

            }
            catch (Exception) { }
        }

        private void cmbEkipman_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ucret = databaseClass.SqlGet("select * from ekipmanlars where Baslik='" + cmbEkipman.Text + "'");
            if (ucret != null)
            {
                foreach (DataRow ekipmanucreti in ucret.Rows)
                {
                    databaseClass.ucret Ucret = new databaseClass.ucret();
                    Ucret.Ucret = ekipmanucreti["Ucret"].ToString();
                    Ucret.ekipmanid = int.Parse(ekipmanucreti["Id"].ToString());
                    txtEkipmanUcret.Text = Ucret.ToString();
                }
            }
        }

        private void txtEkipmanAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtCafeAdet.Text == "")
            {
                lblEkipmanFiyat.Text = "00";
            }
            try
            {
                double ekipmanFiyat, fiyat, adet;
                ekipmanFiyat = Convert.ToDouble(txtEkipmanUcret.Text);
                fiyat = Convert.ToDouble(lblToplamFiyat.Text);
                adet = Convert.ToDouble(txtEkipmanAdet.Text);

                fiyat = adet * ekipmanFiyat;
                lblEkipmanFiyat.Text = fiyat.ToString("N2");
            }
            catch (Exception) { }
        }

        bool ekipmanIslemi = false;
        private void btnEkipmanKaydet_Click(object sender, EventArgs e)
        {
            var ekipman = cmbEkipman.SelectedItem as databaseClass.ekipman;
            if (ekipman == null) return;
            var rezervas = cmbEkipmanRezervasyon.SelectedItem as rezervasyon;
            if (rezervas == null) return;
            int yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == 0) return;

            if (ekipmanIslemi)
            {
                if (cmbEkipmanRezervasyon.Text == "" || cmbEkipman.Text == "" || txtEkipmanUcret.Text == "" || txtEkipmanAdet.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("update ekipmanrezervasyons set RezervasyonId='" + rezervas.rezervasyonId + "',EkipmanId='" + ekipman.EkipmanId + "',YoneticiId='" + yonetici + "',Ucret='" + lblEkipmanFiyat.Text.Replace(",", ".") + "',Adet='" + txtEkipmanAdet.Text + "'where Id='" + dataGridView2.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Başarıyla güncellendi...");
                    GetEkipman();
                    EkipmanClear();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
            else
            {
                if (cmbEkipmanRezervasyon.Text == "" || cmbEkipman.Text == "" || txtEkipmanUcret.Text == "" || txtEkipmanAdet.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("insert into ekipmanrezervasyons (RezervasyonId,EkipmanId,YoneticiId,Ucret,Adet) values('" + rezervas.rezervasyonId + "','" + ekipman.EkipmanId + "','" + yonetici + "','" + lblEkipmanFiyat.Text.Replace(",", ".") + "','" + txtEkipmanAdet.Text + "')");
                    MessageBox.Show("Başarıyla eklendi...");
                    EkipmanClear();
                    GetEkipman();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ekipmanIslemi = true;
            cmbEkipmanRezervasyon.Text = dataGridView2.CurrentRow.Cells["Tarih"].Value.ToString();
            cmbEkipman.Text = dataGridView2.CurrentRow.Cells["Ekipman"].Value.ToString();
            txtEkipmanAdet.Text = dataGridView2.CurrentRow.Cells["Adet"].Value.ToString();
            lblEkipmanFiyat.Text = dataGridView2.CurrentRow.Cells["Ucret"].Value.ToString();
        }

        private void ekipmanıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Ekipmanı silmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update ekipmanrezervasyons set act=0 where Id=" + dataGridView2.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Ekipman başarıyla silindi...");
                    GetEkipman();
                    EkipmanClear();
                }
            }
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e) { CafeClear(); SeciliVar = false; }

        private void yeniKayıtToolStripMenuItem1_Click(object sender, EventArgs e) { ekipmanIslemi = false; EkipmanClear(); }

        private void txtCafeAdet_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }

        private void txtEkipmanAdet_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }
    }
}
