using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_WarrantSummaryMap : EntityTypeConfiguration<LC_WarrantSummary>
	{
		public LC_WarrantSummaryMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Issuer)
				.HasMaxLength(200);
				
			this.Property(t => t.TurnoverOffer)
				.HasMaxLength(200);
				
			this.Property(t => t.TargetName)
				.HasMaxLength(200);
				
			this.Property(t => t.ECode)
				.HasMaxLength(100);
				
			this.Property(t => t.EBrief)
				.HasMaxLength(100);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(100);
				
			this.Property(t => t.IssuerType)
				.HasMaxLength(50);
				
			this.Property(t => t.EDayDescription)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("LC_WarrantSummary");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.WarrantCategory).HasColumnName("WarrantCategory");
			this.Property(t => t.IfListed).HasColumnName("IfListed");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.IssueType).HasColumnName("IssueType");
			this.Property(t => t.IssueWay).HasColumnName("IssueWay");
			this.Property(t => t.Process).HasColumnName("Process");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.AdvancePublDate).HasColumnName("AdvancePublDate");
			this.Property(t => t.SMAnnouncementDate).HasColumnName("SMAnnouncementDate");
			this.Property(t => t.IssueAnnouncementDate).HasColumnName("IssueAnnouncementDate");
			this.Property(t => t.ListAnnouncementDate).HasColumnName("ListAnnouncementDate");
			this.Property(t => t.Issuer).HasColumnName("Issuer");
			this.Property(t => t.IssuerSN).HasColumnName("IssuerSN");
			this.Property(t => t.IsserCode).HasColumnName("IsserCode");
			this.Property(t => t.TurnoverOffer).HasColumnName("TurnoverOffer");
			this.Property(t => t.TurnoverOfferSN).HasColumnName("TurnoverOfferSN");
			this.Property(t => t.TargetName).HasColumnName("TargetName");
			this.Property(t => t.TargetType).HasColumnName("TargetType");
			this.Property(t => t.TargetCode).HasColumnName("TargetCode");
			this.Property(t => t.WarrantType).HasColumnName("WarrantType");
			this.Property(t => t.SpecialType).HasColumnName("SpecialType");
			this.Property(t => t.WarrantCharacter).HasColumnName("WarrantCharacter");
			this.Property(t => t.ExerciseStyle).HasColumnName("ExerciseStyle");
			this.Property(t => t.SettlementMode).HasColumnName("SettlementMode");
			this.Property(t => t.Duration).HasColumnName("Duration");
			this.Property(t => t.DurationFrom).HasColumnName("DurationFrom");
			this.Property(t => t.DurationTo).HasColumnName("DurationTo");
			this.Property(t => t.EDay).HasColumnName("EDay");
			this.Property(t => t.PrimalEPrice).HasColumnName("PrimalEPrice");
			this.Property(t => t.PrimalERate).HasColumnName("PrimalERate");
			this.Property(t => t.ExercisedWarrant).HasColumnName("ExercisedWarrant");
			this.Property(t => t.ExercisedShare).HasColumnName("ExercisedShare");
			this.Property(t => t.ECode).HasColumnName("ECode");
			this.Property(t => t.EBrief).HasColumnName("EBrief");
			this.Property(t => t.IssueDay).HasColumnName("IssueDay");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.RightRegDay).HasColumnName("RightRegDay");
			this.Property(t => t.IssueRate).HasColumnName("IssueRate");
			this.Property(t => t.ShareCapitalB).HasColumnName("ShareCapitalB");
			this.Property(t => t.BaseShareSize).HasColumnName("BaseShareSize");
			this.Property(t => t.IssueVol).HasColumnName("IssueVol");
			this.Property(t => t.IssuePriceUnit).HasColumnName("IssuePriceUnit");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.ListDay).HasColumnName("ListDay");
			this.Property(t => t.ListSize).HasColumnName("ListSize");
			this.Property(t => t.MinTradeSize).HasColumnName("MinTradeSize");
			this.Property(t => t.PriceUnit).HasColumnName("PriceUnit");
			this.Property(t => t.MaxSingleTradeSize).HasColumnName("MaxSingleTradeSize");
			this.Property(t => t.VolatilityYearly).HasColumnName("VolatilityYearly");
			this.Property(t => t.YieldRiskFree).HasColumnName("YieldRiskFree");
			this.Property(t => t.TheoreticalPrice).HasColumnName("TheoreticalPrice");
			this.Property(t => t.Premium).HasColumnName("Premium");
			this.Property(t => t.LeverageRatio).HasColumnName("LeverageRatio");
			this.Property(t => t.EffectiveGearing).HasColumnName("EffectiveGearing");
			this.Property(t => t.ImpliedVolatility).HasColumnName("ImpliedVolatility");
			this.Property(t => t.LastTradeDay).HasColumnName("LastTradeDay");
			this.Property(t => t.ReferenceDay).HasColumnName("ReferenceDay");
			this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
			this.Property(t => t.TargetClosePrice).HasColumnName("TargetClosePrice");
			this.Property(t => t.PriceRatio).HasColumnName("PriceRatio");
			this.Property(t => t.PriceStatus).HasColumnName("PriceStatus");
			this.Property(t => t.WithdrawListingDay).HasColumnName("WithdrawListingDay");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.DateToAccount).HasColumnName("DateToAccount");
			this.Property(t => t.EndDateOfExercise).HasColumnName("EndDateOfExercise");
			this.Property(t => t.IssuerType).HasColumnName("IssuerType");
			this.Property(t => t.Circulation).HasColumnName("Circulation");
			this.Property(t => t.CreationCirculation).HasColumnName("CreationCirculation");
			this.Property(t => t.ExercisedSharesAdded).HasColumnName("ExercisedSharesAdded");
			this.Property(t => t.CreaterHoldingSum).HasColumnName("CreaterHoldingSum");
			this.Property(t => t.IssuerTypeCode).HasColumnName("IssuerTypeCode");
			this.Property(t => t.EDayDescription).HasColumnName("EDayDescription");
		}
	}
}

