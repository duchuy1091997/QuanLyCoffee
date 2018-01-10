using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class BaoCao_BUL
    {
        public static List<BaoCao_DTO> LoadBaoCao()
        {
            return BaoCao_DAL.LoadBaoCao();
        }
    }
}
