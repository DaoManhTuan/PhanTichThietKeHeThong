using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IPCOREDS;
using DevExpress.Utils.Menu;
using System.Configuration;
using System.Data.OleDb;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;

namespace TOSApp
{
    class User
    {
        public static decimal ID_NGUOI_SU_DUNG;
        public static string TAI_KHOAN;
        public static string MAT_KHAU;
        public static decimal ID_NHOM_NGUOI_SU_DUNG;
        public static bool trang_thai_dang_nhap = false;
        public static decimal GetDiemXetTuyen(decimal id_thi_sinh, decimal id_to_hop_mon)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT dbo.get_diem_tb_nhom_mon(" + id_thi_sinh + "," + id_to_hop_mon + ")");
            return CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][0].ToString());
        }
        public static void XetTuyen()
        {
            while (Dieu_kien_Dung() > 0)
            {
                US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
                DataSet v_ds = new DataSet();
                v_ds.Tables.Add(new DataTable());
                v_us.FillDatasetWithQuery(v_ds, "SELECT ID_THI_SINH FROM V_DS_NGANH_NGUYEN_VONG dnnv WHERE dnnv.TRANG_THAI_TRUNG_TUYEN = 'N' AND dnnv.NGUYEN_VONG =1");
                for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
                {
                    v_us.FillTableKQXT(CIPConvert.ToDecimal(v_ds.Tables[0].Rows[i]["ID_THI_SINH"].ToString()));
                }
                v_us.UpdateTrangThaiTrungTuyen();
            }
        }
        public static decimal Dieu_kien_Dung()
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT dbo.f_get_dieu_kien_dung()");
            return CIPConvert.ToDecimal(v_ds.Tables[0].Rows[0][0].ToString());
        }
        public static void xuat_excel(DevExpress.XtraGrid.Views.Grid.GridView v_grv, string name)
        {
            name = name + ".xls";
            v_grv.SaveLayoutToXml("tempLayout.xml");
            foreach (DevExpress.XtraGrid.Columns.GridColumn col in v_grv.Columns)
            {
                col.Visible = true;
            }
            v_grv.ExportToXls(name);

            v_grv.RestoreLayoutFromXml("tempLayout.xml");
        }
    }
}
