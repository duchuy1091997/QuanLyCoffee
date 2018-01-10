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
        DataTable dt = new DataTable();
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
            gvThucUong.Columns[3].Caption = "Hình minh họa";
            gvThucUong.Columns[4].Visible = false;
            gvThucUong.Columns[5].Caption = "Loại";
        }
        //Show thức uống lên grid control
        private void frmDatThucUong_Load(object sender, EventArgs e)
        {
            //Tạo datatable cho danh sách thức uống ở hóa đơn
            dt.Columns.Add("Mã Thức Uống");
            dt.Columns.Add("Tên Thức uống");
            dt.Columns.Add("Đơn Giá");
            dt.Columns.Add("Số Lượng");
            dt.Columns.Add("Thành Tiền");
            //Gán dữ liệu cho dgvThucUong
            gcThucUong.DataSource = typeof(ThucUong_DTO);
            gcThucUong.DataSource = ThucUong_BUL.LoadThucUong();
            //ẩn cột MaLoai
            ShowColumn();
        }
        //Lấy thức uống được chọn từ gvThucUong gán vào gvDSChon
        private void GetValue()
        {
            //Lấy dòng dc chọn
            int rowIndex = gvThucUong.FocusedRowHandle;
            string colFieldName;
            //Lấy cột MaThucUong gán vào maThucUong
            colFieldName = "MaThucUong";
            object value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string maThucUong = value.ToString().Trim();
            //Lấy cột TenThucUong gán vào tenThucUong
            colFieldName = "TenThucUong";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string tenThucUong = value.ToString().Trim();
            //Lấy cột Giá gán vào gia
            colFieldName = "Gia";
            value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string gia = value.ToString().Trim();
            //Lấy số lượng từ SpinEdit
            string soLuong = seSoLuong.Value.ToString();
            //Thành tiền
            string thanhTien = (decimal.Parse(gia) * int.Parse(soLuong)).ToString();
            string[] row = { maThucUong, tenThucUong, gia, soLuong, thanhTien };
            dt.Rows.Add(row);
            gcDSChon.DataSource = dt;
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            bool flag = false;
            int dong = gvThucUong.FocusedRowHandle;
            if (gvDSChon.RowCount==0)
            {
                GetValue();
            }
            else
            {
                for (int i = 0; i < gvDSChon.RowCount; i++)
                {
                    if (gvThucUong.GetRowCellValue(dong,"MaThucUong").ToString()==gvDSChon.GetRowCellValue(i,"Mã Thức Uống").ToString())
                    {
                        MessageBox.Show("Đã có thức uống này trong danh sách chọn!");
                        flag = true;
                    }
                }
                if (flag==false)
                {
                    GetValue();
                }
            }
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            if (gcDSChon.DataSource==null)
            {
                MessageBox.Show("Chưa có thức uống được chọn!","Thông Báo!");
            }
            else
            {
                frmHoaDon frmHD = new frmHoaDon();
                frmHD.gcHoaDon.DataSource = gcDSChon.DataSource;
                frmHD.ShowDialog();
            }
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
            string filePath = "D:/15DTH14/CNPM/QuanLyCoffee/QuanLyCoffee/QuanLyCoffee/Images/" + anhMinhHoa;
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

        private void gcThucUong_Click(object sender, EventArgs e)
        {
            //Lấy dòng dc chọn
            int rowIndex = gvThucUong.FocusedRowHandle;
            string colFieldName;
            //Lấy cột TenThucUong gán vào txtTenThucUong
            colFieldName = "TenThucUong";
            object value = gvThucUong.GetRowCellValue(rowIndex, colFieldName);
            string tenThucUong = value.ToString().Trim();
            txtTenThucUong.Text = tenThucUong;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            gvDSChon.DeleteSelectedRows();
        }
    }
}