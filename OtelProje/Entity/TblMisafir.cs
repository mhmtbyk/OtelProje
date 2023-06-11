namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblMisafir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblMisafir()
        {
            
        }
    
        public int MisafirID { get; set; }
        public string AdSoyad { get; set; }
        public string TC { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public string KimlikFoto1 { get; set; }
        public string KimlikFoto2 { get; set; }
        public Nullable<int> Ulke { get; set; }
        public Nullable<int> Durum { get; set; }
        public Nullable<int> sehir { get; set; }
        public Nullable<int> ilce { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
        
    }
}
