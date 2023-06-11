namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblKasa
    {
        public int KasaID { get; set; }
        public string KasaAdi { get; set; }
        public Nullable<decimal> Bakiye { get; set; }
        public Nullable<decimal> Giren { get; set; }
        public Nullable<decimal> Cikan { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
    }
}
