using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_InterBankIndices
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public int DataType { get; set; }
		public System.DateTime TradingDay { get; set; }
		public Nullable<decimal> IndexValue { get; set; }
		public Nullable<decimal> Duration1 { get; set; }
		public Nullable<decimal> Duration2 { get; set; }
		public Nullable<decimal> Convexity1 { get; set; }
		public Nullable<decimal> Convexity2 { get; set; }
		public Nullable<decimal> YTM { get; set; }
		public Nullable<decimal> TTM { get; set; }
		public Nullable<decimal> InterestPaymentRate { get; set; }
		public Nullable<decimal> TotalMarketValue { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

