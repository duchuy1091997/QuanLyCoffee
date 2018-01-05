using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class NguyenLieu_DTO
    {
        public string MaNguyenLieu { get; set; }
        public string TenNguyenLieu { get; set; }
        public string NhaSX { get; set; }
        public int SoLuongTon { get; set; }
        public string DonViTinh { get; set; }
        public decimal Gia { get; set; }
        public DateTime NgayNhap { get; set; }
    }
}
