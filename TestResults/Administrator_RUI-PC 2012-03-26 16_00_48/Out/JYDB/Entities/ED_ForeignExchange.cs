using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_ForeignExchange
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> TradeCode { get; set; }
		public Nullable<int> CurrencyBefore { get; set; }
		public Nullable<int> CurrencyAfter { get; set; }
		public Nullable<int> UnitCurrencyBefore { get; set; }
		public Nullable<int> ValueDate { get; set; }
		public Nullable<decimal> OpenPrice { get; set; }
		public Nullable<decimal> ClosePrice { get; set; }
		public Nullable<decimal> WeightedAvgClosePrice { get; set; }
		public Nullable<decimal> BidPrice { get; set; }
		public Nullable<decimal> AskPrice { get; set; }
		public Nullable<decimal> HighPrice { get; set; }
		public Nullable<decimal> LowPrice { get; set; }
		public Nullable<decimal> PrevClosePrice { get; set; }
		public Nullable<decimal> PrevWeightedAvgClosePrice { get; set; }
		public Nullable<decimal> TradingVolume { get; set; }
		public Nullable<decimal> TradingVolumeGrowth { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

