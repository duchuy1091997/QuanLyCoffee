using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class LoaiKhachHang_DAL
    {
        //Load loại KH
        public static List<LoaiKhachHang_DTO> LoadLoaiKhachHang()
        {
            var lstLoaiKH = from lkh in DbConnection.db.LoaiKhachHangs select new LoaiKhachHang_DTO { MaLoaiKH = lkh.MaLoaiKH, TenLoaiKH = lkh.TenLoaiKH, GhiChu=lkh.GhiChu };
            return lstLoaiKH.ToList();
        }
    }
}
