using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_WorkandGrowIndexMap : EntityTypeConfiguration<LC_WorkandGrowIndex>
	{
		public LC_WorkandGrowIndexMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_WorkandGrowIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.NetAssetGrowRate).HasColumnName("NetAssetGrowRate");
			this.Property(t => t.NetProfitGrowRate).HasColumnName("NetProfitGrowRate");
			this.Property(t => t.MainIncomeGrowRate).HasColumnName("MainIncomeGrowRate");
			this.Property(t => t.GrossProfitGrowRate).HasColumnName("GrossProfitGrowRate");
			this.Property(t => t.OperProfitGrowRate).HasColumnName("OperProfitGrowRate");
			this.Property(t => t.TotalProfeiGrowRate).HasColumnName("TotalProfeiGrowRate");
			this.Property(t => t.TotalAssetGrowRate).HasColumnName("TotalAssetGrowRate");
			this.Property(t => t.ARTRGrowRate).HasColumnName("ARTRGrowRate");
			this.Property(t => t.FATRGrowRate).HasColumnName("FATRGrowRate");
			this.Property(t => t.FAExpansionRate).HasColumnName("FAExpansionRate");
			this.Property(t => t.CapitalItemKeepRate).HasColumnName("CapitalItemKeepRate");
			this.Property(t => t.InventoryTRGrowRate).HasColumnName("InventoryTRGrowRate");
			this.Property(t => t.OperCashPSGrowRate).HasColumnName("OperCashPSGrowRate");
			this.Property(t => t.CashEquivalentsGroRate).HasColumnName("CashEquivalentsGroRate");
			this.Property(t => t.SustainableGrowRate).HasColumnName("SustainableGrowRate");
			this.Property(t => t.PBVGrowRate).HasColumnName("PBVGrowRate");
			this.Property(t => t.EPSGrowRate).HasColumnName("EPSGrowRate");
			this.Property(t => t.OperCycle).HasColumnName("OperCycle");
			this.Property(t => t.InventoryTRate).HasColumnName("InventoryTRate");
			this.Property(t => t.InventoryTDays).HasColumnName("InventoryTDays");
			this.Property(t => t.ARTRate).HasColumnName("ARTRate");
			this.Property(t => t.ARTDays).HasColumnName("ARTDays");
			this.Property(t => t.CreditTRate).HasColumnName("CreditTRate");
			this.Property(t => t.CurrentTRate).HasColumnName("CurrentTRate");
			this.Property(t => t.TotalAssetTRate).HasColumnName("TotalAssetTRate");
			this.Property(t => t.FixedAssetTRate).HasColumnName("FixedAssetTRate");
			this.Property(t => t.EquityTRate).HasColumnName("EquityTRate");
			this.Property(t => t.AssetLossRatio).HasColumnName("AssetLossRatio");
			this.Property(t => t.NewnessRate).HasColumnName("NewnessRate");
			this.Property(t => t.AccruedPayableTRate).HasColumnName("AccruedPayableTRate");
			this.Property(t => t.FinancialLeverage).HasColumnName("FinancialLeverage");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.EPSWeighted).HasColumnName("EPSWeighted");
			this.Property(t => t.EPSCut).HasColumnName("EPSCut");
			this.Property(t => t.EPSCutWeighted).HasColumnName("EPSCutWeighted");
			this.Property(t => t.NetAssetPS).HasColumnName("NetAssetPS");
			this.Property(t => t.NetAssetPSAdjusted).HasColumnName("NetAssetPSAdjusted");
			this.Property(t => t.AccumulationFundPS).HasColumnName("AccumulationFundPS");
			this.Property(t => t.UndividedProfit).HasColumnName("UndividedProfit");
			this.Property(t => t.OperCashFlowPS).HasColumnName("OperCashFlowPS");
			this.Property(t => t.CashEquivalentPS).HasColumnName("CashEquivalentPS");
			this.Property(t => t.OperProfitPS).HasColumnName("OperProfitPS");
			this.Property(t => t.MainOperProfitPS).HasColumnName("MainOperProfitPS");
			this.Property(t => t.DividendPS).HasColumnName("DividendPS");
			this.Property(t => t.MainIncomePS).HasColumnName("MainIncomePS");
			this.Property(t => t.CashFlowPS).HasColumnName("CashFlowPS");
			this.Property(t => t.CapitalSurplusFundPS).HasColumnName("CapitalSurplusFundPS");
			this.Property(t => t.EnterpriseValue).HasColumnName("EnterpriseValue");
			this.Property(t => t.Q).HasColumnName("Q");
			this.Property(t => t.EVPS).HasColumnName("EVPS");
			this.Property(t => t.EVtoEBITDA).HasColumnName("EVtoEBITDA");
			this.Property(t => t.MVA).HasColumnName("MVA");
			this.Property(t => t.FloatMVA).HasColumnName("FloatMVA");
			this.Property(t => t.CompanyDividendRatio).HasColumnName("CompanyDividendRatio");
			this.Property(t => t.MarketValueToDebt1).HasColumnName("MarketValueToDebt1");
			this.Property(t => t.MarketValueToDebt2).HasColumnName("MarketValueToDebt2");
			this.Property(t => t.DebtToAssetValue1).HasColumnName("DebtToAssetValue1");
			this.Property(t => t.DebtToAssetValue2).HasColumnName("DebtToAssetValue2");
			this.Property(t => t.CompanyPERatio1).HasColumnName("CompanyPERatio1");
			this.Property(t => t.CompanyPERatio2).HasColumnName("CompanyPERatio2");
			this.Property(t => t.CompanyPERatio3).HasColumnName("CompanyPERatio3");
			this.Property(t => t.CompanyPBRatio).HasColumnName("CompanyPBRatio");
			this.Property(t => t.CompanyPBRatioAdjusted).HasColumnName("CompanyPBRatioAdjusted");
			this.Property(t => t.CompanyCFM1).HasColumnName("CompanyCFM1");
			this.Property(t => t.CompanyCFM2).HasColumnName("CompanyCFM2");
			this.Property(t => t.CompanyCFM3).HasColumnName("CompanyCFM3");
			this.Property(t => t.CompanyPSRatio1).HasColumnName("CompanyPSRatio1");
			this.Property(t => t.CompanyPSRatio2).HasColumnName("CompanyPSRatio2");
			this.Property(t => t.CompanyPSRatio3).HasColumnName("CompanyPSRatio3");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

