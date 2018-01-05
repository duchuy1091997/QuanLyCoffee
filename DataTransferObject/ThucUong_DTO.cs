using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class ThucUong_DTO
    {
        public string MaThucUong { get; set; }
        public string TenThucUong { get; set; }
        public decimal? Gia { get; set; }
        public string AnhMinhHoa { get; set; }
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
