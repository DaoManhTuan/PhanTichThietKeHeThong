using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class f200_doi_mat_khau : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (check_du_lieu_truoc_luu())
                {

                    update_mat_khau();
                    Response.Redirect("Login.aspx");

                }
                
            }
            catch
            {
                Response.Write("<script type=\"text/javascript\">alert('Đã xảy ra lỗi hệ thống!');</script>");
            }
        }

        private void update_mat_khau()
        {
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=HAGOROMO\\manhtuan;Initial Catalog=HTTS_DHBKHN;User ID=sa;Password=sa";
            cnn = new SqlConnection(connetionString);
            string sql = "";
            string sql_delete = "";
            SqlCommand command;
            SqlDataReader reader;
            cnn.Open();
            //xóa các nguyện vọng cũ 
            sql_delete = "UPdate user_password set mat_khau=" + m_txt_pass_1.Value.ToString() + "where tai_khoan='"+SinhVien.tai_khoan+"'";
            command = new SqlCommand(sql_delete, cnn);
            reader = command.ExecuteReader();
            command.Dispose();
            reader.Dispose();
            Response.Write("<script type=\"text/javascript\">alert('Đổi mật khẩu thành công!');</script>");
        }
        private bool check_du_lieu_truoc_luu()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from USER_PASSWORD where tai_khoan ='" + SinhVien.tai_khoan + "'");
            if ( v_ds.Tables[0].Rows[0]["MAT_KHAU"].ToString()!= m_txt_username.Value)
            {
                Response.Write("<script type=\"text/javascript\">alert('Mật khẩu cũ không đúng!');</script>");
                return false;
            }
            if (m_txt_pass_1.Value!=m_txt_pass_2.Value)
            {
                Response.Write("<script type=\"text/javascript\">alert('Xác nhận mật khẩu mới chưa chính xác!');</script>");
                return false;
            }
            return true;
        }
    }
}