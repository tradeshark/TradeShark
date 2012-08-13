using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_StockPortfolioChange
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public int ChangeType { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public int StockInnerCode { get; set; }
		public Nullable<decimal> AccumulatedTradeSum { get; set; }
		public Nullable<decimal> RatioInNVAtBegin { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

