//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BromoAirlines
{
    using System;
    using System.Collections.Generic;
    
    public partial class StatusPenerbangan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatusPenerbangan()
        {
            this.PerubahanStatusJadwalPenerbangans = new HashSet<PerubahanStatusJadwalPenerbangan>();
        }
    
        public int ID { get; set; }
        public string Nama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerubahanStatusJadwalPenerbangan> PerubahanStatusJadwalPenerbangans { get; set; }
    }
}
