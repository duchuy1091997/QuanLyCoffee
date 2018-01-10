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
    }
}
