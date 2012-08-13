using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Business
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public string IfPassed { get; set; }
		public string BusinessMajor { get; set; }
		public string BusinessMinor { get; set; }
		public string MainBusiness { get; set; }
		public string MainName { get; set; }
		public string CSRCInduCategory { get; set; }
		public string InduEngaged { get; set; }
		public string ChangeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

