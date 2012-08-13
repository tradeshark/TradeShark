using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_BSharePlacementMap : EntityTypeConfiguration<LC_BSharePlacement>
	{
		public LC_BSharePlacementMap()
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
				
			this.Property(t => t.PriceUnit)
				.HasMaxLength(10);
				
			this.Property(t => t.WarrantAbbrName)
				.HasMaxLength(20);
				
			this.Property(t => t.WarrantCode)
				.HasMaxLength(10);
				
			this.Property(t => t.PlaObject)
				.HasMaxLength(255);
				
			this.Property(t => t.ChangeStatement)
				.HasMaxLength(255);
				
			// Table & Column Mappings
			this.ToTable("LC_BSharePlacement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InitialInfoPublDate).HasColumnName("InitialInfoPublDate");
			this.Property(t => t.PlaYear).HasColumnName("PlaYear");
			this.Property(t => t.StockType).HasColumnName("StockType");
			this.Property(t => t.AdvanceDate).HasColumnName("AdvanceDate");
			this.Property(t => t.SMDeciPublDate).HasColumnName("SMDeciPublDate");
			this.Property(t => t.AdvanceValidStartDate).HasColumnName("AdvanceValidStartDate");
			this.Property(t => t.AdvanceValidEndDate).HasColumnName("AdvanceValidEndDate");
			this.Property(t => t.PlaRatioPlanned).HasColumnName("PlaRatioPlanned");
			this.Property(t => t.PricingModel).HasColumnName("PricingModel");
			this.Property(t => t.PricingDescription).HasColumnName("PricingDescription");
			this.Property(t => t.PriceUnit).HasColumnName("PriceUnit");
			this.Property(t => t.PlaPriceCeilingRMB).HasColumnName("PlaPriceCeilingRMB");
			this.Property(t => t.PlaPriceFloorRMB).HasColumnName("PlaPriceFloorRMB");
			this.Property(t => t.PlaPriceCeilingFC).HasColumnName("PlaPriceCeilingFC");
			this.Property(t => t.PlaPriceFloorFC).HasColumnName("PlaPriceFloorFC");
			this.Property(t => t.AuthorizedDeclareDate).HasColumnName("AuthorizedDeclareDate");
			this.Property(t => t.PlaProspectusPublDate).HasColumnName("PlaProspectusPublDate");
			this.Property(t => t.WarrantAbbrName).HasColumnName("WarrantAbbrName");
			this.Property(t => t.WarrantCode).HasColumnName("WarrantCode");
			this.Property(t => t.ActualPlaRatio).HasColumnName("ActualPlaRatio");
			this.Property(t => t.PlaObject).HasColumnName("PlaObject");
			this.Property(t => t.ParValueRMB).HasColumnName("ParValueRMB");
			this.Property(t => t.PlaPriceRMB).HasColumnName("PlaPriceRMB");
			this.Property(t => t.PlaPriceFC).HasColumnName("PlaPriceFC");
			this.Property(t => t.PlannedPlaVol).HasColumnName("PlannedPlaVol");
			this.Property(t => t.OddLotsTreatment).HasColumnName("OddLotsTreatment");
			this.Property(t => t.LastTradingDay).HasColumnName("LastTradingDay");
			this.Property(t => t.ExRightDate).HasColumnName("ExRightDate");
			this.Property(t => t.RightRegDate).HasColumnName("RightRegDate");
			this.Property(t => t.WarrantTradeStartDate).HasColumnName("WarrantTradeStartDate");
			this.Property(t => t.WarrantTradeEndDate).HasColumnName("WarrantTradeEndDate");
			this.Property(t => t.PayStartDate).HasColumnName("PayStartDate");
			this.Property(t => t.PayEndDate).HasColumnName("PayEndDate");
			this.Property(t => t.PlaListDate).HasColumnName("PlaListDate");
			this.Property(t => t.IPOProceedsRMB).HasColumnName("IPOProceedsRMB");
			this.Property(t => t.IssueCostRMB).HasColumnName("IssueCostRMB");
			this.Property(t => t.IPONetProceedsRMB).HasColumnName("IPONetProceedsRMB");
			this.Property(t => t.IPOProceedsFC).HasColumnName("IPOProceedsFC");
			this.Property(t => t.IssueCostFC).HasColumnName("IssueCostFC");
			this.Property(t => t.IPONetProceedsFC).HasColumnName("IPONetProceedsFC");
			this.Property(t => t.SchemeChange).HasColumnName("SchemeChange");
			this.Property(t => t.ChangeStatement).HasColumnName("ChangeStatement");
			this.Property(t => t.UnderwritingMode).HasColumnName("UnderwritingMode");
			this.Property(t => t.ActualPlaVol).HasColumnName("ActualPlaVol");
			this.Property(t => t.UnderwriterBoughtVol).HasColumnName("UnderwriterBoughtVol");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

