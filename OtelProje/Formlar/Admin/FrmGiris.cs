using DevExpress.XtraEditors;
using OtelProje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProje.Formlar.Admin
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            var kullanici = db.TblAdmin.Where(x => x.Kullanici == TxtKullaniciAdi.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (kullanici != null)
            {
                Form1 frm = new Form1();
                
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifreniz hatalı. Lütfen tekrar deneyiniz...","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
