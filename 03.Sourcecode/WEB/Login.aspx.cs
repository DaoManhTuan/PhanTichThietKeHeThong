using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            m_txt_password.Value = string.Empty;
        }

        protected void m_cmd_Login_Click(object sender, EventArgs e)
        {
            clsLogIn objUser = new clsLogIn(m_txt_username.Value.Trim(), m_txt_password.Value.Trim());
            if (objUser.IsLoged)
            {
                SinhVien.tai_khoan = m_txt_username.Value;
                SinhVien.mat_khau = m_txt_password.Value;
                Session["sesLogin"] = objUser;
                Response.Redirect("f100_thay_doi_nguyen_vong.aspx"); //Nếu đúng tên đăng nhập và mật khẩu thì gọi trang HomePage.aspx hiển thị
            }
            else
            {
                Response.Write("<script type=\"text/javascript\">alert('Tài khoản hoặc mật khẩu chưa chính xác!');</script>");
            }
        }
    }
}