using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_PayBebtSummary
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> EventType { get; set; }
		public Nullable<decimal> PeriodBeginOccupySum { get; set; }
		public Nullable<decimal> PeriodEndOccupySum { get; set; }
		public Nullable<decimal> ThisPeriodPayBebtSum { get; set; }
		public string PayBebtStatement { get; set; }
		public Nullable<int> AnnouncementType { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

