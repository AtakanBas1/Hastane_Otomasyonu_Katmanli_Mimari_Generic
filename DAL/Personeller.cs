//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personeller()
        {
            this.Doktorlars = new HashSet<Doktorlar>();
        }
    
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelTc { get; set; }
        public Nullable<int> HastaneID { get; set; }
        public Nullable<int> UnvanID { get; set; }
        public Nullable<int> PersonelYas { get; set; }
        public string PersonelCinsiyet { get; set; }
        public string PersonelTel { get; set; }
        public string PersonelMail { get; set; }
        public string PersonelAdres { get; set; }
        public string Sifre { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doktorlar> Doktorlars { get; set; }
        public virtual Hastaneler Hastaneler { get; set; }
        public virtual Unvan Unvan { get; set; }
    }
}
