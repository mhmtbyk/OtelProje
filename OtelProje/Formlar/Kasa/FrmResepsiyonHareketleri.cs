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

namespace OtelProje.Formlar.Kasa
{
    public partial class FrmResepsiyonHareketleri : Form
    {
        public FrmResepsiyonHareketleri()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void FrmResepsiyonHareketleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblKasaHareketi
                                       select new
                                       {
                                           x.Misafir,
                                           x.Tarih,
                                           x.Tutar
                                       }).ToList();
            ;
        }
    }
}
