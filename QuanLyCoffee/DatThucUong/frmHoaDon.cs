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
using QuanLyCoffee.DatThucUong;

namespace QuanLyCoffee.DatThucUong
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            string maHD = DateTime.Now.ToString("HHmmssddMMyy");
            txtMaHD.Text = maHD;
            dtNgayLap.DateTime = DateTime.Now;
            
        }
    }
}