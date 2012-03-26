using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class BD_ConIndicatorD
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime TradingDay { get; set; }
		public Nullable<decimal> ClosePriceCon { get; set; }
		public Nullable<decimal> ActualConvPrice { get; set; }
		public Nullable<decimal> ConvValue { get; set; }
		public Nullable<decimal> ConvPremiumRate { get; set; }
		public Nullable<decimal> ConvParity { get; set; }
		public Nullable<decimal> DeltaStkPr { get; set; }
		public Nullable<decimal> CallTriggerPrice { get; set; }
		public Nullable<decimal> PutTriggerPrice { get; set; }
		public Nullable<int> TradeCodeStk { get; set; }
		public Nullable<int> InnerCodeStk { get; set; }
		public Nullable<decimal> ClosePriceStk { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

