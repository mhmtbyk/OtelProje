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

namespace OtelProje.Formlar.Grafikler
{
    public partial class FrmUrunStokGrafik : Form
    {
        public FrmUrunStokGrafik()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmGrafik1_Load(object sender, EventArgs e)
        {
            var urunler = db.TblUrun.ToList();
            foreach (var x in urunler)
            {
                chartControl1.Series["Urun-Stok"].Points.AddPoint(x.UrunAd, double.Parse(x.Toplam.ToString()));
            }
        }
    }
}
