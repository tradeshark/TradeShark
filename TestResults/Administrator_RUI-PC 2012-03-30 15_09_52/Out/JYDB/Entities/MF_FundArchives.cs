using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_FundArchives
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> EstablishmentDate { get; set; }
		public Nullable<System.DateTime> ListedDate { get; set; }
		public Nullable<decimal> Duration { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> ExpireDate { get; set; }
		public string Manager { get; set; }
		public Nullable<int> InvestAdvisorCode { get; set; }
		public Nullable<int> TrusteeCode { get; set; }
		public string Warrantor { get; set; }
		public Nullable<int> Type { get; set; }
		public Nullable<int> InvestmentType { get; set; }
		public Nullable<int> InvestStyle { get; set; }
		public Nullable<decimal> FoundedSize { get; set; }
		public string InvestOrientation { get; set; }
		public string InvestTarget { get; set; }
		public string PerformanceBenchMark { get; set; }
		public string ProfitDistributionRule { get; set; }
		public string InvestField { get; set; }
		public string BriefIntro { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public string ApplyingCodeFront { get; set; }
		public string ApplyingCodeBack { get; set; }
		public Nullable<decimal> GuaranteedPeriod { get; set; }
		public string RiskReturncharacter { get; set; }
		public string LowestSumSubscribing { get; set; }
		public Nullable<int> LowestSumRedemption { get; set; }
		public string LSFRDescription { get; set; }
		public Nullable<int> LowestSumForHolding { get; set; }
		public string LSFHDescription { get; set; }
		public Nullable<int> FundNature { get; set; }
		public Nullable<int> FundTypeCode { get; set; }
		public string FundType { get; set; }
		public Nullable<int> CarryOverDate { get; set; }
		public string CarryOverDateRemark { get; set; }
		public Nullable<int> CarryOverType { get; set; }
	}
}

