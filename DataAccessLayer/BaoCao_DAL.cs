using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class BaoCao_DAL
    {
        //Load báo cáo
        public static List<BaoCao_DTO> LoadBaoCao()
        {
            var lstBaoCao = from bc in DbConnection.db.HoaDons select new BaoCao_DTO{ MaHD=bc.MaHD, NgayLap=bc.NgayLap, TongTriGia=bc.TongTriGia };
            return lstBaoCao.ToList();
        }
    }
}
