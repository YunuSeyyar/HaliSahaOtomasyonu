using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenSaha.Cafe_Ekipman;

namespace OpenSaha
{
    public partial class Odeme : Form
    {
        public class rezervasyon
        {
            public int rezervasyonId { get; set; }
            public DateTime baslangicSaat { get; set; }
            public DateTime bitisSaat { get; set; }
            public override string ToString()
            { return baslangicSaat + " - " + bitisSaat; }
        }
        public Odeme() { InitializeComponent(); }
        void GetOdeme()
        {
            dataGridView1.DataSource = databaseClass.SqlGet("SELECT Id,SahaUcret,KafeUcret,EkipmanUcret,CONCAT(DATE_FORMAT(CAST((SELECT rz.RandevuBaslangic FROM rezervasyons AS rz WHERE rz.Id = o.RezervasyonId) AS DATETIME),'%Y-%m-%d : %H-%i'),' - ',DATE_FORMAT(CAST((SELECT rz.RandevuBitis FROM rezervasyons AS rz WHERE rz.Id = o.RezervasyonId) AS DATETIME),'%Y-%m-%d : %H-%i')) AS Tarih,CASE OdemeTipleri WHEN 0 THEN 'Nakit' WHEN 1 THEN 'Kredi Kartı' WHEN 2 THEN 'Sanal Pos' END AS OdemeTipleri,(SELECT sh.Baslik FROM sahas AS sh WHERE sh.Id = o.SahaId) AS Saha,(SELECT CONCAT(kl.Isim, ' ', kl.Soyisim) FROM kullanicis AS kl WHERE kl.YoneticiId = o.YoneticiId limit 1) AS Kisi,Act FROM odemes o WHERE Act = 1");
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Act"].Visible = false;
        }
        void Clear()
        {
            txtSaha.ResetText();
            cmbRezervasyon.ResetText();
            lblCafeUcret.Text = "00";
            lblSahaUcret.Text = "00";
            lblEkipmanUcret.Text = "00";
            rbKrediKartı.Checked = false;
            rbNakit.Checked = false;
            rbSanalPos.Checked = false;
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            cmbRezervasyon.Items.Add("Lütfen rezervasyonu seçiniz.");
            GetOdeme();
            txtSaha.Enabled = false;
            var rezervasyonTables = databaseClass.SqlGet("select * from rezervasyons where act=1");
            if (rezervasyonTables != null)
            {
                foreach (DataRow rezerv in rezervasyonTables.Rows)
                {
                    rezervasyon rezervasyon = new rezervasyon();
                    rezervasyon.rezervasyonId = int.Parse(rezerv["Id"].ToString());
                    rezervasyon.baslangicSaat = DateTime.Parse(rezerv["RandevuBaslangic"].ToString());
                    rezervasyon.bitisSaat = DateTime.Parse(rezerv["RandevuBitis"].ToString());
                    cmbRezervasyon.Items.Add(rezervasyon);
                }
                cmbRezervasyon.SelectedIndex = 0;
            }
        }

        private void cmbRezervasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rezervas = cmbRezervasyon.SelectedItem as rezervasyon;
            if (rezervas == null) return;
            int toplamUcret = 0;
            var sahaTable = databaseClass.SqlGet("SELECT * FROM sahas WHERE Act = 1 AND Id = (SELECT SahaId FROM rezervasyons WHERE Id = " + rezervas.rezervasyonId + ")");
            if (sahaTable != null)
            {
                foreach (DataRow item in sahaTable.Rows)
                {
                    databaseClass.saha saha = new databaseClass.saha();
                    lblSahaUcret.Text = item["Ucret"].ToString();
                    saha.Baslik = item["Baslik"].ToString();
                    saha.SahaId = int.Parse(item["Id"].ToString());
                    txtSaha.Text = saha.Baslik;
                }
            }
            else { lblSahaUcret.Text = "00"; }

            var cafeTable = databaseClass.SqlGet("select * from cafetakips where Act = 1 and RezervasyonId=" + rezervas.rezervasyonId + "");
            if (cafeTable != null)
            {
                foreach (DataRow cafe in cafeTable.Rows)
                { int cafeUcret = Convert.ToInt32(cafe["Ucret"]);
                    toplamUcret += cafeUcret;
                    lblCafeUcret.Text = toplamUcret.ToString();
                }
            }
            else { lblCafeUcret.Text = "00"; }

