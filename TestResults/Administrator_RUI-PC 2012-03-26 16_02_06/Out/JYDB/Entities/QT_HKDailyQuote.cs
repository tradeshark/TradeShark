using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_HKDailyQuote
	{
		public long ID { get; set; }
		public System.DateTime TradingDay { get; set; }
		public int InnerCode { get; set; }
		public Nullable<decimal> ClosePrice { get; set; }
		public Nullable<decimal> HighPrice { get; set; }
		public Nullable<decimal> LowPrice { get; set; }
		public Nullable<decimal> TurnoverValue { get; set; }
		public Nullable<decimal> TurnoverVolume { get; set; }
		public Nullable<int> Lot { get; set; }
		public Nullable<decimal> OpenPrice { get; set; }
		public Nullable<double> Change { get; set; }
		public Nullable<decimal> PrevClosePrice { get; set; }
		public Nullable<decimal> PERatio { get; set; }
		public Nullable<decimal> DividendYield { get; set; }
		public Nullable<decimal> BidVolume { get; set; }
		public Nullable<decimal> AskVolume { get; set; }
		public Nullable<decimal> BidPrice { get; set; }
		public Nullable<decimal> AskPrice { get; set; }
		public Nullable<double> ChangePCT { get; set; }
		public string Currency { get; set; }
		public Nullable<decimal> SMA10 { get; set; }
		public Nullable<decimal> SMA20 { get; set; }
		public Nullable<decimal> SMA50 { get; set; }
		public Nullable<decimal> SMA250 { get; set; }
		public Nullable<decimal> AnnualHigh { get; set; }
		public Nullable<decimal> AnnualLow { get; set; }
		public Nullable<decimal> MonthHigh { get; set; }
		public Nullable<decimal> MonthLow { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

