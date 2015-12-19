using DevExpress.Web.ASPxEditors;
using IP.Core.IPCommon;
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
    public partial class f100_thay_doi_nguyen_vong : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
               
               
                    return;
            }

            load_data_2_cbo_nhom_nganh();
            load_data_2_cbo_to_hop_mon();
            load_data_2_diem_thi();
            load_data_2_thong_tinh_sinh_vien();
            load_data_2_nguyen_vong_sinh_vien();


        }
       
        private void load_data_2_cbo_to_hop_mon()
        {
            US_DUNG_CHUNG k_us = new US_DUNG_CHUNG();
            DataSet k_ds = new DataSet();
            k_ds.Tables.Add(new DataTable());

            k_us.FillDatasetWithQuery(k_ds, "select * from V_THI_SINH_NGUYEN_VONG where  ma_thi_sinh='" + SinhVien.tai_khoan + "' order by nguyen_vong");


            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            for (int i = 0; i < k_ds.Tables[0].Rows.Count; i++)
            {
                v_us.FillDatasetWithQuery(v_ds, "select distinct ID_TO_HOP_MON, TO_HOP_MON from V_DS_NGANH_TO_HOP_MON where id_ma_nganh=" + k_ds.Tables[0].Rows[i]["ID_MA_NGANH"]);
                if (i == 0)
                {
                    //nguyện vọng 1       
                    m_cbo_to_hop_mon_NV1.ValueField = "ID_TO_HOP_MON";
                    m_cbo_to_hop_mon_NV1.TextField = "TO_HOP_MON";
                    m_cbo_to_hop_mon_NV1.DataSource = v_ds.Tables[0];
                    m_cbo_to_hop_mon_NV1.DataBind();
                }
                else if (i == 1)
                {
                    //nguyện vọng 2       
                    m_cbo_to_hop_mon_NV2.ValueField = "ID_TO_HOP_MON";
                    m_cbo_to_hop_mon_NV2.TextField = "TO_HOP_MON";
                    m_cbo_to_hop_mon_NV2.DataSource = v_ds.Tables[0];
                    m_cbo_to_hop_mon_NV2.DataBind();
                }
                else if (i == 2)
                {
                    //nguyện vọng 3       
                    m_cbo_to_hop_mon_NV3.ValueField = "ID_TO_HOP_MON";
                    m_cbo_to_hop_mon_NV3.TextField = "TO_HOP_MON";
                    m_cbo_to_hop_mon_NV3.DataSource = v_ds.Tables[0];
                    m_cbo_to_hop_mon_NV3.DataBind();
                }
                else if (i == 3)
                {
                    //nguyện vọng 4       
                    m_cbo_to_hop_mon_NV4.ValueField = "ID_TO_HOP_MON";
                    m_cbo_to_hop_mon_NV4.TextField = "TO_HOP_MON";
                    m_cbo_to_hop_mon_NV4.DataSource = v_ds.Tables[0];
                    m_cbo_to_hop_mon_NV4.DataBind();
                }


                v_ds.Tables[0].Clear();

            }


        }



        private void load_data_2_nguyen_vong_sinh_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_THI_SINH_NGUYEN_VONG where ma_thi_sinh='" + SinhVien.tai_khoan + "' order by nguyen_vong");
            if (v_ds.Tables[0].Rows.Count != 0)
            {
                SinhVien.id_sinh_vien = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID_THI_SINH"]);

                if (v_ds.Tables[0].Rows.Count == 1)
                {

                    m_cbo_nhom_nganh_NV1.Text = v_ds.Tables[0].Rows[0]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV1.Text = v_ds.Tables[0].Rows[0]["TO_HOP_MON"].ToString();
                }
                else if (v_ds.Tables[0].Rows.Count == 2)
                {
                    m_ck_nv2.Checked = true;
                    m_cbo_nhom_nganh_NV1.Text = v_ds.Tables[0].Rows[0]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV1.Text = v_ds.Tables[0].Rows[0]["TO_HOP_MON"].ToString();
                    m_cbo_nhom_nganh_NV2.Text = v_ds.Tables[0].Rows[1]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV2.Text = v_ds.Tables[0].Rows[1]["TO_HOP_MON"].ToString();
                }
                else if (v_ds.Tables[0].Rows.Count == 3)
                {
                    m_ck_nv2.Checked = true;
                    m_ck_nv3.Checked = true;
                    m_cbo_nhom_nganh_NV1.Text = v_ds.Tables[0].Rows[0]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV1.Text = v_ds.Tables[0].Rows[0]["TO_HOP_MON"].ToString();
                    m_cbo_nhom_nganh_NV2.Text = v_ds.Tables[0].Rows[1]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV2.Text = v_ds.Tables[0].Rows[1]["TO_HOP_MON"].ToString();
                    m_cbo_nhom_nganh_NV3.Text = v_ds.Tables[0].Rows[2]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV3.Text = v_ds.Tables[0].Rows[2]["TO_HOP_MON"].ToString();
                }
                else if (v_ds.Tables[0].Rows.Count == 4)
                {
                    m_ck_nv2.Checked = true;
                    m_ck_nv3.Checked = true;
                    m_ck_nv4.Checked = true;

                    m_cbo_nhom_nganh_NV1.Text = v_ds.Tables[0].Rows[0]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV1.Text = v_ds.Tables[0].Rows[0]["TO_HOP_MON"].ToString();
                    m_cbo_nhom_nganh_NV2.Text = v_ds.Tables[0].Rows[1]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV2.Text = v_ds.Tables[0].Rows[1]["TO_HOP_MON"].ToString();
                    m_cbo_nhom_nganh_NV3.Text = v_ds.Tables[0].Rows[2]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV3.Text = v_ds.Tables[0].Rows[2]["TO_HOP_MON"].ToString();
                    m_cbo_nhom_nganh_NV4.Text = v_ds.Tables[0].Rows[3]["MA_NGANH"].ToString();
                    m_cbo_to_hop_mon_NV4.Text = v_ds.Tables[0].Rows[3]["TO_HOP_MON"].ToString();
                }

            }
            else
            {
                v_us.FillDatasetWithQuery(v_ds, "select ID from DS_HO_SO_THI_SINH where ma_thi_sinh= '" + SinhVien.tai_khoan + "'");

            }
            if (m_ck_nv2.Checked == false)
            {
                m_cbo_to_hop_mon_NV2.Enabled = false;
                m_cbo_nhom_nganh_NV2.Enabled = false;
            }
            if (m_ck_nv3.Checked == false)
            {
                m_cbo_to_hop_mon_NV3.Enabled = false;
                m_cbo_nhom_nganh_NV3.Enabled = false;
            }
            if (m_ck_nv4.Checked == false)
            {
                m_cbo_to_hop_mon_NV4.Enabled = false;
                m_cbo_nhom_nganh_NV4.Enabled = false;
            }
        }

        private void load_data_2_thong_tinh_sinh_vien()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_DS_HO_SO_THI_SINH where ma_thi_sinh='" + SinhVien.tai_khoan + "'");
            SinhVien.id_sinh_vien = CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"]);
            m_lbl_so_bao_danh.Text = v_ds.Tables[0].Rows[0]["MA_THI_SINH"].ToString();
            m_lbl_ho_ten.Text = v_ds.Tables[0].Rows[0]["HO_TEN"].ToString();
            m_lbl_ngay_sinh.Text = v_ds.Tables[0].Rows[0]["NGAY_SINH"].ToString();
            if (v_ds.Tables[0].Rows[0]["TEN_KHU_VUC"].ToString() != "")
            {
                m_lbl_khu_vuc.Text = v_ds.Tables[0].Rows[0]["TEN_KHU_VUC"].ToString();
            }
            else m_lbl_khu_vuc.Text = "Không";
            if (v_ds.Tables[0].Rows[0]["TEN_DOI_TUONG"].ToString() != "")
            {
                m_lbl_doi_tuong.Text = v_ds.Tables[0].Rows[0]["TEN_DOI_TUONG"].ToString();
            }
            else m_lbl_doi_tuong.Text = "Không";
            if (v_ds.Tables[0].Rows[0]["UU_TIEN_YN"].ToString() == "Y")
            {
                m_lbl_uu_tien.Text = "Có";
            }
            else m_lbl_uu_tien.Text = "Không";

            m_lbl_ho_ten_ts.Text = v_ds.Tables[0].Rows[0]["Ho_ten"].ToString();
        }

        private void load_data_2_diem_thi()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from v_diem_thi where ma_thi_sinh='" + SinhVien.tai_khoan + "'");
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 1) m_lbl_toan.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 2) m_lbl_van.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 3) m_lbl_ly.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 4) m_lbl_hoa.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 5) m_lbl_sinh.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 6) m_lbl_su.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 7) m_lbl_dia.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 8) m_lbl_Anh.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 9) m_lbl_Tieng_Nga.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 10) m_lbl_Tieng_Phap.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 11) m_lbl_Tieng_Trung.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 12) m_lbl_Tieng_Duc.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
                else if (CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_MA_MON"].ToString()) == 13) m_lbl_Tieng_Nhat.Text = v_ds.Tables[0].Rows[i]["DIEM"].ToString();
            }
        }

        private void load_data_2_cbo_nhom_nganh()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select distinct * from DM_NGANH_TUYEN_SINH");

            //nguyện vọng 1       
            m_cbo_nhom_nganh_NV1.ValueField = "ID";
            m_cbo_nhom_nganh_NV1.TextField = "MA_NGANH";
            m_cbo_nhom_nganh_NV1.DataSource = v_ds.Tables[0];
            m_cbo_nhom_nganh_NV1.DataBind();
            //nguyện vọng 2       
            m_cbo_nhom_nganh_NV2.ValueField = "ID";
            m_cbo_nhom_nganh_NV2.TextField = "MA_NGANH";
            m_cbo_nhom_nganh_NV2.DataSource = v_ds.Tables[0];
            m_cbo_nhom_nganh_NV2.DataBind();
            //nguyện vọng 1       
            m_cbo_nhom_nganh_NV3.ValueField = "ID";
            m_cbo_nhom_nganh_NV3.TextField = "MA_NGANH";
            m_cbo_nhom_nganh_NV3.DataSource = v_ds.Tables[0];
            m_cbo_nhom_nganh_NV3.DataBind();
            //nguyện vọng 1       
            m_cbo_nhom_nganh_NV4.ValueField = "ID";
            m_cbo_nhom_nganh_NV4.TextField = "MA_NGANH";
            m_cbo_nhom_nganh_NV4.DataSource = v_ds.Tables[0];
            m_cbo_nhom_nganh_NV4.DataBind();


        }

        public void fill_data_nguyen_vong_with_ma_nganh(ASPxComboBox x, string condition)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select distinct * from V_DS_NGANH_TO_HOP_MON where ID_MA_NGANH =" + condition);
            x.DataSource = v_ds.Tables[0];
            x.TextField = "TO_HOP_MON";
            x.ValueField = "ID_TO_HOP_MON";
            x.DataBind();

        }

        protected void m_cbo_nhom_nganh_NV1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fill_data_nguyen_vong_with_ma_nganh(m_cbo_to_hop_mon_NV1, m_cbo_nhom_nganh_NV1.Value.ToString());
            }
            catch
            {
                Response.Write("<script type=\"text/javascript\">alert('Đã xảy ra lỗi hệ thống!');</script>");
            }


        }

        protected void m_cbo_nhom_nganh_NV2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fill_data_nguyen_vong_with_ma_nganh(m_cbo_to_hop_mon_NV2, m_cbo_nhom_nganh_NV2.Value.ToString());
            }
            catch
            {
                Response.Write("<script type=\"text/javascript\">alert('Đã xảy ra lỗi hệ thống!');</script>");
            }

        }

        protected void m_cbo_nhom_nganh_NV3_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                fill_data_nguyen_vong_with_ma_nganh(m_cbo_to_hop_mon_NV3, m_cbo_nhom_nganh_NV3.Value.ToString());
            }
            catch
            {
                Response.Write("<script type=\"text/javascript\">alert('Đã xảy ra lỗi hệ thống!');</script>");
            }
        }

        protected void m_cbo_nhom_nganh_NV4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                fill_data_nguyen_vong_with_ma_nganh(m_cbo_to_hop_mon_NV4, m_cbo_nhom_nganh_NV4.Value.ToString());
            }
            catch
            {
                Response.Write("<script type=\"text/javascript\">alert('Đã xảy ra lỗi hệ thống!');</script>");
            }

        }

        protected void m_cmd_luu_thay_doi_Click(object sender, EventArgs e)
        {
            try
            {
                int v_so_nguyen_vong = check_du_lieu_truoc_luu();
                if (v_so_nguyen_vong != 0)
                {
                    xoa_ket_qua_thi_sinh();
                    update_nguyen_vong(v_so_nguyen_vong);
                    Response.Redirect("f100_thay_doi_nguyen_vong_.aspx");

                }
                else Response.Write("<script type=\"text/javascript\">alert('Hãy xem lại nguyện vọng!');</script>");
            }
            catch
            {
                Response.Write("<script type=\"text/javascript\">alert('Đã xảy ra lỗi hệ thống!');</script>");
            }
        }

        private void xoa_ket_qua_thi_sinh()
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
            sql_delete = "delete from DS_KET_QUA_XET_TUYEN where id_thi_sinh=" + SinhVien.id_sinh_vien;
            command = new SqlCommand(sql_delete, cnn);
            reader = command.ExecuteReader();
            command.Dispose();
            reader.Dispose();
        }

        private bool check_nhom_nganh_to_hop_mon(int so_nguyen_vong)
        {

            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "select * from V_DS_NGANH_TO_HOP_MON where id_nganh=" + m_cbo_nhom_nganh_NV1.Value + "and id_to_hop_mon" + m_cbo_to_hop_mon_NV1.Value);
            v_us.FillDatasetWithQuery(v_ds, "select * from V_DS_NGANH_TO_HOP_MON where id_nganh=" + m_cbo_nhom_nganh_NV2.Value + "and id_to_hop_mon" + m_cbo_to_hop_mon_NV2.Value);
            v_us.FillDatasetWithQuery(v_ds, "select * from V_DS_NGANH_TO_HOP_MON where id_nganh=" + m_cbo_nhom_nganh_NV3.Value + "and id_to_hop_mon" + m_cbo_to_hop_mon_NV3.Value);
            v_us.FillDatasetWithQuery(v_ds, "select * from V_DS_NGANH_TO_HOP_MON where id_nganh=" + m_cbo_nhom_nganh_NV4.Value + "and id_to_hop_mon" + m_cbo_to_hop_mon_NV4.Value);
            if (v_ds.Tables[0].Rows.Count < so_nguyen_vong)
            {
                return false;
            }

            return true;

        }

        private void update_nguyen_vong(int v_so_nguyen_vong)
        {
            List<decimal> NhomNganh = new List<decimal>();
            NhomNganh.Add(Convert.ToDecimal(m_cbo_nhom_nganh_NV1.Value));
            NhomNganh.Add(Convert.ToDecimal(m_cbo_nhom_nganh_NV2.Value));
            NhomNganh.Add(Convert.ToDecimal(m_cbo_nhom_nganh_NV3.Value));
            NhomNganh.Add(Convert.ToDecimal(m_cbo_nhom_nganh_NV4.Value));
            //kiểm tra xem có bất kỳ nhóm ngành nào trùng nhau không
            for (int j = 0; j < NhomNganh.Count; j++)
            {
                for (int i = j + 1; i < NhomNganh.Count; i++)
                {

                    if (NhomNganh[j] == NhomNganh[i])
                    {
                        Response.Write("<script type=\"text/javascript\">alert('Hãy xem lại,mỗi ngành chỉ có 1 nguyện vọng!');</script>");
                        return;
                    }
                }
            }
            List<decimal> ToHopMon = new List<decimal>();
            ToHopMon.Add(Convert.ToDecimal(m_cbo_to_hop_mon_NV1.Value));
            ToHopMon.Add(Convert.ToDecimal(m_cbo_to_hop_mon_NV2.Value));
            ToHopMon.Add(Convert.ToDecimal(m_cbo_to_hop_mon_NV3.Value));
            ToHopMon.Add(Convert.ToDecimal(m_cbo_to_hop_mon_NV4.Value));

            List<decimal> ID_NGANH_TO_HOP_MON = new List<decimal>();
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
            sql_delete = "delete from DS_NGUYEN_VONG where id_thi_sinh=" + SinhVien.id_sinh_vien;
            command = new SqlCommand(sql_delete, cnn);
            reader = command.ExecuteReader();
            command.Dispose();
            reader.Dispose();

            for (int k = 0; k < v_so_nguyen_vong; k++)
            {
                int index = k + 1;
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "select * from DS_NGANH_TO_HOP_MON where ID_MA_NGANH=" + NhomNganh[k] + " and ID_TO_HOP_MON =" + ToHopMon[k]);
                ID_NGANH_TO_HOP_MON.Add(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0]["ID"]));
                sql = "Insert into DS_NGUYEN_VONG Values(" + SinhVien.id_sinh_vien + "," + ID_NGANH_TO_HOP_MON[k] + "," + index + ",dbo.get_diem_tb_nhom_mon(" + SinhVien.id_sinh_vien + "," + ToHopMon[k] + "),'N')";
                command = new SqlCommand(sql, cnn);
                reader = command.ExecuteReader();
                command.Dispose();
                reader.Dispose();
            }
            Response.Write("<script type=\"text/javascript\">alert('Đã lưu thành công!');</script>");
        }


        private int check_du_lieu_truoc_luu()
        {
            if (check_tung_nguyen_vong1() && !check_tung_nguyen_vong2() && !check_tung_nguyen_vong3() && !check_tung_nguyen_vong4())
            {
                return 1;
            }
            else if (check_tung_nguyen_vong1() && check_tung_nguyen_vong2() && !check_tung_nguyen_vong3() && !check_tung_nguyen_vong4())
            {
                return 2;
            }
            else if (check_tung_nguyen_vong1() && check_tung_nguyen_vong2() && check_tung_nguyen_vong3() && !check_tung_nguyen_vong4())
            {
                return 3;
            }
            else if (check_tung_nguyen_vong1() && check_tung_nguyen_vong2() && check_tung_nguyen_vong3() && check_tung_nguyen_vong4())
            {
                return 4;
            }
            return 0;
        }

        private bool check_tung_nguyen_vong1()
        {
            if (m_cbo_nhom_nganh_NV1.Value != null && m_cbo_to_hop_mon_NV1.Value != null)
            {

                return true;
            }
            else
                return false;
        }
        private bool check_tung_nguyen_vong2()
        {
            if (m_cbo_nhom_nganh_NV2.Value != null && m_cbo_to_hop_mon_NV2.SelectedIndex != null && m_ck_nv2.Checked)
            {
                return true;
            }
            else
                return false;
        }
        private bool check_tung_nguyen_vong3()
        {
            if (m_cbo_nhom_nganh_NV3.Value != null && m_cbo_to_hop_mon_NV3.Value != null && m_ck_nv3.Checked)
            {
                return true;
            }
            else
                return false;
        }
        private bool check_tung_nguyen_vong4()
        {
            if (m_cbo_nhom_nganh_NV4.Value != null && m_cbo_to_hop_mon_NV4.Value != null && m_ck_nv4.Checked)
            {
                return true;
            }
            else
                return false;
        }

        protected void m_ck_nv2_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ck_nv2.Checked == true)
            {
                m_cbo_nhom_nganh_NV2.Enabled = true;
                m_cbo_to_hop_mon_NV2.Enabled = true;
            }
            else
            {
                m_ck_nv3.Checked = false;
                m_ck_nv4.Checked = false;
                m_cbo_nhom_nganh_NV2.Enabled = false;
                m_cbo_to_hop_mon_NV2.Enabled = false;
                m_cbo_nhom_nganh_NV4.Enabled = false;
                m_cbo_to_hop_mon_NV4.Enabled = false;
                m_cbo_nhom_nganh_NV3.Enabled = false;
                m_cbo_to_hop_mon_NV3.Enabled = false;
            }
        }

        protected void m_ck_nv3_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ck_nv3.Checked == true)
            {
                m_cbo_nhom_nganh_NV3.Enabled = true;
                m_cbo_to_hop_mon_NV3.Enabled = true;
            }
            else
            {

                m_ck_nv4.Checked = false;
                m_cbo_nhom_nganh_NV3.Enabled = false;
                m_cbo_to_hop_mon_NV3.Enabled = false;
                m_cbo_nhom_nganh_NV4.Enabled = false;
                m_cbo_to_hop_mon_NV4.Enabled = false;
            }
        }

        protected void m_ck_nv4_CheckedChanged(object sender, EventArgs e)
        {
            if (m_ck_nv4.Checked == true)
            {
                m_cbo_nhom_nganh_NV4.Enabled = true;
                m_cbo_to_hop_mon_NV4.Enabled = true;
            }
            else
            {
                m_cbo_nhom_nganh_NV4.Enabled = false;
                m_cbo_to_hop_mon_NV4.Enabled = false;
            }
        }
    }
}