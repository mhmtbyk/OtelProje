namespace OtelProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblTelefon
    {
        public int TelefonID { get; set; }
        public string Aciklama { get; set; }
        public string Telefon { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
    }
}
