using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_MMBenchmarkRate
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> OriginalDataName { get; set; }
		public Nullable<int> DataProcessingMethod { get; set; }
		public Nullable<int> IndicatorName { get; set; }
		public Nullable<decimal> Indicator { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

