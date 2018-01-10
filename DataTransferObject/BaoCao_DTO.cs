using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class BaoCao_DTO
    {
        public string MaHD { get; set; }
        public DateTime? NgayLap { get; set; }
        public string MaThucUong { get; set; }
        public string TenThucUong { get; set; }
        public int SoLuong { get; set; }
        public double KhuyenMai { get; set; }
        public decimal GiaBan { get; set; }
        public decimal? TongTriGia { get; set; }
    }
}
