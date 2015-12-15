///************************************************
/// Generated by: tuandm
/// Date: 15/12/2015 05:21:54
/// Goal: Create User Service Class for DS_TO_HOP_MON
///************************************************
/// <summary>
/// Create User Service Class for DS_TO_HOP_MON
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_DS_TO_HOP_MON : US_Object
	{
		private const string c_TableName = "DS_TO_HOP_MON";
		#region Public Properties
		public decimal dcID 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID"] = value;
			}
		}

		public bool IsIDNull()	{
			return pm_objDR.IsNull("ID");
		}

		public void SetIDNull() {
			pm_objDR["ID"] = System.Convert.DBNull;
		}

		public decimal dcID_MA_MON_1 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_MA_MON_1", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_MA_MON_1"] = value;
			}
		}

		public bool IsID_MA_MON_1Null()	{
			return pm_objDR.IsNull("ID_MA_MON_1");
		}

		public void SetID_MA_MON_1Null() {
			pm_objDR["ID_MA_MON_1"] = System.Convert.DBNull;
		}

		public decimal dcID_MA_MON_2 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_MA_MON_2", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_MA_MON_2"] = value;
			}
		}

		public bool IsID_MA_MON_2Null()	{
			return pm_objDR.IsNull("ID_MA_MON_2");
		}

		public void SetID_MA_MON_2Null() {
			pm_objDR["ID_MA_MON_2"] = System.Convert.DBNull;
		}

		public decimal dcID_MA_MON_3 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_MA_MON_3", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_MA_MON_3"] = value;
			}
		}

		public bool IsID_MA_MON_3Null()	{
			return pm_objDR.IsNull("ID_MA_MON_3");
		}

		public void SetID_MA_MON_3Null() {
			pm_objDR["ID_MA_MON_3"] = System.Convert.DBNull;
		}

		public string strUU_TIEN_Y_N 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "UU_TIEN_Y_N", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["UU_TIEN_Y_N"] = value;
			}
		}

		public bool IsUU_TIEN_Y_NNull() 
		{
			return pm_objDR.IsNull("UU_TIEN_Y_N");
		}

		public void SetUU_TIEN_Y_NNull() {
			pm_objDR["UU_TIEN_Y_N"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_DS_TO_HOP_MON() 
		{
			pm_objDS = new DS_DS_TO_HOP_MON();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_DS_TO_HOP_MON(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_DS_TO_HOP_MON(decimal i_dbID) 
		{
			pm_objDS = new DS_DS_TO_HOP_MON();
			pm_strTableName = c_TableName;
			IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
			v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
			SqlCommand v_cmdSQL;
			v_cmdSQL = v_objMkCmd.getSelectCmd();
			this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
			pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
		}
		#endregion


	}
}
