using System;
using System.Data;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class Ekipler : Form
    {
        public Ekipler() { InitializeComponent(); }

        void GetEkipler()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("select Id,(select concat_ws(' ',kl.Isim,kl.Soyisim) as 'Ad-Soyad' from kullanicis as kl " +
                "where kl.Id=KullaniciId) as Kullanici,(select sl.SehirAdi as sehir from sehirlistes as sl where sl.Id=SehirId) as Sehir," +
                "(select il.IlceAdi as ilce from ilcelistes as il where il.Id=IlceId) as Ilce,Kadro,Baslik from takims where act=1");
            dataGridView1.Columns["Id"].Visible = false;
        }

        void Clear()
        {
            cmbIlce.SelectedIndex = 0;
            cmbSehir.SelectedIndex = 0;
            cmbKullanici.SelectedIndex = 0;
            txtKadro.ResetText();
            txtTakımAdı.ResetText();
        }

        private void Ekipler_Load(object sender, EventArgs e)
        {
            GetEkipler();
            cmbKullanici.Items.Add("Lütfen kullanıcıyı seçiniz.");
            cmbSehir.Items.Add("Lütfen şehri seçiniz.");

            var kullanicitable = databaseClass.SqlGet("select * from kullanicis where Act = 1");
            if (kullanicitable != null)
            {
                foreach (DataRow item in kullanicitable.Rows)
                {
                    databaseClass.kisi kisi = new databaseClass.kisi();
                    kisi.Isim = item["Isim"].ToString();
                    kisi.Soyisim = item["Soyisim"].ToString();
                    kisi.KullaniciId = int.Parse(item["Id"].ToString());
                    cmbKullanici.Items.Add(kisi);
                }
                cmbKullanici.SelectedIndex = 0;
            }
            var SehirTables = databaseClass.SqlGet("select * from sehirlistes");
            if (SehirTables != null)
            {
                foreach (DataRow sehirlistesi in SehirTables.Rows)
                {
                    databaseClass.sehirliste sehir = new databaseClass.sehirliste();
                    sehir.sehiradi = sehirlistesi["SehirAdi"].ToString();
                    sehir.sehirid = int.Parse(sehirlistesi["Id"].ToString());
                    cmbSehir.Items.Add(sehir);
                }
                cmbSehir.SelectedIndex = 0;
            }
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
            var sehir = cmbSehir.SelectedItem as databaseClass.sehirliste;
            if (sehir == null)
                return;

            var IlceTables = databaseClass.SqlGet("select * from ilcelistes where SehirId='" + sehir.sehirid + "'");
            if (IlceTables != null)
            {
                foreach (DataRow ilcelistesi in IlceTables.Rows)
                {
                    databaseClass.ilceliste ilce = new databaseClass.ilceliste();
                    ilce.ilceadi = ilcelistesi["IlceAdi"].ToString();
                    ilce.ilceid = int.Parse(ilcelistesi["Id"].ToString());
                    cmbIlce.Items.Add(ilce);
                }
            }
        }

        bool SeciliVar = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var kullanici = cmbKullanici.SelectedItem as databaseClass.kisi;
            if (kullanici == null)
                return;
            var sehir = cmbSehir.SelectedItem as databaseClass.sehirliste;
            if (sehir == null)
                return;
            var ilce = cmbIlce.SelectedItem as databaseClass.ilceliste;
            if (ilce == null)
                return;

            if (SeciliVar)
            {
                if (cmbKullanici.Text == "" || cmbSehir.Text == "" || cmbIlce.Text == "" || txtKadro.Text == "" || txtTakımAdı.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    databaseClass.SqlSend("update takims set KullaniciId='" + kullanici.KullaniciId + "',SehirId='" + sehir.sehirid + "',IlceId='" + ilce.ilceid + "',Kadro='" + txtKadro.Text + "',Baslik='" + txtTakımAdı.Text + "'where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme başarılı...");
                    GetEkipler();
                    Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Güncelleme sırasında hata oluştu...");
                }
            }
            else
            {
                if (cmbKullanici.Text == "" || cmbSehir.Text == "" || cmbIlce.Text == "" || txtKadro.Text == "" || txtTakımAdı.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz."); return; }
                try
                {
                    databaseClass.SqlSend("insert into takims (KullaniciId,SehirId,IlceId,Kadro,Baslik) values('" + kullanici.KullaniciId + "','" + sehir.sehirid + "','" + ilce.ilceid + "','" + txtKadro.Text + "','" + txtTakımAdı.Text + "')");
                    MessageBox.Show("Kayıt başarılı...");
                    GetEkipler();
                    Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu...");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliVar = true;
            cmbKullanici.Text = dataGridView1.CurrentRow.Cells["Kullanici"].Value.ToString();
            cmbSehir.Text = dataGridView1.CurrentRow.Cells["Sehir"].Value.ToString();
            cmbIlce.Text = dataGridView1.CurrentRow.Cells["Ilce"].Value.ToString();
            txtKadro.Text = dataGridView1.CurrentRow.Cells["Kadro"].Value.ToString();
            txtTakımAdı.Text = dataGridView1.CurrentRow.Cells["Baslik"].Value.ToString();
        }

        private void ekibiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Ekibi silmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update takims set act=0 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Ekip başarıyla silindi...");
                    GetEkipler();
                    Clear();
                }
            }
        }

        private void yeniEkipToolStripMenuItem_Click(object sender, EventArgs e)
        { Clear(); SeciliVar = false; }

        private void txtKadro_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }
    }
}
