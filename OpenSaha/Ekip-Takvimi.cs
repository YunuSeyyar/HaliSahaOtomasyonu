using System;
using System.Data;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class Ekip_Takvimi : Form
    {
        public Ekip_Takvimi() { InitializeComponent(); }

        void GetEkipTakvim()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("select Id,(select Baslik from takims ke where ke.Id=k.TakimId) as 'Baslik',(select concat_ws(' ',kl.Isim,kl.Soyisim) as 'Ad-Soyad' from kullanicis as kl where kl.Id=k.KullaniciId) as Kullanici,(select sh.Baslik as saha from sahas as sh where sh.Id=SahaId) as Saha,TarihBaslangic,TarihBitis from takimtakvims k where act=1");
            dataGridView1.Columns["Id"].Visible = false;
        }

        void Clear()
        {
            txtKullanici.ResetText();
            cmbEkip.ResetText();
            dtpTarihBitis.ResetText();
            dtpTarihBaslangic.ResetText();
        }

        private void Ekip_Takvimi_Load(object sender, EventArgs e)
        {
            txtKullanici.Enabled = false;
            GetEkipTakvim();
            cmbEkip.Items.Add("Lütfen takımı seçiniz");
            cmbSaha.Items.Add("Lütfen sahayı seçiniz");
            var ekiptable = databaseClass.SqlGet("select * from takims where Act = 1");
            if (ekiptable != null)
            {
                foreach (DataRow ekiplistesi in ekiptable.Rows)
                {
                    databaseClass.ekiptakvim ekiptakvim = new databaseClass.ekiptakvim();
                    ekiptakvim.Baslik = ekiplistesi["Baslik"].ToString();
                    ekiptakvim.EkipId = int.Parse(ekiplistesi["Id"].ToString());
                    cmbEkip.Items.Add(ekiptakvim);
                }
                cmbEkip.SelectedIndex = 0;
            }
            var sahatable = databaseClass.SqlGet("select * from sahas where Act = 1 and YoneticiId='" + databaseClass.yonetici.YoneticiId + "'");
            if (sahatable != null)
            {
                foreach (DataRow item in sahatable.Rows)
                {
                    databaseClass.saha saha = new databaseClass.saha();
                    saha.Baslik = item["Baslik"].ToString();
                    saha.SahaId = int.Parse(item["Id"].ToString());
                    cmbSaha.Items.Add(saha);
                }
                cmbSaha.SelectedIndex = 0;
            }
        }
        private void cmbEkip_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKullanici.ResetText();
            var ekip = cmbEkip.SelectedItem as databaseClass.ekiptakvim;
            if (ekip == null) return;

            var kullaniciTables = databaseClass.SqlGet("select * from kullanicis where Id=(select KullaniciId from takims where Id='" + ekip.EkipId + "')");
            if (kullaniciTables != null)
            {
                foreach (DataRow item in kullaniciTables.Rows)
                {
                    databaseClass.kisi kisi = new databaseClass.kisi();
                    kisi.Isim = item["Isim"].ToString();
                    kisi.Soyisim = item["Soyisim"].ToString();
                    kisi.KullaniciId = int.Parse(item["Id"].ToString());
                    txtKullanici.Text = kisi.ToString();
                }
            }
        }

        bool SeciliVar = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var ekip = cmbEkip.SelectedItem as databaseClass.ekiptakvim;
            if (ekip == null) return;
            var sahaid = cmbSaha.SelectedItem as databaseClass.saha;
            if (sahaid == null) return;
            var kullaniciTables = databaseClass.SqlGet("select * from kullanicis where Id=(select KullaniciId from takims where Id='" + ekip.EkipId + "')");
            if (kullaniciTables == null || kullaniciTables.Rows.Count == 0)
            { MessageBox.Show("Kullanıcı bulunamadı."); return; }

            DataRow item = kullaniciTables.Rows[0];
            databaseClass.kisi kullanici = new databaseClass.kisi();
            kullanici.Isim = item["Isim"].ToString();
            kullanici.Soyisim = item["Soyisim"].ToString();
            kullanici.KullaniciId = int.Parse(item["Id"].ToString());

            string baslangicTarih = dtpTarihBaslangic.Value.ToString("yyyy.MM.dd - HH:mm");
            string bitisTarih = dtpTarihBitis.Value.ToString("yyyy.MM.dd - HH:mm");

            if (SeciliVar)
            {
                if (cmbEkip.Text == "" || cmbSaha.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    databaseClass.SqlSend("update takimtakvims set TakimId='" + ekip.EkipId + "',KullaniciId='" + kullanici.KullaniciId + "',SahaId='" + sahaid.SahaId + "',TarihBaslangic='" + baslangicTarih + "',TarihBitis='" + bitisTarih + "'where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme başarılı...");
                    GetEkipTakvim();
                    Clear();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
            else
            {
                if (cmbEkip.Text == "" || cmbSaha.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    databaseClass.SqlSend("insert into takimtakvims (TakimId,KullaniciId,SahaId,TarihBaslangic,TarihBitis) values('" + ekip.EkipId + "','" + kullanici.KullaniciId + "','" + sahaid.SahaId + "','" + baslangicTarih + "','" + bitisTarih + "')");
                    MessageBox.Show("Kayıt başarılı...");
                    GetEkipTakvim();
                    Clear();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
        }

        private void ekibiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Ekibi silmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update takimtakvims set act=0 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Ekip silindi...");
                    GetEkipTakvim();
                    Clear();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliVar = true;
            cmbEkip.Text = dataGridView1.CurrentRow.Cells["Baslik"].Value.ToString();
            txtKullanici.Text = dataGridView1.CurrentRow.Cells["Kullanici"].Value.ToString();
            cmbSaha.Text = dataGridView1.CurrentRow.Cells["Saha"].Value.ToString();
            dtpTarihBaslangic.Text = dataGridView1.CurrentRow.Cells["TarihBaslangic"].Value.ToString();
            dtpTarihBitis.Text = dataGridView1.CurrentRow.Cells["TarihBitis"].Value.ToString();
        }

        private void yeniEkipToolStripMenuItem_Click(object sender, EventArgs e)
        { SeciliVar = false; Clear(); }
    }
}
