using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_ExchangeRateRMBtoUSD
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public int DataReportPeriod { get; set; }
		public int Currency { get; set; }
		public Nullable<decimal> ExchangeRatetoUSDollar { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

