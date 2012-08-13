using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_FinancialBalanceMap : EntityTypeConfiguration<ED_FinancialBalance>
	{
		public ED_FinancialBalanceMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("ED_FinancialBalance");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.DataType).HasColumnName("DataType");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.FinancialRevenue).HasColumnName("FinancialRevenue");
			this.Property(t => t.Taxs).HasColumnName("Taxs");
			this.Property(t => t.CommercialTax).HasColumnName("CommercialTax");
			this.Property(t => t.ConsumptionTax).HasColumnName("ConsumptionTax");
			this.Property(t => t.ValueAddedTax).HasColumnName("ValueAddedTax");
			this.Property(t => t.VATCustom).HasColumnName("VATCustom");
			this.Property(t => t.SalesTax).HasColumnName("SalesTax");
			this.Property(t => t.StampTaxSecuTrade).HasColumnName("StampTaxSecuTrade");
			this.Property(t => t.CityMCTax).HasColumnName("CityMCTax");
			this.Property(t => t.DrawbackFTradeEnterprise).HasColumnName("DrawbackFTradeEnterprise");
			this.Property(t => t.IndividualIncomeTax).HasColumnName("IndividualIncomeTax");
			this.Property(t => t.EnterpriseIncomeTax).HasColumnName("EnterpriseIncomeTax");
			this.Property(t => t.IncomeTaxSOE).HasColumnName("IncomeTaxSOE");
			this.Property(t => t.IncomeTaxCollectiveCom).HasColumnName("IncomeTaxCollectiveCom");
			this.Property(t => t.CustomsDuties).HasColumnName("CustomsDuties");
			this.Property(t => t.AgriculturalTax).HasColumnName("AgriculturalTax");
			this.Property(t => t.AgricultureTax).HasColumnName("AgricultureTax");
			this.Property(t => t.DeedTax).HasColumnName("DeedTax");
			this.Property(t => t.FarmLandOccupationTax).HasColumnName("FarmLandOccupationTax");
			this.Property(t => t.VehiclePurchaseTax).HasColumnName("VehiclePurchaseTax");
			this.Property(t => t.OtherTax).HasColumnName("OtherTax");
			this.Property(t => t.EnterpriseIncome).HasColumnName("EnterpriseIncome");
			this.Property(t => t.LossSubsidy).HasColumnName("LossSubsidy");
			this.Property(t => t.LossSubsidyIE).HasColumnName("LossSubsidyIE");
			this.Property(t => t.LossSubsidyFE).HasColumnName("LossSubsidyFE");
			this.Property(t => t.LossSubsidyCE).HasColumnName("LossSubsidyCE");
			this.Property(t => t.MajorProjectFund).HasColumnName("MajorProjectFund");
			this.Property(t => t.BudgetAdjustFund).HasColumnName("BudgetAdjustFund");
			this.Property(t => t.EducationalFee).HasColumnName("EducationalFee");
			this.Property(t => t.OtherIncome).HasColumnName("OtherIncome");
			this.Property(t => t.DebtIncome).HasColumnName("DebtIncome");
			this.Property(t => t.FinancialExpenditure).HasColumnName("FinancialExpenditure");
			this.Property(t => t.CapitalConstruction).HasColumnName("CapitalConstruction");
			this.Property(t => t.AdditionalApprForCCapital).HasColumnName("AdditionalApprForCCapital");
			this.Property(t => t.EIFandSTP).HasColumnName("EIFandSTP");
			this.Property(t => t.EnterpriseInnovationFunds).HasColumnName("EnterpriseInnovationFunds");
			this.Property(t => t.SciTechPromotion).HasColumnName("SciTechPromotion");
			this.Property(t => t.GeoProspectingExpense).HasColumnName("GeoProspectingExpense");
			this.Property(t => t.OperatingExpensesITC).HasColumnName("OperatingExpensesITC");
			this.Property(t => t.SupportingAgriProduction).HasColumnName("SupportingAgriProduction");
			this.Property(t => t.ExpenditureAFIM).HasColumnName("ExpenditureAFIM");
			this.Property(t => t.ExpenditureCityMC).HasColumnName("ExpenditureCityMC");
			this.Property(t => t.OperatingExpensesCESH).HasColumnName("OperatingExpensesCESH");
			this.Property(t => t.OperExpensesE).HasColumnName("OperExpensesE");
			this.Property(t => t.PensionsSocialReliefFunds).HasColumnName("PensionsSocialReliefFunds");
			this.Property(t => t.SocialSecurity).HasColumnName("SocialSecurity");
			this.Property(t => t.NationalDefense).HasColumnName("NationalDefense");
			this.Property(t => t.GovAdmin).HasColumnName("GovAdmin");
			this.Property(t => t.PublidSecurityProcurCourt).HasColumnName("PublidSecurityProcurCourt");
			this.Property(t => t.ExpenditureArmy).HasColumnName("ExpenditureArmy");
			this.Property(t => t.SupportUnderdevelopedArea).HasColumnName("SupportUnderdevelopedArea");
			this.Property(t => t.TaxFeeVehicle).HasColumnName("TaxFeeVehicle");
			this.Property(t => t.OtherExpenditures).HasColumnName("OtherExpenditures");
			this.Property(t => t.IntrestExpense).HasColumnName("IntrestExpense");
			this.Property(t => t.OffsetRE).HasColumnName("OffsetRE");
			this.Property(t => t.ExpenditureOnDebt).HasColumnName("ExpenditureOnDebt");
			this.Property(t => t.OBRevenue).HasColumnName("OBRevenue");
			this.Property(t => t.OBGovAdmin).HasColumnName("OBGovAdmin");
			this.Property(t => t.OBFundRaisingTownshipGov).HasColumnName("OBFundRaisingTownshipGov");
			this.Property(t => t.OBLocalGovRevenue).HasColumnName("OBLocalGovRevenue");
			this.Property(t => t.OBSOERevenue).HasColumnName("OBSOERevenue");
			this.Property(t => t.OBExpenditure).HasColumnName("OBExpenditure");
			this.Property(t => t.OBCapitalConstruction).HasColumnName("OBCapitalConstruction");
			this.Property(t => t.OBSpecialExpense).HasColumnName("OBSpecialExpense");
			this.Property(t => t.OBAdminFee).HasColumnName("OBAdminFee");
			this.Property(t => t.OBTownshipExpense).HasColumnName("OBTownshipExpense");
			this.Property(t => t.OBOtherExpense).HasColumnName("OBOtherExpense");
			this.Property(t => t.CentralGovRevenue).HasColumnName("CentralGovRevenue");
			this.Property(t => t.LocalGovRevenue).HasColumnName("LocalGovRevenue");
			this.Property(t => t.CentralGovExpenditure).HasColumnName("CentralGovExpenditure");
			this.Property(t => t.LocalGovExpenditure).HasColumnName("LocalGovExpenditure");
			this.Property(t => t.OBCentralGovRevenue).HasColumnName("OBCentralGovRevenue");
			this.Property(t => t.OBLocalRevenue).HasColumnName("OBLocalRevenue");
			this.Property(t => t.OBCentralGovExpenditure).HasColumnName("OBCentralGovExpenditure");
			this.Property(t => t.OBLocalGovExpenditure).HasColumnName("OBLocalGovExpenditure");
			this.Property(t => t.GFinancialRevenue).HasColumnName("GFinancialRevenue");
			this.Property(t => t.GTaxs).HasColumnName("GTaxs");
			this.Property(t => t.GCommercialTax).HasColumnName("GCommercialTax");
			this.Property(t => t.GConsumptionTax).HasColumnName("GConsumptionTax");
			this.Property(t => t.GValueAddedTax).HasColumnName("GValueAddedTax");
			this.Property(t => t.GVATCustom).HasColumnName("GVATCustom");
			this.Property(t => t.GSalesTax).HasColumnName("GSalesTax");
			this.Property(t => t.GStampTaxSecuTrade).HasColumnName("GStampTaxSecuTrade");
			this.Property(t => t.GCityMCTax).HasColumnName("GCityMCTax");
			this.Property(t => t.GDrawbackFTradeEnterprise).HasColumnName("GDrawbackFTradeEnterprise");
			this.Property(t => t.GIndividualIncomeTax).HasColumnName("GIndividualIncomeTax");
			this.Property(t => t.GEnterpriseIncomeTax).HasColumnName("GEnterpriseIncomeTax");
			this.Property(t => t.GIncomeTaxSOE).HasColumnName("GIncomeTaxSOE");
			this.Property(t => t.GIncomeTaxCollectiveCom).HasColumnName("GIncomeTaxCollectiveCom");
			this.Property(t => t.GCustomsDuties).HasColumnName("GCustomsDuties");
			this.Property(t => t.GAgriculturalTax).HasColumnName("GAgriculturalTax");
			this.Property(t => t.GAgricultureTax).HasColumnName("GAgricultureTax");
			this.Property(t => t.GDeedTax).HasColumnName("GDeedTax");
			this.Property(t => t.GFarmLandOccupationTax).HasColumnName("GFarmLandOccupationTax");
			this.Property(t => t.GVehiclePurchaseTax).HasColumnName("GVehiclePurchaseTax");
			this.Property(t => t.GOtherTax).HasColumnName("GOtherTax");
			this.Property(t => t.GEnterpriseIncome).HasColumnName("GEnterpriseIncome");
			this.Property(t => t.GLossSubsidy).HasColumnName("GLossSubsidy");
			this.Property(t => t.GLossSubsidyIE).HasColumnName("GLossSubsidyIE");
			this.Property(t => t.GLossSubsidyFE).HasColumnName("GLossSubsidyFE");
			this.Property(t => t.GLossSubsidyCE).HasColumnName("GLossSubsidyCE");
			this.Property(t => t.GMajorProjectFund).HasColumnName("GMajorProjectFund");
			this.Property(t => t.GBudgetAdjustFund).HasColumnName("GBudgetAdjustFund");
			this.Property(t => t.GEducationalFee).HasColumnName("GEducationalFee");
			this.Property(t => t.GOtherIncome).HasColumnName("GOtherIncome");
			this.Property(t => t.GDebtIncome).HasColumnName("GDebtIncome");
			this.Property(t => t.GFinancialExpenditure).HasColumnName("GFinancialExpenditure");
			this.Property(t => t.GCapitalConstruction).HasColumnName("GCapitalConstruction");
			this.Property(t => t.GAdditionalApprForCCapital).HasColumnName("GAdditionalApprForCCapital");
			this.Property(t => t.GEIFandSTP).HasColumnName("GEIFandSTP");
			this.Property(t => t.GEnterpriseInnovationFunds).HasColumnName("GEnterpriseInnovationFunds");
			this.Property(t => t.GSciTechPromotion).HasColumnName("GSciTechPromotion");
			this.Property(t => t.GGeoProspectingExpense).HasColumnName("GGeoProspectingExpense");
			this.Property(t => t.GOperatingExpensesITC).HasColumnName("GOperatingExpensesITC");
			this.Property(t => t.GSupportingAgriProduction).HasColumnName("GSupportingAgriProduction");
			this.Property(t => t.GExpenditureAFIM).HasColumnName("GExpenditureAFIM");
			this.Property(t => t.GExpenditureCityMC).HasColumnName("GExpenditureCityMC");
			this.Property(t => t.GOperatingExpensesCESH).HasColumnName("GOperatingExpensesCESH");
			this.Property(t => t.GOperExpensesE).HasColumnName("GOperExpensesE");
			this.Property(t => t.GPensionsSocialReliefFunds).HasColumnName("GPensionsSocialReliefFunds");
			this.Property(t => t.GSocialSecurity).HasColumnName("GSocialSecurity");
			this.Property(t => t.GNationalDefense).HasColumnName("GNationalDefense");
			this.Property(t => t.GGovAdmin).HasColumnName("GGovAdmin");
			this.Property(t => t.GPublidSecurityProcurCourt).HasColumnName("GPublidSecurityProcurCourt");
			this.Property(t => t.GExpenditureArmy).HasColumnName("GExpenditureArmy");
			this.Property(t => t.GSupportUnderdevelopedArea).HasColumnName("GSupportUnderdevelopedArea");
			this.Property(t => t.GTaxFeeVehicle).HasColumnName("GTaxFeeVehicle");
			this.Property(t => t.GOtherExpenditures).HasColumnName("GOtherExpenditures");
			this.Property(t => t.GIntrestExpense).HasColumnName("GIntrestExpense");
			this.Property(t => t.GOffsetRE).HasColumnName("GOffsetRE");
			this.Property(t => t.GExpenditureOnDebt).HasColumnName("GExpenditureOnDebt");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

