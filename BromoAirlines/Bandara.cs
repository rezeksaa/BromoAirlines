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
    
    public partial class Bandara
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bandara()
        {
            this.JadwalPenerbangans = new HashSet<JadwalPenerbangan>();
            this.JadwalPenerbangans1 = new HashSet<JadwalPenerbangan>();
        }
    
        public int ID { get; set; }
        public string Nama { get; set; }
        public string KodeIATA { get; set; }
        public string Kota { get; set; }
        public int NegaraID { get; set; }
        public int JumlahTerminal { get; set; }
        public string Alamat { get; set; }
    
        public virtual Negara Negara { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JadwalPenerbangan> JadwalPenerbangans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JadwalPenerbangan> JadwalPenerbangans1 { get; set; }
    }
}
