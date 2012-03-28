using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ListStatus
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> ChangeDate { get; set; }
		public Nullable<int> SecuMarket { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public Nullable<int> ChangeReason { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> LargeApplyingMax { get; set; }
	}
}

