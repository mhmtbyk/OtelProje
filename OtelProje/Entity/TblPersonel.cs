namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblPersonel
    {
        public int PersonelID { get; set; }
        public string AdSoyad { get; set; }
        public string TC { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public Nullable<System.DateTime> IseGirisTarih { get; set; }
        public Nullable<System.DateTime> IstenCikisTarih { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<int> Gorev { get; set; }
        public string Aciklama { get; set; }
        public Nullable<int> Durum { get; set; }
        public string KimlikOn { get; set; }
        public string KimlkArka { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }
    
        public virtual TblDepartman TblDepartman { get; set; }
        public virtual TblDurum TblDurum { get; set; }
        public virtual TblGorev TblGorev { get; set; }
    }
}
