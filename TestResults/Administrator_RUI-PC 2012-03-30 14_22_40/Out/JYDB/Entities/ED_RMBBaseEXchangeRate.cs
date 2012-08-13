using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_RMBBaseEXchangeRate
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public int DataReportPeriod { get; set; }
		public int Currency { get; set; }
		public Nullable<decimal> PeriodBegPrice { get; set; }
		public Nullable<decimal> PeriodEndPrice { get; set; }
		public Nullable<decimal> HighestPrice { get; set; }
		public Nullable<decimal> LowestPrice { get; set; }
		public Nullable<decimal> AveragePrice { get; set; }
		public Nullable<decimal> AccmdAvgPrice { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

