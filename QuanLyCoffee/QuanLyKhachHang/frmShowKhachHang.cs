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
using BussinessLogicLayer;
using DataTransferObject;
using System.IO;
using DataAccessLayer;

namespace QuanLyCoffee.QuanLyKhachHang
{
    public partial class frmShowKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmShowKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu frmThem = new frmThemNguyenLieu();
            frmThem.ShowDialog();
        }

        private void frmShowKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng cửa sổ này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ẩn cột MaLoai
        private void ShowColumn()
        {
            gvKhachHang.Columns[0].Caption = "Mã Khách Hàng";
            gvKhachHang.Columns[1].Caption = "Tên Khách Hàng";
            gvKhachHang.Columns[2].Caption = "Địa Chỉ";
            gvKhachHang.Columns[3].Caption = "Sđt";
            gvKhachHang.Columns[4].Visible = false;
            gvKhachHang.Columns[5].Caption = "Loại Khách Hàng";
        }
        //Show thức uống lên grid control
        private void frmShowThucUong_Load(object sender, EventArgs e)
        {
            ReloadGC();
        }
        //Gán dữ liệu cho gvNguyenLieu
        public void ReloadGC()
        {
            gcKhachHang.DataSource = typeof(KhachHang);
            gcKhachHang.DataSource = KhachHang_BUL.LoadKhachHang();
            ShowColumn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaNguyenLieu frmSua = new frmSuaNguyenLieu();
            //Đưa dữ liệu từ gridControl lên frmSuaNguyenLieu
            int rowIndex = gvKhachHang.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaNguyenLieu gán vào txtMaNguyenLieu
            colFieldName = "MaNguyenLieu";
            object value = gvKhachHang.GetRowCellValue(rowIndex,colFieldName);
            string maNguyenLieu = value.ToString().Trim();
            frmSua.txtMaNguyenLieu.Text = maNguyenLieu;
            //Lấy cột TenNguyenLieu gán vào txtTenNguyenLieu
            colFieldName = "TenNguyenLieu";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string tenNguyenLieu = value.ToString();
            frmSua.txtTenNguyenLieu.Text = tenNguyenLieu;
            //Lấy cột NhaSX gán vào txtNSX
            colFieldName = "NhaSX";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string nhaSX = value.ToString();
            frmSua.txtNSX.Text = nhaSX;
            //Lấy cột SoLuongTon gán vào txtSLT
            colFieldName = "SoLuongTon";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string slTon = value.ToString();
            frmSua.txtSLTon.Text = slTon;
            //Lấy cột Gia gán vào txtGia
            colFieldName = "Gia";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string gia = value.ToString();
            frmSua.txtGiaNguyenLieu.Text = gia;
            //Lấy cột NgayNhap gán vào dtNgayNhap
            colFieldName = "NgayNhap";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            DateTime ngayNhap =DateTime.Parse(value.ToString());
            frmSua.dtNgayNhap.DateTime = ngayNhap;
            //Lấy DonViTinh gán vào lkDVT
            colFieldName = "DonViTinh";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            frmSua.lkDVT.EditValue = value;
            frmSua.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = gvKhachHang.FocusedRowHandle;
            string colFieldName = "MaNguyenLieu";
            object value = gvKhachHang.GetRowCellValue(rowIndex,colFieldName);
            string maNguyenLieu = value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa nhân viên có mã "+maNguyenLieu+"?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NguyenLieu_BUL.DeleteNguyenLieu(maNguyenLieu);
                MessageBox.Show("Xóa thành công!","Thông Báo!");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!","Lỗi!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadGC();
        }
    }
}