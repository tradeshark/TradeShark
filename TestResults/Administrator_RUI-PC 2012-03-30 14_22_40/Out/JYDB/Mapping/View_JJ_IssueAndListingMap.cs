using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_IssueAndListingMap : EntityTypeConfiguration<View_JJ_IssueAndListing>
	{
		public View_JJ_IssueAndListingMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_FundRaisingMethod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_FundType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ApplyingTimes)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ListedPlace)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(100);
				
			this.Property(t => t.AbbrNameForApplying)
				.HasMaxLength(20);
				
			this.Property(t => t.ApplyingCode)
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_IssueAndListing");
			this.Property(t => t.N_FundRaisingMethod).HasColumnName("N_FundRaisingMethod");
			this.Property(t => t.N_FundType).HasColumnName("N_FundType");
			this.Property(t => t.N_ApplyingTimes).HasColumnName("N_ApplyingTimes");
			this.Property(t => t.N_ListedPlace).HasColumnName("N_ListedPlace");
			this.Property(t => t.N_HitRatio).HasColumnName("N_HitRatio");
			this.Property(t => t.N_FirstdayTurnoverRatio).HasColumnName("N_FirstdayTurnoverRatio");
			this.Property(t => t.N_MiniInitiatorHoldingRatio).HasColumnName("N_MiniInitiatorHoldingRatio");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.ProspectusIssuedDate).HasColumnName("ProspectusIssuedDate");
			this.Property(t => t.ListAnnouncementIssueDate).HasColumnName("ListAnnouncementIssueDate");
			this.Property(t => t.FundRaisingMethod).HasColumnName("FundRaisingMethod");
			this.Property(t => t.FundType).HasColumnName("FundType");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.IssueStartDate).HasColumnName("IssueStartDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.UnitIssuePrice).HasColumnName("UnitIssuePrice");
			this.Property(t => t.UnitIssueFee).HasColumnName("UnitIssueFee");
			this.Property(t => t.ShareIssued).HasColumnName("ShareIssued");
			this.Property(t => t.InitiatorSubscribeVolume).HasColumnName("InitiatorSubscribeVolume");
			this.Property(t => t.InitiatorHoldFloatShares).HasColumnName("InitiatorHoldFloatShares");
			this.Property(t => t.InitiatorHoldTerm).HasColumnName("InitiatorHoldTerm");
			this.Property(t => t.MiniInitiatorHoldingRatio).HasColumnName("MiniInitiatorHoldingRatio");
			this.Property(t => t.FInstitutionQuota).HasColumnName("FInstitutionQuota");
			this.Property(t => t.PublicOfferShares).HasColumnName("PublicOfferShares");
			this.Property(t => t.GeneralLegalPersonQuota).HasColumnName("GeneralLegalPersonQuota");
			this.Property(t => t.AbbrNameForApplying).HasColumnName("AbbrNameForApplying");
			this.Property(t => t.ApplyingCode).HasColumnName("ApplyingCode");
			this.Property(t => t.ApplyingUnit).HasColumnName("ApplyingUnit");
			this.Property(t => t.MinimumApplying).HasColumnName("MinimumApplying");
			this.Property(t => t.MaximumApplying).HasColumnName("MaximumApplying");
			this.Property(t => t.ApplyingTimes).HasColumnName("ApplyingTimes");
			this.Property(t => t.ValidlApplyingAccounts).HasColumnName("ValidlApplyingAccounts");
			this.Property(t => t.ValidApplyingVol).HasColumnName("ValidApplyingVol");
			this.Property(t => t.OverApplyingMultiples).HasColumnName("OverApplyingMultiples");
			this.Property(t => t.FreezeFunds).HasColumnName("FreezeFunds");
			this.Property(t => t.HitRatio).HasColumnName("HitRatio");
			this.Property(t => t.ListedDate).HasColumnName("ListedDate");
			this.Property(t => t.ListedPlace).HasColumnName("ListedPlace");
			this.Property(t => t.OutstandingShares).HasColumnName("OutstandingShares");
			this.Property(t => t.FirstDayOpenPrice).HasColumnName("FirstDayOpenPrice");
			this.Property(t => t.FirstDayColsePrice).HasColumnName("FirstDayColsePrice");
			this.Property(t => t.FirstDayTurnoverRatio).HasColumnName("FirstDayTurnoverRatio");
			this.Property(t => t.EstablishmentDate).HasColumnName("EstablishmentDate");
			this.Property(t => t.ApplyOpeningDate).HasColumnName("ApplyOpeningDate");
			this.Property(t => t.RedeemOpeningDate).HasColumnName("RedeemOpeningDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

