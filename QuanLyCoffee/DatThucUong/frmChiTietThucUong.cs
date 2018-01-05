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

namespace QuanLyCoffee
{
    public partial class frmChiTietThucUong : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietThucUong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietThucUong_Load(object sender, EventArgs e)
        {
            
        }
    }
}