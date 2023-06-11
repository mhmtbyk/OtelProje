namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblDepartman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblDepartman()
        {
            this.TblGorev = new HashSet<TblGorev>();
            this.TblPersonel = new HashSet<TblPersonel>();
        }
    
        public int DepartmanID { get; set; }
        public string DepartmanAd { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblGorev> TblGorev { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblPersonel> TblPersonel { get; set; }
    }
}
