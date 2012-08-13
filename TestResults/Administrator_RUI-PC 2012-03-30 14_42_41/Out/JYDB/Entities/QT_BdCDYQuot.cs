using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_BdCDYQuot
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> TradingDay { get; set; }
		public Nullable<decimal> PrevClosePriceClean { get; set; }
		public Nullable<decimal> OpenPriceClean { get; set; }
		public Nullable<decimal> HighPriceClean { get; set; }
		public Nullable<decimal> LowPriceClean { get; set; }
		public Nullable<decimal> ClosePriceClean { get; set; }
		public Nullable<decimal> WtdAveragePriceClean { get; set; }
		public Nullable<decimal> PrevClosePriceDirty { get; set; }
		public Nullable<decimal> OpenPriceDirty { get; set; }
		public Nullable<decimal> HighPriceDirty { get; set; }
		public Nullable<decimal> LowPriceDirty { get; set; }
		public Nullable<decimal> ClosePriceDirty { get; set; }
		public Nullable<decimal> WtdAveragePriceDirty { get; set; }
		public Nullable<decimal> PrevCloseYTM { get; set; }
		public Nullable<decimal> OpenYTM { get; set; }
		public Nullable<decimal> HighYTM { get; set; }
		public Nullable<decimal> LowYTM { get; set; }
		public Nullable<decimal> CloseYTM { get; set; }
		public Nullable<decimal> YTMWtdAveragePriceDirty { get; set; }
		public Nullable<decimal> TurnoverVolume { get; set; }
		public Nullable<decimal> TurnoverValue { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

