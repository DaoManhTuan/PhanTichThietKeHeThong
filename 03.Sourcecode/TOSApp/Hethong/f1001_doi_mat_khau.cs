using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOSApp.Hethong
{
    public partial class f1001_doi_mat_khau : Form
    {
        public f1001_doi_mat_khau()
        {
            InitializeComponent();
        }
        private void m_cmd_doi_mat_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu())
                {
                    update_mat_khau();
                    m_lb_output.Text = "";
                    MessageBox.Show("Đổi mật khẩu thành công!");
                    this.Close();
                }
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

        private void update_mat_khau()
        {
            US_NGUOI_SU_DUNG v_us = new US_NGUOI_SU_DUNG(User.ID_NGUOI_SU_DUNG);
            v_us.strMAT_KHAU = m_txt_mk_moi.Text;
            v_us.Update();
            User.MAT_KHAU = v_us.strMAT_KHAU;
        }

        private bool check_du_lieu()
        {
            if (m_txt_mk_cu.Text != User.MAT_KHAU)
            {
                m_lb_output.Text = "Mật khẩu cũ chưa chính xác!";
                m_txt_mk_cu.Focus();
                return false;
            }
            if (m_txt_mk_moi.TextLength == 0)
            {
                m_lb_output.Text = "Nhập mật khẩu mới";
                m_txt_mk_moi.Focus();
                return false;
            }
            if (m_txt_xac_nhan_mk.Text != m_txt_mk_moi.Text)
            {
                m_lb_output.Text = "Nhập lại mật khẩu xác nhận";
                m_txt_xac_nhan_mk.Focus();
                return false;
            }
            return true;
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
