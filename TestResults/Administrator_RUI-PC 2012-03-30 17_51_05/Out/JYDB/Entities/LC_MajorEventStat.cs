using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_MajorEventStat
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public int EventType { get; set; }
		public int Subitem { get; set; }
		public Nullable<int> Unit { get; set; }
		public decimal Data { get; set; }
		public string Note { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

