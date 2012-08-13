using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_UsualIndex
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime TradingDay { get; set; }
		public Nullable<decimal> ClosePriceDt { get; set; }
		public Nullable<decimal> AccruedInterest { get; set; }
		public Nullable<double> YTM { get; set; }
		public Nullable<double> Duration { get; set; }
		public Nullable<double> Duration2 { get; set; }
		public Nullable<double> Convexity { get; set; }
		public Nullable<int> RemainPaymentNum { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

