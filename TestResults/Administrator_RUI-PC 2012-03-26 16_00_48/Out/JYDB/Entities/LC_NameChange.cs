using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_NameChange
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public Nullable<int> IfPassed { get; set; }
		public Nullable<System.DateTime> ChangeDate { get; set; }
		public string ChiName { get; set; }
		public string ChiNameAbbr { get; set; }
		public string EngName { get; set; }
		public string EngNameAbbr { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

