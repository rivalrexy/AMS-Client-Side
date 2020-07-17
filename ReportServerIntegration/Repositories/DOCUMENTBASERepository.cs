using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ReportServerIntegration.Models;

namespace ReportServerIntegration.Repositories
{
	public partial class DOCUMENTBASERepository
	{
		private string connString;
		public string Message { get; set; }

		public DOCUMENTBASERepository(string connectionString)
		{
			connString = connectionString;
		}

		//public List<DOCUMENTBASE> GetData()
		//{
		//	List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
		//	using (var conn = new SqlConnection(connString))
		//	{
		//		Message = "";
		//		try
		//		{
		//			conn.Open();
		//			SqlCommand command = new SqlCommand("SELECT  TOP 10 [OID], [LastModifiedTime], [Name], [Description], [Category], [OptimisticLockField], [ObjectType] FROM DocumentBase where [ObjectType] = 21  order by [LastModifiedTime] desc", conn);
		//			SqlDataReader reader = command.ExecuteReader();
		//			DOCUMENTBASE item = new DOCUMENTBASE();
		//			while(reader.Read())
		//			{
		//				item = new DOCUMENTBASE();
		//				if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
		//				if (reader[1] != DBNull.Value) { item.LastModifiedTime = Convert.ToDateTime(reader[1]); }
		//				if (reader[2] != DBNull.Value) { item.Name = Convert.ToString(reader[2]); }
		//				if (reader[3] != DBNull.Value) { item.Description = Convert.ToString(reader[3]); }
		//				if (reader[4] != DBNull.Value) { item.Category = Convert.ToInt32(reader[4]); }
		//				if (reader[5] != DBNull.Value) { item.OptimisticLockField = Convert.ToInt32(reader[5]); }
		//				if (reader[6] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[6]); }
		//				items.Add(item);
		//			}
		//		}
		//		catch (Exception ex)
		//		{
		//			Message = ex.Message;
		//		}
		//	}
		//	return items;
		//}

		public List<DOCUMENTBASE> GetData()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						items.Add(item);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}


		public List<DOCUMENTBASE> GetDataSideMenuAlarm()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID =10 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}


		public List<DOCUMENTBASE> GetDataSideMenuReport()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID =4   order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}


		public List<DOCUMENTBASE> GetDataSideMenuBadActor()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 9 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataSideMenuAlarmPrio()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 11 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataSideMenuAlarmCount()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 12 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataSideMenuAlarmDistribution()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 13 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataSideMenuStanding()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 14 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataSideMenuShelved()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 15 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}


		public List<DOCUMENTBASE> GetDataSideMenuTimeAlarm()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 5 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataSideMenuTimeAction()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 16 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}


		public List<DOCUMENTBASE> GetDataSideMenuKPITrends()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 8 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataAlarmPerformance()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID =7 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public List<DOCUMENTBASE> GetDataOperatorActiv()
		{
			List<DOCUMENTBASE> items = new List<DOCUMENTBASE>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand(" SELECT db.[OID] ,sm.[MENU_NAME] ,sm.[CONTROLLER_NAME] ,sm.[VIEW_NAME] ,db.Name  ,sm.[LINK] ,sm.[ISACTIVE]  ,db.ObjectType,sm.PARENT_ID,sm.PARENT_NAME FROM [DevExpressReportServer].[dbo].[SIDE_MENU] AS SM left join DocumentBase as db on db.OID = sm.OID_DOCUMENT_BASE WHERE sm.PARENT_ID = 18 order by ObjectType asc ", conn);
					SqlDataReader reader = command.ExecuteReader();
					DOCUMENTBASE item = new DOCUMENTBASE();
					while (reader.Read())
					{
						item = new DOCUMENTBASE();
						if (reader[0] != DBNull.Value) { item.OID = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.MENU_NAME = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.CONTROLLER_NAME = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.VIEW_NAME = Convert.ToString(reader[3]); }
						if (reader[4] != DBNull.Value) { item.Name = Convert.ToString(reader[4]); }
						if (reader[5] != DBNull.Value) { item.LINK = Convert.ToString(reader[5]); }
						if (reader[6] != DBNull.Value) { item.ISACTIVE = Convert.ToInt32(reader[6]); }
						if (reader[7] != DBNull.Value) { item.ObjectType = Convert.ToInt32(reader[7]); }
						if (reader[8] != DBNull.Value) { item.PARENT_ID = Convert.ToInt32(reader[8]); }
						if (reader[9] != DBNull.Value) { item.PARENT_NAME = Convert.ToString(reader[9]); }
						items.Add(item);
					}
				}

				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
			return items;
		}

		public DataTable GetDataTable(List<DOCUMENTBASE> documentbase)
		{
			DataTable dt = new DataTable("DOCUMENTBASE");

			DataColumn c1 = new DataColumn("OID", typeof(int)); c1.AllowDBNull = true;
			dt.Columns.Add(c1);
			DataColumn c2 = new DataColumn("LastModifiedTime", typeof(DateTime)); c2.AllowDBNull = true;
			dt.Columns.Add(c2);
			DataColumn c3 = new DataColumn("Name", typeof(string)); c3.AllowDBNull = true;
			dt.Columns.Add(c3);
			DataColumn c4 = new DataColumn("Description", typeof(string)); c4.AllowDBNull = true;
			dt.Columns.Add(c4);
			DataColumn c5 = new DataColumn("Category", typeof(int)); c5.AllowDBNull = true;
			dt.Columns.Add(c5);
			DataColumn c6 = new DataColumn("OptimisticLockField", typeof(int)); c6.AllowDBNull = true;
			dt.Columns.Add(c6);
			DataColumn c7 = new DataColumn("ObjectType", typeof(int)); c7.AllowDBNull = true;
			dt.Columns.Add(c7);

			foreach (DOCUMENTBASE v in documentbase)
			{
				DataRow dr = dt.NewRow();
				if (v.OID != null) { dr[0] = v.OID; } else { dr[0] = DBNull.Value; }
				if (v.LastModifiedTime != null) { dr[1] = v.LastModifiedTime; } else { dr[1] = DBNull.Value; }
				if (v.Name != null) { dr[2] = v.Name; } else { dr[2] = DBNull.Value; }
				if (v.Description != null) { dr[3] = v.Description; } else { dr[3] = DBNull.Value; }
				if (v.Category != null) { dr[4] = v.Category; } else { dr[4] = DBNull.Value; }
				if (v.OptimisticLockField != null) { dr[5] = v.OptimisticLockField; } else { dr[5] = DBNull.Value; }
				if (v.ObjectType != null) { dr[6] = v.ObjectType; } else { dr[6] = DBNull.Value; }
				dt.Rows.Add(dr);
			}
			dt.AcceptChanges();

			return dt;
		}

		public void AddManyBulk(List<DOCUMENTBASE> documentbase)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();

					DataTable dt = GetDataTable(documentbase);
					using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connString))
					{
						bulkCopy.DestinationTableName = dt.TableName;
						bulkCopy.WriteToServer(dt);
					}
				}
				catch (Exception ex)
				{
					Message = ex.Message;
				}
			}
		}

	}
}