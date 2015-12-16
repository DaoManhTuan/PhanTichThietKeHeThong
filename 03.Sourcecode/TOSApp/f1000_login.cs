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

namespace TOSApp
{
    public partial class f1000_login : Form
    {
        public f1000_login()
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

        private void m_cmd_dang_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetLogin(v_ds, m_txt_user.Text, m_txt_password.Text);
                if(v_ds.Tables[0].Rows.Count != 1)
                {
                    m_lab_eror.Text = "Tên hoặc mật khẩu không chính xác";
                }
                else
                {
                    User.ID_NGUOI_SU_DUNG = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
                    US_NGUOI_SU_DUNG v_us_nguoi_sd = new US_NGUOI_SU_DUNG(User.ID_NGUOI_SU_DUNG);
                    User.ID_NHOM_NGUOI_SU_DUNG = v_us_nguoi_sd.dcID_NHOM_NGUOI_SU_DUNG;
                    User.TAI_KHOAN = v_us_nguoi_sd.strTAI_KHOAN;
                    User.MAT_KHAU = v_us_nguoi_sd.strMAT_KHAU;
                    this.Hide();
                    f100_main v_f = new f100_main();
                    User.trang_thai_dang_nhap = true;
                    v_f.Text = "HỆ THỐNG TUYỂN SINH ĐẠI HỌC BÁCH KHOA HÀ NỘI:          " + User.TAI_KHOAN;
                    v_f.ShowDialog();
                    if (User.trang_thai_dang_nhap == false)
                    {
                        this.Show();
                        m_txt_password.Text = "";
                        m_lab_eror.Text = "";
                    }
                }
            }
            catch
            {
              MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }
    }
}
