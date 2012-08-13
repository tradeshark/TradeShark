using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_ShareIPOMap : EntityTypeConfiguration<HK_ShareIPO>
	{
		public HK_ShareIPOMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Stetement)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("HK_ShareIPO");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.Process).HasColumnName("Process");
			this.Property(t => t.BDDecisionPublDate).HasColumnName("BDDecisionPublDate");
			this.Property(t => t.BDDecisionSignDate).HasColumnName("BDDecisionSignDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.ProspectusPublDate).HasColumnName("ProspectusPublDate");
			this.Property(t => t.ContractSignDate).HasColumnName("ContractSignDate");
			this.Property(t => t.AbortPublDate).HasColumnName("AbortPublDate");
			this.Property(t => t.IssueType).HasColumnName("IssueType");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.CurrencyUnit).HasColumnName("CurrencyUnit");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.TradeUnit).HasColumnName("TradeUnit");
			this.Property(t => t.IssuePriceCurrencyUnit).HasColumnName("IssuePriceCurrencyUnit");
			this.Property(t => t.UnderwritingMode).HasColumnName("UnderwritingMode");
			this.Property(t => t.RationModel).HasColumnName("RationModel");
			this.Property(t => t.IssueVolPlanned).HasColumnName("IssueVolPlanned");
			this.Property(t => t.NewShareVolPlanned).HasColumnName("NewShareVolPlanned");
			this.Property(t => t.StoreShareVolPlanned).HasColumnName("StoreShareVolPlanned");
			this.Property(t => t.QualifiedSHAllotmentPlanned).HasColumnName("QualifiedSHAllotmentPlanned");
			this.Property(t => t.PublicNewSharePlanned).HasColumnName("PublicNewSharePlanned");
			this.Property(t => t.PublicStoreSharePlanned).HasColumnName("PublicStoreSharePlanned");
			this.Property(t => t.StaffPriorAllotmentPlanned).HasColumnName("StaffPriorAllotmentPlanned");
			this.Property(t => t.OverAllotmentOptionPlanned).HasColumnName("OverAllotmentOptionPlanned");
			this.Property(t => t.IssuePriceCeiling).HasColumnName("IssuePriceCeiling");
			this.Property(t => t.IssuePriceFloor).HasColumnName("IssuePriceFloor");
			this.Property(t => t.TradeUnitPriceAtCeiling).HasColumnName("TradeUnitPriceAtCeiling");
			this.Property(t => t.ReferrencePrice).HasColumnName("ReferrencePrice");
			this.Property(t => t.ProceedsPlanned).HasColumnName("ProceedsPlanned");
			this.Property(t => t.NetProceedsPlanned).HasColumnName("NetProceedsPlanned");
			this.Property(t => t.OverAllotmentProceedsPlanned).HasColumnName("OverAllotmentProceedsPlanned");
			this.Property(t => t.IssueCostPlanned).HasColumnName("IssueCostPlanned");
			this.Property(t => t.CommisionRatio).HasColumnName("CommisionRatio");
			this.Property(t => t.IssueExpireDate).HasColumnName("IssueExpireDate");
			this.Property(t => t.LastTradeDate).HasColumnName("LastTradeDate");
			this.Property(t => t.ExDiviDate).HasColumnName("ExDiviDate");
			this.Property(t => t.RightRegDate).HasColumnName("RightRegDate");
			this.Property(t => t.TransferEndFirstDate).HasColumnName("TransferEndFirstDate");
			this.Property(t => t.TransferEndLastDate).HasColumnName("TransferEndLastDate");
			this.Property(t => t.PayEndDate).HasColumnName("PayEndDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.DateToAccount).HasColumnName("DateToAccount");
			this.Property(t => t.RefundmentOutDate).HasColumnName("RefundmentOutDate");
			this.Property(t => t.IssueComplishmentDate).HasColumnName("IssueComplishmentDate");
			this.Property(t => t.ProposedListDate).HasColumnName("ProposedListDate");
			this.Property(t => t.OverAllotmentProposedListDate).HasColumnName("OverAllotmentProposedListDate");
			this.Property(t => t.IssueResultPublDate).HasColumnName("IssueResultPublDate");
			this.Property(t => t.OverAllotmentOptionExpireDate).HasColumnName("OverAllotmentOptionExpireDate");
			this.Property(t => t.OfferRatioX).HasColumnName("OfferRatioX");
			this.Property(t => t.OfferRatioY).HasColumnName("OfferRatioY");
			this.Property(t => t.IssueBase).HasColumnName("IssueBase");
			this.Property(t => t.IssueBaseShares).HasColumnName("IssueBaseShares");
			this.Property(t => t.IssueVol).HasColumnName("IssueVol");
			this.Property(t => t.RatioInPriShare).HasColumnName("RatioInPriShare");
			this.Property(t => t.RatioInPostShare).HasColumnName("RatioInPostShare");
			this.Property(t => t.NewShareVol).HasColumnName("NewShareVol");
			this.Property(t => t.StoreShareAllotment).HasColumnName("StoreShareAllotment");
			this.Property(t => t.QualifiedSHPriorAllotment).HasColumnName("QualifiedSHPriorAllotment");
			this.Property(t => t.PublicOfferedNewShare).HasColumnName("PublicOfferedNewShare");
			this.Property(t => t.PublicOfferedStoreShare).HasColumnName("PublicOfferedStoreShare");
			this.Property(t => t.StaffPriorAllotment).HasColumnName("StaffPriorAllotment");
			this.Property(t => t.OverAllotmentOption).HasColumnName("OverAllotmentOption");
			this.Property(t => t.OverAllotmentNewShare).HasColumnName("OverAllotmentNewShare");
			this.Property(t => t.OverAllotmentStoreShare).HasColumnName("OverAllotmentStoreShare");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.TotalProceeds).HasColumnName("TotalProceeds");
			this.Property(t => t.NetProceeds).HasColumnName("NetProceeds");
			this.Property(t => t.OverAllotmentProceeds).HasColumnName("OverAllotmentProceeds");
			this.Property(t => t.OverAllotmentNetProceeds).HasColumnName("OverAllotmentNetProceeds");
			this.Property(t => t.PubApplyUnit).HasColumnName("PubApplyUnit");
			this.Property(t => t.PubApplyShares).HasColumnName("PubApplyShares");
			this.Property(t => t.PubApplyMultiple).HasColumnName("PubApplyMultiple");
			this.Property(t => t.StaffApplyUnit).HasColumnName("StaffApplyUnit");
			this.Property(t => t.StaffApplyShares).HasColumnName("StaffApplyShares");
			this.Property(t => t.StaffApplyMultiple).HasColumnName("StaffApplyMultiple");
			this.Property(t => t.AllotmentApplyUnits).HasColumnName("AllotmentApplyUnits");
			this.Property(t => t.AllotmentApplyShares).HasColumnName("AllotmentApplyShares");
			this.Property(t => t.AllotmentApplyMultiple).HasColumnName("AllotmentApplyMultiple");
			this.Property(t => t.QualifiedSHApplyUnits).HasColumnName("QualifiedSHApplyUnits");
			this.Property(t => t.QualifiedSHApplyShares).HasColumnName("QualifiedSHApplyShares");
			this.Property(t => t.QualifiedSHApplyMultiple).HasColumnName("QualifiedSHApplyMultiple");
			this.Property(t => t.ValidApplyShares).HasColumnName("ValidApplyShares");
			this.Property(t => t.ValidApplyAllotmentShares).HasColumnName("ValidApplyAllotmentShares");
			this.Property(t => t.ValidApplyOverAllotmentShares).HasColumnName("ValidApplyOverAllotmentShares");
			this.Property(t => t.IrrevocableUndertakingShares).HasColumnName("IrrevocableUndertakingShares");
			this.Property(t => t.SubscribeRemainShares).HasColumnName("SubscribeRemainShares");
			this.Property(t => t.UnderwriterBoughtVol).HasColumnName("UnderwriterBoughtVol");
			this.Property(t => t.UnderwriterNumber).HasColumnName("UnderwriterNumber");
			this.Property(t => t.FirstUnderwriterAllotment).HasColumnName("FirstUnderwriterAllotment");
			this.Property(t => t.First5UnderwritersAllotment).HasColumnName("First5UnderwritersAllotment");
			this.Property(t => t.First10UnderwritersAllotment).HasColumnName("First10UnderwritersAllotment");
			this.Property(t => t.First15UnderwritersAllotment).HasColumnName("First15UnderwritersAllotment");
			this.Property(t => t.First20UnderwritersAllotment).HasColumnName("First20UnderwritersAllotment");
			this.Property(t => t.First25UnderwritersAllotment).HasColumnName("First25UnderwritersAllotment");
			this.Property(t => t.RelativeAllotment).HasColumnName("RelativeAllotment");
			this.Property(t => t.Stetement).HasColumnName("Stetement");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

