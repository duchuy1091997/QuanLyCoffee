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
            frmThemKhachHang frmThem = new frmThemKhachHang();
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
            gvKhachHang.Columns[4].Caption = "Giới tính";
            gvKhachHang.Columns[5].Visible = false;
            gvKhachHang.Columns[6].Caption = "Loại Khách Hàng";
        }
        //Show thức uống lên grid control
        private void frmShowThucUong_Load(object sender, EventArgs e)
        {
            ReloadGC();
        }
        //Gán dữ liệu cho gvKhachHang
        public void ReloadGC()
        {
            gcKhachHang.DataSource = typeof(KhachHang);
            gcKhachHang.DataSource = KhachHang_BUL.LoadKhachHang();
            ShowColumn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaKhachHang frmSua = new frmSuaKhachHang();
            //Đưa dữ liệu từ gridControl lên frmSuaNguyenLieu
            int rowIndex = gvKhachHang.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaNV gán vào txtMaNV
            colFieldName = "MaKH";
            object value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string maKH = value.ToString().Trim();
            if (maKH=="KH00")
            {
                MessageBox.Show("Không được sửa khách hàng này!", "Lỗi");
                return;
            }
            frmSua.txtMaKhachHang.Text = maKH;
            //Lấy cột TenNV gán vào txtTenNV
            colFieldName = "TenKH";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string tenKH = value.ToString();
            frmSua.txtTenKhachHang.Text = tenKH;
            //Lấy cột DiaChi gán vào txtDiaChi
            colFieldName = "DiaChi";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string diaChi = value.ToString();
            frmSua.txtDiaChi.Text = diaChi;
            //Lấy cột sdt gán vào txtsdt
            colFieldName = "Sdt";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string sdt = value.ToString();
            frmSua.txtSDT.Text = sdt;
            //Lấy cột GioiTinh gán vào radioBtn
            colFieldName = "GioiTinh";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            string gioiTinh = value.ToString().Trim();
            if (gioiTinh == "Nam")
            {
                frmSua.rdNam.Checked = true;
            }
            else
            {
                if (gioiTinh == "Nữ")
                {
                    frmSua.rdNu.Checked = true;
                }
                else
                {
                    frmSua.rdKhac.Checked = true;
                }
            }
            //Lấy MaLoaiNV gán vào lkLoaiNV
            colFieldName = "MaLoaiKH";
            value = gvKhachHang.GetRowCellValue(rowIndex, colFieldName);
            frmSua.lkLoaiKhachHang.EditValue = value;
            frmSua.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = gvKhachHang.FocusedRowHandle;
            string colFieldName = "MaKH";
            object value = gvKhachHang.GetRowCellValue(rowIndex,colFieldName);
            string maKH = value.ToString().Trim();
            if (maKH == "KH00")
            {
                MessageBox.Show("Không được xóa khách hàng này!", "Lỗi");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa nhân viên có mã "+maKH+"?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KhachHang_BUL.DeleteKhachHang(maKH);
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