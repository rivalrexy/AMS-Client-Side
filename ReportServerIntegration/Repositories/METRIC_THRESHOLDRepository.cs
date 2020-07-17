using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ReportServerIntegration.Models;

namespace ReportServerIntegration.Repositories
{
	public partial class METRIC_THRESHOLDRepository
	{
		private string connString;
		public string Message { get; set; }

		public METRIC_THRESHOLDRepository(string connectionString)
		{
			connString = connectionString;
		}

		public List<METRIC_THRESHOLD> GetData()
		{
			List<METRIC_THRESHOLD> items = new List<METRIC_THRESHOLD>();
			using (var conn = new SqlConnection(connString))
			{
				Message = "";
				try
				{
					conn.Open();
					SqlCommand command = new SqlCommand("SELECT [id], [code_id], [metric_name], [threshold] FROM metric_threshold", conn);
					SqlDataReader reader = command.ExecuteReader();
					METRIC_THRESHOLD item = new METRIC_THRESHOLD();
					while(reader.Read())
					{
						item = new METRIC_THRESHOLD();
						if (reader[0] != DBNull.Value) { item.id = Convert.ToInt32(reader[0]); }
						if (reader[1] != DBNull.Value) { item.code_id = Convert.ToString(reader[1]); }
						if (reader[2] != DBNull.Value) { item.metric_name = Convert.ToString(reader[2]); }
						if (reader[3] != DBNull.Value) { item.threshold = Convert.ToInt32(reader[3]); }
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

		public DataTable GetDataTable(List<METRIC_THRESHOLD> metric_threshold)
		{
			DataTable dt = new DataTable("METRIC_THRESHOLD");

			DataColumn c1 = new DataColumn("id", typeof(int)); c1.AllowDBNull = true;
			dt.Columns.Add(c1);
			DataColumn c2 = new DataColumn("code_id", typeof(string)); c2.AllowDBNull = true;
			dt.Columns.Add(c2);
			DataColumn c3 = new DataColumn("metric_name", typeof(string)); c3.AllowDBNull = true;
			dt.Columns.Add(c3);
			DataColumn c4 = new DataColumn("threshold", typeof(int)); c4.AllowDBNull = true;
			dt.Columns.Add(c4);

			foreach (METRIC_THRESHOLD v in metric_threshold)
			{
				DataRow dr = dt.NewRow();
				if (v.id != null) { dr[0] = v.id; } else { dr[0] = DBNull.Value; }
				if (v.code_id != null) { dr[1] = v.code_id; } else { dr[1] = DBNull.Value; }
				if (v.metric_name != null) { dr[2] = v.metric_name; } else { dr[2] = DBNull.Value; }
				if (v.threshold != null) { dr[3] = v.threshold; } else { dr[3] = DBNull.Value; }
				dt.Rows.Add(dr);
			}
			dt.AcceptChanges();

			return dt;
		}

		public void AddManyBulk(List<METRIC_THRESHOLD> metric_threshold)
		{
			using (var conn = new SqlConnection(connString))
			{
				try
				{
					Message = "";
					conn.Open();

					DataTable dt = GetDataTable(metric_threshold);
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