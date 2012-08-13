using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_FundTradeInfo
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> BuyingCost { get; set; }
		public Nullable<decimal> SellingIncome { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

