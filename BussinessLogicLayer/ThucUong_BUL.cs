using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;

namespace BussinessLogicLayer
{
    public class ThucUong_BUL
    {
        public static List<ThucUong_DTO> LoadThucUong()
        {
            return ThucUong_DAL.LoadThucUong();
        }
        public static ThucUong AddThucUong(ThucUong tu)
        {
            return ThucUong_DAL.AddThucUong(tu);
        }
        public static bool DeleteThucUong(string maThucUong)
        {
            return ThucUong_DAL.DeleteThucUong(maThucUong);
        }
        public static ThucUong EditThucUong(ThucUong tu)
        {
            return ThucUong_DAL.EditThucUong(tu);
        }
    }
}
