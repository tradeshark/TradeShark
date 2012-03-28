using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_QZ_ArchiveMap : EntityTypeConfiguration<View_QZ_Archive>
	{
		public View_QZ_ArchiveMap()
		{
			// Primary Key
			this.HasKey(t => new { t.N_Listed, t.ID, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.SecuCode)
				.HasMaxLength(13);
				
			this.Property(t => t.SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.N_ChiName)
				.HasMaxLength(200);
				
			this.Property(t => t.N_ListedState)
				.HasMaxLength(300);
				
			this.Property(t => t.N_SecuMarket)
				.HasMaxLength(300);
				
			this.Property(t => t.N_WarrantCategory)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IssueType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IssueWay)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Process)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IssuerSN)
				.HasMaxLength(100);
				
			this.Property(t => t.N_TargetType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_SecuCode)
				.HasMaxLength(13);
				
			this.Property(t => t.N_SecuAbbr)
				.HasMaxLength(20);
				
			this.Property(t => t.N_WarrantType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_SpecialType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_WarrantCharacter)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ExerciseStyle)
				.HasMaxLength(300);
				
			this.Property(t => t.N_SettlementMode)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IssuePriceUnit)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Listed)
				.IsRequired()
				.HasMaxLength(2);
				
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
				
			// Table & Column Mappings
			this.ToTable("View_QZ_Archive");
			this.Property(t => t.SecuCode).HasColumnName("SecuCode");
			this.Property(t => t.SecuAbbr).HasColumnName("SecuAbbr");
			this.Property(t => t.N_ChiName).HasColumnName("N_ChiName");
			this.Property(t => t.N_ListedState).HasColumnName("N_ListedState");
			this.Property(t => t.N_SecuMarket).HasColumnName("N_SecuMarket");
			this.Property(t => t.N_WarrantCategory).HasColumnName("N_WarrantCategory");
			this.Property(t => t.N_IssueType).HasColumnName("N_IssueType");
			this.Property(t => t.N_IssueWay).HasColumnName("N_IssueWay");
			this.Property(t => t.N_Process).HasColumnName("N_Process");
			this.Property(t => t.N_IssuerSN).HasColumnName("N_IssuerSN");
			this.Property(t => t.N_TargetType).HasColumnName("N_TargetType");
			this.Property(t => t.N_SecuCode).HasColumnName("N_SecuCode");
			this.Property(t => t.N_SecuAbbr).HasColumnName("N_SecuAbbr");
			this.Property(t => t.N_WarrantType).HasColumnName("N_WarrantType");
			this.Property(t => t.N_SpecialType).HasColumnName("N_SpecialType");
			this.Property(t => t.N_WarrantCharacter).HasColumnName("N_WarrantCharacter");
			this.Property(t => t.N_ExerciseStyle).HasColumnName("N_ExerciseStyle");
			this.Property(t => t.N_SettlementMode).HasColumnName("N_SettlementMode");
			this.Property(t => t.N_IssuePriceUnit).HasColumnName("N_IssuePriceUnit");
			this.Property(t => t.N_Listed).HasColumnName("N_Listed");
			this.Property(t => t.N_IssueRate).HasColumnName("N_IssueRate");
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
		}
	}
}

