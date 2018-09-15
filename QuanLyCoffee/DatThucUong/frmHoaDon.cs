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
<<<<<<< HEAD
        decimal donGia, thanhTien;
=======
        decimal donGia;
>>>>>>> e723d41e68fa06675e63c7d63cd30acf63448353
        object value;
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string maHD = DateTime.Now.ToString("HHmmssddMMyy");
            txtMaHD.Text = maHD;
            dtNgayLap.DateTime = DateTime.Now;
<<<<<<< HEAD
            decimal tongTien = 0;
            //Tính thành tiền
            for (int i = 0; i < gvHoaDon.RowCount; i++)
            {
                value = gvHoaDon.GetRowCellValue(i, "Thành Tiền");
                thanhTien = decimal.Parse(value.ToString().Trim());
                tongTien = tongTien + thanhTien;
            }
            txtTongTien.Text = tongTien.ToString();
            //Load danh sách nhân viên lên lkNhanVien
            lkNhanVien.Properties.DataSource = NhanVien_BUL.LoadNhanVien();
            lkNhanVien.Properties.ValueMember = "MaNV";
            lkNhanVien.Properties.DisplayMember = "TenNV";
            lkNhanVien.Properties.PopulateColumns();
            lkNhanVien.Properties.Columns[0].Visible = false;
            lkNhanVien.Properties.Columns[1].Caption = "Tên Nhân Viên";
            lkNhanVien.Properties.Columns[2].Visible = false;
            lkNhanVien.Properties.Columns[3].Visible = false;
            lkNhanVien.Properties.Columns[4].Visible = false;
            lkNhanVien.Properties.Columns[5].Visible = false;
            lkNhanVien.Properties.Columns[6].Visible = false;
            //Load ds Khach hang len lkKhachHang
            lkKhachHang.Properties.DataSource = KhachHang_BUL.LoadKhachHang();
            lkKhachHang.Properties.ValueMember = "MaKH";
            lkKhachHang.Properties.DisplayMember = "TenKH";
            lkKhachHang.Properties.PopulateColumns();
            lkKhachHang.Properties.Columns[0].Visible = false;
            lkKhachHang.Properties.Columns[1].Caption = "Tên Khách Hàng";
            lkKhachHang.Properties.Columns[2].Visible = false;
            lkKhachHang.Properties.Columns[3].Visible = false;
            lkKhachHang.Properties.Columns[4].Visible = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn hủy hóa đơn "+txtMaHD.Text+" này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
=======
            decimal thanhTien = 0;
            //Tính thành tiền
            for (int i = 0; i < gvHoaDon.RowCount; i++)
            {
                value = gvHoaDon.GetRowCellValue(i, "Đơn Giá");
                donGia = decimal.Parse(value.ToString().Trim());
                thanhTien = thanhTien + donGia;
            }
            txtThanhTien.Text = thanhTien.ToString();
>>>>>>> e723d41e68fa06675e63c7d63cd30acf63448353
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
<<<<<<< HEAD
            
            //Thêm hóa đơn
            try
            {
                hd.MaHD = txtMaHD.Text;
                hd.NgayLap = DateTime.Parse(dtNgayLap.Text);
                hd.TongTriGia = decimal.Parse(txtTongTien.Text);
                hd.MaKH = lkKhachHang.EditValue.ToString();
                hd.MaNV = lkNhanVien.EditValue.ToString();
                HoaDon_BUL.AddHoaDon(hd);
            }
            catch
            {
                MessageBox.Show("Lỗi thêm hóa đơn");
            }
            //Thêm vào CTHD
            try
            {
                
                for (int i = 0; i < gvHoaDon.RowCount; i++)
                {
                    CTHD cthd = new CTHD();
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
            }
            catch
            {

                MessageBox.Show("Lỗi Thêm chi tiết hóa đơn");
            }
            MessageBox.Show("Thêm hóa đơn thành công!");
=======
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
>>>>>>> e723d41e68fa06675e63c7d63cd30acf63448353
        }
    }
}