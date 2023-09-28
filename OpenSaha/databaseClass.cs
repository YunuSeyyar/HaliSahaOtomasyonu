using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace OpenSaha
{
    internal static class databaseClass
    {
        static MySqlConnection baglanti = new MySqlConnection("Server=localhost;" +
            "Database=opensaha;Uid=root;Pwd=''");
        public static string SqlSend(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, baglanti);
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();
                cmd.Connection = baglanti;
                MySqlDataReader dr = cmd.ExecuteReader();
                baglanti.Close();
                return "Basarili";
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static DataTable SqlGet(string sql)
        {
            DataSet DTS = new DataSet();
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                MySqlDataAdapter Adaptor = new MySqlDataAdapter();
                Adaptor.SelectCommand = new MySqlCommand(sql, baglanti);
                Adaptor.Fill(DTS); Adaptor.Dispose();
                baglanti.Close();

                return DTS.Tables[0];
            }
            catch { }
            return null;
        }
        public static string TelNoDuzeltOn(string telno)
        {
            string tel = telno;
            tel = tel.Replace("(", "");
            tel = tel.Replace(")", "");
            tel = tel.Replace(".", "");
            tel = tel.Replace("-", "");
            tel = tel.Replace(" ", "");
            if (tel.Length == 11)
                tel = tel.Substring(1, tel.Length - 1);
            if (tel.Length == 10)
                return tel;
            else
                return "";
        }
        public static string SHA1Hash(string text)
        {
            string source = text;
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Substring(0,30).Replace("-",string.Empty);
                return (hash);
            }
        }
        public static class yonetici
        {
            public static int YoneticiId { get; set; }
        }
        public class kisi
        {
            public string Isim { get; set; }
            public string Soyisim { get; set; }
            public int KullaniciId { get; set; }
            public override string ToString()
            { return Isim + " " + Soyisim; }
        }
        public class saha
        {
            public int SahaId { get; set; }
            public string Baslik { get; set; }
            public override string ToString()
            { return Baslik; }
        }   
        public class sehirliste
        {
            public int sehirid { get; set; }
            public string sehiradi { get; set; }
            public override string ToString()
            { return sehiradi; }
        }
        public class ilceliste
        {
            public int ilceid { get; set; }
            public string ilceadi { get; set; }
            public override string ToString()
            { return ilceadi; }
        }
        public class ucret
        {
            public int ekipmanid { get; set; }
            public string Ucret { get; set; }
            public override string ToString()
            { return Ucret; }
        }
        public class ekipman
        {
            public int EkipmanId { get; set; }
            public string Baslik { get; set; }
            public override string ToString()
            { return Baslik; }
        }
        public class urun
        {
            public int UrunId { get; set; }
            public string Baslik { get; set; }
            public override string ToString()
            { return Baslik; }
        }
        public class ekiptakvim
        {
            public int EkipId { get; set; }
            public string Baslik { get; set; }
            public override string ToString()
            { return Baslik; }
        }
        static BarcodeWriter barcodeWriter;
        public static void GenerateBarcode(string barcode,PictureBox pictureBox)
        {
            barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.CODE_128;
            var barcodeBitmap = barcodeWriter.Write(barcode);

            pictureBox.Image = barcodeBitmap;
        }
    }
}
