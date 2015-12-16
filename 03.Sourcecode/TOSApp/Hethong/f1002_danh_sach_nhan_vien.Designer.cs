namespace TOSApp.Hethong
{
    partial class f1002_danh_sach_nhan_vien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f1002_danh_sach_nhan_vien));
            this.m_nhom_nguoi_su_dung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grv_user_name = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_col_tai_khoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_grc_user_name = new DevExpress.XtraGrid.GridControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_cbo_nhom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_cmd_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_sua = new DevExpress.XtraEditors.SimpleButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_user_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_user_name)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_nhom_nguoi_su_dung
            // 
            this.m_nhom_nguoi_su_dung.Caption = "Nhóm";
            this.m_nhom_nguoi_su_dung.FieldName = "NHOM_NGUOI_SU_DUNG";
            this.m_nhom_nguoi_su_dung.Name = "m_nhom_nguoi_su_dung";
            this.m_nhom_nguoi_su_dung.Visible = true;
            this.m_nhom_nguoi_su_dung.VisibleIndex = 1;
            // 
            // m_grv_user_name
            // 
            this.m_grv_user_name.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_col_tai_khoan,
            this.m_nhom_nguoi_su_dung});
            this.m_grv_user_name.GridControl = this.m_grc_user_name;
            this.m_grv_user_name.Name = "m_grv_user_name";
            this.m_grv_user_name.OptionsBehavior.ReadOnly = true;
            this.m_grv_user_name.OptionsView.ShowAutoFilterRow = true;
            this.m_grv_user_name.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.m_grv_user_name_FocusedRowChanged);
            // 
            // m_col_tai_khoan
            // 
            this.m_col_tai_khoan.Caption = "Tài khoản";
            this.m_col_tai_khoan.FieldName = "TAI_KHOAN";
            this.m_col_tai_khoan.Name = "m_col_tai_khoan";
            this.m_col_tai_khoan.Visible = true;
            this.m_col_tai_khoan.VisibleIndex = 0;
            // 
            // m_grc_user_name
            // 
            this.m_grc_user_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_user_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_user_name.Location = new System.Drawing.Point(0, 0);
            this.m_grc_user_name.MainView = this.m_grv_user_name;
            this.m_grc_user_name.Name = "m_grc_user_name";
            this.m_grc_user_name.Size = new System.Drawing.Size(838, 329);
            this.m_grc_user_name.TabIndex = 0;
            this.m_grc_user_name.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_user_name});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_grc_user_name);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 329);
            this.panel3.TabIndex = 5;
            // 
            // m_cbo_nhom
            // 
            this.m_cbo_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhom.FormattingEnabled = true;
            this.m_cbo_nhom.Location = new System.Drawing.Point(79, 14);
            this.m_cbo_nhom.Name = "m_cbo_nhom";
            this.m_cbo_nhom.Size = new System.Drawing.Size(239, 21);
            this.m_cbo_nhom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 65);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.m_txt_tai_khoan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 59);
            this.panel4.TabIndex = 0;
            // 
            // m_txt_tai_khoan
            // 
            this.m_txt_tai_khoan.Location = new System.Drawing.Point(88, 17);
            this.m_txt_tai_khoan.Name = "m_txt_tai_khoan";
            this.m_txt_tai_khoan.Size = new System.Drawing.Size(146, 20);
            this.m_txt_tai_khoan.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.m_cbo_nhom);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(422, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(413, 59);
            this.panel5.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 65);
            this.panel2.TabIndex = 4;
            // 
            // m_cmd_xoa
            // 
            this.m_cmd_xoa.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xoa.Image")));
            this.m_cmd_xoa.Location = new System.Drawing.Point(293, 7);
            this.m_cmd_xoa.Name = "m_cmd_xoa";
            this.m_cmd_xoa.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_xoa.TabIndex = 0;
            this.m_cmd_xoa.Text = "Xóa";
            this.m_cmd_xoa.Click += new System.EventHandler(this.m_cmd_xoa_Click);
            // 
            // m_cmd_sua
            // 
            this.m_cmd_sua.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_sua.Image")));
            this.m_cmd_sua.Location = new System.Drawing.Point(170, 7);
            this.m_cmd_sua.Name = "m_cmd_sua";
            this.m_cmd_sua.Size = new System.Drawing.Size(92, 35);
            this.m_cmd_sua.TabIndex = 0;
            this.m_cmd_sua.Text = "Cập nhật";
            this.m_cmd_sua.Click += new System.EventHandler(this.m_cmd_sua_Click);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.m_cmd_xoa);
            this.panel15.Controls.Add(this.m_cmd_sua);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(432, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(406, 56);
            this.panel15.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 56);
            this.panel1.TabIndex = 3;
            // 
            // f1002_danh_sach_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f1002_danh_sach_nhan_vien";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.f1002_danh_sach_nhan_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_user_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_user_name)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn m_nhom_nguoi_su_dung;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_user_name;
        private DevExpress.XtraGrid.Columns.GridColumn m_col_tai_khoan;
        private DevExpress.XtraGrid.GridControl m_grc_user_name;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox m_cbo_nhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox m_txt_tai_khoan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xoa;
        private DevExpress.XtraEditors.SimpleButton m_cmd_sua;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel1;

    }
}