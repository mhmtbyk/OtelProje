namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUrun()
        {
            
        }
    
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public Nullable<int> UrunGrup { get; set; }
        public Nullable<int> Birim { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<decimal> Toplam { get; set; }
        public Nullable<byte> Kdv { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblBirim TblBirim { get; set; }
        public virtual TblDurum TblDurum { get; set; }
        public virtual TblUrunGrup TblUrunGrup { get; set; }
        
        
    }
}
