using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
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
    public partial class f1002_danh_sach_nhan_vien : Form
    {
        public f1002_danh_sach_nhan_vien()
        {
            InitializeComponent();
        }

        private void f1002_danh_sach_nhan_vien_Load(object sender, EventArgs e)
        {
            try
            {
                load_data_2_cbo();
                load_data_2_grid();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }

        }

        private void load_data_2_cbo()
        {
            WinFormControls.load_data_to_combobox("NHOM_NGUOI_SU_DUNG", "ID", "NHOM_NGUOI_SU_DUNG", "", WinFormControls.eTAT_CA.NO, m_cbo_nhom);
        }

        private void load_data_2_grid()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithTableName(v_ds, "V_NGUOI_SU_DUNG");
            m_grc_user_name.DataSource = v_ds.Tables[0];
            load_data_2_thong_tin_chi_tiet(v_ds.Tables[0].Rows[0]);
        }

        private void m_grv_user_name_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                Point pt = view.GridControl.PointToClient(Control.MousePosition);
                DoRowClick(view, pt);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }
        private void DoRowClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
                if (v_dr != null)
                    load_data_2_thong_tin_chi_tiet(v_dr);
            }
        }

        private void load_data_2_thong_tin_chi_tiet(DataRow v_dr)
        {
            m_txt_tai_khoan.Text = v_dr["TAI_KHOAN"].ToString();
            m_cbo_nhom.SelectedValue = (decimal)v_dr["ID_NHOM_NGUOI_SU_DUNG"];
        }

        private void m_cmd_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
                if (v_dr != null)
                {
                    US_NGUOI_SU_DUNG v_us = new US_NGUOI_SU_DUNG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                    DialogResult result = new DialogResult();
                    result = MessageBox.Show("Bạn có chắc chắc muốn xóa tài khoản " + v_us.strTAI_KHOAN + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        v_us.Delete();
                        MessageBox.Show("Bạn vừa xóa thành công!");
                        load_data_2_grid();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn tài khoản cần xóa!");
                }
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
                if (v_dr != null)
                {
                    if (check_du_lieu_truoc_luu())
                    {
                        US_NGUOI_SU_DUNG v_us = new US_NGUOI_SU_DUNG(CIPConvert.ToDecimal(v_dr["ID"].ToString()));
                        v_us.strTAI_KHOAN = m_txt_tai_khoan.Text;
                        v_us.dcID_NHOM_NGUOI_SU_DUNG = CIPConvert.ToDecimal(m_cbo_nhom.SelectedValue.ToString());
                        v_us.Update();
                        MessageBox.Show("Cập nhật thành công tài khoản " + m_txt_tai_khoan.Text);
                        load_data_2_grid();
                    }
                }
                else
                {
                    MessageBox.Show("chọn 1 dòng");
                }
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private bool check_du_lieu_truoc_luu()
        {
            if (m_txt_tai_khoan.Text == "")
            {
                MessageBox.Show("Tài khoản chưa đúng!");
                m_txt_tai_khoan.Focus();
                return false;
            }

            DataRow v_dr = m_grv_user_name.GetDataRow(m_grv_user_name.FocusedRowHandle);
            if (v_dr["TAI_KHOAN"].ToString() != m_txt_tai_khoan.Text)
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetTaiKhoan(v_ds, m_txt_tai_khoan.Text );
                if (v_ds.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return false;
                }
            }
            return true;
        }
    }
}
