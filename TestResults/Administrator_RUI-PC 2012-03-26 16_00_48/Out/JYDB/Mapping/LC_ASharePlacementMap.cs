using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_ASharePlacementMap : EntityTypeConfiguration<LC_ASharePlacement>
	{
		public LC_ASharePlacementMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.InitialInfoPublDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.StockType)
				.IsFixedLength()
				.HasMaxLength(1);
				
			this.Property(t => t.PricingDescription)
				.HasMaxLength(255);
				
			this.Property(t => t.PlaAbbrName)
				.HasMaxLength(20);
				
			this.Property(t => t.PlaCode)
				.HasMaxLength(10);
				
			this.Property(t => t.PlaObject)
				.HasMaxLength(255);
				
			this.Property(t => t.ChangeStatement)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_ASharePlacement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.PlaYear).HasColumnName("PlaYear");
			this.Property(t => t.StockType).HasColumnName("StockType");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.PricingModel).HasColumnName("PricingModel");
			this.Property(t => t.PricingDescription).HasColumnName("PricingDescription");
			this.Property(t => t.AdvanceValidStartDate).HasColumnName("AdvanceValidStartDate");
			this.Property(t => t.AdvanceValidEndDate).HasColumnName("AdvanceValidEndDate");
			this.Property(t => t.PlaRatioPlanned).HasColumnName("PlaRatioPlanned");
			this.Property(t => t.PlaPriceCeiling).HasColumnName("PlaPriceCeiling");
			this.Property(t => t.PlaPriceFloor).HasColumnName("PlaPriceFloor");
			this.Property(t => t.DeciPublDate).HasColumnName("DeciPublDate");
			this.Property(t => t.PlaProspectusPublDate).HasColumnName("PlaProspectusPublDate");
			this.Property(t => t.PlaAbbrName).HasColumnName("PlaAbbrName");
			this.Property(t => t.PlaCode).HasColumnName("PlaCode");
			this.Property(t => t.BaseShares).HasColumnName("BaseShares");
			this.Property(t => t.PlannedPlaVol).HasColumnName("PlannedPlaVol");
			this.Property(t => t.ActualPlaRatio).HasColumnName("ActualPlaRatio");
			this.Property(t => t.ActualPlaVol).HasColumnName("ActualPlaVol");
			this.Property(t => t.PlaObject).HasColumnName("PlaObject");
			this.Property(t => t.ParValue).HasColumnName("ParValue");
			this.Property(t => t.PlaPrice).HasColumnName("PlaPrice");
			this.Property(t => t.TransferPlaRatio).HasColumnName("TransferPlaRatio");
			this.Property(t => t.TransferPlaVol).HasColumnName("TransferPlaVol");
			this.Property(t => t.TransferFeePerShare).HasColumnName("TransferFeePerShare");
			this.Property(t => t.OddLotsTreatment).HasColumnName("OddLotsTreatment");
			this.Property(t => t.PlaProceeds).HasColumnName("PlaProceeds");
			this.Property(t => t.PlaCost).HasColumnName("PlaCost");
			this.Property(t => t.UnderwritingFee).HasColumnName("UnderwritingFee");
			this.Property(t => t.CPAFee).HasColumnName("CPAFee");
			this.Property(t => t.AssetAppraisalFee).HasColumnName("AssetAppraisalFee");
			this.Property(t => t.LandEvaluationFee).HasColumnName("LandEvaluationFee");
			this.Property(t => t.AttorneyFee).HasColumnName("AttorneyFee");
			this.Property(t => t.TotalAgentFee).HasColumnName("TotalAgentFee");
			this.Property(t => t.OnlineIssueFee).HasColumnName("OnlineIssueFee");
			this.Property(t => t.ScripFee).HasColumnName("ScripFee");
			this.Property(t => t.SponsorFee).HasColumnName("SponsorFee");
			this.Property(t => t.OtherFee).HasColumnName("OtherFee");
			this.Property(t => t.PlaNetProceeds).HasColumnName("PlaNetProceeds");
			this.Property(t => t.RightRegDate).HasColumnName("RightRegDate");
			this.Property(t => t.ExRightDate).HasColumnName("ExRightDate");
			this.Property(t => t.PayStartDate).HasColumnName("PayStartDate");
			this.Property(t => t.PayEndDate).HasColumnName("PayEndDate");
			this.Property(t => t.DateToAccount).HasColumnName("DateToAccount");
			this.Property(t => t.MoneyToAccount).HasColumnName("MoneyToAccount");
			this.Property(t => t.PlaListDate).HasColumnName("PlaListDate");
			this.Property(t => t.LargeSHSubsStatement).HasColumnName("LargeSHSubsStatement");
			this.Property(t => t.SchemeChange).HasColumnName("SchemeChange");
			this.Property(t => t.ChangeStatement).HasColumnName("ChangeStatement");
			this.Property(t => t.UnderwritingMode).HasColumnName("UnderwritingMode");
			this.Property(t => t.UnderwriterBoughtVol).HasColumnName("UnderwriterBoughtVol");
			this.Property(t => t.PublicSHSubscriptionEsti).HasColumnName("PublicSHSubscriptionEsti");
			this.Property(t => t.PublicSHSubscriptionActu).HasColumnName("PublicSHSubscriptionActu");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

