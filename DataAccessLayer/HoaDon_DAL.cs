﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class HoaDon_DAL
    {
        //Thêm Hóa Đơn
        public static HoaDon AddHoaDon(HoaDon hd)
        {
            hd = DbConnection.db.HoaDons.Add(hd);
            DbConnection.db.SaveChanges();
            return hd;
        }
    }
}
