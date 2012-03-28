using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_FirstFiveOfRPAccount
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public int AcountType { get; set; }
		public string Debtor { get; set; }
		public Nullable<decimal> DebtSum { get; set; }
		public string DebtTime { get; set; }
		public string Reason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

