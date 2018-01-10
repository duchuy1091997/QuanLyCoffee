using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CTHD_DAL
    {
        //Thêm CTHD
        public static CTHD AddCTHD(CTHD cthd)
        {
            cthd = DbConnection.db.CTHDs.Add(cthd);
            DbConnection.db.SaveChanges();
            return cthd;
        }
    }
}
