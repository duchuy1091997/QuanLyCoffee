using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NguyenLieu_DAL
    {
        //Load danh sách nguyên liệu
        public static List<NguyenLieu> LoadNguyenLieu()
        {
            var lstNgLieu = DbConnection.db.NguyenLieux.ToList();
            return lstNgLieu;
        }
        //Thêm nguyên liệu
        public static NguyenLieu AddNguyenLieu(NguyenLieu nl)
        {
            nl = DbConnection.db.NguyenLieux.Add(nl);
            DbConnection.db.SaveChanges();
            return nl;
        }
        //Xóa nguyên liệu
        public static bool DeleteNguyenLieu(string maNguyenLieu)
        {
            NguyenLieu nlDelete = DbConnection.db.NguyenLieux.SingleOrDefault(n=>n.MaNguyenLieu==maNguyenLieu);
            if (nlDelete==null)
            {
                return false;
            }
            DbConnection.db.NguyenLieux.Remove(nlDelete);
            DbConnection.db.SaveChanges();
            return true;
        }
    }
}
