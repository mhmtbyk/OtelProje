namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblKur
    {
        public int KurID { get; set; }
        public string KurAd { get; set; }
        public string Sembol { get; set; }
        public Nullable<decimal> Deger { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
    }
}
