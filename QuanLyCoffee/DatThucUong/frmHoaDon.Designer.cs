namespace QuanLyCoffee.DatThucUong
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gcHoaDon = new DevExpress.XtraGrid.GridControl();
            this.gvHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaHD = new DevExpress.XtraEditors.TextEdit();
            this.dtNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenThucUong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.seSoLuong = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucUong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(370, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hóa đơn";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(62, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã HD:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(62, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày lập:";
            // 
            // gcHoaDon
            // 
            this.gcHoaDon.Location = new System.Drawing.Point(59, 211);
            this.gcHoaDon.MainView = this.gvHoaDon;
            this.gcHoaDon.Name = "gcHoaDon";
            this.gcHoaDon.Size = new System.Drawing.Size(674, 200);
            this.gcHoaDon.TabIndex = 1;
            this.gcHoaDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHoaDon});
            // 
            // gvHoaDon
            // 
            this.gvHoaDon.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvHoaDon.GridControl = this.gcHoaDon;
            this.gvHoaDon.Name = "gvHoaDon";
            this.gvHoaDon.OptionsBehavior.Editable = false;
            this.gvHoaDon.OptionsBehavior.ReadOnly = true;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(490, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên thức uống:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(490, 144);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Số lượng:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(559, 426);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(620, 419);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(113, 20);
            this.txtThanhTien.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(175, 421);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(106, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Xuất hóa đơn";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(333, 421);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(106, 23);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(132, 48);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Properties.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(159, 20);
            this.txtMaHD.TabIndex = 4;
            // 
            // dtNgayLap
            // 
            this.dtNgayLap.EditValue = null;
            this.dtNgayLap.Location = new System.Drawing.Point(132, 93);
            this.dtNgayLap.Name = "dtNgayLap";
            this.dtNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtNgayLap.Properties.ReadOnly = true;
            this.dtNgayLap.Size = new System.Drawing.Size(159, 20);
            this.dtNgayLap.TabIndex = 5;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(62, 154);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Nhân viên:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(132, 147);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(159, 20);
            this.lookUpEdit1.TabIndex = 6;
            // 
            // txtTenThucUong
            // 
            this.txtTenThucUong.Location = new System.Drawing.Point(574, 98);
            this.txtTenThucUong.Name = "txtTenThucUong";
            this.txtTenThucUong.Properties.ReadOnly = true;
            this.txtTenThucUong.Size = new System.Drawing.Size(159, 20);
            this.txtTenThucUong.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(490, 55);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Khách hàng:";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(574, 48);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(159, 20);
            this.textEdit2.TabIndex = 4;
            // 
            // seSoLuong
            // 
            this.seSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seSoLuong.Location = new System.Drawing.Point(574, 141);
            this.seSoLuong.Name = "seSoLuong";
            this.seSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuong.Properties.IsFloatValue = false;
            this.seSoLuong.Properties.Mask.EditMask = "N00";
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
            this.seSoLuong.Properties.ReadOnly = true;
            this.seSoLuong.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.seSoLuong.Size = new System.Drawing.Size(100, 20);
            this.seSoLuong.TabIndex = 7;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.seSoLuong);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.dtNgayLap);
            this.Controls.Add(this.txtTenThucUong);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.gcHoaDon);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmHoaDon";
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenThucUong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraGrid.GridControl gcHoaDon;
        public DevExpress.XtraGrid.Views.Grid.GridView gvHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.TextEdit txtMaHD;
        private DevExpress.XtraEditors.DateEdit dtNgayLap;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit txtTenThucUong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SpinEdit seSoLuong;
    }
}