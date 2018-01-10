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
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            return KhachHang_DAL.LoadKhachHang();
        }
    }
}
