namespace TOSApp.BaoCao
{
    partial class f600_ds_thi_sinh_truot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f600_ds_thi_sinh_truot));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_grc_ds_truot = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_truot = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_col_ma_thi_sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_ho_ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_gioi_tinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_ngay_sinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_doi_tuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_khu_vuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_uu_tien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_truot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_truot)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_truot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 376);
            this.panel1.TabIndex = 1;
            // 
            // m_grc_ds_truot
            // 
            this.m_grc_ds_truot.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_truot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_truot.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_truot.MainView = this.m_grv_ds_truot;
            this.m_grc_ds_truot.Name = "m_grc_ds_truot";
            this.m_grc_ds_truot.Size = new System.Drawing.Size(1005, 376);
            this.m_grc_ds_truot.TabIndex = 2;
            this.m_grc_ds_truot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_truot});
            // 
            // m_grv_ds_truot
            // 
            this.m_grv_ds_truot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_col_ma_thi_sinh,
            this.m_col_ho_ten,
            this.m_col_gioi_tinh,
            this.m_col_ngay_sinh,
            this.m_col_doi_tuong,
            this.m_col_khu_vuc,
            this.m_col_uu_tien});
            this.m_grv_ds_truot.GridControl = this.m_grc_ds_truot;
            this.m_grv_ds_truot.Name = "m_grv_ds_truot";
            this.m_grv_ds_truot.OptionsBehavior.Editable = false;
            this.m_grv_ds_truot.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.m_col_uu_tien, DevExpress.Data.ColumnSortOrder.Descending)});
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
            // m_col_doi_tuong
            // 
            this.m_col_doi_tuong.Caption = "Đối tượng";
            this.m_col_doi_tuong.FieldName = "TEN_DOI_TUONG";
            this.m_col_doi_tuong.Name = "m_col_doi_tuong";
            this.m_col_doi_tuong.Visible = true;
            this.m_col_doi_tuong.VisibleIndex = 4;
            // 
            // m_col_khu_vuc
            // 
            this.m_col_khu_vuc.Caption = "Khu vực";
            this.m_col_khu_vuc.FieldName = "TEN_KHU_VUC";
            this.m_col_khu_vuc.Name = "m_col_khu_vuc";
            this.m_col_khu_vuc.Visible = true;
            this.m_col_khu_vuc.VisibleIndex = 5;
            // 
            // m_col_uu_tien
            // 
            this.m_col_uu_tien.Caption = "Ưu tiên";
            this.m_col_uu_tien.FieldName = "UU_TIEN_YN";
            this.m_col_uu_tien.Name = "m_col_uu_tien";
            this.m_col_uu_tien.Visible = true;
            this.m_col_uu_tien.VisibleIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 62);
            this.panel2.TabIndex = 2;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xuat_excel.Appearance.Options.UseFont = true;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(17, 12);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(124, 41);
            this.m_cmd_xuat_excel.TabIndex = 1;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_cmd_xuat_excel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(850, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 62);
            this.panel3.TabIndex = 2;
            // 
            // f600_ds_thi_sinh_truot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "f600_ds_thi_sinh_truot";
            this.Text = "Danh sách thí sinh trượt";
            this.Load += new System.EventHandler(this.f600_ds_thi_sinh_truot_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_truot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_truot)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraGrid.GridControl m_grc_ds_truot;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_truot;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ma_thi_sinh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ho_ten;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_gioi_tinh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ngay_sinh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_doi_tuong;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_khu_vuc;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_uu_tien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}