using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_JJ_SharesSplit
	{
		public string N_InfoType { get; set; }
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> InfoType { get; set; }
		public Nullable<System.DateTime> SplitDay { get; set; }
		public Nullable<decimal> SplitRatio { get; set; }
		public Nullable<System.DateTime> OutcomeNoticeIssueDate { get; set; }
		public Nullable<System.DateTime> ChangeRegDate { get; set; }
		public Nullable<decimal> NV { get; set; }
		public Nullable<decimal> SharesBefore { get; set; }
		public Nullable<decimal> SharesAfter { get; set; }
		public Nullable<decimal> UnitNVBefore { get; set; }
		public Nullable<decimal> UnitNVAfter { get; set; }
		public Nullable<decimal> AccumulatedUnitNVBefore { get; set; }
		public Nullable<decimal> AccumulatedUnitNVAfter { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

