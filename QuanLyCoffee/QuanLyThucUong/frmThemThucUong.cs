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
using QuanLyCoffee.QuanLyThucUong;

namespace QuanLyCoffee
{
    public partial class frmThemThucUong : DevExpress.XtraEditors.XtraForm
    {
        public frmThemThucUong()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string filePath;
            dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog()==DialogResult.OK)
            {
                filePath = Path.GetFileName(dlg.FileName);
                txtDuongDan.Text = filePath.ToString();
                pteHinhMinhHoa.Image = new Bitmap(dlg.FileName);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThucUong tu = new ThucUong();
            try
            {
                tu.MaThucUong = txtMaThucUong.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Trùng mã thức uống!","Lỗi!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            tu.TenThucUong = txtTenThucUong.Text;
            try
            {
                tu.Gia =decimal.Parse(txtGiaThucUong.Text);
            }
            catch
            {

                MessageBox.Show("Vui lòng nhập số!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            tu.AnhMinhHoa = txtDuongDan.Text;
            try
            {
                tu.MaLoai = lkLoaiThucUong.EditValue.ToString();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn loại thức uống!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ThucUong_BUL.AddThucUong(tu);
            MessageBox.Show("Thêm Thành Công!","Thông Báo");
            this.Close();
        }
        private void frmThemThucUong_Load(object sender, EventArgs e)
        {
            //Load LoaiThucUong vào combobox
            lkLoaiThucUong.Properties.DataSource = LoaiThucUong_BUL.LoadLoaiThucUong();
            lkLoaiThucUong.Properties.ValueMember = "MaLoai";
            lkLoaiThucUong.Properties.DisplayMember = "TenLoai";
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaThucUong.Text = "";
            txtTenThucUong.Text = "";
            txtGiaThucUong.Text = "";
            txtDuongDan.Text = "";
        }
    }
}