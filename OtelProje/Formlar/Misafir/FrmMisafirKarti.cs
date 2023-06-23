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

namespace OtelProje.Formlar.Misafir
{
    public partial class FrmMisafirKarti : Form
    {
        public FrmMisafirKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        string kimlik1, kimlik2;
        public int id;
        Repository<TblMisafir> repo = new Repository<TblMisafir>();
        TblMisafir t = new TblMisafir();
        private void FrmMisafirKarti_Load(object sender, EventArgs e)
        {
            

            try
            {
                //Güncellenecek kart nilgileri
                if (id != 0)
                {
                    var misafir = repo.Find(x => x.MisafirID == id);
                    TxtAdSoyad.Text = misafir.AdSoyad;
                    TxtTc.Text = misafir.TC;
                    TxtAdres.Text = misafir.Adres;
                    TxtTelefon.Text = misafir.Telefon;
                    TxtMail.Text = misafir.Mail;
                    TxtAciklama.Text = misafir.Aciklama;
                    pictureEditKimlikOn.Image = Image.FromFile(misafir.KimlikFoto1);
                    pictureEditKimlikArka.Image = Image.FromFile(misafir.KimlikFoto2);
                    kimlik1 = misafir.KimlikFoto1;
                    kimlik2 = misafir.KimlikFoto2;
                    lookUpEditSehir.EditValue = misafir.sehir;
                    lookUpEditUlke.EditValue = misafir.Ulke;
                    lookUpEditIlce.EditValue = misafir.ilce;
                }
                //Ülke listesi
                lookUpEditUlke.Properties.DataSource = (from x in db.TblUlke
                                                        select new
                                                        {
                                                            x.UlkeID,
                                                            x.UlkeAd
                                                        }).ToList();
                //Şehir listesi
                lookUpEditSehir.Properties.DataSource = (from x in db.iller
                                                         select new
                                                         {
                                                             Id = x.id,
                                                             Şehir = x.sehir
                                                         }).ToList();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Bir hata oluştu lütfe nsütunları kontrol ediniz.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            
            

        }

        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
            secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            lookUpEditIlce.Properties.DataSource = (from x in db.ilceler
                                                    select new
                                                    {
                                                        Id = x.id,
                                                        İlçe = x.ilce,
                                                        Şehir = x.sehir
                                                    }).Where(y => y.Şehir == secilen).ToList();
        }

        private void pictureEditKimlikOn_EditValueChanged(object sender, EventArgs e)
        {
            kimlik1 = pictureEditKimlikOn.GetLoadedImageLocation().ToString();
        }

        private void pictureEditKimlikArka_EditValueChanged(object sender, EventArgs e)
        {
            kimlik2 = pictureEditKimlikArka.GetLoadedImageLocation().ToString();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.MisafirID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTc.Text;
            deger.Mail = TxtMail.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Adres = TxtAdres.Text;
            deger.Aciklama = TxtAciklama.Text;
            deger.KimlikFoto1 = kimlik1;
            deger.KimlikFoto2 = kimlik2;
            deger.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            deger.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            deger.ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
            deger.Durum = 1;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Misafir bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTc.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtMail.Text;
            t.Adres = TxtAdres.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = 1;
            t.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            t.ilce = int.Parse(lookUpEditIlce.EditValue.ToString());
            t.Ulke = int.Parse(lookUpEditUlke.EditValue.ToString());
            t.KimlikFoto1 = kimlik1;
            t.KimlikFoto2 = kimlik2;
            repo.TAdd(t);
            XtraMessageBox.Show("Misafir sisteme başarılı bir şekilde kaydedildi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
