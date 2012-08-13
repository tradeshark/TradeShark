using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_BShareSeasonedNewIssueMap : EntityTypeConfiguration<LC_BShareSeasonedNewIssue>
	{
		public LC_BShareSeasonedNewIssueMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InitialInfoPublDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.PriceIntervalStatement)
				.HasMaxLength(255);
				
			this.Property(t => t.IssueObject)
				.HasMaxLength(255);
				
			this.Property(t => t.ChangeStatement)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_BShareSeasonedNewIssue");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.AdvanceValidStartDate).HasColumnName("AdvanceValidStartDate");
			this.Property(t => t.AdvanceValidEndDate).HasColumnName("AdvanceValidEndDate");
			this.Property(t => t.StockType).HasColumnName("StockType");
			this.Property(t => t.PriceIntervalStatement).HasColumnName("PriceIntervalStatement");
			this.Property(t => t.PricingModel).HasColumnName("PricingModel");
			this.Property(t => t.RationModel).HasColumnName("RationModel");
			this.Property(t => t.IssueMethod).HasColumnName("IssueMethod");
			this.Property(t => t.IssueObject).HasColumnName("IssueObject");
			this.Property(t => t.PriceUnit).HasColumnName("PriceUnit");
			this.Property(t => t.ParValueRMB).HasColumnName("ParValueRMB");
			this.Property(t => t.IssuePriceFloorRMB).HasColumnName("IssuePriceFloorRMB");
			this.Property(t => t.IssuePriceCeilingRMB).HasColumnName("IssuePriceCeilingRMB");
			this.Property(t => t.ReferredPriceRMB).HasColumnName("ReferredPriceRMB");
			this.Property(t => t.IssueVolFloor).HasColumnName("IssueVolFloor");
			this.Property(t => t.IssueVolCeiling).HasColumnName("IssueVolCeiling");
			this.Property(t => t.OverAllotmentOption).HasColumnName("OverAllotmentOption");
			this.Property(t => t.IntentLetterPublDate).HasColumnName("IntentLetterPublDate");
			this.Property(t => t.ProspectusPublDate).HasColumnName("ProspectusPublDate");
			this.Property(t => t.UnderwritingSignDate).HasColumnName("UnderwritingSignDate");
			this.Property(t => t.IssueStartDate).HasColumnName("IssueStartDate");
			this.Property(t => t.IssueEndDate).HasColumnName("IssueEndDate");
			this.Property(t => t.PublicIssueDate).HasColumnName("PublicIssueDate");
			this.Property(t => t.UnderwritingStartDate).HasColumnName("UnderwritingStartDate");
			this.Property(t => t.UnderwritingEndDate).HasColumnName("UnderwritingEndDate");
			this.Property(t => t.IssuePriceRMB).HasColumnName("IssuePriceRMB");
			this.Property(t => t.IssuePrice).HasColumnName("IssuePrice");
			this.Property(t => t.WeightedPERatio).HasColumnName("WeightedPERatio");
			this.Property(t => t.DilutedPERatio).HasColumnName("DilutedPERatio");
			this.Property(t => t.StraInvestorPlaPriceFC).HasColumnName("StraInvestorPlaPriceFC");
			this.Property(t => t.UnderwritingMode).HasColumnName("UnderwritingMode");
			this.Property(t => t.ActualIssueVol).HasColumnName("ActualIssueVol");
			this.Property(t => t.StraInvestorPlaVol).HasColumnName("StraInvestorPlaVol");
			this.Property(t => t.TotalIssueMVRMB).HasColumnName("TotalIssueMVRMB");
			this.Property(t => t.IssueCostRMB).HasColumnName("IssueCostRMB");
			this.Property(t => t.PlaProceedsRMB).HasColumnName("PlaProceedsRMB");
			this.Property(t => t.PlaNetProceedsRMB).HasColumnName("PlaNetProceedsRMB");
			this.Property(t => t.IssueCostPerShareRMB).HasColumnName("IssueCostPerShareRMB");
			this.Property(t => t.TotalIssueMVFC).HasColumnName("TotalIssueMVFC");
			this.Property(t => t.IssueCostFC).HasColumnName("IssueCostFC");
			this.Property(t => t.PlaProceedsFC).HasColumnName("PlaProceedsFC");
			this.Property(t => t.PlaNetProceedsFC).HasColumnName("PlaNetProceedsFC");
			this.Property(t => t.IssueCostPerShareFC).HasColumnName("IssueCostPerShareFC");
			this.Property(t => t.ShareChangePublDate).HasColumnName("ShareChangePublDate");
			this.Property(t => t.SNIListDate).HasColumnName("SNIListDate");
			this.Property(t => t.OutstandingShares).HasColumnName("OutstandingShares");
			this.Property(t => t.PlaNum).HasColumnName("PlaNum");
			this.Property(t => t.UnderwriterBoughtVol).HasColumnName("UnderwriterBoughtVol");
			this.Property(t => t.EarningForecastYear).HasColumnName("EarningForecastYear");
			this.Property(t => t.MainIncomeForecastRMB).HasColumnName("MainIncomeForecastRMB");
			this.Property(t => t.NetProfitForecastRMB).HasColumnName("NetProfitForecastRMB");
			this.Property(t => t.DilutedEPSForecastRMB).HasColumnName("DilutedEPSForecastRMB");
			this.Property(t => t.ChangeStatement).HasColumnName("ChangeStatement");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

