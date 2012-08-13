using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ExgIndustry
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int Standard { get; set; }
		public Nullable<int> Industry { get; set; }
		public int IfPerformed { get; set; }
		public Nullable<System.DateTime> CancelDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public string FirstIndustryCode { get; set; }
		public string FirstIndustryName { get; set; }
		public string SecondIndustryCode { get; set; }
		public string SecondIndustryName { get; set; }
		public string ThirdIndustryCode { get; set; }
		public string ThirdIndustryName { get; set; }
	}
}

