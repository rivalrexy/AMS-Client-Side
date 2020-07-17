using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using ReportServerIntegration.Models;
using ReportServerIntegration.Repositories;

namespace ReportServerIntegration
{
	public class DOCUMENTBASEController : ApiController
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
		[HttpGet]
		public IQueryable<DOCUMENTBASE> Get()
		{
			DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
			List<DOCUMENTBASE> list = rep.GetData();
			return list.AsQueryable();
		}

	}
}