using IP.Core.IPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOSApp.BaoCao
{
    public partial class f500_ds_thi_sinh_trung_tuyen : Form
    {
        public f500_ds_thi_sinh_trung_tuyen()
        {
            InitializeComponent();
        }

        private void f500_ds_thi_sinh_trung_tuyen_Load(object sender, EventArgs e)
        {
            load_data_2_nhom_nganh();
        }

        private void load_data_2_nhom_nganh()
        {
            WinFormControls.load_data_to_combobox("DM_NGANH_TUYEN_SINH", "ID", "MA_NGANH", "", WinFormControls.eTAT_CA.YES, m_cbo_nganh);
        }

        private void m_cbo_nganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_2_grid();
                load_data_2_chitieu();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }
        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            if (CIPConvert.ToDecimal(m_cbo_nganh.SelectedValue.ToString()) > -1)
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM  V_DS_KET_QUA_XET_TUYEN WHERE ID_NGANH =" + m_cbo_nganh.SelectedValue.ToString());
            else
                v_us.FillDatasetWithQuery(v_ds, "SELECT *FROM  V_DS_KET_QUA_XET_TUYEN ");
            m_grc_ds_trung_tuyen.DataSource = v_ds.Tables[0];
        }
        private void load_data_2_chitieu()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds_chi_tieu = new DataSet();
            v_ds_chi_tieu.Tables.Add(new DataTable());
            DataSet v_ds_tong_so = new DataSet();
            v_ds_tong_so.Tables.Add(new DataTable());
            if (CIPConvert.ToDecimal(m_cbo_nganh.SelectedValue.ToString()) > -1)
            {
                v_us.FillDatasetWithQuery(v_ds_chi_tieu, "SELECT CHI_TIEU FROM DM_NGANH_TUYEN_SINH WHERE ID = " + m_cbo_nganh.SelectedValue.ToString());
                m_lab_chi_tieu.Text = v_ds_chi_tieu.Tables[0].Rows[0]["CHI_TIEU"].ToString();
                v_us.FillDatasetWithQuery(v_ds_tong_so, "SELECT COUNT(ID) AS CHI_TIEU FROM DS_KET_QUA_XET_TUYEN WHERE ID_NGANH = " + m_cbo_nganh.SelectedValue.ToString());
                m_lab_tong_so.Text = v_ds_tong_so.Tables[0].Rows[0]["CHI_TIEU"].ToString();
            }
            else
            {
                v_us.FillDatasetWithQuery(v_ds_chi_tieu, "SELECT SUM(CHI_TIEU) AS CHI_TIEU FROM DM_NGANH_TUYEN_SINH");
                m_lab_chi_tieu.Text = v_ds_chi_tieu.Tables[0].Rows[0]["CHI_TIEU"].ToString();
                v_us.FillDatasetWithQuery(v_ds_tong_so, "SELECT COUNT(ID) AS CHI_TIEU FROM DS_KET_QUA_XET_TUYEN");
                m_lab_tong_so.Text = v_ds_tong_so.Tables[0].Rows[0]["CHI_TIEU"].ToString();
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog f = new SaveFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    User.xuat_excel(m_grv_ds_trung_tuyen, f.FileName);
                }
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }

    }
}
