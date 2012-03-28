using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_GrossDomesticProductMap : EntityTypeConfiguration<ED_GrossDomesticProduct>
	{
		public ED_GrossDomesticProductMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSources)
				.HasMaxLength(100);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_GrossDomesticProduct");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSources).HasColumnName("InfoSources");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.GNP).HasColumnName("GNP");
			this.Property(t => t.GDP).HasColumnName("GDP");
			this.Property(t => t.PrimaryIndustryGDP).HasColumnName("PrimaryIndustryGDP");
			this.Property(t => t.SecondIndustryGDP).HasColumnName("SecondIndustryGDP");
			this.Property(t => t.IndustryGDP).HasColumnName("IndustryGDP");
			this.Property(t => t.ConstructionGDP).HasColumnName("ConstructionGDP");
			this.Property(t => t.ThirdIndustryGDP).HasColumnName("ThirdIndustryGDP");
			this.Property(t => t.FarmingService).HasColumnName("FarmingService");
			this.Property(t => t.GeoExplWaterConservancy).HasColumnName("GeoExplWaterConservancy");
			this.Property(t => t.TrafficStorageTelecom).HasColumnName("TrafficStorageTelecom");
			this.Property(t => t.WRTradeFoodBeverage).HasColumnName("WRTradeFoodBeverage");
			this.Property(t => t.FinanceInsurance).HasColumnName("FinanceInsurance");
			this.Property(t => t.RealEstate).HasColumnName("RealEstate");
			this.Property(t => t.SocialService).HasColumnName("SocialService");
			this.Property(t => t.HealthSportsSocialWelfare).HasColumnName("HealthSportsSocialWelfare");
			this.Property(t => t.EduArtsRadioMoviesTV).HasColumnName("EduArtsRadioMoviesTV");
			this.Property(t => t.SciResearchTechService).HasColumnName("SciResearchTechService");
			this.Property(t => t.StatePartyOrgSocialGroup).HasColumnName("StatePartyOrgSocialGroup");
			this.Property(t => t.OtherSectors).HasColumnName("OtherSectors");
			this.Property(t => t.GDPPerCapita).HasColumnName("GDPPerCapita");
			this.Property(t => t.GDPGrowthYOY).HasColumnName("GDPGrowthYOY");
			this.Property(t => t.GYOYofPrimaryIndustryGDP).HasColumnName("GYOYofPrimaryIndustryGDP");
			this.Property(t => t.GYOYofSecondIndustryGDP).HasColumnName("GYOYofSecondIndustryGDP");
			this.Property(t => t.GYOYofTertiaryGDP).HasColumnName("GYOYofTertiaryGDP");
			this.Property(t => t.IncomeMethodGDP).HasColumnName("IncomeMethodGDP");
			this.Property(t => t.LaborCompensation).HasColumnName("LaborCompensation");
			this.Property(t => t.FixedAssetDepreciation).HasColumnName("FixedAssetDepreciation");
			this.Property(t => t.ProductionTaxNet).HasColumnName("ProductionTaxNet");
			this.Property(t => t.OperatingBalance).HasColumnName("OperatingBalance");
			this.Property(t => t.ExpenditureMethodGDP).HasColumnName("ExpenditureMethodGDP");
			this.Property(t => t.FinalConsumptionABSValue).HasColumnName("FinalConsumptionABSValue");
			this.Property(t => t.ResidentConsumption).HasColumnName("ResidentConsumption");
			this.Property(t => t.RuralResidentConsumption).HasColumnName("RuralResidentConsumption");
			this.Property(t => t.UrbanResidentConsumption).HasColumnName("UrbanResidentConsumption");
			this.Property(t => t.GovernmentalConsumption).HasColumnName("GovernmentalConsumption");
			this.Property(t => t.GrossCapitalFormedABSValue).HasColumnName("GrossCapitalFormedABSValue");
			this.Property(t => t.GrossFixedCapitalFormation).HasColumnName("GrossFixedCapitalFormation");
			this.Property(t => t.InventoryIncreasement).HasColumnName("InventoryIncreasement");
			this.Property(t => t.GoodsServicesNetExport).HasColumnName("GoodsServicesNetExport");
			this.Property(t => t.CapitalFormationRateInvest).HasColumnName("CapitalFormationRateInvest");
			this.Property(t => t.FinalConsumptionRate).HasColumnName("FinalConsumptionRate");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

