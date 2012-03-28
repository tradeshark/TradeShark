using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_BOCForexQuote
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> StatPeriodCode { get; set; }
		public Nullable<int> CurrencyCode { get; set; }
		public Nullable<decimal> BidPriceSpot { get; set; }
		public Nullable<decimal> BidPriceCurrency { get; set; }
		public Nullable<decimal> AskedPriceSpot { get; set; }
		public Nullable<decimal> BenchMarkPrice { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

