using OtelProje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje.Formlar.AnaSayfa
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            //Misafir Listesi
            gridControlMisafir.DataSource = (from x in db.TblMisafir
                                       select new
                                       {
                                           x.AdSoyad

                                       }).ToList();
            //Mesaj Listesi
            gridControlMesaj.DataSource = (from x in db.TblMesaj
                                             select new
                                             {
                                                 x.Gonderen,
                                                 x.Konu

                                             }).ToList();
            //Bugün Gelecek Misafirler Listesi
            gridControlBugunGelecek.DataSource = (from x in db.TblRezervasyon
                                             select new
                                             {
                                                 x.TblMisafir.AdSoyad,
                                                 x.Durum

                                             }).Where(y => y.Durum == 15).ToList();
            //Ürün-Stok Listesi
            gridControlUrunStok.DataSource = (from x in db.TblUrun
                                                  select new
                                                  {
                                                      x.UrunAd,
                                                      x.Toplam

                                                  }).ToList();
            //Ürün-Stok Grafiği
            var urunler = db.TblUrun.ToList();
            foreach (var x in urunler)
            {
                chartControl1.Series["Urun-Stok"].Points.AddPoint(x.UrunAd, double.Parse(x.Toplam.ToString()));
            }
            //Oda Doluluk Grafiği
            var durumlar = db.OdaDurum();
            foreach (var x in durumlar)
            {
                chartControl2.Series["Durumlar"].Points.AddPoint(x.DurumAd,double.Parse(x.Sayı.ToString()));
            }
        }
    }
}
