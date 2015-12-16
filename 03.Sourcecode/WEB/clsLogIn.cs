using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCF = System.Web.Configuration.WebConfigurationManager; 
using System.Data.SqlClient;
using System.Data;

namespace WEB
{
    public class clsLogIn
    {
        String strUserName = "";
        String strPassword = "";
        String strMessage = "";
        bool bolIsAdmin = false;
        bool bolIsLoged = false;

        public String UserName
        {
            set { strUserName = value; }
            get { return strUserName; }
        }

        public String Password
        {
            set { strPassword = value; }
            get { return strPassword; }
        }

        public String Message
        {
            set { strMessage = value; }
            get { return strMessage; }
        }

        public bool IsAdmin
        {
            //set { bolIsAdmin = value; }
            get { return bolIsAdmin; }
        }

        public bool IsLoged
        {
            //set { bolIsLoged=value;}
            get { return bolIsLoged; }
        }

        public clsLogIn(string username, string password)
        {
            strUserName = username;
            strPassword = password;
            LogIn();
        }

        private void LogIn()
        {
           //  Method clsMT = new Method();

            String strCon = WCF.ConnectionStrings["CRMDatabase"].ConnectionString;
            SqlConnection myCon = new SqlConnection(strCon);
            myCon.Open();
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandText = "sp_LogInCRM";
            myCommand.Parameters.Add("@username", UserName);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Connection = myCon;
            SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);
            DataTable myDataTable = new DataTable();
            myAdapter.Fill(myDataTable);

            if (myDataTable.Rows.Count == 0)
            {
                bolIsLoged = false;
                strMessage = "Tên đăng nhập không đúng!!!!";
            }
            else if (myDataTable.Rows[0][1].ToString() != strPassword)
            {
                bolIsLoged = false;
                strMessage = "Mật khẩu không đúng!!!!";
            }
            else
            {
                bolIsLoged = true;
               
            }
        }
    }
}
