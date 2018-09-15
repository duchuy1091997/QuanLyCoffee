namespace QuanLyCoffee.QuanLyNhanVien
{
    partial class frmSuaNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaNhanVien));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.lkLoaiNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdKhac = new System.Windows.Forms.RadioButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(185, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sửa Nhân Viên";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 88);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã nhân viên:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tên nhân viên:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(45, 199);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Địa chỉ:";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(91, 471);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDatLai
            // 
            this.btnDatLai.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatLai.ImageOptions.Image")));
            this.btnDatLai.Location = new System.Drawing.Point(195, 471);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(75, 23);
            this.btnDatLai.TabIndex = 9;
            this.btnDatLai.Text = "Đặt Lại";
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(298, 471);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(170, 85);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.MaxLength = 5;
            this.txtMaNhanVien.Properties.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(203, 20);
            this.txtMaNhanVien.TabIndex = 0;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(170, 137);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(203, 20);
            this.txtTenNhanVien.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(170, 192);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(203, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // lkLoaiNhanVien
            // 
            this.lkLoaiNhanVien.Location = new System.Drawing.Point(170, 366);
            this.lkLoaiNhanVien.Name = "lkLoaiNhanVien";
            this.lkLoaiNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLoaiNhanVien.Size = new System.Drawing.Size(203, 20);
            this.lkLoaiNhanVien.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(170, 238);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.MaxLength = 13;
            this.txtSDT.Size = new System.Drawing.Size(203, 20);
            this.txtSDT.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(45, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Số điện thoại:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(45, 309);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Giới tính:";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(170, 304);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(46, 17);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(231, 304);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 5;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdKhac
            // 
            this.rdKhac.AutoSize = true;
            this.rdKhac.Location = new System.Drawing.Point(287, 304);
            this.rdKhac.Name = "rdKhac";
            this.rdKhac.Size = new System.Drawing.Size(48, 17);
            this.rdKhac.TabIndex = 6;
            this.rdKhac.Text = "Khác";
            this.rdKhac.UseVisualStyleBackColor = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(45, 369);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Loại nhân viên:";
            // 
            // frmSuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.rdKhac);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lkLoaiNhanVien);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmSuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Nhân Viên";
            this.Load += new System.EventHandler(this.frmSuaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkLoaiNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.SimpleButton btnLuu;
        public DevExpress.XtraEditors.SimpleButton btnDatLai;
        public DevExpress.XtraEditors.SimpleButton btnThoat;
        public DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        public DevExpress.XtraEditors.TextEdit txtTenNhanVien;
        public DevExpress.XtraEditors.TextEdit txtDiaChi;
        public DevExpress.XtraEditors.LookUpEdit lkLoaiNhanVien;
        public DevExpress.XtraEditors.TextEdit txtSDT;
        public DevExpress.XtraEditors.LabelControl labelControl6;
        public DevExpress.XtraEditors.LabelControl labelControl7;
        public System.Windows.Forms.RadioButton rdNam;
        public System.Windows.Forms.RadioButton rdNu;
        public System.Windows.Forms.RadioButton rdKhac;
        public DevExpress.XtraEditors.LabelControl labelControl5;
    }
}