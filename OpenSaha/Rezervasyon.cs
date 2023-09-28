using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class Rezervasyon : Form
    {

        public Rezervasyon() { InitializeComponent(); }

        private class sahaSaat
        {
            public int SahaId { get; set; }
            public string Baslik { get; set; }
            public DateTime AcilisSaat { get; set; }
            public DateTime KapanisSaat { get; set; }
            public override string ToString()
            { return Baslik; }
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            cmbSahaIsmi.Items.Add("Lütfen sahayı seçiniz...");
            cmbKullaniciAdi.Items.Add("Lütfen kullanıcı adını seçiniz...");
            cmbEslesme.Items.Add("Varsa eşleşme seçiniz...");
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

            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;
            var sahatable = databaseClass.SqlGet("select * from sahas where Act = 1 and " +
                "YoneticiId='" + databaseClass.yonetici.YoneticiId + "'");
            if (sahatable != null)
            {
                foreach (DataRow item in sahatable.Rows)
                {
                    sahaSaat saha = new sahaSaat();
                    saha.Baslik = item["Baslik"].ToString();
                    saha.SahaId = int.Parse(item["Id"].ToString());
                    saha.AcilisSaat = DateTime.Parse(item["AcilisSaat"].ToString());
                    saha.KapanisSaat = DateTime.Parse(item["KapanisSaat"].ToString());
                    cmbSahaIsmi.Items.Add(saha);
                }
                cmbSahaIsmi.SelectedIndex = 0;
            }

            var eslesmetable = databaseClass.SqlGet("select * from eslesmes where OnayDurum=1");
            if (eslesmetable != null)
                foreach (DataRow eslesme in eslesmetable.Rows)
                    cmbEslesme.Items.Add(eslesme["Id"].ToString());
            cmbEslesme.SelectedIndex = 0;
        }

        private void cmbSahaIsmi_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var saat = cmbSahaIsmi.SelectedItem as sahaSaat;
            if (saat == null)
                return;

            DateTime saatBaslangic = saat.AcilisSaat;
            DateTime saatBitis = saat.KapanisSaat;
            while (saatBaslangic < saatBitis)
            {
                Button button = new Button();
                button.Text = saatBaslangic.ToString("HH:mm") + " - " + saatBaslangic.AddHours(1).ToString("HH:mm");
                button.Tag = saatBaslangic;
                button.Width = 320;
                button.Height = 60;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.Black;
                button.FlatAppearance.BorderSize = 2;

                DataTable rezervasyon = databaseClass.SqlGet("SELECT Durum FROM rezervasyons WHERE Act = 1 AND SahaId = " + saat.SahaId + " AND RandevuBaslangic <= '" + saatBaslangic.ToString("yyyy-MM-dd HH:mm:ss") + "' AND RandevuBitis > '" + saatBaslangic.ToString("yyyy-MM-dd HH:mm:ss") + "'");
                if (rezervasyon != null && rezervasyon.Rows.Count > 0) 
                {
                    int durum = Convert.ToInt32(rezervasyon.Rows[0]["Durum"]);
                    if (durum == 1) { button.BackColor = Color.Yellow; }
                    else if (durum == 2) { button.BackColor = Color.Red; }
                    else { button.BackColor = Color.White; }
                        
                }
                else { button.BackColor = Color.White; }

                button.Click += new EventHandler(button_Click);
                flowLayoutPanel1.Controls.Add(button);
                saatBaslangic = saatBaslangic.AddHours(1);
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            string baslangicTarih = dtpBaslangic.Value.ToString("yyyy-MM-dd");
            string bitisTarih = dtpBitis.Value.ToString("yyyy-MM-dd");

            var kullanici = cmbKullaniciAdi.SelectedItem as databaseClass.kisi;
            if (kullanici == null) return;
            var sahaid = cmbSahaIsmi.SelectedItem as sahaSaat;
            if (sahaid == null) return;
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;

            Button button = (Button)sender;
            DateTime randevuBaslangic = Convert.ToDateTime(button.Tag);
            DateTime randevuBitis = randevuBaslangic.AddHours(1);
            DateTime tarih = randevuBaslangic.Date;

            if (button.BackColor == Color.White)
            {
                DialogResult beklemede = MessageBox.Show("Randevu oluşturmak istiyor musunuz?", button.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (beklemede == DialogResult.Yes)
                {
                    if (cmbKullaniciAdi.Text == "" || cmbSahaIsmi.Text == "")
                    { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                    try
                    {
                        string eslesmeId = string.IsNullOrEmpty(cmbEslesme.Text) ? null : cmbEslesme.Text;
                        databaseClass.SqlSend("insert into rezervasyons(SahaId,RandevuBaslangic,RandevuBitis,KullaniciId,EslesmeId,Durum,YoneticiId) values('" + sahaid.SahaId + "','" + (baslangicTarih + randevuBaslangic.ToString(" HH:mm")) + "','" + (bitisTarih + randevuBitis.ToString(" HH:mm")) + "','" + kullanici.KullaniciId + "','" + eslesmeId + "','" + 1 + "','" + yonetici + "')");
                        MessageBox.Show("Rezervasyon oluşturdunuz...");
                        button.BackColor = Color.Yellow;
                    }
                    catch { MessageBox.Show("İşlem sırasında hata var..."); }
                }
            }
            else if (button.BackColor == Color.Yellow)
            {
                DialogResult onaylandi = MessageBox.Show("Randevuyu onaylamak istiyor musunuz?", button.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onaylandi == DialogResult.Yes)
                {
                    try
                    {
                        databaseClass.SqlSend("update rezervasyons set Durum=2 where '" + button + "'");
                        MessageBox.Show("Rezervasyonu onayladınız...");
                        button.BackColor = Color.Red;
                    }
                    catch { MessageBox.Show("İşlem sırasında hata var..."); }
                }
            }
            else if (button.BackColor == Color.Red)
            {
                DialogResult iptal = MessageBox.Show("Randevuyu iptal etmek istiyor musunuz?", button.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iptal == DialogResult.Yes)
                {
                    try
                    {
                        databaseClass.SqlSend("update rezervasyons set Durum=0 where '" + button + "'");
                        MessageBox.Show("Rezervasyonu onayladınız...");
                        button.BackColor = Color.White;
                    }
                    catch { MessageBox.Show("İşlem sırasında hata var..."); }
                }
            }
        }
    }
}
