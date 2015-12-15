///************************************************
/// Generated by: tuandm
/// Date: 15/12/2015 05:24:40
/// Goal: Create User Service Class for DS_NGANH_TO_HOP_MON
///************************************************
/// <summary>
/// Create User Service Class for DS_NGANH_TO_HOP_MON
/// </summary>

using System;
using IPCOREDS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;


namespace IPCOREUS
{

	public class US_DS_NGANH_TO_HOP_MON : US_Object
	{
		private const string c_TableName = "DS_NGANH_TO_HOP_MON";
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

		public decimal dcID_MA_NGANH 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_MA_NGANH", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_MA_NGANH"] = value;
			}
		}

		public bool IsID_MA_NGANHNull()	{
			return pm_objDR.IsNull("ID_MA_NGANH");
		}

		public void SetID_MA_NGANHNull() {
			pm_objDR["ID_MA_NGANH"] = System.Convert.DBNull;
		}

		public decimal dcID_TO_HOP_MON 
		{
			get
			{
				return CNull.RowNVLDecimal(pm_objDR, "ID_TO_HOP_MON", IPConstants.c_DefaultDecimal);
			}
			set	
			{
				pm_objDR["ID_TO_HOP_MON"] = value;
			}
		}

		public bool IsID_TO_HOP_MONNull()	{
			return pm_objDR.IsNull("ID_TO_HOP_MON");
		}

		public void SetID_TO_HOP_MONNull() {
			pm_objDR["ID_TO_HOP_MON"] = System.Convert.DBNull;
		}

		#endregion


		#region Init Functions
		public US_DS_NGANH_TO_HOP_MON() 
		{
			pm_objDS = new DS_DS_NGANH_TO_HOP_MON();
			pm_strTableName = c_TableName;
			pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
		}

		public US_DS_NGANH_TO_HOP_MON(DataRow i_objDR): this()
		{
			this.DataRow2Me(i_objDR);
		}

		public US_DS_NGANH_TO_HOP_MON(decimal i_dbID) 
		{
			pm_objDS = new DS_DS_NGANH_TO_HOP_MON();
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
