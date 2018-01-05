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
using BussinessLogicLayer;
using DataAccessLayer;

namespace QuanLyCoffee
{
    public partial class frmThemNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmThemNguyenLieu_Load(object sender, EventArgs e)
        {
            //Load đơn vị tính vào lkDVT
            lkDVT.Properties.DataSource = NguyenLieu_BUL.LoadNguyenLieu();
            lkDVT.Properties.DisplayMember = "DonViTinh";
            lkDVT.Properties.ValueMember = "DonViTinh";
            lkDVT.Properties.PopulateColumns();
            lkDVT.Properties.Columns[0].Visible = false;
            lkDVT.Properties.Columns[1].Visible = false;
            lkDVT.Properties.Columns[2].Visible = false;
            lkDVT.Properties.Columns[3].Visible = false;
            lkDVT.Properties.Columns[4].Caption = "Đơn vị tính";
            lkDVT.Properties.Columns[5].Visible = false;
            lkDVT.Properties.Columns[6].Visible = false;
            lkDVT.Properties.Columns[7].Visible = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguyenLieu nl = new NguyenLieu();
            try
            {
                nl.MaNguyenLieu = txtMaNguyenLieu.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Trùng mã nguyên liệu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            nl.TenNguyenLieu = txtTenNguyenLieu.Text;
            nl.NhaSX = txtNSX.Text;
            nl.SoLuongTon =Int32.Parse(txtSLTon.Text);
            try
            {
                nl.Gia = decimal.Parse(txtGiaNguyenLieu.Text);
            }
            catch
            {

                MessageBox.Show("Vui lòng nhập số!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                nl.DonViTinh = lkDVT.EditValue.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            nl.NgayNhap = dtNgayNhap.DateTime;
            NguyenLieu_BUL.AddNguyenLieu(nl);
            MessageBox.Show("Thêm Thành Công!", "Thông Báo");
            this.Close();
        }
    }
}