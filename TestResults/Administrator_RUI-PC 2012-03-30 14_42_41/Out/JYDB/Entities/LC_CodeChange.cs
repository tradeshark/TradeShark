using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_CodeChange
	{
		public long ID { get; set; }
		public string SecuCode { get; set; }
		public Nullable<int> SecuMarket { get; set; }
		public Nullable<int> CodeDefine { get; set; }
		public int InnerCode { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> BeginDate { get; set; }
		public Nullable<System.DateTime> StopDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

