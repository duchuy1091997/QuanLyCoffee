namespace QuanLyCoffee.QuanLyThucUong
{
    partial class frmDatThucUong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatThucUong));
            this.gcThucUong = new DevExpress.XtraGrid.GridControl();
            this.gvThucUong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaHet = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // gcThucUong
            // 
            this.gcThucUong.Location = new System.Drawing.Point(12, 12);
            this.gcThucUong.MainView = this.gvThucUong;
            this.gcThucUong.Name = "gcThucUong";
            this.gcThucUong.Size = new System.Drawing.Size(554, 371);
            this.gcThucUong.TabIndex = 0;
            this.gcThucUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThucUong});
            // 
            // gvThucUong
            // 
            this.gvThucUong.GridControl = this.gcThucUong;
            this.gvThucUong.Name = "gvThucUong";
            this.gvThucUong.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvThucUong.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvThucUong.OptionsBehavior.Editable = false;
            this.gvThucUong.OptionsBehavior.ReadOnly = true;
            this.gvThucUong.Click += new System.EventHandler(this.gvThucUong_Click);
            this.gvThucUong.DoubleClick += new System.EventHandler(this.gvThucUong_DoubleClick);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(850, 389);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChon
            // 
            this.btnChon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.ImageOptions.Image")));
            this.btnChon.Location = new System.Drawing.Point(131, 389);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(112, 36);
            this.btnChon.TabIndex = 6;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.Location = new System.Drawing.Point(593, 12);
            this.gcHoaDon.MainView = this.gvHoaDon;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(379, 200);
            this.gcHoaDon.TabIndex = 7;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.GridControl = this.gcHoaDon;
            this.gvHoaDon.Name = "gvHoaDon";
            // 
            // btnDat
            // 
            this.btnDat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDat.ImageOptions.Image")));
            this.btnDat.Location = new System.Drawing.Point(614, 218);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(112, 36);
            this.btnDat.TabIndex = 6;
            this.btnDat.Text = "Đặt hàng";
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(732, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 36);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHet.ImageOptions.Image")));
            this.btnXoaHet.Location = new System.Drawing.Point(850, 218);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(112, 36);
            this.btnXoaHet.TabIndex = 6;
            this.btnXoaHet.Text = "Xóa hết";
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChiTiet.ImageOptions.Image")));
            this.btnChiTiet.Location = new System.Drawing.Point(306, 389);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(112, 36);
            this.btnChiTiet.TabIndex = 6;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // frmDatThucUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.gcHoaDon);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnXoaHet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gcThucUong);
            this.Name = "frmDatThucUong";
            this.Text = "Đặt Thức Uống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatThucUong_FormClosing);
            this.Load += new System.EventHandler(this.frmDatThucUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcThucUong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThucUong;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraGrid.GridControl gcHoaDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnDat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXoaHet;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
    }
}