using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class User_BUL
    {
        public static bool GetUser(string tenNguoiDung, string matKhau)
        {
            return User_DAL.GetUser(tenNguoiDung,matKhau);
        }
    }
}
