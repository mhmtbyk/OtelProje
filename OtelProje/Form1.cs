using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDurumTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDurum fr = new Formlar.Tanımlamalar.FrmDurum();
            fr.Show();
        }

        private void BtnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmBirim fr = new Formlar.Tanımlamalar.FrmBirim();
            fr.Show();
        }

        private void BtnDepartmanTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDepartman fr = new Formlar.Tanımlamalar.FrmDepartman();
            fr.Show();
        }

        private void BtnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmGorev fr = new Formlar.Tanımlamalar.FrmGorev();
            fr.Show();
        }

        private void BtnKasaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKasa fr = new Formlar.Tanımlamalar.FrmKasa();
            fr.Show();
        }

        private void BtnKurTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKurlar fr = new Formlar.Tanımlamalar.FrmKurlar();
            fr.Show();
        }

        private void BtnOdaTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmOda fr = new Formlar.Tanımlamalar.FrmOda();
            fr.Show();
        }

        private void BtnTelefonTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmTelefon fr = new Formlar.Tanımlamalar.FrmTelefon();
            fr.Show();
        }

        private void BtnUlkeTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmUlke fr = new Formlar.Tanımlamalar.FrmUlke();
            fr.Show();
        }

        private void BtnUrunGrupTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmUrunGrup fr = new Formlar.Tanımlamalar.FrmUrunGrup();
            fr.Show();
        }

        private void BtnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelKarti fr = new Formlar.Personel.FrmPersonelKarti();
            fr.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelListesi fr = new Formlar.Personel.FrmPersonelListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnMisafirKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir.FrmMisafirKarti fr = new Formlar.Misafir.FrmMisafirKarti();
            fr.Show();
        }

        private void BtnMisafirListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Misafir.FrmMisafirListesi fr = new Formlar.Misafir.FrmMisafirListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunListesi fr = new Formlar.Urun.FrmUrunListesi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunKarti fr = new Formlar.Urun.FrmUrunKarti();
            fr.Show();
        }

        private void BtnUrunGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunGirisHareketleri fr = new Formlar.Urun.FrmUrunGirisHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnUrunCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunCikisHareketleri fr = new Formlar.Urun.FrmUrunCikisHareketleri();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniUrunHareketi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Urun.FrmUrunHareketTanimi fr = new Formlar.Urun.FrmUrunHareketTanimi();
            fr.Show();
        }

        private void BtnRezervasyonKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmRezervasyonKarti fr = new Formlar.Rezervasyon.FrmRezervasyonKarti();
            fr.Show();
        }

        private void BtnTumRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmTumRezervasyonlar fr = new Formlar.Rezervasyon.FrmTumRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAktifRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmAktifRezervasyon fr = new Formlar.Rezervasyon.FrmAktifRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnIptalRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmIptalRezervasyon fr = new Formlar.Rezervasyon.FrmIptalRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGecmisRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGecmisRezervasyonlar fr = new Formlar.Rezervasyon.FrmGecmisRezervasyonlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGelecekRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGelecekRezervasyon fr = new Formlar.Rezervasyon.FrmGelecekRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");

        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmKurlar fr = new Formlar.Araclar.FrmKurlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmYoutube fr = new Formlar.Araclar.FrmYoutube();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGoogle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmGoogle fr = new Formlar.Araclar.FrmGoogle();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniKayitlar_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmYeniKayit fr = new Formlar.WebSite.FrmYeniKayit();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnOnRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmOnRezervasyon fr = new Formlar.WebSite.FrmOnRezervasyon();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnGelenMesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmGelenMesajlar fr = new Formlar.WebSite.FrmGelenMesajlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnYeniMesaj_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmMesajKarti fr = new Formlar.WebSite.FrmMesajKarti();
            fr.Show();
        }

        private void BtnGidenMesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmGidenMesajlar fr = new Formlar.WebSite.FrmGidenMesajlar();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnIletisim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmIletisim fr = new Formlar.WebSite.FrmIletisim();
            fr.MdiParent = this;
            fr.Show();
        }

        private void BtnAdresKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmAdresKarti fr = new Formlar.WebSite.FrmAdresKarti();
            fr.Show();
        }

        private void BtnHakkimizdaKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.WebSite.FrmHakkimizda fr = new Formlar.WebSite.FrmHakkimizda();
            fr.Show();
        }

        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.AnaSayfa.FrmAnaSayfa fr = new Formlar.AnaSayfa.FrmAnaSayfa();
            fr.MdiParent = this;
            fr.Show();
        }
        private void BtnUrunStokGrafik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Grafikler.FrmUrunStokGrafik fr = new Formlar.Grafikler.FrmUrunStokGrafik();
            fr.MdiParent = this;
            fr.Show();
        }
        private void BtnGrafik1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Grafikler.FrmOdaDolulukGrafik fr = new Formlar.Grafikler.FrmOdaDolulukGrafik();
            fr.MdiParent = this;
            fr.Show();
        }

        
    }
}
