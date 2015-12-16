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
    public partial class f700_ds_diem_chuan : Form
    {
        public f700_ds_diem_chuan()
        {
            InitializeComponent();
        }

        private void f700_ds_diem_chuan_Load(object sender, EventArgs e)
        {
            try
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithTableName(v_ds,"V_DIEM_CHUAN");
                m_grc_ds_diem_chuan.DataSource = v_ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong hệ thống!");
            }
        }

        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog f = new SaveFileDialog();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    User.xuat_excel(m_grv_ds_diem_chuan, f.FileName);
                }
            }
            catch
            {

                MessageBox.Show("Đã xảy ra lỗi hệ thống!");
            }
        }
    }
}
