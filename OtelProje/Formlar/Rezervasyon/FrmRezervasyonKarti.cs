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

namespace OtelProje.Formlar.Rezervasyon
{
    public partial class FrmRezervasyonKarti : Form
    {
        public FrmRezervasyonKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        public int id;
        Repository<TblRezervasyon> repo = new Repository<TblRezervasyon>();
        TblRezervasyon t = new TblRezervasyon();
        private void FrmRezervasyonKarti_Load(object sender, EventArgs e)
        {
            //Misafir Listesi
            lookUpEditMisafir.Properties.DataSource = (from x in db.TblMisafir
                                                        select new
                                                        {
                                                            x.MisafirID,
                                                            x.AdSoyad
                                                        }).ToList();
            //Oda Listesi
            lookUpEditOda.Properties.DataSource = (from x in db.TblOda
                                                        select new
                                                        {
                                                            x.OdaID,
                                                            x.OdaNo,
                                                            x.TblDurum.DurumAd
                                                        }).Where(y => y.DurumAd == "Aktif").ToList();
            //Durum Listesi
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurum
                                                        select new
                                                        {
                                                            x.DurumID,
                                                            x.DurumAd
                                                        }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            t.GirisTarih = DateTime.Parse(dateEditGiris.Text);
            t.CikisTarih = DateTime.Parse(dateEditCikis.Text);
            t.Kisi = numericUpDown1.Value.ToString();
            t.Oda = int.Parse(lookUpEditOda.EditValue.ToString());
            t.RezervasyonAdSoyad = TxtRezervasyonAdSoyad.Text;
            t.Telefon = TxtTelefon.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            repo.TAdd(t);
            XtraMessageBox.Show("Rezervasyon başarılı bir şekilde kaydedilmiştir.");

        }
    }
}