            var ekipmanTable = databaseClass.SqlGet("select * from ekipmanrezervasyons where Act = 1 and RezervasyonId=" + rezervas.rezervasyonId + "");
            if(ekipmanTable != null)
            {
                foreach (DataRow ekipman in ekipmanTable.Rows)
                { int ekipmanUcret = Convert.ToInt32(ekipman["Ucret"]);
                    toplamUcret += ekipmanUcret;
                    lblEkipmanUcret.Text= toplamUcret.ToString();
                }
            }
            else { lblEkipmanUcret.Text = "00"; } 
        }
        bool SeciliVar = false;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var rezervas = cmbRezervasyon.SelectedItem as rezervasyon;
            if (rezervas == null) return;
            int odemetipi = 0;
            if (rbNakit.Checked) { odemetipi = 0; }
            if (rbKrediKartı.Checked) { odemetipi = 1; }
            if (rbSanalPos.Checked) { odemetipi = 2; }
            int? yonetici = databaseClass.yonetici.YoneticiId;
            if (yonetici == null) return;
            var sahaTable = databaseClass.SqlGet("SELECT * FROM sahas WHERE Act = 1 AND Id = (SELECT SahaId FROM rezervasyons WHERE Id = " + rezervas.rezervasyonId + ")");
            if (sahaTable == null || sahaTable.Rows.Count == 0) return;
            

            DataRow item = sahaTable.Rows[0];
            databaseClass.saha saha = new databaseClass.saha();
            saha.Baslik = item["Baslik"].ToString();
            saha.SahaId = int.Parse(item["Id"].ToString());


            if (SeciliVar)
            {
                if (cmbRezervasyon.Text == "" || (rbKrediKartı.Checked == false && rbNakit.Checked == false && rbSanalPos.Checked == false))
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("update odemes set SahaUcret='" + lblSahaUcret.Text + "',KafeUcret='" + lblCafeUcret.Text + "',EkipmanUcret='" + lblEkipmanUcret.Text + "',RezervasyonId='" + rezervas.rezervasyonId + "',OdemeTipleri='" + odemetipi + "',SahaId='" + saha.SahaId + "',YoneticiId='" + yonetici + "'where Id='" + dataGridView1.CurrentRow.Cells["Id"].Value.ToString() + "'");
                    MessageBox.Show("Güncelleme Başaralı...");
                    Clear();
                    GetOdeme();
                }
                catch { MessageBox.Show("İşlem sırasında hata var!"); }
            }
            else
            {
                if (cmbRezervasyon.Text == "" || (rbKrediKartı.Checked == false && rbNakit.Checked == false && rbSanalPos.Checked == false))
                { MessageBox.Show("Boş alanları doldurunuz..."); return; }
                try
                {
                    databaseClass.SqlSend("insert into odemes(SahaUcret,KafeUcret,EkipmanUcret,RezervasyonId,OdemeTipleri,SahaId,YoneticiId) values ('" + lblSahaUcret.Text + "','" + lblCafeUcret.Text + "','" + lblEkipmanUcret.Text + "','" + rezervas.rezervasyonId + "','" + odemetipi + "','" + saha.SahaId + "','" + yonetici + "')");
                    MessageBox.Show("Ödeme Başaralı...");
                    Clear();
                    GetOdeme();
                }
                catch { MessageBox.Show("İşlem sırasında hata var!"); }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliVar = true;
            cmbRezervasyon.Text = dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString();
            txtSaha.Text = dataGridView1.CurrentRow.Cells["Saha"].Value.ToString();
            lblCafeUcret.Text = dataGridView1.CurrentRow.Cells["KafeUcret"].Value.ToString();
            lblSahaUcret.Text = dataGridView1.CurrentRow.Cells["SahaUcret"].Value.ToString();
            lblEkipmanUcret.Text = dataGridView1.CurrentRow.Cells["EkipmanUcret"].Value.ToString();

            string odemetipi = dataGridView1.Rows[e.RowIndex].Cells["OdemeTipleri"].Value.ToString();
            if (odemetipi == "Nakit") { rbNakit.Checked = true; }
            else if (odemetipi == "Kredi Kartı") { rbKrediKartı.Checked = true; }
            else if (odemetipi == "Sanal Pos") { rbSanalPos.Checked = true; }
        }
    }
}
