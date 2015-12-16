using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.NghiepVu;
using TOSApp.Hethong;
using TOSApp.BaoCao;

namespace TOSApp
{
    public partial class f100_main : Form
    {
        public f100_main()
        {
            InitializeComponent();
        }
        f101_tiep_nhan_ho_so v_f101;
        f103_tra_ho_so v_f103;
        f104_thay_doi_nguyen_vong v_f104;
        f102_xet_tuyen v_f102;
        //HỆ THỐNG
        f1002_danh_sach_nhan_vien v_1002;
        //BÁO CÁO
        f500_ds_thi_sinh_trung_tuyen v_f500;
        f600_ds_thi_sinh_truot v_f600;
        f700_ds_diem_chuan v_f700;
        public bool IsFormOpen(Form checkForm)
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == checkForm.Name)
                    return true;
            return false;
        }

        private void m_cmd_tiep_nhan_ho_so_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (v_f101 == null || !IsFormOpen(v_f101))
                {
                    v_f101 = new f101_tiep_nhan_ho_so();
                    v_f101.MdiParent = this;
                    v_f101.Show();
                }
                else
                {
                    v_f101.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cnd_tra_ho_so_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_f103 == null || !IsFormOpen(v_f103))
                {
                    v_f103 = new f103_tra_ho_so();
                    v_f103.MdiParent = this;
                    v_f103.Show();
                }
                else
                {
                    v_f103.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private void m_cmd_thay_doi_nguyen_vong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_f104 == null || !IsFormOpen(v_f104))
                {
                    v_f104 = new f104_thay_doi_nguyen_vong();
                    v_f104.MdiParent = this;
                    v_f104.Show();
                }
                else
                {
                    v_f104.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_ds_trung_tuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_f102 == null || !IsFormOpen(v_f102))
                {
                    v_f102 = new f102_xet_tuyen();
                    v_f102.MdiParent = this;
                    v_f102.Show();
                }
                else
                {
                    v_f102.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_dang_xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                User.trang_thai_dang_nhap = false;
                this.Close();
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void f100_main_Load(object sender, EventArgs e)
        {
            try
            {
                FormatControl();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void FormatControl()
        {
            if (User.ID_NHOM_NGUOI_SU_DUNG == 2)
            {
                m_ribpag_tra_ho_so.Visible = false;
                m_ribpag_xet_tuyen.Visible = false;
                m_rib_thay_doi_nguyen_vong.Visible = false;
                m_rib_bao_cao.Visible = false;
                m_rib_he_thong.Visible = false;
            }
            if (User.ID_NHOM_NGUOI_SU_DUNG == 3)
            {
                m_ribpag_tiep_nhan_ho_so.Visible = false;
                m_ribpag_xet_tuyen.Visible = false;
                m_rib_thay_doi_nguyen_vong.Visible = false;
                m_rib_bao_cao.Visible = false;
                m_rib_he_thong.Visible = false;
            }
            if (User.ID_NHOM_NGUOI_SU_DUNG == 4)
            {
                m_ribpag_xet_tuyen.Visible = false;
                m_rib_dang_ky_xet_tuyen.Visible = false;
                m_rib_bao_cao.Visible = false;
                m_rib_he_thong.Visible = false;
            }
        }

        private void m_cmd_doi_mat_khau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f1001_doi_mat_khau v_f = new f1001_doi_mat_khau();
                v_f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_ds_nhan_vien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (v_1002 == null || !IsFormOpen(v_1002))
                {
                    v_1002 = new f1002_danh_sach_nhan_vien();
                    v_1002.MdiParent = this;
                    v_1002.Show();
                }
                else
                {
                    v_1002.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_them_moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f1003_them_moi_nhan_vien v_f = new f1003_them_moi_nhan_vien();
                v_f.ShowDialog();
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_ds_thi_sinh_trung_tuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_f500 == null || !IsFormOpen(v_f500))
                {
                    v_f500 = new f500_ds_thi_sinh_trung_tuyen();
                    v_f500.MdiParent = this;
                    v_f500.Show();
                }
                else
                {
                    v_f500.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_ds_truot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_f600 == null || !IsFormOpen(v_f600))
                {
                    v_f600 = new f600_ds_thi_sinh_truot();
                    v_f600.MdiParent = this;
                    v_f600.Show();
                }
                else
                {
                    v_f600.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_ds_diem_chuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (v_f700 == null || !IsFormOpen(v_f700))
                {
                    v_f700 = new f700_ds_diem_chuan();
                    v_f700.MdiParent = this;
                    v_f700.Show();
                }
                else
                {
                    v_f700.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }
    }
}
