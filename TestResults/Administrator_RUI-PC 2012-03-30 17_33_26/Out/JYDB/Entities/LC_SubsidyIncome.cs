using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_SubsidyIncome
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> TaxReduExemRefund { get; set; }
		public Nullable<decimal> TaxReduExemRefund_VAT { get; set; }
		public Nullable<decimal> TaxReduExemRefund_IT { get; set; }
		public Nullable<decimal> TaxReduExemRefund_BT { get; set; }
		public Nullable<decimal> FiscalInterestSubsidy { get; set; }
		public Nullable<decimal> ExportSubsidy { get; set; }
		public Nullable<decimal> ExportRebate { get; set; }
		public Nullable<decimal> ExportInterestSubsidy { get; set; }
		public Nullable<decimal> Compensation { get; set; }
		public Nullable<decimal> TechSubsidyAndSupportFund { get; set; }
		public Nullable<decimal> SurpportFund { get; set; }
		public Nullable<decimal> TechSubsidy { get; set; }
		public Nullable<decimal> FiscalSubsidy { get; set; }
		public Nullable<decimal> OtherSubsidy { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

