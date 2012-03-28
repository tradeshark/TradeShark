using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Announcement
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string Media { get; set; }
		public int Category { get; set; }
		public string InfoTitle { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string SubTitle { get; set; }
		public string Content { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
	}
}

