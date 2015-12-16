namespace TOSApp.BaoCao
{
    partial class f700_ds_diem_chuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f700_ds_diem_chuan));
            this.m_grc_ds_diem_chuan = new DevExpress.XtraGrid.GridControl();
            this.m_grv_ds_diem_chuan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_col_ma_nganh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_chi_tieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_tong_thi_sinh_trung_tuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_diem_chuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_col_ty_le = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_diem_chuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_diem_chuan)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_grc_ds_diem_chuan
            // 
            this.m_grc_ds_diem_chuan.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_ds_diem_chuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_ds_diem_chuan.Location = new System.Drawing.Point(0, 0);
            this.m_grc_ds_diem_chuan.MainView = this.m_grv_ds_diem_chuan;
            this.m_grc_ds_diem_chuan.Name = "m_grc_ds_diem_chuan";
            this.m_grc_ds_diem_chuan.Size = new System.Drawing.Size(1005, 376);
            this.m_grc_ds_diem_chuan.TabIndex = 2;
            this.m_grc_ds_diem_chuan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_ds_diem_chuan});
            // 
            // m_grv_ds_diem_chuan
            // 
            this.m_grv_ds_diem_chuan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_col_ma_nganh,
            this.m_col_chi_tieu,
            this.m_col_tong_thi_sinh_trung_tuyen,
            this.m_col_diem_chuan,
            this.m_col_ty_le});
            this.m_grv_ds_diem_chuan.GridControl = this.m_grc_ds_diem_chuan;
            this.m_grv_ds_diem_chuan.Name = "m_grv_ds_diem_chuan";
            this.m_grv_ds_diem_chuan.OptionsBehavior.Editable = false;
            // 
            // m_col_ma_nganh
            // 
            this.m_col_ma_nganh.Caption = "Mã ngành";
            this.m_col_ma_nganh.FieldName = "MA_NGANH";
            this.m_col_ma_nganh.Name = "m_col_ma_nganh";
            this.m_col_ma_nganh.Visible = true;
            this.m_col_ma_nganh.VisibleIndex = 0;
            // 
            // m_col_chi_tieu
            // 
            this.m_col_chi_tieu.Caption = "Chỉ tiêu";
            this.m_col_chi_tieu.FieldName = "CHI_TIEU";
            this.m_col_chi_tieu.Name = "m_col_chi_tieu";
            this.m_col_chi_tieu.Visible = true;
            this.m_col_chi_tieu.VisibleIndex = 1;
            // 
            // m_col_tong_thi_sinh_trung_tuyen
            // 
            this.m_col_tong_thi_sinh_trung_tuyen.Caption = "Tổng thí sinh trúng tuyển";
            this.m_col_tong_thi_sinh_trung_tuyen.FieldName = "TONG_THI_SINH_TRUNG_TUYEN";
            this.m_col_tong_thi_sinh_trung_tuyen.Name = "m_col_tong_thi_sinh_trung_tuyen";
            this.m_col_tong_thi_sinh_trung_tuyen.Visible = true;
            this.m_col_tong_thi_sinh_trung_tuyen.VisibleIndex = 2;
            // 
            // m_col_diem_chuan
            // 
            this.m_col_diem_chuan.Caption = "Điểm chuẩn";
            this.m_col_diem_chuan.FieldName = "DIEM_CHUAN";
            this.m_col_diem_chuan.Name = "m_col_diem_chuan";
            this.m_col_diem_chuan.Visible = true;
            this.m_col_diem_chuan.VisibleIndex = 3;
            // 
            // m_col_ty_le
            // 
            this.m_col_ty_le.Caption = "Tỷ lệ";
            this.m_col_ty_le.FieldName = "TY_LE";
            this.m_col_ty_le.Name = "m_col_ty_le";
            this.m_col_ty_le.Visible = true;
            this.m_col_ty_le.VisibleIndex = 4;
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
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_grc_ds_diem_chuan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 376);
            this.panel1.TabIndex = 1;
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
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(57, 12);
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
            this.panel3.Location = new System.Drawing.Point(805, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 62);
            this.panel3.TabIndex = 2;
            // 
            // f700_ds_diem_chuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "f700_ds_diem_chuan";
            this.Text = "Danh sách điểm chuẩn";
            this.Load += new System.EventHandler(this.f700_ds_diem_chuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_ds_diem_chuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_ds_diem_chuan)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_ds_diem_chuan;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_ds_diem_chuan;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ma_nganh;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_chi_tieu;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_tong_thi_sinh_trung_tuyen;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_diem_chuan;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_ty_le;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private System.Windows.Forms.Panel panel3;
    }
}