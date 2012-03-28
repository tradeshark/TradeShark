using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_WarrantDetails
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<int> InvestType { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public Nullable<int> WarrantInnerCode { get; set; }
		public Nullable<decimal> SharesHolding { get; set; }
		public Nullable<decimal> MarketValue { get; set; }
		public Nullable<decimal> RatioInNV { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

