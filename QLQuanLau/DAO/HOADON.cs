//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CTHOADONs = new HashSet<CTHOADON>();
        }
    
        public string MAHD { get; set; }
        public System.DateTime NGAYLAP { get; set; }
        public string MANVLAPDON { get; set; }
        public string MABAN { get; set; }
        public double TONGTIEN { get; set; }
        public bool THANHTOAN { get; set; }
    
        public virtual BANAN BANAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHOADON> CTHOADONs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
