using System;
using System.Data;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class Sahalar : Form
    {
        public Sahalar() { InitializeComponent(); }

        void Clear()
        {
            cmbSehir.ResetText();
            cmbIlce.ResetText();
            cmbKullaniciAdi.ResetText();
            txtSahaIsmi.ResetText();
            txtOzellik.ResetText();
            rtAciklama.ResetText();
            txtSahaUcret.ResetText();
            rbAcik.Text = "Açık";
            rbKapali.Text = "Kapalı";
            rbAcik.Checked = false;
            rbKapali.Checked = false;
            cbYirmiDort.Checked = false;
        }

        void GetUser()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("select Id,(select sl.SehirAdi as sehir from sehirlistes as sl where sl.Id=sa.SehirId) as Sehir,(select il.IlceAdi as Ilce from ilcelistes as il where il.Id=sa.IlceId) as Ilce,(select concat_ws(' ',kl.Isim,kl.Soyisim) as 'Ad-Soyad' from kullanicis as kl where kl.Id=KullaniciId) as Kullanici,Baslik,Aciklama,AcilisSaat,KapanisSaat,YirmiDortSaat,Ozellik,Ucret,(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=sa.YoneticiId limit 1) as Kisi,(case SahaTipi when 0 then \"Kapalı\" else \"Açık\" end)as SahaTipi from sahas as sa where sa.act=1");
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void Sahalar_Load(object sender, EventArgs e)
        {
            GetUser();
            cmbSehir.Items.Add("Lütfen şehri seçiniz...");
            cmbKullaniciAdi.Items.Add("Lütfen kullanıcıyı seçiniz");
            cmbIlce.Enabled = false;
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

            var kullanicitable = databaseClass.SqlGet("select * from kullanicis where Act = 1");
            if (kullanicitable != null)
            {
                foreach (DataRow item in kullanicitable.Rows)
                {
                    databaseClass.kisi kisi = new databaseClass.kisi();
                    kisi.Isim = item["Isim"].ToString();
                    kisi.Soyisim = item["Soyisim"].ToString();
                    kisi.KullaniciId = int.Parse(item["Id"].ToString());
                    cmbKullaniciAdi.Items.Add(kisi);
                }
                cmbKullaniciAdi.SelectedIndex = 0;
            }
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
            cmbIlce.Enabled = true;
            var sehir = cmbSehir.SelectedItem as databaseClass.sehirliste;
            if (sehir == null) return;

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
        private void btnSahaKaydı_Click(object sender, EventArgs e)
        {
            int sahatipi = 0;
            if (rbAcik.Checked) { sahatipi = 1; }
            if (rbKapali.Checked) { sahatipi = 0; }

            int yirmiDort = 0;
            if (cbYirmiDort.Checked) { yirmiDort = 1; }

            string acilisSaat = dtpAcilisSaat.Value.ToString("yyyy.MM.dd - HH:mm");
            string kapanisSaat = dtpKapanisSaat.Value.ToString("yyyy.MM.dd - HH:mm");

            var sehir = cmbSehir.SelectedItem as databaseClass.sehirliste;
            if (sehir == null) return;
            var ilce = cmbIlce.SelectedItem as databaseClass.ilceliste;
            if (ilce == null) return;
            var kullanici = cmbKullaniciAdi.SelectedItem as databaseClass.kisi;
            if (kullanici == null) return;
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;

            if (SeciliVar)
            {
                try
                {
                    if (cmbSehir.Text == "" || cmbIlce.Text == "" || cmbKullaniciAdi.Text == "" || txtSahaIsmi.Text == "" || txtSahaUcret.Text == "" || (rbAcik.Checked == false && rbKapali.Checked == false))
                    { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                    databaseClass.SqlSend("update sahas set SehirId='" + sehir.sehirid + "',IlceId='" + ilce.ilceid + "',KullaniciId='" + kullanici.KullaniciId + "',Baslik='" + txtSahaIsmi.Text + "',Aciklama='" + rtAciklama.Text + "',AcilisSaat='" + acilisSaat + "',KapanisSaat='" + kapanisSaat + "',YirmiDortSaat='" + yirmiDort + "',SahaTipi='" + sahatipi + "',Ozellik='" + txtOzellik.Text + "',Ucret='" + Convert.ToDouble(txtSahaUcret.Text) + "',YoneticiId='" + yonetici + "' where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme Başarılı...");
                    GetUser();
                    Clear();
                }
                catch { MessageBox.Show("İşlem sırasında hata var!"); }
            }
            else
            {
                if (cmbSehir.Text == "" || cmbIlce.Text == "" || cmbKullaniciAdi.Text == "" || txtSahaIsmi.Text == "" || txtSahaUcret.Text == "" || (rbAcik.Checked == false && rbKapali.Checked == false))
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("insert into sahas (SehirId,IlceId,KullaniciId,Baslik,Aciklama,AcilisSaat,KapanisSaat,YirmiDortSaat,Ozellik,Ucret,YoneticiId,SahaTipi) values('" + sehir.sehirid + "','" + ilce.ilceid + "','" + kullanici.KullaniciId + "','" + txtSahaIsmi.Text + "','" + rtAciklama.Text + "','" + acilisSaat + "','" + kapanisSaat + "','" + yirmiDort + "','" + txtOzellik.Text + "','" + Convert.ToDouble(txtSahaUcret.Text) + "','" + yonetici + "','" + sahatipi + "')");
                    MessageBox.Show("Saha kaydı başarılı...");
                    GetUser();
                    Clear();
                }
                catch { MessageBox.Show("İşlem sırasında hata var!"); }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliVar = true;
            string sahatipi = dataGridView1.Rows[e.RowIndex].Cells["SahaTipi"].Value.ToString();
            if (sahatipi == "Açık") { rbAcik.Checked = true; }
            else if (sahatipi == "Kapalı") { rbKapali.Checked = true; }
            string yirmiDort = dataGridView1.Rows[e.RowIndex].Cells["YirmiDortSaat"].Value.ToString();
            if (yirmiDort == "True") { cbYirmiDort.Checked = true; }
            else { cbYirmiDort.Checked = false; }

            cmbSehir.Text = dataGridView1.CurrentRow.Cells["Sehir"].Value.ToString();
            cmbIlce.Text = dataGridView1.CurrentRow.Cells["Ilce"].Value.ToString();
            cmbKullaniciAdi.Text = dataGridView1.CurrentRow.Cells["Kullanici"].Value.ToString();
            txtSahaIsmi.Text = dataGridView1.CurrentRow.Cells["Baslik"].Value.ToString();
            rtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            dtpAcilisSaat.Text = dataGridView1.CurrentRow.Cells["AcilisSaat"].Value.ToString();
            dtpKapanisSaat.Text = dataGridView1.CurrentRow.Cells["KapanisSaat"].Value.ToString();
            txtOzellik.Text = dataGridView1.CurrentRow.Cells["Ozellik"].Value.ToString();
            txtSahaUcret.Text = dataGridView1.CurrentRow.Cells["Ucret"].Value.ToString();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Sahayı silmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update sahas set act=0 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Saha başarıyla silindi...");
                    GetUser();
                    Clear();
                }
            }
        }

        private void yeniSahaToolStripMenuItem_Click(object sender, EventArgs e)
        { Clear(); SeciliVar = false; }

        private void txtSahaUcret_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }

        private void cbYirmiDort_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYirmiDort.Checked) { dtpAcilisSaat.Enabled = false; dtpKapanisSaat.Enabled = false; }
            else { dtpAcilisSaat.Enabled = true; dtpKapanisSaat.Enabled = true; }
        }
    }
}
