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

namespace QuanLyCoffee.QuanLyThucUong
{
    public partial class frmShowNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        public frmShowNguyenLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemNguyenLieu frmThem = new frmThemNguyenLieu();
            frmThem.ShowDialog();
        }

        private void frmShowNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
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
            gvNguyenLieu.Columns[0].Caption = "Mã Nguyên Liệu";
            gvNguyenLieu.Columns[1].Caption = "Tên Nguyên liệu";
            gvNguyenLieu.Columns[2].Caption = "Nhà sản xuất";
            gvNguyenLieu.Columns[3].Caption = "Số Lượng Tồn";
            gvNguyenLieu.Columns[4].Caption = "Đơn vị tính";
            gvNguyenLieu.Columns[5].Caption = "Giá";
            gvNguyenLieu.Columns[6].Caption = "Ngày Nhập";
            gvNguyenLieu.Columns[7].Visible = false;
        }
        //Show thức uống lên grid control
        private void frmShowThucUong_Load(object sender, EventArgs e)
        {
            ReloadGC();
        }
        //Gán dữ liệu cho gvNguyenLieu
        public void ReloadGC()
        {
            gcNguyenLieu.DataSource = typeof(NguyenLieu);
            gcNguyenLieu.DataSource = NguyenLieu_BUL.LoadNguyenLieu();
            ShowColumn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaThucUong frmSua = new frmSuaThucUong();
            //Đưa dữ liệu từ gridControl lên frmSuaThucUong
            int rowIndex = gvNguyenLieu.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaThucUong gán vào txtMaThucUong
            colFieldName = "MaThucUong";
            object value = gvNguyenLieu.GetRowCellValue(rowIndex,colFieldName);
            string maThucUong = value.ToString().Trim();
            frmSua.txtMaThucUong.Text = maThucUong;
            //Lấy cột TenThucUong gán vào txtTenThucUong
            colFieldName = "TenThucUong";
            value = gvNguyenLieu.GetRowCellValue(rowIndex, colFieldName);
            string tenThucUong = value.ToString();
            frmSua.txtTenThucUong.Text = tenThucUong;
            //Lấy cột Gia gán vào txtGia
            colFieldName = "Gia";
            value = gvNguyenLieu.GetRowCellValue(rowIndex, colFieldName);
            string gia = value.ToString();
            frmSua.txtGiaThucUong.Text = gia;
            //Lấy cột AnhMinhHoa gan vao txtAnhMinhHoa
            colFieldName = "AnhMinhHoa";
            value = gvNguyenLieu.GetRowCellValue(rowIndex, colFieldName);
            string anhMinhHoa="";
            try
            {
                anhMinhHoa = value.ToString();
            }
            catch
            {
                MessageBox.Show("Chưa có ảnh minh họa!","Thông Báo");
            }
            frmSua.txtDuongDan.Text = anhMinhHoa;
            //Lấy đường dẫn gán vào ImgBox
            string filePath = Path.GetFullPath("D:/15DTH14/CNPM/QuanLyCoffee/QuanLyCoffee/QuanLyCoffee/Images/" + frmSua.txtDuongDan.Text);
            try
            {
                frmSua.pteHinhMinhHoa.Image = Image.FromFile(filePath);
            }
            catch
            {

                MessageBox.Show("Đường dẫn không đúng!","Lỗi!");
            }
            //Lấy LoaiThucUong gán vào cmbLoaiThucUong
            colFieldName = "MaLoai";
            value = gvNguyenLieu.GetRowCellValue(rowIndex, colFieldName);
            frmSua.lkLoaiThucUong.EditValue = value;
            frmSua.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = gvNguyenLieu.FocusedRowHandle;
            string colFieldName = "MaNguyenLieu";
            object value = gvNguyenLieu.GetRowCellValue(rowIndex,colFieldName);
            string maNguyenLieu = value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa nguyên liệu có mã "+maNguyenLieu+"?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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