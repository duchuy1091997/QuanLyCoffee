using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class KhachHang_DAL
    {
        //Load khách hàng
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            var lstKhachHang = from kh in DbConnection.db.KhachHangs select new KhachHang_DTO { MaKH=kh.MaKH, TenKH=kh.TenKH, DiaChi=kh.DiaChi,Sdt=kh.Sdt, MaLoaiKH=kh.MaLoaiKH, TenLoaiKH=kh.LoaiKhachKhang.TenLoaiKH };
            return lstKhachHang.ToList();
        }
    }
}
