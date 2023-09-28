using System;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class KullanıcıIslemleri : Form
    {
        public KullanıcıIslemleri() { InitializeComponent(); }

        private void KayitIslemleri_Load(object sender, EventArgs e)
        { Clear(); GetUser(); }

        bool SeciliVar = false;
        private void kullaniciEkleme_Click(object sender, EventArgs e)
        {
            string dogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Text).ToString("yyyy-MM-dd");
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;

            if (SeciliVar)
            {
                if (txtIsim.Text == "" || txtSoyisim.Text == "" || String.IsNullOrEmpty(databaseClass.TelNoDuzeltOn(mskTelefon.Text)) || txtEmail.Text == "" || txtSifre.Text == "" )
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("update kullanicis SET Isim='" + txtIsim.Text + "',Soyisim='" + txtSoyisim.Text + "',Telefon='" + databaseClass.TelNoDuzeltOn(mskTelefon.Text) + "',Email='" + txtEmail.Text  + "',DogumTarihi='" + dogumTarihi + "',Password='" + databaseClass.SHA1Hash(txtSifre.Text) + "',Puan='" + txtPuan.Text + "',YoneticiId='" + yonetici + "' where Id='" + dataGridView2.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme başarılı...");
                    GetUser();
                    Clear();
                }
                catch { MessageBox.Show("İşlem sırasında hata var!"); }
            }
            else
            {
                if (txtIsim.Text == "" || txtSoyisim.Text == "" || String.IsNullOrEmpty(databaseClass.TelNoDuzeltOn(mskTelefon.Text)) || txtEmail.Text == "" || txtSifre.Text == "")
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("insert into kullanicis (Isim,Soyisim,Telefon,Email,Password,DogumTarihi,Puan,YoneticiId) values('" + txtIsim.Text + "','" + txtSoyisim.Text + "','" + databaseClass.TelNoDuzeltOn(mskTelefon.Text) + "','" + txtEmail.Text + "','" + databaseClass.SHA1Hash(txtSifre.Text) + "','" + dogumTarihi + "','" + txtPuan.Text + "','" + yonetici + "')");
                    MessageBox.Show("Kullanıcı kaydı başarılı...");
                    Clear();
                    GetUser();
                }
                catch { MessageBox.Show("İşlem sırasında hata var!"); }
            }
        }

        void GetUser()
        {
            dataGridView2.DataSource = databaseClass.SqlGet("select Id,Isim,Soyisim,Telefon,Email,Password,DogumTarihi,Puan,UserType,(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=k.YoneticiId limit 1) as Kisi,Act from kullanicis k where act=1");
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Act"].Visible = false;
            dataGridView2.Columns["UserType"].Visible = false;
            dataGridView2.Columns["Password"].Visible = false;
        }

        private void yeniKullanici_Click(object sender, EventArgs e)
        {
            Clear();
            kullaniciEdit.Visible = true;
            SeciliVar = false;
            GetUser();  
        }

        void Clear()
        {
            kullaniciEdit.Visible = false;
            txtIsim.ResetText();
            txtSoyisim.ResetText();
            mskTelefon.ResetText();
            txtEmail.ResetText();
            txtSifre.ResetText();
            txtPuan.ResetText();
        }

        private void btnclosed_Click(object sender, EventArgs e)
        { if (kullaniciEdit.Visible == true) kullaniciEdit.Visible = false; }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Kullanıcıyı Sileceğinizden Emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update kullanicis set act=0 where Id=" + dataGridView2.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Kullanıcı başarıyla silindi...");
                    Clear();
                    GetUser();
                }
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            kullaniciEdit.Visible = true;
            SeciliVar = true;
            txtIsim.Text = dataGridView2.CurrentRow.Cells["Isim"].Value.ToString();
            txtSoyisim.Text = dataGridView2.CurrentRow.Cells["Soyisim"].Value.ToString();
            mskTelefon.Text = dataGridView2.CurrentRow.Cells["Telefon"].Value.ToString();
            txtEmail.Text = dataGridView2.CurrentRow.Cells["Email"].Value.ToString();
            txtSifre.Text = dataGridView2.CurrentRow.Cells["Password"].Value.ToString();
            txtPuan.Text = dataGridView2.CurrentRow.Cells["Puan"].Value.ToString();
            dtpDogumTarihi.Text = dataGridView2.CurrentRow.Cells["DogumTarihi"].Value.ToString();
        }

        private void mskTelefon_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }

        private void txtPuan_KeyPress(object sender, KeyPressEventArgs e)
        { if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; } }
    }
}