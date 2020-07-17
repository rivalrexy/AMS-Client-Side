using System;
using System.Collections.Generic;

namespace ReportServerIntegration.Models
{
	public partial class METRIC_THRESHOLD
	{
		public virtual int? id { get; set; }
		public virtual string code_id { get; set; }
		public virtual string metric_name { get; set; }
		public virtual int? threshold { get; set; }

		public METRIC_THRESHOLD()
		{

		}
	}
}