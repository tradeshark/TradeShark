using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_CentralBankSpotTrading
	{
		public long ID { get; set; }
		public System.DateTime TradingDay { get; set; }
		public int InnerCode { get; set; }
		public Nullable<int> SpotTradingType { get; set; }
		public Nullable<int> SpotTradingMethod { get; set; }
		public Nullable<decimal> TenderSize { get; set; }
		public Nullable<decimal> TenderPrice { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

