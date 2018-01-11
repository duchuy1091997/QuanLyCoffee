using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class NhanVien_DAL
    {
        //Load nhân viên
        public static List<NhanVien_DTO> LoadNhanVien()
        {
            var lstNhanVien = from nv in DbConnection.db.NhanViens select new NhanVien_DTO { MaNV=nv.MaNV, TenNV=nv.TenNV,DiaChi=nv.DiaChi,Sdt=nv.Sdt,GioiTinh=nv.GioiTinh,MaLoaiNV=nv.MaLoaiNV,TenLoaiNV=nv.LoaiNhanVien.TenLoaiNV };
            return lstNhanVien.ToList();
        }
        //Thêm NV
        public static NhanVien AddNhanVien(NhanVien nv)
        {
            nv = DbConnection.db.NhanViens.Add(nv);
            DbConnection.db.SaveChanges();
            return nv;
        }
        //Xóa NV
        public static bool DeleteNhanVien(string maNV)
        {
            NhanVien nv = DbConnection.db.NhanViens.SingleOrDefault(n => n.MaNV == maNV);
            if (nv==null)
            {
                return false;
            }
            DbConnection.db.NhanViens.Remove(nv);
            DbConnection.db.SaveChanges();
            return true;
        }
        //Sửa NV
        public static NhanVien EditNhanVien(NhanVien nv)
        {
            NhanVien nvUpdate = DbConnection.db.NhanViens.SingleOrDefault(n => n.MaNV == nv.MaNV);
            if (nvUpdate == null)
            {
                return null;
            }
            nvUpdate.TenNV = nv.TenNV;
            nvUpdate.DiaChi = nv.DiaChi;
            nvUpdate.Sdt = nv.Sdt;
            nvUpdate.GioiTinh = nv.GioiTinh;
            nvUpdate.MaLoaiNV = nv.MaLoaiNV;
            DbConnection.db.SaveChanges();
            return nvUpdate;
        }
    }
}
