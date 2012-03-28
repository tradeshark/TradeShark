using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_FixedInvestmentMap : EntityTypeConfiguration<ED_FixedInvestment>
	{
		public ED_FixedInvestmentMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSources)
				.HasMaxLength(50);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_FixedInvestment");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSources).HasColumnName("InfoSources");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.SectorsType).HasColumnName("SectorsType");
			this.Property(t => t.EnterPriseType).HasColumnName("EnterPriseType");
			this.Property(t => t.CurrentPeriodCompletedInv).HasColumnName("CurrentPeriodCompletedInv");
			this.Property(t => t.PlannedInv).HasColumnName("PlannedInv");
			this.Property(t => t.ActualCompletedInv).HasColumnName("ActualCompletedInv");
			this.Property(t => t.StateControlledInv).HasColumnName("StateControlledInv");
			this.Property(t => t.House).HasColumnName("House");
			this.Property(t => t.Flat).HasColumnName("Flat");
			this.Property(t => t.EconomicalHouse).HasColumnName("EconomicalHouse");
			this.Property(t => t.Mansion).HasColumnName("Mansion");
			this.Property(t => t.BusinessBuilding).HasColumnName("BusinessBuilding");
			this.Property(t => t.OtherPurposeInv).HasColumnName("OtherPurposeInv");
			this.Property(t => t.HouseCommodityInv).HasColumnName("HouseCommodityInv");
			this.Property(t => t.LandDevelopmentInv).HasColumnName("LandDevelopmentInv");
			this.Property(t => t.CompletedUrbanInv).HasColumnName("CompletedUrbanInv");
			this.Property(t => t.CompletedRuralInv).HasColumnName("CompletedRuralInv");
			this.Property(t => t.RuralCollectivesInv).HasColumnName("RuralCollectivesInv");
			this.Property(t => t.RuralPersonalInv).HasColumnName("RuralPersonalInv");
			this.Property(t => t.InfrasructureInv).HasColumnName("InfrasructureInv");
			this.Property(t => t.VehicleShipAircraftPurchase).HasColumnName("VehicleShipAircraftPurchase");
			this.Property(t => t.ReplacementRenovationInv).HasColumnName("ReplacementRenovationInv");
			this.Property(t => t.RealEstateDevelopmentInv).HasColumnName("RealEstateDevelopmentInv");
			this.Property(t => t.OtherInv).HasColumnName("OtherInv");
			this.Property(t => t.CentralGovernmentProjects).HasColumnName("CentralGovernmentProjects");
			this.Property(t => t.LocalGovernmentProjects).HasColumnName("LocalGovernmentProjects");
			this.Property(t => t.NewConstruction).HasColumnName("NewConstruction");
			this.Property(t => t.Expansion).HasColumnName("Expansion");
			this.Property(t => t.Renovation).HasColumnName("Renovation");
			this.Property(t => t.PrimaryIndustry).HasColumnName("PrimaryIndustry");
			this.Property(t => t.SecondIndustry).HasColumnName("SecondIndustry");
			this.Property(t => t.ThirdIndustry).HasColumnName("ThirdIndustry");
			this.Property(t => t.EasternRegion).HasColumnName("EasternRegion");
			this.Property(t => t.CentralRegion).HasColumnName("CentralRegion");
			this.Property(t => t.WesternRegion).HasColumnName("WesternRegion");
			this.Property(t => t.ConstructionInstallation).HasColumnName("ConstructionInstallation");
			this.Property(t => t.EquipmentVehiclePurchase).HasColumnName("EquipmentVehiclePurchase");
			this.Property(t => t.OtherExpenditure).HasColumnName("OtherExpenditure");
			this.Property(t => t.FixedAssetAdded).HasColumnName("FixedAssetAdded");
			this.Property(t => t.BuildingAcreage).HasColumnName("BuildingAcreage");
			this.Property(t => t.HouseAcreage).HasColumnName("HouseAcreage");
			this.Property(t => t.FinishedBuildingAcreage).HasColumnName("FinishedBuildingAcreage");
			this.Property(t => t.FinishedHouseAcreage).HasColumnName("FinishedHouseAcreage");
			this.Property(t => t.ProjectsNumber).HasColumnName("ProjectsNumber");
			this.Property(t => t.ProjectsAdded).HasColumnName("ProjectsAdded");
			this.Property(t => t.PlannedInvOfProjects).HasColumnName("PlannedInvOfProjects");
			this.Property(t => t.PlannedInvOfProjectsAdded).HasColumnName("PlannedInvOfProjectsAdded");
			this.Property(t => t.FinishedLandAcreage).HasColumnName("FinishedLandAcreage");
			this.Property(t => t.DevelopingLandAcreage).HasColumnName("DevelopingLandAcreage");
			this.Property(t => t.AcreageOfLandToDevelope).HasColumnName("AcreageOfLandToDevelope");
			this.Property(t => t.AcreageOfLandPurchased).HasColumnName("AcreageOfLandPurchased");
			this.Property(t => t.ExpenseOfLandPurchased).HasColumnName("ExpenseOfLandPurchased");
			this.Property(t => t.TotalFundSource).HasColumnName("TotalFundSource");
			this.Property(t => t.BalanceLastYear).HasColumnName("BalanceLastYear");
			this.Property(t => t.CurrentPeriodFundSources).HasColumnName("CurrentPeriodFundSources");
			this.Property(t => t.FundWithinNationalBudget).HasColumnName("FundWithinNationalBudget");
			this.Property(t => t.NationalLoans).HasColumnName("NationalLoans");
			this.Property(t => t.Bonds).HasColumnName("Bonds");
			this.Property(t => t.ForeignCapital).HasColumnName("ForeignCapital");
			this.Property(t => t.FDI).HasColumnName("FDI");
			this.Property(t => t.FundRaisingAndOtherInv).HasColumnName("FundRaisingAndOtherInv");
			this.Property(t => t.FundRaising).HasColumnName("FundRaising");
			this.Property(t => t.OrgSelfOwnedCapital).HasColumnName("OrgSelfOwnedCapital");
			this.Property(t => t.StockIssuance).HasColumnName("StockIssuance");
			this.Property(t => t.OtherFund).HasColumnName("OtherFund");
			this.Property(t => t.DepositPrepayment).HasColumnName("DepositPrepayment");
			this.Property(t => t.TotalPayables).HasColumnName("TotalPayables");
			this.Property(t => t.ProjectMoney).HasColumnName("ProjectMoney");
			this.Property(t => t.EquipmentMoney).HasColumnName("EquipmentMoney");
			this.Property(t => t.GYoYCompletedInv).HasColumnName("GYoYCompletedInv");
			this.Property(t => t.GYoYPlannedInv).HasColumnName("GYoYPlannedInv");
			this.Property(t => t.GYoYActualCompletedInv).HasColumnName("GYoYActualCompletedInv");
			this.Property(t => t.GYoYStateControlledInv).HasColumnName("GYoYStateControlledInv");
			this.Property(t => t.GYoYHouse).HasColumnName("GYoYHouse");
			this.Property(t => t.GYoYFlat).HasColumnName("GYoYFlat");
			this.Property(t => t.GYoYEconomicalHouse).HasColumnName("GYoYEconomicalHouse");
			this.Property(t => t.GYoYMansion).HasColumnName("GYoYMansion");
			this.Property(t => t.GYoYBusinessBuilding).HasColumnName("GYoYBusinessBuilding");
			this.Property(t => t.GYoYOtherPurposeInv).HasColumnName("GYoYOtherPurposeInv");
			this.Property(t => t.GYoYHouseCommodityInv).HasColumnName("GYoYHouseCommodityInv");
			this.Property(t => t.GYoYLandDevelopmentInv).HasColumnName("GYoYLandDevelopmentInv");
			this.Property(t => t.GYoYCompletedUrbanInv).HasColumnName("GYoYCompletedUrbanInv");
			this.Property(t => t.GYoYCompletedRuralInv).HasColumnName("GYoYCompletedRuralInv");
			this.Property(t => t.GYoYRuralCollectivesInv).HasColumnName("GYoYRuralCollectivesInv");
			this.Property(t => t.GYoYRuralPersonalInv).HasColumnName("GYoYRuralPersonalInv");
			this.Property(t => t.GYoYInfrasructureInv).HasColumnName("GYoYInfrasructureInv");
			this.Property(t => t.GYoYVSAPurchase).HasColumnName("GYoYVSAPurchase");
			this.Property(t => t.GYoYRRInv).HasColumnName("GYoYRRInv");
			this.Property(t => t.GYoYRealEstateInv).HasColumnName("GYoYRealEstateInv");
			this.Property(t => t.GYoYOtherInv).HasColumnName("GYoYOtherInv");
			this.Property(t => t.GYoYCentralGovProjects).HasColumnName("GYoYCentralGovProjects");
			this.Property(t => t.GYoYLocalGovProjects).HasColumnName("GYoYLocalGovProjects");
			this.Property(t => t.GYoYNewConstruction).HasColumnName("GYoYNewConstruction");
			this.Property(t => t.GYoYExpansion).HasColumnName("GYoYExpansion");
			this.Property(t => t.GYoYRenovation).HasColumnName("GYoYRenovation");
			this.Property(t => t.GYoYPrimaryIndustry).HasColumnName("GYoYPrimaryIndustry");
			this.Property(t => t.GYoYSecondIndustry).HasColumnName("GYoYSecondIndustry");
			this.Property(t => t.GYoYThirdIndustry).HasColumnName("GYoYThirdIndustry");
			this.Property(t => t.GYoYEasternRegion).HasColumnName("GYoYEasternRegion");
			this.Property(t => t.GYoYCentralRegion).HasColumnName("GYoYCentralRegion");
			this.Property(t => t.GYoYWesternRegion).HasColumnName("GYoYWesternRegion");
			this.Property(t => t.GYoYConstrInstal).HasColumnName("GYoYConstrInstal");
			this.Property(t => t.GYoYEVPurchase).HasColumnName("GYoYEVPurchase");
			this.Property(t => t.GYoYOtherExpenditure).HasColumnName("GYoYOtherExpenditure");
			this.Property(t => t.GYoYFixedAssetAdded).HasColumnName("GYoYFixedAssetAdded");
			this.Property(t => t.GYoYBuildingAcreage).HasColumnName("GYoYBuildingAcreage");
			this.Property(t => t.GYoYHouseAcreage).HasColumnName("GYoYHouseAcreage");
			this.Property(t => t.GYoYFBuildingAcreage).HasColumnName("GYoYFBuildingAcreage");
			this.Property(t => t.GYoYFHouseAcreage).HasColumnName("GYoYFHouseAcreage");
			this.Property(t => t.GYoYProjectsNumber).HasColumnName("GYoYProjectsNumber");
			this.Property(t => t.GYoYProjectsAdded).HasColumnName("GYoYProjectsAdded");
			this.Property(t => t.GYoYPlannedInvProjects).HasColumnName("GYoYPlannedInvProjects");
			this.Property(t => t.GYoYPInvProjectsAdded).HasColumnName("GYoYPInvProjectsAdded");
			this.Property(t => t.GYoYFinishedLandAcreage).HasColumnName("GYoYFinishedLandAcreage");
			this.Property(t => t.GYoYDevelopingLandAcreage).HasColumnName("GYoYDevelopingLandAcreage");
			this.Property(t => t.GYoYAcreageLandToDevelop).HasColumnName("GYoYAcreageLandToDevelop");
			this.Property(t => t.GYoYAcreageLandPurchased).HasColumnName("GYoYAcreageLandPurchased");
			this.Property(t => t.GYoYExpenseOfLandPurchase).HasColumnName("GYoYExpenseOfLandPurchase");
			this.Property(t => t.GYoYTotalFundSource).HasColumnName("GYoYTotalFundSource");
			this.Property(t => t.GYoYBalanceLastYear).HasColumnName("GYoYBalanceLastYear");
			this.Property(t => t.GYoYCPFundSources).HasColumnName("GYoYCPFundSources");
			this.Property(t => t.GYoYFundWithinNBudget).HasColumnName("GYoYFundWithinNBudget");
			this.Property(t => t.GYoYNationalLoans).HasColumnName("GYoYNationalLoans");
			this.Property(t => t.GYoYBonds).HasColumnName("GYoYBonds");
			this.Property(t => t.GYoYForeignCapital).HasColumnName("GYoYForeignCapital");
			this.Property(t => t.GYoYFDI).HasColumnName("GYoYFDI");
			this.Property(t => t.GYoYFundRaisingOtherInv).HasColumnName("GYoYFundRaisingOtherInv");
			this.Property(t => t.GYoYFundRaising).HasColumnName("GYoYFundRaising");
			this.Property(t => t.GYoYOrgSelfOwnedCapital).HasColumnName("GYoYOrgSelfOwnedCapital");
			this.Property(t => t.GYoYStockIssuance).HasColumnName("GYoYStockIssuance");
			this.Property(t => t.GYoYOtherFund).HasColumnName("GYoYOtherFund");
			this.Property(t => t.GYoYDepositPrepayment).HasColumnName("GYoYDepositPrepayment");
			this.Property(t => t.GYoYTotalPayables).HasColumnName("GYoYTotalPayables");
			this.Property(t => t.GYoYProjectMoney).HasColumnName("GYoYProjectMoney");
			this.Property(t => t.GYoYEquipmentMoney).HasColumnName("GYoYEquipmentMoney");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

