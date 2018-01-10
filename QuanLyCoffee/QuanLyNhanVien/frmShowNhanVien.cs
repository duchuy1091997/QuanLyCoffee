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
            frmThemNguyenLieu frmThem = new frmThemNguyenLieu();
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
            frmSuaNguyenLieu frmSua = new frmSuaNguyenLieu();
            //Đưa dữ liệu từ gridControl lên frmSuaNguyenLieu
            int rowIndex = gvNhanVien.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaNguyenLieu gán vào txtMaNguyenLieu
            colFieldName = "MaNguyenLieu";
            object value = gvNhanVien.GetRowCellValue(rowIndex,colFieldName);
            string maNguyenLieu = value.ToString().Trim();
            frmSua.txtMaNguyenLieu.Text = maNguyenLieu;
            //Lấy cột TenNguyenLieu gán vào txtTenNguyenLieu
            colFieldName = "TenNguyenLieu";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string tenNguyenLieu = value.ToString();
            frmSua.txtTenNguyenLieu.Text = tenNguyenLieu;
            //Lấy cột NhaSX gán vào txtNSX
            colFieldName = "NhaSX";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string nhaSX = value.ToString();
            frmSua.txtNSX.Text = nhaSX;
            //Lấy cột SoLuongTon gán vào txtSLT
            colFieldName = "SoLuongTon";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string slTon = value.ToString();
            frmSua.txtSLTon.Text = slTon;
            //Lấy cột Gia gán vào txtGia
            colFieldName = "Gia";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            string gia = value.ToString();
            frmSua.txtGiaNguyenLieu.Text = gia;
            //Lấy cột NgayNhap gán vào dtNgayNhap
            colFieldName = "NgayNhap";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            DateTime ngayNhap =DateTime.Parse(value.ToString());
            frmSua.dtNgayNhap.DateTime = ngayNhap;
            //Lấy DonViTinh gán vào lkDVT
            colFieldName = "DonViTinh";
            value = gvNhanVien.GetRowCellValue(rowIndex, colFieldName);
            frmSua.lkDVT.EditValue = value;
            frmSua.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = gvNhanVien.FocusedRowHandle;
            string colFieldName = "MaNguyenLieu";
            object value = gvNhanVien.GetRowCellValue(rowIndex,colFieldName);
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