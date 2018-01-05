using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class User_DAL
    {
        //Hàm lấy user và password
        public static bool GetUser(string tenNguoiDung, string matKhau)
        {
            User us = DbConnection.db.Users.SingleOrDefault(n=>n.AccountName==tenNguoiDung && n.Password==matKhau);
            if (us==null)
            {
                return false;
            }
            return true;
        }
    }
}
