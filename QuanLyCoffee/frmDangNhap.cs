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
using DataAccessLayer;
using BussinessLogicLayer;

namespace QuanLyCoffee
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (User_BUL.GetUser(txtTenDangNhap.Text.Trim(),txtMatKhau.Text.Trim()))
            {
                frmTrangChinh frmMainPage = new frmTrangChinh();
                this.Hide();
                frmMainPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập!", "Thông Báo");
            }
        }
    }
}