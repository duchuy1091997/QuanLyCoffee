using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BussinessLogicLayer
{
    public class KhachHang_BUL
    {
        //Load KH
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            return KhachHang_DAL.LoadKhachHang();
        }
        //Thêm KH
        public static KhachHang AddKhachHang(KhachHang kh)
        {
            return KhachHang_DAL.AddKhachHang(kh);
        }
        //Xóa KH
        public static bool DeleteKhachHang(string maKH)
        {
            return KhachHang_DAL.DeleteKhachHang(maKH);
        }
        //Sửa KH
        public static KhachHang EditKhachHang(KhachHang kh)
        {
            return KhachHang_DAL.EditKhachHang(kh);
        }
    }
}
