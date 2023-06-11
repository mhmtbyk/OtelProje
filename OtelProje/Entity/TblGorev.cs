namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblGorev
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblGorev()
        {
            this.TblPersonel = new HashSet<TblPersonel>();
        }
    
        public int GorevID { get; set; }
        public string GorevAd { get; set; }
        public Nullable<int> Departman { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDepartman TblDepartman { get; set; }
        public virtual TblDurum TblDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblPersonel> TblPersonel { get; set; }
    }
}
