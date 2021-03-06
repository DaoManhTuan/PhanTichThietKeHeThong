///************************************************
/// Generated by: tuandm
/// Date: 15/12/2015 05:30:20
/// Goal: Create User Service Class for USER_PASSWORD
///************************************************
/// <summary>
/// Create User Service Class for USER_PASSWORD
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_USER_PASSWORD : US_Object
	{
		private const string c_TableName = "USER_PASSWORD";
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

		public string strTAI_KHOAN 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "TAI_KHOAN", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["TAI_KHOAN"] = value;
			}
		}

		public bool IsTAI_KHOANNull() 
		{
			return pm_objDR.IsNull("TAI_KHOAN");
		}

		public void SetTAI_KHOANNull() {
			pm_objDR["TAI_KHOAN"] = System.Convert.DBNull;
		}

		public string strMAT_KHAU 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "MAT_KHAU", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["MAT_KHAU"] = value;
			}
		}

		public bool IsMAT_KHAUNull() 
		{
			return pm_objDR.IsNull("MAT_KHAU");
		}

		public void SetMAT_KHAUNull() {
			pm_objDR["MAT_KHAU"] = System.Convert.DBNull;
		}

		public string strGHI_CHU 
		{
			get 
			{
				return CNull.RowNVLString(pm_objDR, "GHI_CHU", IPConstants.c_DefaultString);
			}
			set 
			{
				pm_objDR["GHI_CHU"] = value;
			}
		}

		public bool IsGHI_CHUNull() 
		{
			return pm_objDR.IsNull("GHI_CHU");
		}

		public void SetGHI_CHUNull() {
			pm_objDR["GHI_CHU"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_USER_PASSWORD() 
		{
			pm_objDS = new DS_USER_PASSWORD();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_USER_PASSWORD(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_USER_PASSWORD(decimal i_dbID) 
		{
			pm_objDS = new DS_USER_PASSWORD();
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
