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
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.btnDat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenThucUong = new DevExpress.XtraEditors.TextEdit();
            this.seSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.gcThucUong = new DevExpress.XtraGrid.GridControl();
            this.gvThucUong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcDSChon = new DevExpress.XtraGrid.GridControl();
            this.gvDSChon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucUong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSChon)).BeginInit();
            this.SuspendLayout();
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
            // btnDat
            // 
            this.btnDat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDat.ImageOptions.Image")));
            this.btnDat.Location = new System.Drawing.Point(685, 281);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(112, 36);
            this.btnDat.TabIndex = 6;
            this.btnDat.Text = "Đặt hàng";
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(803, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 36);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 300);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Tên thức uống:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(62, 341);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Số lượng:";
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.Location = new System.Drawing.Point(143, 297);
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.Properties.ReadOnly = true;
            this.txtTenThucUong.Size = new System.Drawing.Size(186, 20);
            this.txtTenThucUong.TabIndex = 9;
            // 
            // seSoLuong
            // 
            this.seSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seSoLuong.Location = new System.Drawing.Point(143, 341);
            this.seSoLuong.Name = "seSoLuong";
            this.seSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuong.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seSoLuong.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seSoLuong.Size = new System.Drawing.Size(100, 20);
            this.seSoLuong.TabIndex = 10;
            // 
            // gcThucUong
            // 
            this.gcThucUong.Location = new System.Drawing.Point(62, 12);
            this.gcThucUong.MainView = this.gvThucUong;
            this.gcThucUong.Name = "gcThucUong";
            this.gcThucUong.Size = new System.Drawing.Size(463, 264);
            this.gcThucUong.TabIndex = 11;
            this.gcThucUong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThucUong});
            this.gcThucUong.Click += new System.EventHandler(this.gcThucUong_Click);
            // 
            // gvThucUong
            // 
            this.gvThucUong.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvThucUong.GridControl = this.gcThucUong;
            this.gvThucUong.Name = "gvThucUong";
            this.gvThucUong.OptionsBehavior.Editable = false;
            this.gvThucUong.OptionsBehavior.ReadOnly = true;
            // 
            // gcDSChon
            // 
            this.gcDSChon.Location = new System.Drawing.Point(582, 76);
            this.gcDSChon.MainView = this.gvDSChon;
            this.gcDSChon.Name = "gcDSChon";
            this.gcDSChon.Size = new System.Drawing.Size(390, 200);
            this.gcDSChon.TabIndex = 12;
            this.gcDSChon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSChon});
            // 
            // gvDSChon
            // 
            this.gvDSChon.GridControl = this.gcDSChon;
            this.gvDSChon.Name = "gvDSChon";
            this.gvDSChon.OptionsBehavior.Editable = false;
            this.gvDSChon.OptionsBehavior.ReadOnly = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(659, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(256, 19);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Danh sách thức uống được chọn";
            // 
            // frmDatThucUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.gcDSChon);
            this.Controls.Add(this.gcThucUong);
            this.Controls.Add(this.seSoLuong);
            this.Controls.Add(this.txtTenThucUong);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDat);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmDatThucUong";
            this.Text = "Đặt Thức Uống";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDatThucUong_FormClosing);
            this.Load += new System.EventHandler(this.frmDatThucUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucUong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThucUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSChon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnChon;
        private DevExpress.XtraEditors.SimpleButton btnDat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnChiTiet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenThucUong;
        private DevExpress.XtraEditors.SpinEdit seSoLuong;
        private DevExpress.XtraGrid.GridControl gcThucUong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThucUong;
        public DevExpress.XtraGrid.GridControl gcDSChon;
        public DevExpress.XtraGrid.Views.Grid.GridView gvDSChon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}