using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_HG_HBGY_YD
	{
		public string N_ReportArea { get; set; }
		public string N_Country { get; set; }
		public string N_Province { get; set; }
		public string N_ReportPeriod { get; set; }
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int ReportArea { get; set; }
		public Nullable<int> Country { get; set; }
		public Nullable<int> Province { get; set; }
		public System.DateTime EndDate { get; set; }
		public int ReportPeriod { get; set; }
		public Nullable<decimal> BroadMoney { get; set; }
		public Nullable<decimal> NarrowMoney { get; set; }
		public Nullable<decimal> CashCirculation { get; set; }
		public Nullable<decimal> NetAmountCash { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

