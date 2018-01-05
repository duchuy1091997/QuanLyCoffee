using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BussinessLogicLayer
{
    public class LoaiThucUong_BUL
    {
        public static List<LoaiThucUong_DTO> LoadLoaiThucUong()
        {
            return LoaiThucUong_DAL.LoadLoaiThucUong();
        }
    }
}
