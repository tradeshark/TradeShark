using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_StockPortfolioDetail
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public int InvestType { get; set; }
		public int SerialNumber { get; set; }
		public int StockInnerCode { get; set; }
		public Nullable<decimal> SharesHolding { get; set; }
		public Nullable<decimal> MarketValue { get; set; }
		public Nullable<decimal> RatioInNV { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

