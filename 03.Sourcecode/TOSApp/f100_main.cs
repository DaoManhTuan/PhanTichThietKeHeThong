using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TOSApp.NghiepVu;

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
        f102_ds_trung_tuyen v_f102;
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
                    v_f102 = new f102_ds_trung_tuyen();
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
    }
}
