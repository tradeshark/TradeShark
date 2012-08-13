using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ShareMergerReform
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> LatestInfoPublDate { get; set; }
		public Nullable<int> Process { get; set; }
		public Nullable<System.DateTime> EventAnnounceDate { get; set; }
		public string PrimaryIntention { get; set; }
		public Nullable<int> ProgramType { get; set; }
		public string ContactTel { get; set; }
		public string Fax { get; set; }
		public string Email { get; set; }
		public string ContactMan { get; set; }
		public string Sponsor { get; set; }
		public Nullable<int> CompanyNumber { get; set; }
		public Nullable<decimal> SponsorHolding { get; set; }
		public Nullable<System.DateTime> DMDate { get; set; }
		public Nullable<System.DateTime> DMDAnnounceDate { get; set; }
		public Nullable<System.DateTime> OnlineVotingStartDate { get; set; }
		public Nullable<System.DateTime> OnlineVotingEndDate { get; set; }
		public Nullable<System.DateTime> SMRecordDate { get; set; }
		public Nullable<System.DateTime> SMDate { get; set; }
		public string SMAddress { get; set; }
		public string VoterCollector { get; set; }
		public Nullable<System.DateTime> IDCollectStartDate { get; set; }
		public Nullable<System.DateTime> IDCollectEndDate { get; set; }
		public string Authorizingdept { get; set; }
		public Nullable<int> IfAuthorized { get; set; }
		public Nullable<int> IfFCLPShareAuthorized { get; set; }
		public Nullable<System.DateTime> AuthorizedDate { get; set; }
		public Nullable<System.DateTime> SMDAnnounceDate { get; set; }
		public Nullable<int> IfPassed { get; set; }
		public Nullable<System.DateTime> ImplementionAnnouceDate { get; set; }
		public Nullable<System.DateTime> ImplementionRecordDate { get; set; }
		public Nullable<System.DateTime> SuspendDate { get; set; }
		public Nullable<System.DateTime> RecoverTradinDate { get; set; }
		public Nullable<System.DateTime> SConsiderationPayDate { get; set; }
		public Nullable<System.DateTime> SConsiderationListDate { get; set; }
		public Nullable<System.DateTime> CConsiderationPayDate { get; set; }
		public Nullable<System.DateTime> WarrantIssueDate { get; set; }
		public Nullable<decimal> BaseShareCapital { get; set; }
		public Nullable<decimal> NTShareBR { get; set; }
		public Nullable<decimal> NTTermEShare { get; set; }
		public Nullable<decimal> NTEShare { get; set; }
		public Nullable<decimal> FCLPShareBR { get; set; }
		public Nullable<decimal> TShareBR { get; set; }
		public Nullable<decimal> TAShareBR { get; set; }
		public Nullable<decimal> BShareBR { get; set; }
		public Nullable<decimal> HShareBR { get; set; }
		public Nullable<decimal> OTShareBR { get; set; }
		public Nullable<decimal> TotalShareAR { get; set; }
		public Nullable<decimal> RestrainedTShare { get; set; }
		public Nullable<decimal> RTTermEShare { get; set; }
		public Nullable<decimal> RTEShare { get; set; }
		public Nullable<decimal> RTFCLPShare { get; set; }
		public Nullable<decimal> UnstintedTShare { get; set; }
		public Nullable<decimal> TAShareAR { get; set; }
		public Nullable<decimal> BShareAR { get; set; }
		public Nullable<decimal> HShareAR { get; set; }
		public Nullable<decimal> OTShareAR { get; set; }
		public Nullable<decimal> TotalSharePaid { get; set; }
		public Nullable<decimal> TotalCashPaid { get; set; }
		public Nullable<decimal> TotalWarrant { get; set; }
		public Nullable<decimal> SConsideration { get; set; }
		public Nullable<decimal> CConsideration { get; set; }
		public Nullable<decimal> Wconsideration { get; set; }
		public Nullable<decimal> ShareCompressed { get; set; }
		public Nullable<int> SubsidiaryProgram { get; set; }
		public string SPStatement { get; set; }
		public string Note { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> ProgramPrePublDate { get; set; }
		public Nullable<int> AdjustmentType { get; set; }
	}
}

