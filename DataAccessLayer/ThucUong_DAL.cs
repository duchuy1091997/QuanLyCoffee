using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class ThucUong_DAL
    {
        //Show danh sách thức uống lên gridControl
        public static List<ThucUong_DTO> LoadThucUong()
        {
            var lstThucUong = from tu in DbConnection.db.ThucUongs select new ThucUong_DTO { MaThucUong = tu.MaThucUong, TenThucUong = tu.TenThucUong, Gia = tu.Gia, AnhMinhHoa = tu.AnhMinhHoa, MaLoai = tu.MaLoai, TenLoai = tu.LoaiThucUong.TenLoai };
            return lstThucUong.ToList();
        }
        //Thêm thức uống
        public static ThucUong AddThucUong(ThucUong tu)
        {
            tu = DbConnection.db.ThucUongs.Add(tu);
            DbConnection.db.SaveChanges();
            return tu;
        }
        //Xóa thức uống
        public static bool DeleteThucUong(string maThucUong)
        {
            ThucUong tuDelete = DbConnection.db.ThucUongs.SingleOrDefault(n => n.MaThucUong == maThucUong);
            if (tuDelete == null)
            {
                return false;
            }
            DbConnection.db.ThucUongs.Remove(tuDelete);
            DbConnection.db.SaveChanges();
            return true;
        }
        //Sửa thức uống
        public static ThucUong EditThucUong(ThucUong tu)
        {
            ThucUong tuUpdate = DbConnection.db.ThucUongs.SingleOrDefault(n => n.MaThucUong == tu.MaThucUong);
            if (tuUpdate == null)
            {
                return null;
            }
            tuUpdate.TenThucUong = tu.TenThucUong;
            tuUpdate.Gia = tu.Gia;
            tuUpdate.AnhMinhHoa = tu.AnhMinhHoa;
            tuUpdate.MaLoai = tu.MaLoai;
            DbConnection.db.SaveChanges();
            return tuUpdate;
        }
    }
}
