namespace TOSApp
{
    partial class f100_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f100_main));
            this.m_rib_main = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.m_cmd_tiep_nhan_ho_so = new DevExpress.XtraBars.BarButtonItem();
            this.m_cnd_tra_ho_so = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_ds_trung_tuyen = new DevExpress.XtraBars.BarButtonItem();
            this.m_cmd_thay_doi_nguyen_vong = new DevExpress.XtraBars.BarButtonItem();
            this.m_rib_dang_ky_xet_tuyen = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.m_ribpag_tiep_nhan_ho_so = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m_ribpag_ds_sinh_vien_trung_tuyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m_rib_thay_doi_nguyen_vong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.m_ribpag_thay_doi_nguyen_vong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.m_rib_bao_cao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.m_rib_main)).BeginInit();
            this.SuspendLayout();
            // 
            // m_rib_main
            // 
            this.m_rib_main.ExpandCollapseItem.Id = 0;
            this.m_rib_main.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.m_rib_main.ExpandCollapseItem,
            this.m_cmd_tiep_nhan_ho_so,
            this.m_cnd_tra_ho_so,
            this.m_cmd_ds_trung_tuyen,
            this.m_cmd_thay_doi_nguyen_vong});
            this.m_rib_main.Location = new System.Drawing.Point(0, 0);
            this.m_rib_main.MaxItemId = 5;
            this.m_rib_main.Name = "m_rib_main";
            this.m_rib_main.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.m_rib_dang_ky_xet_tuyen,
            this.m_rib_thay_doi_nguyen_vong,
            this.m_rib_bao_cao});
            this.m_rib_main.Size = new System.Drawing.Size(1003, 161);
            // 
            // m_cmd_tiep_nhan_ho_so
            // 
            this.m_cmd_tiep_nhan_ho_so.Caption = "Tiếp nhận hồ sơ";
            this.m_cmd_tiep_nhan_ho_so.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_tiep_nhan_ho_so.Glyph")));
            this.m_cmd_tiep_nhan_ho_so.Id = 1;
            this.m_cmd_tiep_nhan_ho_so.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_tiep_nhan_ho_so.LargeGlyph")));
            this.m_cmd_tiep_nhan_ho_so.Name = "m_cmd_tiep_nhan_ho_so";
            this.m_cmd_tiep_nhan_ho_so.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cmd_tiep_nhan_ho_so_ItemClick);
            // 
            // m_cnd_tra_ho_so
            // 
            this.m_cnd_tra_ho_so.Caption = "Trả hồ sơ";
            this.m_cnd_tra_ho_so.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cnd_tra_ho_so.Glyph")));
            this.m_cnd_tra_ho_so.Id = 2;
            this.m_cnd_tra_ho_so.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cnd_tra_ho_so.LargeGlyph")));
            this.m_cnd_tra_ho_so.Name = "m_cnd_tra_ho_so";
            this.m_cnd_tra_ho_so.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.m_cnd_tra_ho_so_ItemClick);
            // 
            // m_cmd_ds_trung_tuyen
            // 
            this.m_cmd_ds_trung_tuyen.Caption = "Danh sách sinh viên trúng tuyển";
            this.m_cmd_ds_trung_tuyen.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_ds_trung_tuyen.Glyph")));
            this.m_cmd_ds_trung_tuyen.Id = 3;
            this.m_cmd_ds_trung_tuyen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_ds_trung_tuyen.LargeGlyph")));
            this.m_cmd_ds_trung_tuyen.Name = "m_cmd_ds_trung_tuyen";
            // 
            // m_cmd_thay_doi_nguyen_vong
            // 
            this.m_cmd_thay_doi_nguyen_vong.Caption = "Thay đổi nguyện vọng";
            this.m_cmd_thay_doi_nguyen_vong.Glyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_thay_doi_nguyen_vong.Glyph")));
            this.m_cmd_thay_doi_nguyen_vong.Id = 4;
            this.m_cmd_thay_doi_nguyen_vong.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("m_cmd_thay_doi_nguyen_vong.LargeGlyph")));
            this.m_cmd_thay_doi_nguyen_vong.Name = "m_cmd_thay_doi_nguyen_vong";
            // 
            // m_rib_dang_ky_xet_tuyen
            // 
            this.m_rib_dang_ky_xet_tuyen.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.m_ribpag_tiep_nhan_ho_so,
            this.m_ribpag_ds_sinh_vien_trung_tuyen});
            this.m_rib_dang_ky_xet_tuyen.Image = ((System.Drawing.Image)(resources.GetObject("m_rib_dang_ky_xet_tuyen.Image")));
            this.m_rib_dang_ky_xet_tuyen.Name = "m_rib_dang_ky_xet_tuyen";
            this.m_rib_dang_ky_xet_tuyen.Text = "Đăng ký xét tuyển";
            // 
            // m_ribpag_tiep_nhan_ho_so
            // 
            this.m_ribpag_tiep_nhan_ho_so.AllowTextClipping = false;
            this.m_ribpag_tiep_nhan_ho_so.ItemLinks.Add(this.m_cmd_tiep_nhan_ho_so);
            this.m_ribpag_tiep_nhan_ho_so.ItemLinks.Add(this.m_cnd_tra_ho_so);
            this.m_ribpag_tiep_nhan_ho_so.Name = "m_ribpag_tiep_nhan_ho_so";
            this.m_ribpag_tiep_nhan_ho_so.Text = "Đăng ký xét tuyển";
            // 
            // m_ribpag_ds_sinh_vien_trung_tuyen
            // 
            this.m_ribpag_ds_sinh_vien_trung_tuyen.ItemLinks.Add(this.m_cmd_ds_trung_tuyen);
            this.m_ribpag_ds_sinh_vien_trung_tuyen.Name = "m_ribpag_ds_sinh_vien_trung_tuyen";
            this.m_ribpag_ds_sinh_vien_trung_tuyen.Text = "Danh sách sinh viên trúng tuyển";
            // 
            // m_rib_thay_doi_nguyen_vong
            // 
            this.m_rib_thay_doi_nguyen_vong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.m_ribpag_thay_doi_nguyen_vong});
            this.m_rib_thay_doi_nguyen_vong.Image = ((System.Drawing.Image)(resources.GetObject("m_rib_thay_doi_nguyen_vong.Image")));
            this.m_rib_thay_doi_nguyen_vong.Name = "m_rib_thay_doi_nguyen_vong";
            this.m_rib_thay_doi_nguyen_vong.Text = "Thay đổi nguyện vọng";
            // 
            // m_ribpag_thay_doi_nguyen_vong
            // 
            this.m_ribpag_thay_doi_nguyen_vong.ItemLinks.Add(this.m_cmd_thay_doi_nguyen_vong);
            this.m_ribpag_thay_doi_nguyen_vong.Name = "m_ribpag_thay_doi_nguyen_vong";
            this.m_ribpag_thay_doi_nguyen_vong.Text = "Thay đổi nguyện vọng";
            // 
            // m_rib_bao_cao
            // 
            this.m_rib_bao_cao.Image = ((System.Drawing.Image)(resources.GetObject("m_rib_bao_cao.Image")));
            this.m_rib_bao_cao.Name = "m_rib_bao_cao";
            this.m_rib_bao_cao.Text = "Báo cáo";
            // 
            // f100_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 440);
            this.Controls.Add(this.m_rib_main);
            this.IsMdiContainer = true;
            this.Name = "f100_main";
            this.Text = "f100_main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.m_rib_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl m_rib_main;
        private DevExpress.XtraBars.BarButtonItem m_cmd_tiep_nhan_ho_so;
        private DevExpress.XtraBars.BarButtonItem m_cnd_tra_ho_so;
        private DevExpress.XtraBars.BarButtonItem m_cmd_ds_trung_tuyen;
        private DevExpress.XtraBars.BarButtonItem m_cmd_thay_doi_nguyen_vong;
        private DevExpress.XtraBars.Ribbon.RibbonPage m_rib_dang_ky_xet_tuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m_ribpag_tiep_nhan_ho_so;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m_ribpag_ds_sinh_vien_trung_tuyen;
        private DevExpress.XtraBars.Ribbon.RibbonPage m_rib_thay_doi_nguyen_vong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup m_ribpag_thay_doi_nguyen_vong;
        private DevExpress.XtraBars.Ribbon.RibbonPage m_rib_bao_cao;
    }
}