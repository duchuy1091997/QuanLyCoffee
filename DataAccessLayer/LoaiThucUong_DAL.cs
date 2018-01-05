using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class LoaiThucUong_DAL
    {
        public static List<LoaiThucUong_DTO> LoadLoaiThucUong()
        {
            var lstLoaiTU = from ltu in DbConnection.db.LoaiThucUongs select new LoaiThucUong_DTO { MaLoai=ltu.MaLoai,TenLoai=ltu.TenLoai };
            return lstLoaiTU.ToList();
        }
    }
}
