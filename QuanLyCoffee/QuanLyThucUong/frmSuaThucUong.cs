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
    public partial class frmSuaThucUong : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaThucUong()
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
            tu.MaThucUong = txtMaThucUong.Text;
            tu.TenThucUong = txtTenThucUong.Text;
            tu.Gia = decimal.Parse(txtGiaThucUong.Text);
            tu.AnhMinhHoa = txtDuongDan.Text;
            tu.MaLoai = lkLoaiThucUong.EditValue.ToString();
            //Lưu vào database
            ThucUong_BUL.EditThucUong(tu);
            MessageBox.Show("Sửa thành công!","Thông Báo");
            this.Close();
        }
        private void frmSuaThucUong_Load(object sender, EventArgs e)
        {
            //Load LoaiThucUong vào combobox
            lkLoaiThucUong.Properties.DataSource = LoaiThucUong_BUL.LoadLoaiThucUong();
            lkLoaiThucUong.Properties.ValueMember = "MaLoai";
            lkLoaiThucUong.Properties.DisplayMember = "TenLoai";
        }
    }
}