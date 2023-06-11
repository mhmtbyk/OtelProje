namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUrunGrup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblUrunGrup()
        {
            this.TblUrun = new HashSet<TblUrun>();
        }
    
        public int UrunGrupID { get; set; }
        public string UrunGrupAd { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblUrun> TblUrun { get; set; }
    }
}
