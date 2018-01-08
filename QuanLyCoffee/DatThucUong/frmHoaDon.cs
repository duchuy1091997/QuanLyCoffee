using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyCoffee.DatThucUong;
using DataAccessLayer;
using BussinessLogicLayer;

namespace QuanLyCoffee.DatThucUong
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        string maThucUong;
        int soLuong;
        decimal donGia;
        object value;
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string maHD = DateTime.Now.ToString("HHmmssddMMyy");
            txtMaHD.Text = maHD;
            dtNgayLap.DateTime = DateTime.Now;
            decimal thanhTien = 0;
            //Tính thành tiền
            for (int i = 0; i < gvHoaDon.RowCount; i++)
            {
                value = gvHoaDon.GetRowCellValue(i, "Đơn Giá");
                donGia = decimal.Parse(value.ToString().Trim());
                thanhTien = thanhTien + donGia;
            }
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            CTHD cthd = new CTHD();
            //Thêm hóa đơn
            hd.MaHD = txtMaHD.Text;
            hd.NgayLap = DateTime.Parse(dtNgayLap.Text);
            hd.TongTriGia = decimal.Parse(txtThanhTien.Text);
            hd.MaKH = "KH01";
            hd.MaNV = "NV01";
            HoaDon_BUL.AddHoaDon(hd);
            //Thêm vào CTHD
            for (int i = 0; i < gvHoaDon.RowCount; i++)
            {
                //Mã HD
                cthd.MaHD = txtMaHD.Text;
                //Mã Thức uống
                value = gvHoaDon.GetRowCellValue(i, "Mã Thức Uống");
                maThucUong = value.ToString().Trim();
                cthd.MaThucUong = maThucUong;
                //Số lượng
                value = gvHoaDon.GetRowCellValue(i, "Số Lượng");
                soLuong = int.Parse(value.ToString().Trim());
                cthd.SoLuong = soLuong;
                //Khuyến mãi
                cthd.KhuyenMai = 0;
                //Đơn giá bán
                value = gvHoaDon.GetRowCellValue(i, "Đơn Giá");
                donGia = decimal.Parse(value.ToString().Trim());
                cthd.GiaBan = donGia;
                CTHD_BUL.AddCTHD(cthd);
            }
            MessageBox.Show("Thêm thành công!");
        }
    }
}