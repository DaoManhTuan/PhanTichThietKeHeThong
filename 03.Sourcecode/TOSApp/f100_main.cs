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

        private void m_cmd_tiep_nhan_ho_so_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                f101_tiep_nhan_ho_so v_f = new f101_tiep_nhan_ho_so();
                v_f.MdiParent = this;
                v_f.Show();
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
                f103_tra_ho_so v_f = new f103_tra_ho_so();
                v_f.MdiParent = this;
                v_f.Show();
            }
            catch
            {
                
            }
           
        }
    }
}
