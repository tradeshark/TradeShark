using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_ShareStru
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> ParValueUnitComShare { get; set; }
		public Nullable<decimal> ParValueComShare { get; set; }
		public Nullable<int> ParValueUnitPreShare { get; set; }
		public Nullable<decimal> ParValuePreShare { get; set; }
		public Nullable<decimal> AuthorizedCapitalComShare { get; set; }
		public Nullable<decimal> AuthorizedSharesComShare { get; set; }
		public Nullable<decimal> PaidUpCapitalComShare { get; set; }
		public Nullable<decimal> PaidUpSharesComShare { get; set; }
		public Nullable<decimal> ListedShares { get; set; }
		public Nullable<decimal> UnlistedShares { get; set; }
		public Nullable<decimal> NotHKShares { get; set; }
		public Nullable<decimal> AuthorizedCapitalPreShare { get; set; }
		public Nullable<decimal> AuthorizedSharesPreShare { get; set; }
		public Nullable<decimal> PaidUpCapitalPreShare { get; set; }
		public Nullable<decimal> PaidUpSharesPreShare { get; set; }
		public Nullable<decimal> AuthorizedCapitalTotal { get; set; }
		public Nullable<decimal> AuthorizedSharesTotal { get; set; }
		public Nullable<decimal> PaidUpCapitalTotal { get; set; }
		public Nullable<decimal> PaidUpSharesTotal { get; set; }
		public Nullable<decimal> PaidUpSharesChgComShare { get; set; }
		public Nullable<decimal> PaidUpSharesChgPreShare { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public string ChangeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

