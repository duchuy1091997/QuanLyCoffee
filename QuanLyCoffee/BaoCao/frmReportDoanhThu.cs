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
using System.Data.SqlClient;

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
            string chuoiKetNoi = "Data Source=DESKTOP-QR164ON\\SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";
            string selectHD = "select * from HoaDon";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = chuoiKetNoi;
            connection.Open();

            SqlDataAdapter dta = new SqlDataAdapter(selectHD, connection);
            DataTable dt = new DataTable();
            dta.Fill(dt);
            rp.SetDataSource(dt);
            rpViewer.ReportSource = rp;
            connection.Close();
        }

        private void dtNgayXem_DateTimeChanged(object sender, EventArgs e)
        {
            try
            {
                rpDoanhThu rp = new rpDoanhThu();
                string chuoiKetNoi = "Data Source=DESKTOP-QR164ON\\SQLEXPRESS;Initial Catalog=QuanLyCoffee;Integrated Security=True";
                string selectHD = "select * from HoaDon where NgayLap='"+dtNgayXem.DateTime.ToString("yyyy-MM-dd")+"'";
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = chuoiKetNoi;
                connection.Open();

                SqlDataAdapter dta = new SqlDataAdapter(selectHD, connection);
                DataTable dt = new DataTable();
                dta.Fill(dt);
                rp.SetDataSource(dt);
                rpViewer.ReportSource = rp;
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Không có hóa đơn của ngày "+dtNgayXem.Text);
                return;
            }
           
        }
    }
}