//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA_ACCESS_LAYER
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANG_DETAIL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANG_DETAIL()
        {
            this.BANG_SANPHAM = new HashSet<BANG_SANPHAM>();
        }
    
        public string iddetail { get; set; }
        public string manhinh { get; set; }
        public string cameratruoc { get; set; }
        public string camerasau { get; set; }
        public string os { get; set; }
        public string ram { get; set; }
        public string rom { get; set; }
        public string dungluongpin { get; set; }
        public string chip { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANG_SANPHAM> BANG_SANPHAM { get; set; }
    }
}
