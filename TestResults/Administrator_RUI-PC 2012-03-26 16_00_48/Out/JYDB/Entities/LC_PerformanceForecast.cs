using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_PerformanceForecast
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> ForcastType { get; set; }
		public Nullable<int> ForcastReason { get; set; }
		public string ResultStatement { get; set; }
		public string ForcastContent { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> EGrowthRateFloor { get; set; }
		public Nullable<decimal> EGrowthRateCeiling { get; set; }
		public Nullable<decimal> EEarningFloor { get; set; }
		public Nullable<decimal> EEarningCeiling { get; set; }
		public Nullable<decimal> EProfitFloor { get; set; }
		public Nullable<decimal> EProfitCeiling { get; set; }
		public Nullable<decimal> EEPSFloor { get; set; }
		public Nullable<decimal> EEPSCeiling { get; set; }
		public Nullable<int> ForecastObject { get; set; }
		public Nullable<decimal> NPYOYConsistentForecast { get; set; }
	}
}

