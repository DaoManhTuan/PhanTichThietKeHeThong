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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_cbo_nganh);
            this.panel1.Controls.Add(this.m_cmd_xuat_excel);
            this.panel1.Controls.Add(this.m_cmd_xet_tuyen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 61);
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
            this.m_cbo_nganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cbo_nganh.FormattingEnabled = true;
            this.m_cbo_nganh.Location = new System.Drawing.Point(160, 19);
            this.m_cbo_nganh.Name = "m_cbo_nganh";
            this.m_cbo_nganh.Size = new System.Drawing.Size(174, 24);
            this.m_cbo_nganh.TabIndex = 2;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xuat_excel.Appearance.Options.UseFont = true;
            this.m_cmd_xuat_excel.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xuat_excel.Image")));
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(645, 9);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(124, 41);
            this.m_cmd_xuat_excel.TabIndex = 1;
            this.m_cmd_xuat_excel.Text = "Xuất Excel";
            // 
            // m_cmd_xet_tuyen
            // 
            this.m_cmd_xet_tuyen.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_cmd_xet_tuyen.Appearance.Options.UseFont = true;
            this.m_cmd_xet_tuyen.Image = ((System.Drawing.Image)(resources.GetObject("m_cmd_xet_tuyen.Image")));
            this.m_cmd_xet_tuyen.Location = new System.Drawing.Point(469, 9);
            this.m_cmd_xet_tuyen.Name = "m_cmd_xet_tuyen";
            this.m_cmd_xet_tuyen.Size = new System.Drawing.Size(124, 41);
            this.m_cmd_xet_tuyen.TabIndex = 0;
            this.m_cmd_xet_tuyen.Text = "Xét tuyển";
            this.m_cmd_xet_tuyen.Click += new System.EventHandler(this.m_cmd_xet_tuyen_Click);
            // 
            // f102_ds_trung_tuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "f102_ds_trung_tuyen";
            this.Text = "Danh sách sinh viên trúng tuyển";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cbo_nganh;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xuat_excel;
        private DevExpress.XtraEditors.SimpleButton m_cmd_xet_tuyen;
    }
}