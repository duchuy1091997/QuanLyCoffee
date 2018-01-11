using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class KhachHang_DAL
    {
        //Load khách hàng
        public static List<KhachHang_DTO> LoadKhachHang()
        {
            var lstKhachHang = from kh in DbConnection.db.KhachHangs select new KhachHang_DTO { MaKH=kh.MaKH, TenKH=kh.TenKH, DiaChi=kh.DiaChi,Sdt=kh.Sdt,GioiTinh=kh.GioiTinh ,MaLoaiKH=kh.MaLoaiKH, TenLoaiKH=kh.LoaiKhachHang.TenLoaiKH };
            return lstKhachHang.ToList();
        }
        //Thêm KH
        public static KhachHang AddKhachHang(KhachHang kh)
        {
            kh = DbConnection.db.KhachHangs.Add(kh);
            DbConnection.db.SaveChanges();
            return kh;
        }
        //Xóa KH
        public static bool DeleteKhachHang(string maKH)
        {
            KhachHang kh = DbConnection.db.KhachHangs.SingleOrDefault(n => n.MaKH == maKH);
            if (kh == null)
            {
                return false;
            }
            DbConnection.db.KhachHangs.Remove(kh);
            DbConnection.db.SaveChanges();
            return true;
        }
        //Sửa KH
        public static KhachHang EditKhachHang(KhachHang kh)
        {
            KhachHang khUpdate = DbConnection.db.KhachHangs.SingleOrDefault(n => n.MaKH == kh.MaKH);
            if (khUpdate == null)
            {
                return null;
            }
            khUpdate.TenKH = kh.TenKH;
            khUpdate.DiaChi = kh.DiaChi;
            khUpdate.Sdt = kh.Sdt;
            khUpdate.GioiTinh = kh.GioiTinh;
            khUpdate.MaLoaiKH = kh.MaLoaiKH;
            DbConnection.db.SaveChanges();
            return khUpdate;
        }
    }
}
