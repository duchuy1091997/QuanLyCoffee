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
using System.IO;
using DataAccessLayer;
using DataTransferObject;
using BussinessLogicLayer;
using System.Text.RegularExpressions;

namespace QuanLyCoffee.QuanLyKhachHang
{
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
        }
        public static bool KiemTraSDT(string number)
        {
            return Regex.Match(number, @"^[-+]?[0-9]*\.?[0-9]+$").Success;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHang nv = new KhachHang();
            try
            {
                nv.MaKH = txtMaKhachHang.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Trùng mã nhân viên!","Lỗi!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            nv.TenKH = txtTenKhachHang.Text;
            nv.DiaChi = txtDiaChi.Text;
            try
            {
                if (KiemTraSDT(txtSDT.Text))
                {
                    nv.Sdt = txtSDT.Text;
                }
                else
                {
                    MessageBox.Show("Nhập sai định dạng số điện thoại!", "Thông báo!");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi định dạng sdt");
            }
            if (rdNam.Checked)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                if (rdNu.Checked)
                {
                    nv.GioiTinh = "Nữ";
                }
                else
                {
                    nv.GioiTinh = "Khác";
                }
            }
            try
            {
                nv.MaLoaiKH = lkLoaiKhachHang.EditValue.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn loại khách hàng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            KhachHang_BUL.AddKhachHang(nv);
            MessageBox.Show("Thêm Thành Công!","Thông Báo");
            this.Close();
        }
        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {
            //Load LoaiThucUong vào combobox
            lkLoaiKhachHang.Properties.DataSource = LoaiKhachHang_BUL.LoadLoaiKhachHang();
            lkLoaiKhachHang.Properties.ValueMember = "MaLoaiKH";
            lkLoaiKhachHang.Properties.DisplayMember = "TenLoaiKH";
            //Ẩn các cột ko cần thiết của lkLoaiNV
            lkLoaiKhachHang.Properties.PopulateColumns();
            lkLoaiKhachHang.Properties.Columns[0].Visible = false;
            lkLoaiKhachHang.Properties.Columns[1].Caption = "Tên loại";
            lkLoaiKhachHang.Properties.Columns[2].Visible = false;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}