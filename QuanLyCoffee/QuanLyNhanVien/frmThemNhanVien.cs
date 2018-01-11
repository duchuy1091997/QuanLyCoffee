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

namespace QuanLyCoffee.QuanLyNhanVien
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
        }
        public static bool KiemTraSDT(string number)
        {
            return Regex.Match(number, @"^[-+]?[0-9]*\.?[0-9]+$").Success;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            try
            {
                nv.MaNV = txtMaNhanVien.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Trùng mã nhân viên!","Lỗi!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            nv.TenNV = txtTenNhanVien.Text;
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
                nv.MaLoaiNV = lkLoaiNhanVien.EditValue.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            NhanVien_BUL.AddNhanVien(nv);
            MessageBox.Show("Thêm Thành Công!","Thông Báo");
            this.Close();
        }
        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            //Load LoaiThucUong vào combobox
            lkLoaiNhanVien.Properties.DataSource = LoaiNhanVien_BUL.LoadLoaiNhanVien();
            lkLoaiNhanVien.Properties.ValueMember = "MaLoaiNV";
            lkLoaiNhanVien.Properties.DisplayMember = "TenLoaiNV";
            //Ẩn các cột ko cần thiết của lkLoaiNV
            lkLoaiNhanVien.Properties.PopulateColumns();
            lkLoaiNhanVien.Properties.Columns[0].Visible = false;
            lkLoaiNhanVien.Properties.Columns[1].Caption = "Tên loại";
            lkLoaiNhanVien.Properties.Columns[2].Visible = false;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}