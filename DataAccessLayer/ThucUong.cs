//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThucUong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucUong()
        {
            this.CTHDs = new HashSet<CTHD>();
            this.ThucUong_NguyenLieu = new HashSet<ThucUong_NguyenLieu>();
        }
    
        public string MaThucUong { get; set; }
        public string TenThucUong { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public string AnhMinhHoa { get; set; }
        public string MaLoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }
        public virtual LoaiThucUong LoaiThucUong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucUong_NguyenLieu> ThucUong_NguyenLieu { get; set; }
    }
}
