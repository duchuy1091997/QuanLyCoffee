using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class NguyenLieu_BUL
    {
        public static List<NguyenLieu> LoadNguyenLieu()
        {
            return NguyenLieu_DAL.LoadNguyenLieu();
        }
        public static NguyenLieu AddNguyenLieu(NguyenLieu nl)
        {
            return NguyenLieu_DAL.AddNguyenLieu(nl);
        }
        public static NguyenLieu EditNguyenLieu(NguyenLieu nl)
        {
            return NguyenLieu_DAL.EditNguyenLieu(nl);
        }
        public static bool DeleteNguyenLieu(string maNguyenLieu)
        {
            return NguyenLieu_DAL.DeleteNguyenLieu(maNguyenLieu);
        }
    }
}
