using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_NewestShareStru
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> NonListedShares { get; set; }
		public Nullable<decimal> PromoterShares { get; set; }
		public Nullable<decimal> StateShares { get; set; }
		public Nullable<decimal> DLegalPersonShares { get; set; }
		public Nullable<decimal> FLegalPersonShares { get; set; }
		public Nullable<decimal> OtherPromoterShares { get; set; }
		public Nullable<decimal> RaisedLPShares { get; set; }
		public Nullable<decimal> NaturalPersonHoldLPShares { get; set; }
		public Nullable<decimal> StaffShares { get; set; }
		public Nullable<decimal> RightsIssueTransferred { get; set; }
		public Nullable<decimal> PreferredAndOtherShares { get; set; }
		public Nullable<decimal> PreferredShares { get; set; }
		public Nullable<decimal> FloatShare { get; set; }
		public Nullable<decimal> AFloats { get; set; }
		public Nullable<decimal> AFloatListed { get; set; }
		public Nullable<decimal> ManagementShares { get; set; }
		public Nullable<decimal> StategicInvestorShares { get; set; }
		public Nullable<decimal> CommonLPShares { get; set; }
		public Nullable<decimal> MutualFundShares { get; set; }
		public Nullable<decimal> AdditionalIssueUnlisted { get; set; }
		public Nullable<decimal> RightsIssueUnlisted { get; set; }
		public Nullable<decimal> Bshares { get; set; }
		public Nullable<decimal> Hshares { get; set; }
		public Nullable<decimal> Sshares { get; set; }
		public Nullable<decimal> Nshares { get; set; }
		public Nullable<decimal> OtherFloatShares { get; set; }
		public Nullable<decimal> TotalShares { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public string ChangeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> SLegalPersonShares { get; set; }
		public Nullable<decimal> RaisedSLPShares { get; set; }
		public Nullable<decimal> OtherAFloatShares { get; set; }
		public Nullable<decimal> RestrictedAFloatShares { get; set; }
		public Nullable<decimal> RestrinctStaffShares { get; set; }
		public Nullable<decimal> NonListedBShares { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public Nullable<decimal> RestrictedShares { get; set; }
		public Nullable<decimal> StateHolding { get; set; }
		public Nullable<decimal> SLegalPersonHolding { get; set; }
		public Nullable<decimal> OtherDCapitalHolding { get; set; }
		public Nullable<decimal> DLegalPersonHolding { get; set; }
		public Nullable<decimal> DNaturalPersonHolding { get; set; }
		public Nullable<decimal> ForeignHolding { get; set; }
		public Nullable<decimal> FLegalPersonHolding { get; set; }
		public Nullable<decimal> FNaturalPersonHolding { get; set; }
		public Nullable<decimal> OtherRestrictedShares { get; set; }
		public Nullable<decimal> RestrictedBFloatShares { get; set; }
		public Nullable<decimal> PerValue { get; set; }
		public Nullable<decimal> Rpt_RestrictedShares { get; set; }
		public Nullable<decimal> Rpt_StateHolding { get; set; }
		public Nullable<decimal> Rpt_SLegalPersonHolding { get; set; }
		public Nullable<decimal> Rpt_OtherDCapitalHolding { get; set; }
		public Nullable<decimal> Rpt_DLegalPersonHolding { get; set; }
		public Nullable<decimal> Rpt_DNaturalPersonHolding { get; set; }
		public Nullable<decimal> Rpt_ForeignHolding { get; set; }
		public Nullable<decimal> Rpt_FLegalPersonHolding { get; set; }
		public Nullable<decimal> Rpt_FNaturalPersonHolding { get; set; }
		public Nullable<decimal> Rpt_FloatListed { get; set; }
		public Nullable<decimal> Rpt_AFloatListed { get; set; }
		public Nullable<decimal> Rpt_BFloatListed { get; set; }
		public Nullable<decimal> Rpt_FFloatListed { get; set; }
		public Nullable<decimal> Rpt_OtherFloatShares { get; set; }
		public Nullable<decimal> Rpt_TotalShares { get; set; }
		public Nullable<decimal> Ashares { get; set; }
		public Nullable<decimal> NonRestrictedShares { get; set; }
		public Nullable<decimal> BsharesTotal { get; set; }
		public Nullable<decimal> ListedBShares { get; set; }
		public Nullable<decimal> NonListedRestrictedBShares { get; set; }
		public Nullable<decimal> ForeignHoldingAshares { get; set; }
		public Nullable<decimal> RestrictedAShares { get; set; }
		public Nullable<decimal> Rpt_ManagementShares { get; set; }
	}
}

