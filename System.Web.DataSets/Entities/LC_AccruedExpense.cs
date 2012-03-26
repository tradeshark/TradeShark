using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_AccruedExpense
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> AccruedInterest { get; set; }
		public Nullable<decimal> AccruedLeaseFee { get; set; }
		public Nullable<decimal> AccruedPowerFee { get; set; }
		public Nullable<decimal> AccruedRepairmentFee { get; set; }
		public Nullable<decimal> AccruedAdFee { get; set; }
		public Nullable<decimal> AccruedTLSFee { get; set; }
		public Nullable<decimal> AccruedProcessFee { get; set; }
		public Nullable<decimal> AccruedResearchFee { get; set; }
		public Nullable<decimal> AccruedOtherFees { get; set; }
		public Nullable<decimal> WageWelfare { get; set; }
		public Nullable<decimal> InsuranceAndPension { get; set; }
		public Nullable<decimal> GovernmentTaxAndFee { get; set; }
		public Nullable<decimal> AgentFee { get; set; }
		public Nullable<decimal> SaleFee { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

