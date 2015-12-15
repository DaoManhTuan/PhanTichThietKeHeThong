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
    public partial class f101_ho_so_thi_sinh : Form
    {
        public f101_ho_so_thi_sinh()
        {
            InitializeComponent();
        }
        decimal m_id = 0;

        private void f101_ho_so_thi_sinh_Load(object sender, EventArgs e)
        {
            load_data_2_nguyen_vong(m_cbo_nhom_nganh_1);
            load_data_2_nguyen_vong(m_cbo_nhom_nganh_2);
            load_data_2_nguyen_vong(m_cbo_nhom_nganh_3);
            load_data_2_nguyen_vong(m_cbo_nhom_nganh_4);
        }

        private void load_data_2_nguyen_vong(ComboBox v_cbo)
        {
            WinFormControls.load_data_to_combobox_with_query(v_cbo, "ID", "MA_NGANH", WinFormControls.eTAT_CA.NO, "SELECT ID, MA_NGANH FROM DM_NGANH_TUYEN_SINH");
        }
        private void m_cmd_kiem_tra_Click(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDataSetMaThiSinh(v_ds, m_txt_ma_thi_sinh.Text);
                if (v_ds.Tables[0].Rows.Count != 1)
                {
                    MessageBox.Show("Mã thí sinh không tồn tại!");
                }
                else
                {
                    load_data_to_thong_tin_thi_sinh(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString()));
                    m_id = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"].ToString());
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

        private void m_cmd_tiep_nhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (check_nguyen_vong())
                {
                    Insert_nguyen_vong(1);
                    if (m_check_nv2.Checked)
                    {
                        Insert_nguyen_vong(2);
                    }
                    if (m_check_nv3.Checked)
                    {
                        Insert_nguyen_vong(3);
                    }
                    if (m_check_nv4.Checked)
                    {
                        Insert_nguyen_vong(4);
                    }
                    Insert_tai_khoan();
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void Insert_tai_khoan()
        {
            //thêm tài khoản cho thí sinh
            US_USER_PASSWORD v_us = new US_USER_PASSWORD();
            v_us.strTAI_KHOAN = m_txt_ma_thi_sinh.Text;
            v_us.strMAT_KHAU = "1";
            v_us.Insert();
        }

        private void Insert_nguyen_vong(int p)
        {
            US_DS_NGUYEN_VONG v_us = new US_DS_NGUYEN_VONG();
            if (p == 1)
            {
                v_us.dcID_NGANH_TO_HOP_MON = CIPConvert.ToDecimal(m_cbo_to_hop_mon_1.SelectedValue.ToString());
                US_DS_NGANH_TO_HOP_MON v_us_nganh_to_hop_mon = new US_DS_NGANH_TO_HOP_MON(v_us.dcID_NGANH_TO_HOP_MON);
                v_us.dcDIEM_XT = User.GetDiemXetTuyen(m_id, v_us_nganh_to_hop_mon.dcID_TO_HOP_MON);
                v_us.dcNGUYEN_VONG = 1;
            }
            if (p == 2)
            {
               v_us.dcID_NGANH_TO_HOP_MON = CIPConvert.ToDecimal(m_cbo_to_hop_mon_2.SelectedValue.ToString());
               US_DS_NGANH_TO_HOP_MON v_us_nganh_to_hop_mon = new US_DS_NGANH_TO_HOP_MON(v_us.dcID_NGANH_TO_HOP_MON);
               v_us.dcDIEM_XT = User.GetDiemXetTuyen(m_id, v_us_nganh_to_hop_mon.dcID_TO_HOP_MON);
               v_us.dcNGUYEN_VONG = 2;
            }
            if (p == 3)
            {
                v_us.dcID_NGANH_TO_HOP_MON = CIPConvert.ToDecimal(m_cbo_to_hop_mon_3.SelectedValue.ToString());
                US_DS_NGANH_TO_HOP_MON v_us_nganh_to_hop_mon = new US_DS_NGANH_TO_HOP_MON(v_us.dcID_NGANH_TO_HOP_MON);
                v_us.dcDIEM_XT = User.GetDiemXetTuyen(m_id, v_us_nganh_to_hop_mon.dcID_TO_HOP_MON);
                v_us.dcNGUYEN_VONG = 3;
            }
            if (p == 4)
            {
                v_us.dcID_NGANH_TO_HOP_MON = CIPConvert.ToDecimal(m_cbo_to_hop_mon_4.SelectedValue.ToString());
                US_DS_NGANH_TO_HOP_MON v_us_nganh_to_hop_mon = new US_DS_NGANH_TO_HOP_MON(v_us.dcID_NGANH_TO_HOP_MON);
                v_us.dcDIEM_XT = User.GetDiemXetTuyen(m_id, v_us_nganh_to_hop_mon.dcID_TO_HOP_MON);
                v_us.dcNGUYEN_VONG = 4;
            }
            v_us.dcID_THI_SINH = m_id;
            v_us.strTRANG_THAI_TRUNG_TUYEN = "N";
            v_us.Insert();

        }

        private bool check_nguyen_vong()
        {
            if (m_id == 0)
            {
                MessageBox.Show("Nhập mã số sinh viên!");
                return false;
            }
            List<decimal> v_lis_id_nganh = new List<decimal>();
            v_lis_id_nganh.Add(CIPConvert.ToDecimal(m_cbo_nhom_nganh_1.SelectedValue.ToString()));
            v_lis_id_nganh.Add(CIPConvert.ToDecimal(m_cbo_nhom_nganh_2.SelectedValue.ToString()));
            v_lis_id_nganh.Add(CIPConvert.ToDecimal(m_cbo_nhom_nganh_3.SelectedValue.ToString()));
            v_lis_id_nganh.Add(CIPConvert.ToDecimal(m_cbo_nhom_nganh_4.SelectedValue.ToString()));
            for (int i = 0; i < v_lis_id_nganh.Count; i++)
            {
                for (int j = i+1; j < v_lis_id_nganh.Count; j++)
                {
                    if (v_lis_id_nganh[i] == v_lis_id_nganh[j])
                    {
                        MessageBox.Show("Chọn lại nguyện vọng!");
                        return false;
                    }
                }
            }
            
            return true;
        }

        private void m_cmd_tra_ho_so_Click(object sender, EventArgs e)
        {

        }

        private void m_cbo_nhom_nganh_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_to_hop_mon_1, "ID", "TO_HOP_MON", WinFormControls.eTAT_CA.NO, "SELECT ID,TO_HOP_MON FROM V_DS_NGANH_TO_HOP_MON WHERE ID_MA_NGANH = " + m_cbo_nhom_nganh_1.SelectedValue.ToString());
        }

        private void m_cbo_nhom_nganh_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_to_hop_mon_2, "ID", "TO_HOP_MON", WinFormControls.eTAT_CA.NO, "SELECT ID,TO_HOP_MON FROM V_DS_NGANH_TO_HOP_MON WHERE ID_MA_NGANH = " + m_cbo_nhom_nganh_2.SelectedValue.ToString());
        }

        private void m_cbo_nhom_nganh_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_to_hop_mon_3, "ID", "TO_HOP_MON", WinFormControls.eTAT_CA.NO, "SELECT ID,TO_HOP_MON FROM V_DS_NGANH_TO_HOP_MON WHERE ID_MA_NGANH = " + m_cbo_nhom_nganh_3.SelectedValue.ToString());
        }

        private void m_cbo_nhom_nganh_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            WinFormControls.load_data_to_combobox_with_query(m_cbo_to_hop_mon_4, "ID", "TO_HOP_MON", WinFormControls.eTAT_CA.NO, "SELECT ID,TO_HOP_MON FROM V_DS_NGANH_TO_HOP_MON WHERE ID_MA_NGANH = " + m_cbo_nhom_nganh_4.SelectedValue.ToString());
        }

        private void m_check_nv2_CheckedChanged(object sender, EventArgs e)
        {
            if(m_check_nv2.Checked)
            {
                m_cbo_nhom_nganh_2.Enabled = true;
                m_cbo_to_hop_mon_2.Enabled = true;
            }
            else
            {
                m_cbo_nhom_nganh_2.Enabled = false;
                m_cbo_to_hop_mon_2.Enabled = false;
            }
        }

        private void m_check_nv3_CheckedChanged(object sender, EventArgs e)
        {
            if (m_check_nv3.Checked)
            {
                m_cbo_nhom_nganh_3.Enabled = true;
                m_cbo_to_hop_mon_3.Enabled = true;
            }
            else
            {
                m_cbo_nhom_nganh_3.Enabled = false;
                m_cbo_to_hop_mon_3.Enabled = false;
            }
        }

        private void m_check_nv4_CheckedChanged(object sender, EventArgs e)
        {
            if (m_check_nv4.Checked)
            {
                m_cbo_nhom_nganh_4.Enabled = true;
                m_cbo_to_hop_mon_4.Enabled = true;
            }
            else
            {
                m_cbo_nhom_nganh_4.Enabled = false;
                m_cbo_to_hop_mon_4.Enabled = false;
            }
        }

    }
}
