using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_SecuChange
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public Nullable<int> IfPassed { get; set; }
		public Nullable<System.DateTime> ChangeDate { get; set; }
		public string SecurityAbbr { get; set; }
		public string ChiSpelling { get; set; }
		public Nullable<int> ChangeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

