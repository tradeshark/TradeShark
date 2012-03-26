using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_WarrantSummary
	{
		public long ID { get; set; }
		public Nullable<int> WarrantCategory { get; set; }
		public Nullable<int> IfListed { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public Nullable<int> IssueType { get; set; }
		public Nullable<int> IssueWay { get; set; }
		public Nullable<int> Process { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> AdvancePublDate { get; set; }
		public Nullable<System.DateTime> SMAnnouncementDate { get; set; }
		public Nullable<System.DateTime> IssueAnnouncementDate { get; set; }
		public Nullable<System.DateTime> ListAnnouncementDate { get; set; }
		public string Issuer { get; set; }
		public Nullable<int> IssuerSN { get; set; }
		public Nullable<int> IsserCode { get; set; }
		public string TurnoverOffer { get; set; }
		public Nullable<int> TurnoverOfferSN { get; set; }
		public string TargetName { get; set; }
		public Nullable<int> TargetType { get; set; }
		public Nullable<int> TargetCode { get; set; }
		public Nullable<int> WarrantType { get; set; }
		public Nullable<int> SpecialType { get; set; }
		public Nullable<int> WarrantCharacter { get; set; }
		public Nullable<int> ExerciseStyle { get; set; }
		public Nullable<int> SettlementMode { get; set; }
		public Nullable<int> Duration { get; set; }
		public Nullable<System.DateTime> DurationFrom { get; set; }
		public Nullable<System.DateTime> DurationTo { get; set; }
		public Nullable<System.DateTime> EDay { get; set; }
		public Nullable<decimal> PrimalEPrice { get; set; }
		public Nullable<decimal> PrimalERate { get; set; }
		public Nullable<int> ExercisedWarrant { get; set; }
		public Nullable<int> ExercisedShare { get; set; }
		public string ECode { get; set; }
		public string EBrief { get; set; }
		public Nullable<System.DateTime> IssueDay { get; set; }
		public string IssueObject { get; set; }
		public Nullable<System.DateTime> RightRegDay { get; set; }
		public Nullable<decimal> IssueRate { get; set; }
		public Nullable<decimal> ShareCapitalB { get; set; }
		public Nullable<decimal> BaseShareSize { get; set; }
		public Nullable<decimal> IssueVol { get; set; }
		public Nullable<int> IssuePriceUnit { get; set; }
		public Nullable<decimal> IssuePrice { get; set; }
		public Nullable<System.DateTime> ListDay { get; set; }
		public Nullable<decimal> ListSize { get; set; }
		public Nullable<int> MinTradeSize { get; set; }
		public Nullable<decimal> PriceUnit { get; set; }
		public Nullable<decimal> MaxSingleTradeSize { get; set; }
		public Nullable<decimal> VolatilityYearly { get; set; }
		public Nullable<decimal> YieldRiskFree { get; set; }
		public Nullable<decimal> TheoreticalPrice { get; set; }
		public Nullable<decimal> Premium { get; set; }
		public Nullable<decimal> LeverageRatio { get; set; }
		public Nullable<decimal> EffectiveGearing { get; set; }
		public Nullable<decimal> ImpliedVolatility { get; set; }
		public Nullable<System.DateTime> LastTradeDay { get; set; }
		public Nullable<System.DateTime> ReferenceDay { get; set; }
		public Nullable<decimal> ClosePrice { get; set; }
		public Nullable<decimal> TargetClosePrice { get; set; }
		public Nullable<decimal> PriceRatio { get; set; }
		public Nullable<int> PriceStatus { get; set; }
		public Nullable<System.DateTime> WithdrawListingDay { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> DateToAccount { get; set; }
		public Nullable<System.DateTime> EndDateOfExercise { get; set; }
		public string IssuerType { get; set; }
		public Nullable<decimal> Circulation { get; set; }
		public Nullable<decimal> CreationCirculation { get; set; }
		public Nullable<decimal> ExercisedSharesAdded { get; set; }
		public Nullable<decimal> CreaterHoldingSum { get; set; }
		public Nullable<int> IssuerTypeCode { get; set; }
		public string EDayDescription { get; set; }
	}
}

