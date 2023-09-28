using System;
using System.Data;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class Giris : Form
    {
        public Giris() { InitializeComponent(); mskTelefon.Focus(); }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(mskTelefon.Text))
            { MessageBox.Show("Telefon ve şifre alanları boş olamaz."); return; }
            var Tables = databaseClass.SqlGet("select * from kullanicis where Telefon='" + databaseClass.TelNoDuzeltOn(mskTelefon.Text) + "' and Password='" + databaseClass.SHA1Hash(txtSifre.Text) + "'and UserType=2");
            if (Tables != null && Tables.Rows.Count > 0)
            {
                foreach (DataRow item in Tables.Rows)
                {
                    int yonetici = int.Parse(item["YoneticiId"].ToString());
                    databaseClass.yonetici.YoneticiId = yonetici;
                    MessageBox.Show("Giriş Başarılı...");
                    AnaSayfa anaSayfa = new AnaSayfa();
                    anaSayfa.ShowDialog();
                    this.Close();
                }
            }
            else { MessageBox.Show("Telefon veya şifre yanlış."); }
        }
    }
}
