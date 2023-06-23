﻿using DevExpress.XtraEditors;
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
    public partial class FrmAdresKarti : Form
    {
        public FrmAdresKarti()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<Tbliletisim> repo = new Repository<Tbliletisim>();
        private void FrmAdresKarti_Load(object sender, EventArgs e)
        {
            var iletisim = repo.Find(x => x.ID == 1);
            TxtMail.Text = iletisim.Mail;
            TxtTelefon.Text = iletisim.Telefon;
            TxtKoordinat.Text = iletisim.Koordinat;
            TxtAdres.Text = iletisim.Adres;
            TxtAciklama.Text = iletisim.Aciklama;
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var iletisim = repo.Find(x => x.ID == 1);
            iletisim.Mail = TxtMail.Text;
            iletisim.Telefon = TxtTelefon.Text;
            iletisim.Koordinat = TxtKoordinat.Text;
            iletisim.Adres = TxtAdres.Text;
            iletisim.Aciklama = TxtAciklama.Text;
            repo.TUpdate(iletisim);
            XtraMessageBox.Show("İletişim başarılı bir şekilde güncellendi.");
        }
    }
}
