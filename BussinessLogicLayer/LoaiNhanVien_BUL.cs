using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BussinessLogicLayer
{
    public class LoaiNhanVien_BUL
    {
        public static List<LoaiNhanVien_DTO> LoadLoaiNhanVien()
        {
            return LoaiNhanVien_DAL.LoadLoaiNhanVien();
        }
    }
}
