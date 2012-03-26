using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_ShortTermLoans
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> CreditLoan { get; set; }
		public Nullable<decimal> SecuredLoan { get; set; }
		public Nullable<decimal> GuaranteedLoan { get; set; }
		public Nullable<decimal> PledgedLoan { get; set; }
		public Nullable<decimal> OtherLoan { get; set; }
		public Nullable<decimal> OverdueLoan { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

