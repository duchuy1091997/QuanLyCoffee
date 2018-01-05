using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyCoffee.QuanLyThucUong;

namespace QuanLyCoffee
{
    public partial class frmTrangChinh : DevExpress.XtraEditors.XtraForm
    {
        public frmTrangChinh()
        {
            InitializeComponent();
        }
        //Hàm gọi form con
        public void ShowFormChild(Form _form)
        {
            if (!IsFormActivated(_form))
            {
                _form.MdiParent = this;
                _form.Show();
            }
        }
        //Kiểm tra form đã mở hay chưa
        public bool IsFormActivated(Form form)
        {
            bool isOpened = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (form.Name == item.Name)
                    {
                        //Bật form con lên
                        mdiTrangChinh.Pages[item].MdiChild.Activate();
                        isOpened = true;
                    }
                }
            }
            return isOpened;
        }
        private void frmTrangChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng chương trình?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnQLThucUong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShowThucUong frmShowTU = new frmShowThucUong();
            ShowFormChild(frmShowTU);
        }

        private void btnDHThucUong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDatThucUong frmDat = new frmDatThucUong();
            ShowFormChild(frmDat);
        }

        private void btnQLNguyenLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmShowNguyenLieu frmNL = new frmShowNguyenLieu();
            ShowFormChild(frmNL);
        }
    }
}
