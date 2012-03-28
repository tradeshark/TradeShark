using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_NVChange
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<decimal> NVAtBegin { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> UnrealizedProfitChange { get; set; }
		public Nullable<decimal> NVChangeDueToOperating { get; set; }
		public Nullable<decimal> ApplyingMoney { get; set; }
		public Nullable<decimal> RedemptionMoney { get; set; }
		public Nullable<decimal> NVChangeDueToUnitTrade { get; set; }
		public Nullable<decimal> DistributedProfit { get; set; }
		public Nullable<decimal> NVAtEnd { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> PriorYearProfitAdjust { get; set; }
	}
}

