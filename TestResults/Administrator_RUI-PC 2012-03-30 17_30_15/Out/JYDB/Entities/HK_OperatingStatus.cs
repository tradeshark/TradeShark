using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_OperatingStatus
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string Retrospection { get; set; }
		public string Prospect { get; set; }
		public string Others { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

