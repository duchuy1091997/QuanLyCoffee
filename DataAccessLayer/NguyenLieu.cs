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
    
    public partial class NguyenLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NguyenLieu()
        {
            this.ThucUong_NguyenLieu = new HashSet<ThucUong_NguyenLieu>();
        }
    
        public string MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string NhaSX { get; set; }
        public Nullable<int> SoLuongTon { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucUong_NguyenLieu> ThucUong_NguyenLieu { get; set; }
    }
}
