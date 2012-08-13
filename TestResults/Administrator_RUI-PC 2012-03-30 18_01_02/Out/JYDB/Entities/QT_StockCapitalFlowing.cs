using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_StockCapitalFlowing
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime TradingDay { get; set; }
		public long BuyVolume0_1 { get; set; }
		public long SaleVolume0_1 { get; set; }
		public decimal BuyValue0_1 { get; set; }
		public decimal SaleValue0_1 { get; set; }
		public long BuyVolume1_5 { get; set; }
		public long SaleVolume1_5 { get; set; }
		public decimal BuyValue1_5 { get; set; }
		public decimal SaleValue1_5 { get; set; }
		public long BuyVolume5_10 { get; set; }
		public long SaleVolume5_10 { get; set; }
		public decimal BuyValue5_10 { get; set; }
		public decimal SaleValue5_10 { get; set; }
		public long BuyVolume10_N { get; set; }
		public long SaleVolume10_N { get; set; }
		public decimal BuyValue10_N { get; set; }
		public decimal SaleValue10_N { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

