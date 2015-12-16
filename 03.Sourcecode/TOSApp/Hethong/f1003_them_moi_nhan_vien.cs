using IP.Core.IPCommon;
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
    public partial class f1003_them_moi_nhan_vien : Form
    {
        public f1003_them_moi_nhan_vien()
        {
            InitializeComponent();
        }
        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private void m_cmd_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_du_lieu())
                {
                    US_NGUOI_SU_DUNG v_us = new US_NGUOI_SU_DUNG();
                    v_us.dcID_NHOM_NGUOI_SU_DUNG = CIPConvert.ToDecimal(m_cbo_nhom.SelectedValue.ToString());
                    v_us.strTAI_KHOAN = m_txt_tai_khoan.Text;
                    v_us.strMAT_KHAU = m_txt_mat_khau.Text;
                    v_us.Insert();
                    MessageBox.Show("Đăng ký thành công tài khoản " + v_us.strTAI_KHOAN);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool check_du_lieu()
        {
            if (m_txt_tai_khoan.Text == "")
            {
                m_txt_output.Text = "Thông tin chưa đầy đủ";
                return false;
            }
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetTaiKhoan (v_ds, m_txt_tai_khoan.Text);
            if (v_ds.Tables[0].Rows.Count != 0)
            {
                m_txt_output.Text = "Tài khoản này đã tồn tại!";
                return false;
            }
            return true;
        }

        private void f001_register_Load(object sender, EventArgs e)
        {
            load_data_2_cbo();

        }

        private void load_data_2_cbo()
        {
            WinFormControls.load_data_to_combobox("NHOM_NGUOI_SU_DUNG", "ID", "NHOM_NGUOI_SU_DUNG", "", WinFormControls.eTAT_CA.NO, m_cbo_nhom);
        }
    }
}
