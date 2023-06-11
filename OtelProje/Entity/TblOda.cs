namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblOda()
        {
            
        }
    
        public int OdaID { get; set; }
        public string OdaNo { get; set; }
        public string Kat { get; set; }
        public string Kapasite { get; set; }
        public string Aciklama { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
        
        
    }
}
