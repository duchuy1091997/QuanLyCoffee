using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BussinessLogicLayer
{
    public class NhanVien_BUL
    {
        //Load nhân viên
        public static List<NhanVien_DTO> LoadNhanVien()
        {
            return NhanVien_DAL.LoadNhanVien();
        }
        //Thêm NV
        public static NhanVien AddNhanVien(NhanVien nv)
        {
            return NhanVien_DAL.AddNhanVien(nv);
        }
        //Xóa NV
        public static bool DeleteNhanVien(string maNV)
        {
            return NhanVien_DAL.DeleteNhanVien(maNV);
        }
        //Sửa NV
        public static NhanVien EditNhanVien(NhanVien nv)
        {
            return NhanVien_DAL.EditNhanVien(nv);
        }
    }
}
