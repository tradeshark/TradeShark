using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_CentralBankRepo
	{
		public long ID { get; set; }
		public System.DateTime TradingDay { get; set; }
		public int RepurchaseVariety { get; set; }
		public Nullable<int> RepurchaseType { get; set; }
		public Nullable<int> RepurchaseMethod { get; set; }
		public Nullable<int> RepurchaseDays { get; set; }
		public Nullable<decimal> TenderRate { get; set; }
		public Nullable<decimal> TenderSize { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

