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
using DevExpress.XtraEditors.Repository;

namespace QuanLyCoffee.QuanLyThucUong
{
    public partial class frmShowThucUong : DevExpress.XtraEditors.XtraForm
    {
        public frmShowThucUong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemThucUong frmThem = new frmThemThucUong();
            frmThem.ShowDialog();
        }

        private void frmShowThucUong_FormClosing(object sender, FormClosingEventArgs e)
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
            //Column
            gvThucUong.Columns[0].Caption = "Mã Thức Uống";
            gvThucUong.Columns[1].Caption = "Tên Thức Uống";
            gvThucUong.Columns[2].Caption = "Giá";
            gvThucUong.Columns[3].Caption = "Ảnh Minh Họa";
            gvThucUong.Columns[4].Visible = false;
            gvThucUong.Columns[5].Caption = "Loại Thức Uống";
        }
        //Show thức uống lên grid control
        private void frmShowThucUong_Load(object sender, EventArgs e)
        {
            ReloadGC();
        }
        //Gán dữ liệu cho gvThucUong
        public void ReloadGC()
        {
            gcThucUong.DataSource = typeof(ThucUong_DTO);
            gcThucUong.DataSource = ThucUong_BUL.LoadThucUong();
            ShowColumn();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaThucUong frmSua = new frmSuaThucUong();
            //Đưa dữ liệu từ gridControl lên frmSuaThucUong
            int rowIndex = gvThucUong.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaThucUong gán vào txtMaThucUong
            colFieldName = "MaThucUong";
            object value = gvThucUong.GetRowCellValue(rowIndex,colFieldName);
            string maThucUong = value.ToString().Trim();
            frmSua.txtMaThucUong.Text = maThucUong;
            //Lấy cột TenThucUong gán vào txtTenThucUong
            colFieldName = "TenThucUong";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string tenThucUong = value.ToString();
            frmSua.txtTenThucUong.Text = tenThucUong;
            //Lấy cột Gia gán vào txtGia
            colFieldName = "Gia";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string gia = value.ToString();
            frmSua.txtGiaThucUong.Text = gia;
            //Lấy cột AnhMinhHoa gan vao txtAnhMinhHoa
            colFieldName = "AnhMinhHoa";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
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
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            frmSua.lkLoaiThucUong.EditValue = value;
            frmSua.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int rowIndex = gvThucUong.FocusedRowHandle;
            string colFieldName = "MaThucUong";
            object value = gvThucUong.GetRowCellValue(rowIndex,colFieldName);
            string maThucUong = value.ToString().Trim();
            if (MessageBox.Show("Bạn có muốn xóa thức uống có mã "+maThucUong+"?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ThucUong_BUL.DeleteThucUong(maThucUong);
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