using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_OperatingStatus
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string OperatingStatement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

