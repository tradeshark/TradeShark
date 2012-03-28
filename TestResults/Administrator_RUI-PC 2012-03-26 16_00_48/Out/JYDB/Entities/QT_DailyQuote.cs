using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.JYDB.Entities
{
    [Serializable]
	public class QT_DailyQuote
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime TradingDay { get; set; }
		public Nullable<decimal> PrevClosePrice { get; set; }
		public Nullable<decimal> OpenPrice { get; set; }
		public Nullable<decimal> HighPrice { get; set; }
		public Nullable<decimal> LowPrice { get; set; }
		public Nullable<decimal> ClosePrice { get; set; }
		public Nullable<decimal> TurnoverVolume { get; set; }
		public Nullable<decimal> TurnoverValue { get; set; }
		public Nullable<int> TurnoverDeals { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

