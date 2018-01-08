using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class CTHD_BUL
    {
        //Thêm cthd
        public static CTHD AddCTHD(CTHD cthd)
        {
            return CTHD_DAL.AddCTHD(cthd);
        }
    }
}
