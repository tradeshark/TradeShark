using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MT_TradingStat
	{
		public long ID { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime TradingDay { get; set; }
		public int SecuMarket { get; set; }
		public int ReportPeriod { get; set; }
		public Nullable<decimal> FinanceValue { get; set; }
		public Nullable<decimal> FinanceBuyValue { get; set; }
		public Nullable<decimal> FinanceRefundValue { get; set; }
		public Nullable<decimal> SecurityValue { get; set; }
		public Nullable<decimal> SecuritySellVolume { get; set; }
		public Nullable<decimal> TradingValue { get; set; }
		public Nullable<decimal> FinaInTVRatio { get; set; }
		public Nullable<decimal> TVChangeRatio { get; set; }
		public Nullable<decimal> TVChangeRatioHS { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

