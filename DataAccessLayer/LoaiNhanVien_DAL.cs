using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class LoaiNhanVien_DAL
    {
        //Load loại nhân viên
        public static List<LoaiNhanVien_DTO> LoadLoaiNhanVien()
        {
            var lstLoaiNV = from lnv in DbConnection.db.LoaiNhanViens select new LoaiNhanVien_DTO { MaLoaiNV=lnv.MaLoaiNV, TenLoaiNV = lnv.TenLoaiNV, GhiChu=lnv.GhiChu };
            return lstLoaiNV.ToList();
        }
    }
}
