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
    public partial class frmSuaNguyenLieu : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaNguyenLieu()
        {
            InitializeComponent();
        }

        private void frmSuaNguyenLieu_Load(object sender, EventArgs e)
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
            nl.MaNguyenLieu = txtMaNguyenLieu.Text;
            nl.TenNguyenLieu = txtTenNguyenLieu.Text;
            nl.NhaSX = txtNSX.Text;
            nl.Gia = decimal.Parse(txtGiaNguyenLieu.Text);
            nl.SoLuongTon = int.Parse(txtSLTon.Text);
            nl.DonViTinh = lkDVT.EditValue.ToString();
            nl.NgayNhap = dtNgayNhap.DateTime;
            //Lưu vào database
            NguyenLieu_BUL.EditNguyenLieu(nl);
            MessageBox.Show("Sửa thành công!", "Thông Báo");
            this.Close();
        }
    }
}