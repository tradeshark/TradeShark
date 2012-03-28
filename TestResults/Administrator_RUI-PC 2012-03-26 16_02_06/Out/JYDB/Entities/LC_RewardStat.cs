using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_RewardStat
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> TotalYearPay { get; set; }
		public Nullable<int> NumPayManagers { get; set; }
		public Nullable<decimal> High3Directors { get; set; }
		public Nullable<decimal> High3Managers { get; set; }
		public Nullable<decimal> TotalIndeSupeYearPay { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> TotalIndeSubsidy { get; set; }
	}
}

