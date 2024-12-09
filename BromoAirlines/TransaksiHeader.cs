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
    
    public partial class TransaksiHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransaksiHeader()
        {
            this.TransaksiDetails = new HashSet<TransaksiDetail>();
        }
    
        public int ID { get; set; }
        public int AkunID { get; set; }
        public System.DateTime TanggalTransaksi { get; set; }
        public int JadwalPenerbanganID { get; set; }
        public int JumlahPenumpang { get; set; }
        public int TotalHarga { get; set; }
        public int KodePromoID { get; set; }
    
        public virtual Akun Akun { get; set; }
        public virtual JadwalPenerbangan JadwalPenerbangan { get; set; }
        public virtual KodePromo KodePromo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransaksiDetail> TransaksiDetails { get; set; }
    }
}
