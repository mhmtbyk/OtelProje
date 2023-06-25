using DevExpress.XtraEditors;
using OtelProje.Entity;
using OtelProje.Repositories;
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
    public partial class FrmKasaCikisKarti : Form
    {
        public FrmKasaCikisKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        public int id;
        Repository<TblKasaCikisHareketi> repo = new Repository<TblKasaCikisHareketi>();
        TblKasaCikisHareketi t = new TblKasaCikisHareketi();
        private void FrmKasaCikisKarti_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.Aciklama = TxtAciklama.Text;
            t.Tarih = DateTime.Parse(dateEdit1.Text);
            t.Tutar = decimal.Parse(TxtToplamTutar.Text);
            repo.TAdd(t);
            XtraMessageBox.Show("Kasa çıkış hareketi kaydedildi");
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
