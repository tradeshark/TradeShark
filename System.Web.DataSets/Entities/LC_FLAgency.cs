using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_FLAgency
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public Nullable<int> IfPassed { get; set; }
		public Nullable<int> AgencyType { get; set; }
		public string NameChangeD { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

