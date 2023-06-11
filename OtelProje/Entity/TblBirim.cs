namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;

    public partial class TblBirim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblBirim()
        {
            this.TblUrun = new HashSet<TblUrun>();
        }

        public int BirimID { get; set; }
        public string BirimAd { get; set; }
        public Nullable<int> Durum { get; set; }

        public virtual TblDurum TblDurum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblUrun> TblUrun { get; set; }
    }
}
