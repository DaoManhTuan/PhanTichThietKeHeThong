namespace TOSApp.NghiepVu
{
    partial class f102_ds_trung_tuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f102_ds_trung_tuyen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_cbo_nganh = new System.Windows.Forms.ComboBox();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_xet_tuyen = new DevExpress.XtraEditors.SimpleButton();
            this.m_grc_ds_trung_tuyen = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_trung_tuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_col_ma_thi_sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_ho_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_gioi_tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_ngay_sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_ma_nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_nguyen_vong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_diem_xet_tuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lab_chi_tieu = new System.Windows.Forms.Label();
            this.m_lab_tong_so = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_trung_tuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_trung_tuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_grc_ds_trung_tuyen, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lab_tong_so);
            this.panel1.Controls.Add(this.m_lab_chi_tieu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cbo_nganh);
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Controls.Add(this.m_cmd_xet_tuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 61);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhóm ngành";
            // 
            // m_cbo_nganh
            // 
            this.m_cbo_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbo_nganh.FormattingEnabled = true;
            this.m_cbo_nganh.Location = new System.Drawing.Point(160, 19);
            this.m_cbo_nganh.Name = "m_cbo_nganh";
            this.m_cbo_nganh.Size = new System.Drawing.Size(174, 24);
            this.m_cbo_nganh.TabIndex = 2;
            this.m_cbo_nganh.SelectedIndexChanged += new System.EventHandler(this.m_cbo_nganh_SelectedIndexChanged);
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xuat_excel.Appearance.Options.UseFont = true;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(872, 11);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(124, 41);
            this.m_cmd_xuat_excel.TabIndex = 1;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
            // 
            // m_cmd_xet_tuyen
            // 
            this.m_cmd_xet_tuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xet_tuyen.Appearance.Options.UseFont = true;
            this.m_cmd_xet_tuyen.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xet_tuyen.Image")));
            this.m_cmd_xet_tuyen.Location = new System.Drawing.Point(731, 11);
            this.m_cmd_xet_tuyen.Name = "m_cmd_xet_tuyen";
            this.m_cmd_xet_tuyen.Size = new System.Drawing.Size(124, 41);
            this.m_cmd_xet_tuyen.TabIndex = 0;
            this.m_cmd_xet_tuyen.Text = "Xét tuyển";
            this.m_cmd_xet_tuyen.Click += new System.EventHandler(this.m_cmd_xet_tuyen_Click);
            // 
            // m_grc_ds_trung_tuyen
            // 
            this.m_grc_ds_trung_tuyen.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_trung_tuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_trung_tuyen.Location = new System.Drawing.Point(3, 70);
            this.m_grc_ds_trung_tuyen.MainView = this.m_grv_ds_trung_tuyen;
            this.m_grc_ds_trung_tuyen.Name = "m_grc_ds_trung_tuyen";
            this.m_grc_ds_trung_tuyen.Size = new System.Drawing.Size(1005, 377);
            this.m_grc_ds_trung_tuyen.TabIndex = 2;
            this.m_grc_ds_trung_tuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_trung_tuyen});
            // 
            // m_grv_ds_trung_tuyen
            // 
            this.m_grv_ds_trung_tuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_col_ma_thi_sinh,
            this.m_col_ho_ten,
            this.m_col_gioi_tinh,
            this.m_col_ngay_sinh,
            this.m_col_ma_nganh,
            this.m_col_nguyen_vong,
            this.m_col_diem_xet_tuyen});
            this.m_grv_ds_trung_tuyen.GridControl = this.m_grc_ds_trung_tuyen;
            this.m_grv_ds_trung_tuyen.Name = "m_grv_ds_trung_tuyen";
            this.m_grv_ds_trung_tuyen.OptionsBehavior.Editable = false;
            this.m_grv_ds_trung_tuyen.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.m_col_diem_xet_tuyen, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // m_col_ma_thi_sinh
            // 
            this.m_col_ma_thi_sinh.Caption = "Mã thí sinh";
            this.m_col_ma_thi_sinh.FieldName = "MA_THI_SINH";
            this.m_col_ma_thi_sinh.Name = "m_col_ma_thi_sinh";
            this.m_col_ma_thi_sinh.Visible = true;
            this.m_col_ma_thi_sinh.VisibleIndex = 0;
            // 
            // m_col_ho_ten
            // 
            this.m_col_ho_ten.Caption = "Họ tên";
            this.m_col_ho_ten.FieldName = "HO_TEN";
            this.m_col_ho_ten.Name = "m_col_ho_ten";
            this.m_col_ho_ten.Visible = true;
            this.m_col_ho_ten.VisibleIndex = 1;
            // 
            // m_col_gioi_tinh
            // 
            this.m_col_gioi_tinh.Caption = "Giới tính";
            this.m_col_gioi_tinh.FieldName = "GIOI_TINH";
            this.m_col_gioi_tinh.Name = "m_col_gioi_tinh";
            this.m_col_gioi_tinh.Visible = true;
            this.m_col_gioi_tinh.VisibleIndex = 2;
            // 
            // m_col_ngay_sinh
            // 
            this.m_col_ngay_sinh.Caption = "Ngày sinh";
            this.m_col_ngay_sinh.FieldName = "NGAY_SINH";
            this.m_col_ngay_sinh.Name = "m_col_ngay_sinh";
            this.m_col_ngay_sinh.Visible = true;
            this.m_col_ngay_sinh.VisibleIndex = 3;
            // 
            // m_col_ma_nganh
            // 
            this.m_col_ma_nganh.Caption = "Mã ngành";
            this.m_col_ma_nganh.FieldName = "MA_NGANH";
            this.m_col_ma_nganh.Name = "m_col_ma_nganh";
            this.m_col_ma_nganh.Visible = true;
            this.m_col_ma_nganh.VisibleIndex = 4;
            // 
            // m_col_nguyen_vong
            // 
            this.m_col_nguyen_vong.Caption = "Nguyện vọng";
            this.m_col_nguyen_vong.FieldName = "NGUYEN_VONG";
            this.m_col_nguyen_vong.Name = "m_col_nguyen_vong";
            this.m_col_nguyen_vong.Visible = true;
            this.m_col_nguyen_vong.VisibleIndex = 5;
            // 
            // m_col_diem_xet_tuyen
            // 
            this.m_col_diem_xet_tuyen.Caption = "Điểm xét tuyển";
            this.m_col_diem_xet_tuyen.FieldName = "DIEM_XT";
            this.m_col_diem_xet_tuyen.Name = "m_col_diem_xet_tuyen";
            this.m_col_diem_xet_tuyen.Visible = true;
            this.m_col_diem_xet_tuyen.VisibleIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chỉ tiêu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng thí sinh đỗ";
            // 
            // m_lab_chi_tieu
            // 
            this.m_lab_chi_tieu.AutoSize = true;
            this.m_lab_chi_tieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lab_chi_tieu.Location = new System.Drawing.Point(427, 24);
            this.m_lab_chi_tieu.Name = "m_lab_chi_tieu";
            this.m_lab_chi_tieu.Size = new System.Drawing.Size(51, 16);
            this.m_lab_chi_tieu.TabIndex = 6;
            this.m_lab_chi_tieu.Text = "Chỉ tiêu";
            // 
            // m_lab_tong_so
            // 
            this.m_lab_tong_so.AutoSize = true;
            this.m_lab_tong_so.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lab_tong_so.Location = new System.Drawing.Point(617, 24);
            this.m_lab_tong_so.Name = "m_lab_tong_so";
            this.m_lab_tong_so.Size = new System.Drawing.Size(51, 16);
            this.m_lab_tong_so.TabIndex = 7;
            this.m_lab_tong_so.Text = "Chỉ tiêu";
            // 
            // f102_ds_trung_tuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "f102_ds_trung_tuyen";
            this.Text = "Danh sách sinh viên trúng tuyển";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.f102_ds_trung_tuyen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_trung_tuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_trung_tuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cbo_nganh;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xet_tuyen;
        private DevExpress.XtraGrid.GridControl m_grc_ds_trung_tuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_trung_tuyen;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ma_thi_sinh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ho_ten;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_gioi_tinh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ngay_sinh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ma_nganh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_nguyen_vong;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_diem_xet_tuyen;
        private System.Windows.Forms.Label m_lab_tong_so;
        private System.Windows.Forms.Label m_lab_chi_tieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}