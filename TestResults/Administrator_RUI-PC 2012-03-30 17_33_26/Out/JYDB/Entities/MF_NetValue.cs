using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_NetValue
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> NV { get; set; }
		public Nullable<decimal> UnitNV { get; set; }
		public Nullable<decimal> AccumulatedUnitNV { get; set; }
		public Nullable<decimal> DailyProfit { get; set; }
		public Nullable<decimal> LatestWeeklyYield { get; set; }
		public Nullable<decimal> NVDailyGrowthRate { get; set; }
		public Nullable<decimal> NVWeeklyGrowthRate { get; set; }
		public Nullable<decimal> DiscountRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

