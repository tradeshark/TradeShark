using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class BD_BidAndIssueMap : EntityTypeConfiguration<BD_BidAndIssue>
	{
		public BD_BidAndIssueMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.DocumentNumber)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("BD_BidAndIssue");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.IssueDate).HasColumnName("IssueDate");
			this.Property(t => t.IssueType).HasColumnName("IssueType");
			this.Property(t => t.BidType).HasColumnName("BidType");
			this.Property(t => t.DocumentNumber).HasColumnName("DocumentNumber");
			this.Property(t => t.IssueSizePlanned).HasColumnName("IssueSizePlanned");
			this.Property(t => t.PaidAmount).HasColumnName("PaidAmount");
			this.Property(t => t.ActualIssuSize).HasColumnName("ActualIssuSize");
			this.Property(t => t.GeneralBasicUnderwrite).HasColumnName("GeneralBasicUnderwrite");
			this.Property(t => t.BasicUnderwrite).HasColumnName("BasicUnderwrite");
			this.Property(t => t.MinUnderwrite).HasColumnName("MinUnderwrite");
			this.Property(t => t.CompeteMinUnderwrite).HasColumnName("CompeteMinUnderwrite");
			this.Property(t => t.NonCompeteMinUnderwrite).HasColumnName("NonCompeteMinUnderwrite");
			this.Property(t => t.BidAmount).HasColumnName("BidAmount");
			this.Property(t => t.CompeteBidAmount).HasColumnName("CompeteBidAmount");
			this.Property(t => t.NonCompeteBidAmount).HasColumnName("NonCompeteBidAmount");
			this.Property(t => t.CompanyNumPresent).HasColumnName("CompanyNumPresent");
			this.Property(t => t.CompeteCompanyNumPresent).HasColumnName("CompeteCompanyNumPresent");
			this.Property(t => t.NonCompeteCompanyNumPresent).HasColumnName("NonCompeteCompanyNumPresent");
			this.Property(t => t.BidCompanyNum).HasColumnName("BidCompanyNum");
			this.Property(t => t.CompeteBidCompanyNum).HasColumnName("CompeteBidCompanyNum");
			this.Property(t => t.NonCompeteBidCompanyNum).HasColumnName("NonCompeteBidCompanyNum");
			this.Property(t => t.BidNumber).HasColumnName("BidNumber");
			this.Property(t => t.CompeteBidNumber).HasColumnName("CompeteBidNumber");
			this.Property(t => t.NonCompeteBidNumber).HasColumnName("NonCompeteBidNumber");
			this.Property(t => t.ValidBidNumber).HasColumnName("ValidBidNumber");
			this.Property(t => t.CompeteValidBidNumber).HasColumnName("CompeteValidBidNumber");
			this.Property(t => t.NonCompeteValidBidNumber).HasColumnName("NonCompeteValidBidNumber");
			this.Property(t => t.InvalidBidNumber).HasColumnName("InvalidBidNumber");
			this.Property(t => t.CompeteInvalidBidNumber).HasColumnName("CompeteInvalidBidNumber");
			this.Property(t => t.NonCompeteInvalidBidNumber).HasColumnName("NonCompeteInvalidBidNumber");
			this.Property(t => t.ValidAmount).HasColumnName("ValidAmount");
			this.Property(t => t.CompeteValidAmount).HasColumnName("CompeteValidAmount");
			this.Property(t => t.NonCompeteValidAmount).HasColumnName("NonCompeteValidAmount");
			this.Property(t => t.HighBidPrice).HasColumnName("HighBidPrice");
			this.Property(t => t.LowBidPrice).HasColumnName("LowBidPrice");
			this.Property(t => t.AmountWinBid).HasColumnName("AmountWinBid");
			this.Property(t => t.CompeteAmountWinBid).HasColumnName("CompeteAmountWinBid");
			this.Property(t => t.NonCompeteAmountWinBid).HasColumnName("NonCompeteAmountWinBid");
			this.Property(t => t.CompanyNumWinBid).HasColumnName("CompanyNumWinBid");
			this.Property(t => t.CompeteCompanyNumWinBid).HasColumnName("CompeteCompanyNumWinBid");
			this.Property(t => t.NonCompeteCompanyNumWinBid).HasColumnName("NonCompeteCompanyNumWinBid");
			this.Property(t => t.NumWinBid).HasColumnName("NumWinBid");
			this.Property(t => t.CompeteNumWinBid).HasColumnName("CompeteNumWinBid");
			this.Property(t => t.NonCompeteNumWinBid).HasColumnName("NonCompeteNumWinBid");
			this.Property(t => t.DistributeAmountWinBid).HasColumnName("DistributeAmountWinBid");
			this.Property(t => t.SelfSupportAmountWinBid).HasColumnName("SelfSupportAmountWinBid");
			this.Property(t => t.HighPriceWinBid).HasColumnName("HighPriceWinBid");
			this.Property(t => t.LowPriceWinBid).HasColumnName("LowPriceWinBid");
			this.Property(t => t.MarginAmountBid).HasColumnName("MarginAmountBid");
			this.Property(t => t.CompeteMarginAmountBid).HasColumnName("CompeteMarginAmountBid");
			this.Property(t => t.NonCompeteMarginAmountBid).HasColumnName("NonCompeteMarginAmountBid");
			this.Property(t => t.MarginAmountWinBid).HasColumnName("MarginAmountWinBid");
			this.Property(t => t.CompeteMarginAmountWinBid).HasColumnName("CompeteMarginAmountWinBid");
			this.Property(t => t.NonCompeteMarginAmountWinBid).HasColumnName("NonCompeteMarginAmountWinBid");
			this.Property(t => t.InterestRateSpread).HasColumnName("InterestRateSpread");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.PriceWinBid).HasColumnName("PriceWinBid");
			this.Property(t => t.ReferrenceYield).HasColumnName("ReferrenceYield");
			this.Property(t => t.CouponRate).HasColumnName("CouponRate");
			this.Property(t => t.InterestRateWinBid).HasColumnName("InterestRateWinBid");
			this.Property(t => t.FirstCouponRate).HasColumnName("FirstCouponRate");
			this.Property(t => t.CompanyNumExcessBid).HasColumnName("CompanyNumExcessBid");
			this.Property(t => t.AmountExcessBid).HasColumnName("AmountExcessBid");
			this.Property(t => t.CompanyNumLackBid).HasColumnName("CompanyNumLackBid");
			this.Property(t => t.AmountLackBid).HasColumnName("AmountLackBid");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

