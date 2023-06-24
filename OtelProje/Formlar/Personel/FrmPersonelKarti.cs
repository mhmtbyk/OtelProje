using DevExpress.XtraEditors;
using OtelProje.Entity;
using OtelProje.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();

        public int id;
        Repository<TblPersonel> repo = new Repository<TblPersonel>();
        public string kimlik1;
        public string kimlik2;

        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {

            if (id != 0)
            {
                var personel = repo.Find(x => x.PersonelID == id);
                TxtAdSoyad.Text = personel.AdSoyad;
                TxtTc.Text = personel.TC;
                TxtAdres.Text = personel.Adres;
                TxtTelefon.Text = personel.Telefon;
                TxtMail.Text = personel.Mail;
                dateEditGiris.Text = personel.IseGirisTarihi.ToString();
                dateEditCikis.Text = personel.IstenCikisTarih.ToString();
                TxtAciklama.Text = personel.Aciklama;
                TxtSifre.Text = personel.Sifre;
                pictureEditKimlikOn.Image = Image.FromFile(personel.KimlikOn);
                pictureEditKimlikArka.Image = Image.FromFile(personel.KimlikArka);
                kimlik1 = personel.KimlikOn; 
                kimlik2 = personel.KimlikArka;
                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGorev.EditValue = personel.Gorev;
            }

            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartman
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd
                                                         }).ToList();
            lookUpEditGorev.Properties.DataSource = (from x in db.TblGorev
                                                         select new
                                                         {
                                                             x.GorevID,
                                                             x.GorevAd
                                                         }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTc.Text;
            t.Adres = TxtAdres.Text;
            t.Telefon = TxtTelefon.Text;
            t.IseGirisTarihi = DateTime.Parse(dateEditGiris.Text);
            t.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            t.Aciklama = TxtAciklama.Text;
            t.Mail = TxtMail.Text;
            t.KimlikOn = pictureEditKimlikOn.GetLoadedImageLocation() ;
            t.KimlikArka = pictureEditKimlikArka.GetLoadedImageLocation();
            t.Sifre = TxtSifre.Text;
            t.Durum = 1;
            repo.TAdd(t);
            XtraMessageBox.Show("Personel başarılı bir şekilde kaydedildi.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTc.Text;
            deger.Adres = TxtAdres.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.IseGirisTarihi = DateTime.Parse(dateEditGiris.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.Gorev = int.Parse(lookUpEditGorev.EditValue.ToString());
            deger.Aciklama = TxtAciklama.Text;
            deger.Mail = TxtMail.Text;
            deger.KimlikOn = kimlik1;
            deger.KimlikArka = kimlik2;
            deger.Sifre = TxtSifre.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel bilgileri başarıyla güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pictureEditKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            kimlik1 = pictureEditKimlikOn.GetLoadedImageLocation().ToString();
        }

        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            kimlik2 = pictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }
    }
}
