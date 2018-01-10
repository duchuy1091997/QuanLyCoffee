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
    }
}
