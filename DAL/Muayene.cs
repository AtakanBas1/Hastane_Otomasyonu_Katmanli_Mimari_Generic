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
    
    public partial class Muayene
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Muayene()
        {
            this.MuayeneTedavis = new HashSet<MuayeneTedavi>();
        }
    
        public int MID { get; set; }
        public Nullable<int> DoktorID { get; set; }
        public Nullable<int> HastaID { get; set; }
        public Nullable<int> MTURID { get; set; }
        public Nullable<System.DateTime> MGiris { get; set; }
        public Nullable<System.DateTime> MCikis { get; set; }
    
        public virtual Doktorlar Doktorlar { get; set; }
        public virtual Hasta Hasta { get; set; }
        public virtual MuayeneTur MuayeneTur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuayeneTedavi> MuayeneTedavis { get; set; }
    }
}
