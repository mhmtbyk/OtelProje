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

namespace OtelProje.Formlar.WebSite
{
    public partial class FrmHakkimizda : Form
    {
        public FrmHakkimizda()
        {
            InitializeComponent();
        }
        DbOtelEntities db = new DbOtelEntities();
        Repository<TblHakkimda> repo = new Repository<TblHakkimda>();
        private void FrmHakkimizda_Load(object sender, EventArgs e)
        {
            var hakkimizda = repo.Find(x => x.ID == 1);
            TxtAciklama1.Text = hakkimizda.Hakkimda1;
            TxtAciklama2.Text = hakkimizda.Hakkimda2;
            TxtAciklama3.Text = hakkimizda.Hakkimda3;
            TxtAciklama4.Text = hakkimizda.Hakkimda4;

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            var hakkimizda = repo.Find(x => x.ID == 1);
            hakkimizda.Hakkimda1 = TxtAciklama1.Text;
            hakkimizda.Hakkimda2 = TxtAciklama2.Text;
            hakkimizda.Hakkimda3 = TxtAciklama3.Text;
            hakkimizda.Hakkimda4 = TxtAciklama4.Text;
            repo.TUpdate(hakkimizda);
            XtraMessageBox.Show("Hakkımızda başarılı bir şekilde güncellendi.");
        }
    }
}
