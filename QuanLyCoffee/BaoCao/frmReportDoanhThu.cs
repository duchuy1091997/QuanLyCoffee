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

namespace QuanLyCoffee.BaoCao
{
    public partial class frmReportDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public frmReportDoanhThu()
        {
            InitializeComponent();
        }

        private void frmReportDoanhThu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmReportDoanhThu_Load(object sender, EventArgs e)
        {
            rpDoanhThu rp = new rpDoanhThu();
        }
    }
}