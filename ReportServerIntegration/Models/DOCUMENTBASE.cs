using System;
using System.Collections.Generic;

namespace ReportServerIntegration.Models
{
	public partial class DOCUMENTBASE
	{
		public virtual int? OID { get; set; }

		public virtual int?  OID_DOCUMENT_BASE { get; set; }
		public virtual DateTime? LastModifiedTime { get; set; }
		public virtual string Name { get; set; }
		public virtual string Description { get; set; }
		public virtual int? Category { get; set; }
		public virtual int? OptimisticLockField { get; set; }
		public virtual int? ObjectType { get; set; }


		public virtual string LINK_NAME { get; set; }
		public virtual string LINK { get; set; }

		public virtual string MENU_NAME { get; set; }

		public virtual string CONTROLLER_NAME { get; set; }

		public virtual string VIEW_NAME { get; set; }

		public virtual int?  ISACTIVE { get; set; }

		public virtual int?  PARENT_ID { get; set; }

		public virtual string  PARENT_NAME { get; set; }

		public DOCUMENTBASE()
		{

		}
	}
}