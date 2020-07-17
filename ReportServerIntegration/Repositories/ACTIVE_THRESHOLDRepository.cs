using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ReportServerIntegration.Models;

namespace ReportServerIntegration.Repositories
{
	public partial class ACTIVE_THRESHOLDRepository
	{
		private string connString;
		public string Message { get; set; }

		public ACTIVE_THRESHOLDRepository(string connectionString)
		{
			connString = connectionString;
		}

		public List<ACTIVE_THRESHOLD> GetData()
		{
			List<ACTIVE_THRESHOLD> items = new List<ACTIVE_THRESHOLD>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [active_code_id] FROM active_threshold", conn);
					SqlDataReader reader = command.ExecuteReader();
					ACTIVE_THRESHOLD item = new ACTIVE_THRESHOLD();
					while(reader.Read())
					{
						item = new ACTIVE_THRESHOLD();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.active_code_id = Convert.ToString(reader[1]); }
						
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

		

	}
}