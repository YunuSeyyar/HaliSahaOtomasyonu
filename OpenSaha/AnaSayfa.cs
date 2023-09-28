using System;
using System.Windows.Forms;

namespace OpenSaha
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.Show();
        }

        private void btnKayitIslemleri_Click(object sender, EventArgs e)
        {
            KullanıcıIslemleri kayitIslemleri = new KullanıcıIslemleri();
            kayitIslemleri.Show();
        }

        private void btnSahalar_Click(object sender, EventArgs e)
        {
            Sahalar sahalar = new Sahalar();
            sahalar.Show();
        }

        private void btnEslesme_Click(object sender, EventArgs e)
        {
            Eslesme eslesme = new Eslesme();
            eslesme.Show();
        }

        private void urunIslenmleri_Click(object sender, EventArgs e)
        {
            UrunIslemleri urunIslemleri = new UrunIslemleri();
            urunIslemleri.Show();
        }

        private void btnCafeEkipman_Click(object sender, EventArgs e)
        {
            Cafe_Ekipman cafe_Ekipman = new Cafe_Ekipman();
            cafe_Ekipman.Show();
        }

        private void btnEkipler_Click(object sender, EventArgs e)
        {
            Ekipler ekipler = new Ekipler();
            ekipler.Show();
        }

        private void btnEkipTakvim_Click(object sender, EventArgs e)
        {
            Ekip_Takvimi ekip_Takvimi = new Ekip_Takvimi();
            ekip_Takvimi.Show();
        }

        private void btnStokTakip_Click(object sender, EventArgs e)
        {
            StokTakibi stokTakibi = new StokTakibi();
            stokTakibi.Show();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            odeme.Show(); 
        }
    }
}
