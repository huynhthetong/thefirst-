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
    
    public partial class BANG_CATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANG_CATEGORY()
        {
            this.BANG_SANPHAM = new HashSet<BANG_SANPHAM>();
        }
    
        public string idcategory { get; set; }
        public string name { get; set; }
        public Nullable<int> quanity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANG_SANPHAM> BANG_SANPHAM { get; set; }
    }
}
