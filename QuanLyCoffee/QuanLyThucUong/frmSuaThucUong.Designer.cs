namespace QuanLyCoffee
{
    partial class frmSuaThucUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaThucUong));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaThucUong = new DevExpress.XtraEditors.TextEdit();
            this.txtTenThucUong = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaThucUong = new DevExpress.XtraEditors.TextEdit();
            this.btnChon = new DevExpress.XtraEditors.SimpleButton();
            this.txtDuongDan = new DevExpress.XtraEditors.TextEdit();
            this.pteHinhMinhHoa = new DevExpress.XtraEditors.PictureEdit();
            this.lkLoaiThucUong = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThucUong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucUong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaThucUong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pteHinhMinhHoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiThucUong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(185, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sửa Thức Uống";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã thức uống:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên thức uống:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 199);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Giá thức uống:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(45, 261);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Loại thức uống:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(45, 323);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Ảnh minh họa:";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(91, 471);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatLai.ImageOptions.Image")));
            this.btnDatLai.Location = new System.Drawing.Point(195, 471);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(75, 23);
            this.btnDatLai.TabIndex = 7;
            this.btnDatLai.Text = "Đặt Lại";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(298, 471);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            // 
            // txtMaThucUong
            // 
            this.txtMaThucUong.Location = new System.Drawing.Point(170, 85);
            this.txtMaThucUong.Name = "txtMaThucUong";
            this.txtMaThucUong.Properties.ReadOnly = true;
            this.txtMaThucUong.Size = new System.Drawing.Size(203, 20);
            this.txtMaThucUong.TabIndex = 0;
            this.txtMaThucUong.TabIndexChanged += new System.EventHandler(this.btnChon_Click);
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.Location = new System.Drawing.Point(170, 137);
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.Size = new System.Drawing.Size(203, 20);
            this.txtTenThucUong.TabIndex = 1;
            // 
            // txtGiaThucUong
            // 
            this.txtGiaThucUong.Location = new System.Drawing.Point(170, 192);
            this.txtGiaThucUong.Name = "txtGiaThucUong";
            this.txtGiaThucUong.Size = new System.Drawing.Size(203, 20);
            this.txtGiaThucUong.TabIndex = 2;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(298, 313);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 5;
            this.btnChon.Text = "Chọn";
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(170, 315);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Properties.ReadOnly = true;
            this.txtDuongDan.Size = new System.Drawing.Size(122, 20);
            this.txtDuongDan.TabIndex = 4;
            // 
            // pteHinhMinhHoa
            // 
            this.pteHinhMinhHoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.pteHinhMinhHoa.Location = new System.Drawing.Point(170, 341);
            this.pteHinhMinhHoa.Name = "pteHinhMinhHoa";
            this.pteHinhMinhHoa.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pteHinhMinhHoa.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pteHinhMinhHoa.Size = new System.Drawing.Size(100, 96);
            this.pteHinhMinhHoa.TabIndex = 10;
            // 
            // lkLoaiThucUong
            // 
            this.lkLoaiThucUong.Location = new System.Drawing.Point(170, 254);
            this.lkLoaiThucUong.Name = "lkLoaiThucUong";
            this.lkLoaiThucUong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiThucUong.Size = new System.Drawing.Size(203, 20);
            this.lkLoaiThucUong.TabIndex = 3;
            // 
            // frmSuaThucUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.lkLoaiThucUong);
            this.Controls.Add(this.pteHinhMinhHoa);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtGiaThucUong);
            this.Controls.Add(this.txtTenThucUong);
            this.Controls.Add(this.txtMaThucUong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmSuaThucUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Thức Uống";
            this.Load += new System.EventHandler(this.frmSuaThucUong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaThucUong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucUong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaThucUong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDuongDan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pteHinhMinhHoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiThucUong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.SimpleButton btnLuu;
        public DevExpress.XtraEditors.SimpleButton btnDatLai;
        public DevExpress.XtraEditors.SimpleButton btnThoat;
        public DevExpress.XtraEditors.TextEdit txtMaThucUong;
        public DevExpress.XtraEditors.TextEdit txtTenThucUong;
        public DevExpress.XtraEditors.TextEdit txtGiaThucUong;
        public DevExpress.XtraEditors.SimpleButton btnChon;
        public DevExpress.XtraEditors.TextEdit txtDuongDan;
        public DevExpress.XtraEditors.PictureEdit pteHinhMinhHoa;
        public DevExpress.XtraEditors.LookUpEdit lkLoaiThucUong;
    }
}