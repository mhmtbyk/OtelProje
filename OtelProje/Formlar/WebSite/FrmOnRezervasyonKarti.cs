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

namespace OtelProje.Formlar.WebSite
{
    public partial class FrmOnRezervasyonKarti : Form
    {
        public FrmOnRezervasyonKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<TblOnRezervasyon> repo = new Repository<TblOnRezervasyon>();
        TblRezervasyon t = new TblRezervasyon();
        public int id;
        private void FrmOnRezervasyonKarti_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                var rezervasyon = repo.Find(x => x.ID == id);
                TxtAdSoyad.Text = rezervasyon.AdSoyad;
                dateEditGiris.Text = rezervasyon.GirisTarih.ToString();
                dateEditCikis.Text = rezervasyon.CikisTarih.ToString();
                numericUpDown1.Value = decimal.Parse(rezervasyon.Kisi.ToString());
                TxtTelefon.Text = rezervasyon.Telefon;
                TxtMail.Text = rezervasyon.Mail;
                TxtAciklama.Text = rezervasyon.Aciklama;
                dateEditTarih.Text = rezervasyon.Tarih.ToString();


            }
        }
    }
}
