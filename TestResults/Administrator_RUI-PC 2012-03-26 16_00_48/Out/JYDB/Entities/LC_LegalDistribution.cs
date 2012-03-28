using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_LegalDistribution
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public decimal DistributionSum { get; set; }
		public Nullable<int> DistributionReason { get; set; }
		public Nullable<int> SerialNum { get; set; }
		public string AquirerName { get; set; }
		public Nullable<int> AquirerCharacter { get; set; }
		public Nullable<int> SecuCoBelongedCode { get; set; }
		public string SecuCoBelonged { get; set; }
		public Nullable<int> SecuCode { get; set; }
		public decimal AquiredSum { get; set; }
		public Nullable<int> OwnedPeriod { get; set; }
		public Nullable<int> DistributeNature { get; set; }
		public Nullable<System.DateTime> FloatDate { get; set; }
		public string Notes { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> IssuePrice { get; set; }
		public Nullable<decimal> ValidApplyVol { get; set; }
		public Nullable<decimal> RefundAmount { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
	}
}

