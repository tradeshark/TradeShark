using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MT_TargetSecurities
	{
		public long ID { get; set; }
		public Nullable<int> SecuMarket { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InDate { get; set; }
		public Nullable<System.DateTime> OutDate { get; set; }
		public int TargetCategory { get; set; }
		public Nullable<int> TargetFlag { get; set; }
		public string ChangeReasonDesc { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

