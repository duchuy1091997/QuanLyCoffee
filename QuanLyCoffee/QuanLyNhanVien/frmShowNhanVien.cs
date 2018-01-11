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

namespace QuanLyCoffee.QuanLyNhanVien
{
    public partial class frmShowNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmShowNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThem = new frmThemNhanVien();
            frmThem.ShowDialog();
        }

        private void frmShowNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
            gvNhanVien.Columns[0].Caption = "Mã Nhân Viên";
            gvNhanVien.Columns[1].Caption = "Tên Nhân Viên";
            gvNhanVien.Columns[2].Caption = "Địa Chỉ";
            gvNhanVien.Columns[3].Caption = "Sđt";
            gvNhanVien.Columns[4].Caption = "Giới tính";
            gvNhanVien.Columns[5].Visible = false;
            gvNhanVien.Columns[6].Caption = "Loại Nhân Viên";
        }
        //Show thức uống lên grid control
        private void frmShowThucUong_Load(object sender, EventArgs e)
        {
            ReloadGC();
        }
        //Gán dữ liệu cho gvNguyenLieu
        public void ReloadGC()
        {
            gcNhanVien.DataSource = typeof(NhanVien);
            gcNhanVien.DataSource = NhanVien_BUL.LoadNhanVien();
            ShowColumn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaNhanVien frmSua = new frmSuaNhanVien();
            //Đưa dữ liệu từ gridControl lên frmSuaNguyenLieu
            int rowIndex = gvNhanVien.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaNV gán vào txtMaNV
            colFieldName = "MaNV";
            object value = gvNhanVien.GetRowCellValue(rowIndex,colFieldName);
            string maNV = value.ToString().Trim();
            frmSua.txtMaNhanVien.Text = maNV;
            //Lấy cột TenNV gán vào txtTenNV
            colFieldName = "TenNV";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string tenNV = value.ToString();
            frmSua.txtTenNhanVien.Text = tenNV;
            //Lấy cột DiaChi gán vào txtDiaChi
            colFieldName = "DiaChi";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string diaChi = value.ToString();
            frmSua.txtDiaChi.Text = diaChi;
            //Lấy cột sdt gán vào txtsdt
            colFieldName = "Sdt";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string sdt = value.ToString();
            frmSua.txtSDT.Text = sdt;
            //Lấy cột GioiTinh gán vào radioBtn
            colFieldName = "GioiTinh";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string gioiTinh = value.ToString().Trim();
            if (gioiTinh=="Nam")
            {
                frmSua.rdNam.Checked = true;
            }
            else
            {
                if (gioiTinh=="Nữ")
                {
                    frmSua.rdNu.Checked = true;
                }
                else
                {
                    frmSua.rdKhac.Checked = true;
                }
            }
            //Lấy MaLoaiNV gán vào lkLoaiNV
            colFieldName = "MaLoaiNV";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            frmSua.lkLoaiNhanVien.EditValue = value;
            frmSua.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = gvNhanVien.FocusedRowHandle;
            string colFieldName = "MaNV";
            object value = gvNhanVien.GetRowCellValue(rowIndex,colFieldName);
            string maNV = value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa nhân viên có mã "+maNV+"?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVien_BUL.DeleteNhanVien(maNV);
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