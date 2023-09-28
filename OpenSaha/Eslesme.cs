using System;
using System.Data;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class Eslesme : Form
    {
        public Eslesme() { InitializeComponent(); }

        void GetEslesme()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("select Id,(select Baslik from takims ke where ke.Id=e.EvSahibi) as 'EvSahibi'," +
                "(select Baslik from takims ke where ke.Id=e.Deplasman) as 'Deplasman',(select Baslik from sahas s where s.Id=e.Sahalar) as 'Saha'," +
                "(select concat(kl.Isim,\" \",kl.Soyisim) FROM kullanicis as kl where kl.YoneticiId=e.YoneticiId limit 1) as Kisi,MacTarihi," +
                "OlusturmaTarihi,AktifSure from eslesmes e where OnayDurum=1");
            dataGridView1.Columns["Id"].Visible = false;
        }

        void Clear()
        {
            cmbEvSahibi.SelectedIndex = 0;
            cmbSahalar.SelectedIndex = 0;
            cmbDeplasman.SelectedIndex = 0;
            dtpAktifSure.ResetText();
            dtpMacTarihi.ResetText();
            dtpOlusturmaTarihi.ResetText();
        }

        private void Eslesme_Load(object sender, EventArgs e)
        {
            GetEslesme();
            cmbEvSahibi.Items.Add("Lütfen ev sahibi takımını seçiniz.");
            cmbDeplasman.Items.Add("Lütfen deplasman takımını seçiniz.");
            cmbSahalar.Items.Add("Lütfen sahayı seçiniz.");
            var evsahibitable = databaseClass.SqlGet("select * from takims where Act = 1");
            if (evsahibitable != null)
            {
                foreach (DataRow ekiplistesi in evsahibitable.Rows)
                {
                    databaseClass.ekiptakvim ekiptakvim = new databaseClass.ekiptakvim();
                    ekiptakvim.Baslik = ekiplistesi["Baslik"].ToString();
                    ekiptakvim.EkipId = int.Parse(ekiplistesi["Id"].ToString());
                    cmbEvSahibi.Items.Add(ekiptakvim);
                    cmbEvSahibi.SelectedIndex = 0;
                }
            }
            var deplasmantable = databaseClass.SqlGet("select * from takims where Act = 1");
            if (deplasmantable != null)
            {
                foreach (DataRow ekiplistesi in deplasmantable.Rows)
                {
                    databaseClass.ekiptakvim ekiptakvim = new databaseClass.ekiptakvim();
                    ekiptakvim.Baslik = ekiplistesi["Baslik"].ToString();
                    ekiptakvim.EkipId = int.Parse(ekiplistesi["Id"].ToString());
                    cmbDeplasman.Items.Add(ekiptakvim);
                    cmbDeplasman.SelectedIndex = 0;
                }
            }

            var sahatable = databaseClass.SqlGet("select * from sahas where Act = 1 and " +
                "YoneticiId='" + databaseClass.yonetici.YoneticiId + "'");
            if (sahatable != null)
            {
                foreach (DataRow sahalistesi in sahatable.Rows)
                {
                    databaseClass.saha saha = new databaseClass.saha();
                    saha.Baslik = sahalistesi["Baslik"].ToString();
                    saha.SahaId = int.Parse(sahalistesi["Id"].ToString());
                    cmbSahalar.Items.Add(saha);
                    cmbSahalar.SelectedIndex = 0;
                }
            }
        }

        bool SeciliVar = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string macTarihi = dtpMacTarihi.Value.ToString("yyyy.MM.dd - HH:mm");
            string olusturmaTarihi = dtpOlusturmaTarihi.Value.ToString("yyyy.MM.dd - HH:mm");
            string aktifSure = dtpAktifSure.Value.ToString("yyyy.MM.dd - HH:mm");

            var evsahibi = cmbEvSahibi.SelectedItem as databaseClass.ekiptakvim;
            if (evsahibi == null) return;
            var deplasman = cmbDeplasman.SelectedItem as databaseClass.ekiptakvim;
            if (deplasman == null) return;
            var sahaid = cmbSahalar.SelectedItem as databaseClass.saha;
            if (sahaid == null) return;
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;

            if (SeciliVar)
            {
                if (cmbEvSahibi.Text == "" || cmbSahalar.Text == "" || cmbDeplasman.Text == cmbEvSahibi.Text)
                { MessageBox.Show("Alanları kontrol ediniz..."); return; }
                try
                {
                    databaseClass.SqlSend("update eslesmes set EvSahibi='" + evsahibi.EkipId + "',Deplasman='" + deplasman.EkipId + "',Sahalar='" + sahaid.SahaId + "',YoneticiId='" + yonetici + "',MacTarihi='" + macTarihi + "',OlusturmaTarihi='" + olusturmaTarihi + "',AktifSure='" + aktifSure + "'where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme başarılı...");
                    GetEslesme();
                    Clear();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
            else
            {
                if (cmbEvSahibi.Text == "" || cmbSahalar.Text == "" || cmbDeplasman.Text == cmbEvSahibi.Text)
                { MessageBox.Show("Alanları kontrol ediniz..."); return; }
                try
                {
                    databaseClass.SqlSend("insert into eslesmes (EvSahibi,Deplasman,Sahalar,YoneticiId,MacTarihi,OlusturmaTarihi,AktifSure) values('" + evsahibi.EkipId + "','" + deplasman.EkipId + "','" + sahaid.SahaId + "','" + yonetici + "','" + macTarihi + "','" + olusturmaTarihi + "','" + aktifSure + "')");
                    MessageBox.Show("Kayıt başarılı...");
                    GetEslesme();
                    Clear();
                }
                catch (Exception) { MessageBox.Show("İşlem sırasında hata var..."); }
            }
        }

        private void eşleşmeyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Eşleşmeyi silmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update eslesmes set OnayDurum=0 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Eşleşme başarıyla silindi...");
                    GetEslesme();
                    Clear();
                }
            }
        }

        private void eşleşmeyionaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Msg = MessageBox.Show("Eşleşmeyi onaylamak istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Msg == DialogResult.Yes)
                {
                    databaseClass.SqlSend("update eslesmes set OnayDurum=2 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                    MessageBox.Show("Eşleşme başarıyla onaylandı...");
                    GetEslesme();
                    Clear();
                }
            }
        }

        private void eşleşmeyiReddetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Msg = MessageBox.Show("Eşleşmeyi reddetmek istediğinize emin misiniz?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Msg == DialogResult.Yes)
            {
                databaseClass.SqlSend("update eslesmes set OnayDurum=3 where Id=" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "");
                MessageBox.Show("Eşleşme başarıyla reddedildi...");
                GetEslesme();
                Clear();
            }
        }

        private void yeniEşleşmeToolStripMenuItem_Click(object sender, EventArgs e)
        { SeciliVar = false; Clear(); }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliVar = true;
            cmbEvSahibi.Text = dataGridView1.CurrentRow.Cells["EvSahibi"].Value.ToString();
            cmbDeplasman.Text = dataGridView1.CurrentRow.Cells["Deplasman"].Value.ToString();
            cmbSahalar.Text = dataGridView1.CurrentRow.Cells["Saha"].Value.ToString();
            dtpMacTarihi.Text = dataGridView1.CurrentRow.Cells["MacTarihi"].Value.ToString();
            dtpOlusturmaTarihi.Text = dataGridView1.CurrentRow.Cells["OlusturmaTarihi"].Value.ToString();
            dtpAktifSure.Text = dataGridView1.CurrentRow.Cells["AktifSure"].Value.ToString();
        }
    }
}
