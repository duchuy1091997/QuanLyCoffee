using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class HoaDon_BUL
    {
        //Thêm HD
        public static HoaDon AddHoaDon(HoaDon hd)
        {
            return HoaDon_DAL.AddHoaDon(hd);
        }
    }
}
