using DevExpress.XtraCharts;
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
    public partial class FrmOdaDolulukGrafik : Form
    {
        public FrmOdaDolulukGrafik()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmOdaDolulukGrafik_Load(object sender, EventArgs e)
        {
            var durumlar = db.OdaDurum();
            foreach (var x in durumlar)
            {
                chartControl1.Series["Odalar"].Points.AddPoint(x.DurumAd, double.Parse(x.Sayı.ToString()));
            }
        }
    }
}
