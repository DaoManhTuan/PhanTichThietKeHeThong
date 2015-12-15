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
        public static decimal GetDiemXetTuyen(decimal id_thi_sinh, decimal id_to_hop_mon)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            v_ds.Tables.Add(new DataTable());
            v_us.FillDatasetWithQuery(v_ds, "SELECT dbo.get_diem_tb_nhom_mon(" + id_thi_sinh + "," + id_to_hop_mon + ")");
            return CIPConvert.ToDecimal( v_ds.Tables[0].Rows[0][0].ToString());
        }
    }
}
