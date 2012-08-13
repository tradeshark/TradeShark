using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MT_TradingDetail
	{
		public long ID { get; set; }
		public string InfoSource { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime TradingDay { get; set; }
		public Nullable<int> SecuMarket { get; set; }
		public Nullable<decimal> FinanceValue { get; set; }
		public Nullable<decimal> FinanceBuyValue { get; set; }
		public Nullable<decimal> FinanceRefundValue { get; set; }
		public Nullable<decimal> SecurityVolume { get; set; }
		public Nullable<decimal> SecuritySellVolume { get; set; }
		public Nullable<decimal> SecurityRefundVolume { get; set; }
		public Nullable<decimal> SecurityValue { get; set; }
		public Nullable<decimal> TradingValue { get; set; }
		public Nullable<decimal> FinaInTotalRatio { get; set; }
		public Nullable<decimal> SecuInTotalRatio { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

