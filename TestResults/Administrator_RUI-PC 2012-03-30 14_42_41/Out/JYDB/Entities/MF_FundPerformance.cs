using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_FundPerformance
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> NetIncome { get; set; }
		public Nullable<decimal> NetIncomePerShare { get; set; }
		public int StatisticRange { get; set; }
		public Nullable<decimal> GrowthRateOfNetValue { get; set; }
		public Nullable<decimal> StandardDeviationOfGRONV { get; set; }
		public Nullable<decimal> GrowthRateOfBenchmark { get; set; }
		public Nullable<decimal> StandardDeviationOfGROB { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

