using IP.Core.IPCommon;
using IPCOREUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TOSApp.NghiepVu
{
    public partial class f103_tra_ho_so : Form
    {
        public f103_tra_ho_so()
        {
            InitializeComponent();
        }
        decimal m_id = 0;
        private void f103_tra_ho_so_Load(object sender, EventArgs e)
        {
           
        }
        private void load_data_2_grid(decimal v_id_thi_sinh)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM V_THI_SINH_NGUYEN_VONG WHERE ID_THI_SINH = " + m_id.ToString() + "ORDER BY NGUYEN_VONG");
            m_grc_diem_xet_tuyen.DataSource = v_ds.Tables[0];
        }
        private void m_cmd_kiem_tra_Click(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDataSetMaThiSinhNguyenVong(v_ds, m_txt_ma_thi_sinh.Text);
                if (v_ds.Tables[0].Rows.Count != 1)
                {
                    MessageBox.Show("Mã thí sinh không tồn tại hoặc chưa đăng ký xét tuyển!");
                }
                else
                {
                    load_data_to_thong_tin_thi_sinh(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString()));
                    m_id = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
                    load_data_2_grid(m_id);
                    m_cmd_tra_ho_so.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void load_data_to_thong_tin_thi_sinh(decimal v_id_thi_sinh)
        {
            US_DS_HO_SO_THI_SINH v_us_ho_so_thi_sinh = new US_DS_HO_SO_THI_SINH(v_id_thi_sinh);
            if (!v_us_ho_so_thi_sinh.IsID_DOI_TUONGNull())
            {
                US_DM_DOI_TUONG v_us_dm_doi_tuong = new US_DM_DOI_TUONG(v_us_ho_so_thi_sinh.dcID_DOI_TUONG);
                m_txt_doi_tuong.Text = v_us_dm_doi_tuong.strTEN_DOI_TUONG.ToString();
            }
            US_DM_KHU_VUC v_us_dm_khu_vuc = new US_DM_KHU_VUC(v_us_ho_so_thi_sinh.dcID_KHU_VUC);
            m_txt_ho_ten.Text = v_us_ho_so_thi_sinh.strHO_TEN.ToString();
            m_txt_dien_thoai.Text = v_us_ho_so_thi_sinh.strDIEN_THOAI.ToString();
            m_txt_dia_chi.Text = v_us_ho_so_thi_sinh.strDIA_CHI.ToString();
            m_txt_cmnd.Text = v_us_ho_so_thi_sinh.strCMND.ToString();
            m_txt_khu_vuc.Text = v_us_dm_khu_vuc.strTEN_KHU_VUC.ToString();
            m_dat_ngay_sinh.Value = Convert.ToDateTime(v_us_ho_so_thi_sinh.strNGAY_SINH.ToString());
            if (!v_us_ho_so_thi_sinh.IsGIOI_TINHNull())
            {
                if (v_us_ho_so_thi_sinh.strGIOI_TINH == "N")
                    m_radio_nam.Checked = true;
                else
                    m_radio_nu.Checked = true;
            }
            if (v_us_ho_so_thi_sinh.strUU_TIEN_YN == "N")
                m_check_dien_uu_tien.Checked = false;
            else
                m_check_dien_uu_tien.Checked = true;
        }

        private void m_cmd_tra_ho_so_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_grv_diem_xet_tuyen.RowCount; i++)
                {
                    US_DS_NGUYEN_VONG v_us = new US_DS_NGUYEN_VONG(CIPConvert.ToDecimal(m_grv_diem_xet_tuyen.GetDataRow(i)["ID"].ToString()));
                    v_us.Delete();
                }
                // xóa tài khoản
                US_DUNG_CHUNG v_us_dc = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us_dc.FillDatasetWithQuery(v_ds, "SELECT ID FROM USER_PASSWORD WHERE TAI_KHOAN = '" + m_txt_ma_thi_sinh.Text + "'");
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    US_USER_PASSWORD v_us_user = new US_USER_PASSWORD(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID"].ToString()));
                    v_us_user.Delete();
                }
                MessageBox.Show("Xóa thành công!");
                load_data_2_grid(m_id);
                m_cmd_tra_ho_so.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
            
        }

    }
}
