using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class LoaiKhachHang_BUL
    {
        public static List<LoaiKhachHang_DTO> LoadLoaiKhachHang()
        {
            return LoaiKhachHang_DAL.LoadLoaiKhachHang();
        }
    }
}
