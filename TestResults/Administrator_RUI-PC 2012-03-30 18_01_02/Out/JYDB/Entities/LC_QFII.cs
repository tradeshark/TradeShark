using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_QFII
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public string ChiName { get; set; }
		public string EngName { get; set; }
		public string TrusteeBank { get; set; }
		public string TrusteeSecuCo { get; set; }
		public Nullable<System.DateTime> AuthorizedDate { get; set; }
		public Nullable<System.DateTime> FirstQuotaAuthorizedDate { get; set; }
		public Nullable<System.DateTime> AccountAuthorizedDate { get; set; }
		public Nullable<decimal> LatestQuota { get; set; }
		public string QuotaChangeRecord { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

