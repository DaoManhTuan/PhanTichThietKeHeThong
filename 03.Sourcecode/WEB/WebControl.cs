using DevExpress.Web.ASPxEditors;
using IP.Core.IPUserService;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WEB
{
    public class WebControl
    {
         
        public enum eTAT_CA
        {
            YES,
            NO
        }
        public enum eLOAI_TU_DIEN
        {
            TRANG_THAI_CHUC_VU,
            LOAI_HOP_DONG,
            LOAI_DON_VI,
            CAP_DON_VI,
            CO_CHE,
            LOAI_DU_AN,
            TRANG_THAI_DU_AN,
            LOAI_QUYET_DINH,
            TRANG_THAI_LAO_DONG,
            DM_CA_HOC
        }
       
    }

    public class US_DUNG_CHUNG : US_Object
    {
        public void FillDatasetWithProc(DataSet op_ds, string ip_str_table_name, string ip_str_column_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_to_dataset_with_table_name_and_column_name");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_NAME", ip_str_column_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetCBO(DataSet op_ds, string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_for_cbo");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.addNVarcharInputParam("@COLUMN_VALUE", ip_str_value_field);
            v_cstore.addNVarcharInputParam("@COLUMN_DISPLAY", ip_str_display_field);
            v_cstore.addNVarcharInputParam("@CONDITION", ip_str_condition);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        internal void FillDatasetWithTableName(DataSet op_ds, string ip_str_table_name)
        {
            CStoredProc v_cstore = new CStoredProc("get_data_from_table");
            v_cstore.addNVarcharInputParam("@TABLE_NAME", ip_str_table_name);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetWithQuery(DataSet op_ds, string ip_query)
        {
            CStoredProc v_cstore = new CStoredProc("pr_fill_ds_with_query");
            v_cstore.addNVarcharInputParam("@SQL_QUERY", ip_query);
            v_cstore.fillDataSetByCommand(this, op_ds);
        }

        public void FillDatasetLogin(DataSet v_ds, string user, string pass, decimal id_chi_nhanh)
        {
            CStoredProc v_cstore = new CStoredProc("check_login");
            v_cstore.addNVarcharInputParam("@user", user);
            v_cstore.addNVarcharInputParam("@pass", pass);
            v_cstore.addDecimalInputParam("@id_chi_nhanh", id_chi_nhanh);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        internal void FillDatasetSQLInjection(DataSet v_ds, string p)
        {
            CStoredProc v_cstore = new CStoredProc("sqlInjection");
            v_cstore.addNVarcharInputParam("@str_query", p);
            v_cstore.fillDataSetByCommand(this, v_ds);
        }

        public void load_data_to_combobox(string ip_str_table_name, string ip_str_value_field, string ip_str_display_field, string ip_str_condition, WEB.WebControl.eTAT_CA ip_e_tat_ca, ASPxComboBox ip_cbo)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetCBO(v_ds, ip_str_table_name, ip_str_value_field, ip_str_display_field, ip_str_condition);

            ip_cbo.DataSource = ip_str_display_field;
            ip_cbo.DataSourceID = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == WEB.WebControl.eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "------------Hãy chọn-----------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }


        public void load_data_to_combobox_with_query(ASPxComboBox ip_cbo, string ip_str_value_field, string ip_str_display_field, WEB.WebControl.eTAT_CA ip_e_tat_ca, string ip_query)
        {
            US_DUNG_CHUNG v_us = new US_DUNG_CHUNG();
            DataSet v_ds = new DataSet();
            DataTable v_dt = new DataTable();
            v_ds.Tables.Add(v_dt);
            v_us.FillDatasetWithQuery(v_ds, ip_query);

            ip_cbo.DataSource = ip_str_display_field;
            ip_cbo.DataSourceID = ip_str_value_field;
            ip_cbo.DataSource = v_ds.Tables[0];

            if (ip_e_tat_ca == WEB.WebControl.eTAT_CA.YES)
            {
                DataRow v_dr = v_ds.Tables[0].NewRow();
                v_dr[0] = -1;
                v_dr[1] = "---------- Hãy chọn ----------";
                v_ds.Tables[0].Rows.InsertAt(v_dr, 0);
                ip_cbo.SelectedIndex = 0;
            }
            else
            {
                ip_cbo.SelectedIndex = 0;
            }
        }

    }
       
}