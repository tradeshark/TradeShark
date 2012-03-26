using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_InstiFinancialStatus
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public string ChiName { get; set; }
		public System.DateTime EndDate { get; set; }
		public string IfAdjusted { get; set; }
		public string IfMerged { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> TotalAsset { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> NetAsset { get; set; }
		public Nullable<decimal> MainIncome { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

