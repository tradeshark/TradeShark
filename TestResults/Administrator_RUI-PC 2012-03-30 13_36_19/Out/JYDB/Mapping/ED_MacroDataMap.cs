using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_MacroDataMap : EntityTypeConfiguration<ED_MacroData>
	{
		public ED_MacroDataMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ED_MacroData");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Country).HasColumnName("Country");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.GNP).HasColumnName("GNP");
			this.Property(t => t.GDP).HasColumnName("GDP");
			this.Property(t => t.GrowthGDP).HasColumnName("GrowthGDP");
			this.Property(t => t.PrimaryIndustry).HasColumnName("PrimaryIndustry");
			this.Property(t => t.GrowthRateP).HasColumnName("GrowthRateP");
			this.Property(t => t.SecondIndustry).HasColumnName("SecondIndustry");
			this.Property(t => t.GrowthRateS).HasColumnName("GrowthRateS");
			this.Property(t => t.ThirdIndustry).HasColumnName("ThirdIndustry");
			this.Property(t => t.GrowthRateT).HasColumnName("GrowthRateT");
			this.Property(t => t.PerCapitaGDP).HasColumnName("PerCapitaGDP");
			this.Property(t => t.UrbanResidentDI).HasColumnName("UrbanResidentDI");
			this.Property(t => t.RuralResidentDCI).HasColumnName("RuralResidentDCI");
			this.Property(t => t.IndustrialValueAdded).HasColumnName("IndustrialValueAdded");
			this.Property(t => t.GrowthIVA).HasColumnName("GrowthIVA");
			this.Property(t => t.LIVA).HasColumnName("LIVA");
			this.Property(t => t.HIVA).HasColumnName("HIVA");
			this.Property(t => t.StateOwnedControlledCom).HasColumnName("StateOwnedControlledCom");
			this.Property(t => t.CollectiveCom).HasColumnName("CollectiveCom");
			this.Property(t => t.StockCooperativeCom).HasColumnName("StockCooperativeCom");
			this.Property(t => t.JointStockCom).HasColumnName("JointStockCom");
			this.Property(t => t.ForeignHKMacauTaiwanInv).HasColumnName("ForeignHKMacauTaiwanInv");
			this.Property(t => t.GIP90ConstantValue).HasColumnName("GIP90ConstantValue");
			this.Property(t => t.GrowthGIP90ConstantValue).HasColumnName("GrowthGIP90ConstantValue");
			this.Property(t => t.ProductionSalesRatio).HasColumnName("ProductionSalesRatio");
			this.Property(t => t.GrowthPSR).HasColumnName("GrowthPSR");
			this.Property(t => t.FixedAssetInv).HasColumnName("FixedAssetInv");
			this.Property(t => t.InfrastructureInv).HasColumnName("InfrastructureInv");
			this.Property(t => t.RenovationInv).HasColumnName("RenovationInv");
			this.Property(t => t.RealEstateInv).HasColumnName("RealEstateInv");
			this.Property(t => t.PrimaryIndustryInv).HasColumnName("PrimaryIndustryInv");
			this.Property(t => t.SecondIndustryInv).HasColumnName("SecondIndustryInv");
			this.Property(t => t.ThirdIndustryInv).HasColumnName("ThirdIndustryInv");
			this.Property(t => t.EasternRegionInv).HasColumnName("EasternRegionInv");
			this.Property(t => t.CentralRegionInv).HasColumnName("CentralRegionInv");
			this.Property(t => t.WesternRegionInv).HasColumnName("WesternRegionInv");
			this.Property(t => t.FinancialRE).HasColumnName("FinancialRE");
			this.Property(t => t.FinancialR).HasColumnName("FinancialR");
			this.Property(t => t.FinancialE).HasColumnName("FinancialE");
			this.Property(t => t.TaxRevenues).HasColumnName("TaxRevenues");
			this.Property(t => t.InfrastructureE).HasColumnName("InfrastructureE");
			this.Property(t => t.RetailValueSC).HasColumnName("RetailValueSC");
			this.Property(t => t.ImportExportValueOfGoods).HasColumnName("ImportExportValueOfGoods");
			this.Property(t => t.ExportValueOfGoods).HasColumnName("ExportValueOfGoods");
			this.Property(t => t.ImportValueOfGoods).HasColumnName("ImportValueOfGoods");
			this.Property(t => t.ApprovedContractualFInv).HasColumnName("ApprovedContractualFInv");
			this.Property(t => t.ActualFInv).HasColumnName("ActualFInv");
			this.Property(t => t.BroadMoney).HasColumnName("BroadMoney");
			this.Property(t => t.NarrowMoney).HasColumnName("NarrowMoney");
			this.Property(t => t.CashCirculation).HasColumnName("CashCirculation");
			this.Property(t => t.NetAmountCash).HasColumnName("NetAmountCash");
			this.Property(t => t.FISavings).HasColumnName("FISavings");
			this.Property(t => t.CorporateSavings).HasColumnName("CorporateSavings");
			this.Property(t => t.ResidentSavings).HasColumnName("ResidentSavings");
			this.Property(t => t.FILoans).HasColumnName("FILoans");
			this.Property(t => t.ShortTermLoans).HasColumnName("ShortTermLoans");
			this.Property(t => t.MediumLongTermLoans).HasColumnName("MediumLongTermLoans");
			this.Property(t => t.StateBankSavings).HasColumnName("StateBankSavings");
			this.Property(t => t.CorporateSavingsSB).HasColumnName("CorporateSavingsSB");
			this.Property(t => t.ResidentSavingsSB).HasColumnName("ResidentSavingsSB");
			this.Property(t => t.StateBankLoans).HasColumnName("StateBankLoans");
			this.Property(t => t.ShortTermLoansSB).HasColumnName("ShortTermLoansSB");
			this.Property(t => t.ICLoansSB).HasColumnName("ICLoansSB");
			this.Property(t => t.MediumLongTermLoansSB).HasColumnName("MediumLongTermLoansSB");
			this.Property(t => t.ForeignReserves).HasColumnName("ForeignReserves");
			this.Property(t => t.GoldReserves).HasColumnName("GoldReserves");
			this.Property(t => t.NationalRCPI).HasColumnName("NationalRCPI");
			this.Property(t => t.UrbanRCPI).HasColumnName("UrbanRCPI");
			this.Property(t => t.RuralRCPI).HasColumnName("RuralRCPI");
			this.Property(t => t.NationalCRPI).HasColumnName("NationalCRPI");
			this.Property(t => t.UrbanCRPI).HasColumnName("UrbanCRPI");
			this.Property(t => t.RuralCRPI).HasColumnName("RuralCRPI");
			this.Property(t => t.GeneralPGPI).HasColumnName("GeneralPGPI");
			this.Property(t => t.AgriculturePGPI).HasColumnName("AgriculturePGPI");
			this.Property(t => t.InflationRate).HasColumnName("InflationRate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

