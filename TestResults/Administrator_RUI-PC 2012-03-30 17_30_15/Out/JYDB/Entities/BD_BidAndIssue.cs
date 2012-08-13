using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_BidAndIssue
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime IssueDate { get; set; }
		public int IssueType { get; set; }
		public int BidType { get; set; }
		public string DocumentNumber { get; set; }
		public Nullable<decimal> IssueSizePlanned { get; set; }
		public Nullable<decimal> PaidAmount { get; set; }
		public Nullable<decimal> ActualIssuSize { get; set; }
		public Nullable<decimal> GeneralBasicUnderwrite { get; set; }
		public Nullable<decimal> BasicUnderwrite { get; set; }
		public Nullable<decimal> MinUnderwrite { get; set; }
		public Nullable<decimal> CompeteMinUnderwrite { get; set; }
		public Nullable<decimal> NonCompeteMinUnderwrite { get; set; }
		public Nullable<decimal> BidAmount { get; set; }
		public Nullable<decimal> CompeteBidAmount { get; set; }
		public Nullable<decimal> NonCompeteBidAmount { get; set; }
		public Nullable<int> CompanyNumPresent { get; set; }
		public Nullable<int> CompeteCompanyNumPresent { get; set; }
		public Nullable<int> NonCompeteCompanyNumPresent { get; set; }
		public Nullable<int> BidCompanyNum { get; set; }
		public Nullable<int> CompeteBidCompanyNum { get; set; }
		public Nullable<int> NonCompeteBidCompanyNum { get; set; }
		public Nullable<int> BidNumber { get; set; }
		public Nullable<int> CompeteBidNumber { get; set; }
		public Nullable<int> NonCompeteBidNumber { get; set; }
		public Nullable<int> ValidBidNumber { get; set; }
		public Nullable<int> CompeteValidBidNumber { get; set; }
		public Nullable<int> NonCompeteValidBidNumber { get; set; }
		public Nullable<int> InvalidBidNumber { get; set; }
		public Nullable<int> CompeteInvalidBidNumber { get; set; }
		public Nullable<int> NonCompeteInvalidBidNumber { get; set; }
		public Nullable<decimal> ValidAmount { get; set; }
		public Nullable<decimal> CompeteValidAmount { get; set; }
		public Nullable<decimal> NonCompeteValidAmount { get; set; }
		public Nullable<decimal> HighBidPrice { get; set; }
		public Nullable<decimal> LowBidPrice { get; set; }
		public Nullable<decimal> AmountWinBid { get; set; }
		public Nullable<decimal> CompeteAmountWinBid { get; set; }
		public Nullable<decimal> NonCompeteAmountWinBid { get; set; }
		public Nullable<int> CompanyNumWinBid { get; set; }
		public Nullable<int> CompeteCompanyNumWinBid { get; set; }
		public Nullable<int> NonCompeteCompanyNumWinBid { get; set; }
		public Nullable<int> NumWinBid { get; set; }
		public Nullable<int> CompeteNumWinBid { get; set; }
		public Nullable<int> NonCompeteNumWinBid { get; set; }
		public Nullable<decimal> DistributeAmountWinBid { get; set; }
		public Nullable<decimal> SelfSupportAmountWinBid { get; set; }
		public Nullable<decimal> HighPriceWinBid { get; set; }
		public Nullable<decimal> LowPriceWinBid { get; set; }
		public Nullable<decimal> MarginAmountBid { get; set; }
		public Nullable<decimal> CompeteMarginAmountBid { get; set; }
		public Nullable<decimal> NonCompeteMarginAmountBid { get; set; }
		public Nullable<decimal> MarginAmountWinBid { get; set; }
		public Nullable<decimal> CompeteMarginAmountWinBid { get; set; }
		public Nullable<decimal> NonCompeteMarginAmountWinBid { get; set; }
		public Nullable<decimal> InterestRateSpread { get; set; }
		public Nullable<decimal> IssuePrice { get; set; }
		public Nullable<decimal> PriceWinBid { get; set; }
		public Nullable<decimal> ReferrenceYield { get; set; }
		public Nullable<decimal> CouponRate { get; set; }
		public Nullable<decimal> InterestRateWinBid { get; set; }
		public Nullable<decimal> FirstCouponRate { get; set; }
		public Nullable<int> CompanyNumExcessBid { get; set; }
		public Nullable<decimal> AmountExcessBid { get; set; }
		public Nullable<int> CompanyNumLackBid { get; set; }
		public Nullable<decimal> AmountLackBid { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

