using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ShareFP
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> TypeSelect { get; set; }
		public string FPSHName { get; set; }
		public string ReceiverName { get; set; }
		public Nullable<decimal> InvolvedSum { get; set; }
		public Nullable<decimal> PCTOfPledger { get; set; }
		public Nullable<decimal> PCTOfTotalShares { get; set; }
		public string FPReason { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> SHSN { get; set; }
	}
}

