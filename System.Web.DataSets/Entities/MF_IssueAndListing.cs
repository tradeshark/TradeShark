using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_IssueAndListing
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> ProspectusIssuedDate { get; set; }
		public Nullable<System.DateTime> ListAnnouncementIssueDate { get; set; }
		public Nullable<int> FundRaisingMethod { get; set; }
		public Nullable<int> FundType { get; set; }
		public string IssueObject { get; set; }
		public Nullable<System.DateTime> IssueStartDate { get; set; }
		public Nullable<System.DateTime> IssueEndDate { get; set; }
		public Nullable<decimal> ParValue { get; set; }
		public Nullable<decimal> UnitIssuePrice { get; set; }
		public Nullable<decimal> UnitIssueFee { get; set; }
		public Nullable<decimal> ShareIssued { get; set; }
		public Nullable<decimal> InitiatorSubscribeVolume { get; set; }
		public Nullable<decimal> InitiatorHoldFloatShares { get; set; }
		public Nullable<decimal> InitiatorHoldTerm { get; set; }
		public Nullable<decimal> MiniInitiatorHoldingRatio { get; set; }
		public Nullable<decimal> FInstitutionQuota { get; set; }
		public Nullable<decimal> PublicOfferShares { get; set; }
		public Nullable<decimal> GeneralLegalPersonQuota { get; set; }
		public string AbbrNameForApplying { get; set; }
		public string ApplyingCode { get; set; }
		public Nullable<int> ApplyingUnit { get; set; }
		public Nullable<int> MinimumApplying { get; set; }
		public Nullable<int> MaximumApplying { get; set; }
		public Nullable<int> ApplyingTimes { get; set; }
		public Nullable<int> ValidlApplyingAccounts { get; set; }
		public Nullable<decimal> ValidApplyingVol { get; set; }
		public Nullable<decimal> OverApplyingMultiples { get; set; }
		public Nullable<decimal> FreezeFunds { get; set; }
		public Nullable<decimal> HitRatio { get; set; }
		public Nullable<System.DateTime> ListedDate { get; set; }
		public Nullable<int> ListedPlace { get; set; }
		public Nullable<decimal> OutstandingShares { get; set; }
		public Nullable<decimal> FirstDayOpenPrice { get; set; }
		public Nullable<decimal> FirstDayColsePrice { get; set; }
		public Nullable<decimal> FirstDayTurnoverRatio { get; set; }
		public Nullable<System.DateTime> EstablishmentDate { get; set; }
		public Nullable<System.DateTime> ApplyOpeningDate { get; set; }
		public Nullable<System.DateTime> RedeemOpeningDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

