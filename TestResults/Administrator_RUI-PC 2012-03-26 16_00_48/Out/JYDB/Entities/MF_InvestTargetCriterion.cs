using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_InvestTargetCriterion
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string IfExecuted { get; set; }
		public Nullable<System.DateTime> CancelDate { get; set; }
		public string InvestTarget { get; set; }
		public Nullable<int> TracedIndexCode { get; set; }
		public Nullable<decimal> TopInvestRatio { get; set; }
		public Nullable<decimal> MinimumInvestRatio { get; set; }
		public string InvestRatioBenchmark { get; set; }
		public string Notes { get; set; }
		public string InvestRatioDescription { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> ExecuteDate { get; set; }
	}
}

