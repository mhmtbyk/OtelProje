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

namespace OtelProje.Formlar.Admin
{
    public partial class FrmSifreIslemleri : Form
    {
        public FrmSifreIslemleri()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<TblAdmin> repo = new Repository<TblAdmin>();
        public int id;
        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtYeniSifre.Text == TxtYeniSifre2.Text)
            {
                TblAdmin t = new TblAdmin();
                t.Kullanici = TxtKullaniciAdi.Text;
                t.Sifre = TxtYeniSifre.Text;
                db.TblAdmin.Add(t);
                db.SaveChanges();
                XtraMessageBox.Show("Yeni kullanıcı başarılı bir şekilde oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Şifreler uyuşmuyor lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (TxtYeniSifre.Text == TxtYeniSifre2.Text)
            {
                var admin = repo.Find(x => x.ID == id);
                admin.Kullanici = TxtKullaniciAdi.Text;
                admin.Sifre = TxtYeniSifre.Text;
                admin.Rol = TxtRol.Text;
                repo.TUpdate(admin);
                XtraMessageBox.Show("Admin bilgileri başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lütfen şifrelerin eşleştiğinden emin olunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmAdminListesi fr = new FrmAdminListesi();
            fr.Show();
            this.Hide();
        }

        private void FrmSifreIslemleri_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var admin = repo.Find(x => x.ID == id);
                TxtKullaniciAdi.Text = admin.Kullanici;
                TxtMevcutSifre.Text = admin.Sifre;
                TxtRol.Text = admin.Rol;
            }
        }
    }
}
