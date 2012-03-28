using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_GoldTradeMarket
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> TradeDate { get; set; }
		public string InfoSource { get; set; }
		public string DateType { get; set; }
		public string TradeVariety { get; set; }
		public Nullable<decimal> OpenPrice { get; set; }
		public Nullable<decimal> ClosePrice { get; set; }
		public Nullable<decimal> HighPrice { get; set; }
		public Nullable<decimal> LowPrice { get; set; }
		public Nullable<decimal> Change { get; set; }
		public Nullable<decimal> ChangePCT { get; set; }
		public Nullable<decimal> PriceWeighted { get; set; }
		public Nullable<decimal> TurnVol { get; set; }
		public Nullable<decimal> TurnValue { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

