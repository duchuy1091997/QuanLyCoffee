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
using QuanLyCoffee.DatThucUong;

namespace QuanLyCoffee.QuanLyThucUong
{
    public partial class frmDatThucUong : DevExpress.XtraEditors.XtraForm
    {
        public frmDatThucUong()
        {
            InitializeComponent();
        }
        private void frmDatThucUong_FormClosing(object sender, FormClosingEventArgs e)
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
            gvThucUong.Columns[0].Caption = "Mã Thức Uống";
            gvThucUong.Columns[1].Caption = "Tên Thức Uống";
            gvThucUong.Columns[2].Caption = "Giá";
            gvThucUong.Columns[3].Caption = "Ảnh Minh Họa";
            gvThucUong.Columns[4].Visible = false;
            gvThucUong.Columns[5].Caption = "Loại Thức Uống";
        }
        //Show thức uống lên grid control
        private void frmDatThucUong_Load(object sender, EventArgs e)
        {
            //Gán dữ liệu cho gvThucUong
            gcThucUong.DataSource = typeof(ThucUong_DTO);
            gcThucUong.DataSource = ThucUong_BUL.LoadThucUong();
            //ẩn cột MaLoai
            ShowColumn();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int rowIndex = gvThucUong.FocusedRowHandle;
            gcHoaDon.DataSource = typeof(ThucUong_DTO);
            gcHoaDon.DataSource = gvThucUong.GetRow(rowIndex);
            //gvHoaDon.GetRow(rowIndex);
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.ShowDialog();
        }

        private void gvThucUong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietThucUong frmChiTiet = new frmChiTietThucUong();
            //Đưa dữ liệu từ gridControl lên frmSuaThucUong
            int rowIndex = gvThucUong.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaThucUong gán vào txtMaThucUong
            colFieldName = "MaThucUong";
            object value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string maThucUong = value.ToString().Trim();
            frmChiTiet.txtMaThucUong.Text = maThucUong;
            //Lấy cột TenThucUong gán vào txtTenThucUong
            colFieldName = "TenThucUong";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string tenThucUong = value.ToString();
            frmChiTiet.txtTenThucUong.Text = tenThucUong;
            //Lấy cột Gia gán vào txtGia
            colFieldName = "Gia";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string gia = value.ToString();
            frmChiTiet.txtGiaThucUong.Text = gia;
            //Lấy cột AnhMinhHoa gan vao txtAnhMinhHoa
            colFieldName = "AnhMinhHoa";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string anhMinhHoa = "";
            try
            {
                anhMinhHoa = value.ToString();
            }
            catch
            {
                MessageBox.Show("Chưa có ảnh minh họa!", "Thông Báo");
            }
            //Lấy đường dẫn gán vào ImgBox
            string filePath = "D:/15DTH14/CNPM/QuanLyCoffee/QuanLyCoffee/QuanLyCoffee/Images/"+anhMinhHoa;
            try
            {
                frmChiTiet.pteHinhMinhHoa.Image = Image.FromFile(filePath);
            }
            catch
            {

                MessageBox.Show("Đường dẫn không đúng!", "Lỗi!");
            }
            //Lấy LoaiThucUong gán vào cmbLoaiThucUong
            colFieldName = "TenLoai";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            frmChiTiet.lkLoaiThucUong.EditValue = value;
            frmChiTiet.ShowDialog();
        }

        private void gvThucUong_DoubleClick(object sender, EventArgs e)
        {
        }
    }
}