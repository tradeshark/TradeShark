using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_BalanceSheetMap : EntityTypeConfiguration<MF_BalanceSheet>
	{
		public MF_BalanceSheetMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("MF_BalanceSheet");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.Cash).HasColumnName("Cash");
			this.Property(t => t.Deposit).HasColumnName("Deposit");
			this.Property(t => t.SettlementproviDealCover).HasColumnName("SettlementproviDealCover");
			this.Property(t => t.Settlementprovi).HasColumnName("Settlementprovi");
			this.Property(t => t.DealCover).HasColumnName("DealCover");
			this.Property(t => t.SecuSettlementReceivables).HasColumnName("SecuSettlementReceivables");
			this.Property(t => t.DividendReceivables).HasColumnName("DividendReceivables");
			this.Property(t => t.Receivables).HasColumnName("Receivables");
			this.Property(t => t.InterestReceivables).HasColumnName("InterestReceivables");
			this.Property(t => t.ApplyingReceivables).HasColumnName("ApplyingReceivables");
			this.Property(t => t.OtherReceivables).HasColumnName("OtherReceivables");
			this.Property(t => t.StockInvestMarketValue).HasColumnName("StockInvestMarketValue");
			this.Property(t => t.StockInvestCost).HasColumnName("StockInvestCost");
			this.Property(t => t.ShareInvestValueAdded).HasColumnName("ShareInvestValueAdded");
			this.Property(t => t.BondInvestMarketValue).HasColumnName("BondInvestMarketValue");
			this.Property(t => t.BondInvestCost).HasColumnName("BondInvestCost");
			this.Property(t => t.BondInvestValueAdded).HasColumnName("BondInvestValueAdded");
			this.Property(t => t.OtherInvestMarketValue).HasColumnName("OtherInvestMarketValue");
			this.Property(t => t.OtherInvestCost).HasColumnName("OtherInvestCost");
			this.Property(t => t.OtherInvestValueAdded).HasColumnName("OtherInvestValueAdded");
			this.Property(t => t.StockOption).HasColumnName("StockOption");
			this.Property(t => t.BoughtSellbackSecu).HasColumnName("BoughtSellbackSecu");
			this.Property(t => t.DeferredExpense).HasColumnName("DeferredExpense");
			this.Property(t => t.OtherAsset).HasColumnName("OtherAsset");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.SecuSettlementPayables).HasColumnName("SecuSettlementPayables");
			this.Property(t => t.RedemptionMoneyPayable).HasColumnName("RedemptionMoneyPayable");
			this.Property(t => t.RedemptionFeePayable).HasColumnName("RedemptionFeePayable");
			this.Property(t => t.ManagementFeePayable).HasColumnName("ManagementFeePayable");
			this.Property(t => t.TrustFeePayable).HasColumnName("TrustFeePayable");
			this.Property(t => t.PerformancePayment).HasColumnName("PerformancePayment");
			this.Property(t => t.ProfitPayable).HasColumnName("ProfitPayable");
			this.Property(t => t.AccountPayable).HasColumnName("AccountPayable");
			this.Property(t => t.CommisionPayable).HasColumnName("CommisionPayable");
			this.Property(t => t.AllocationFundPayable).HasColumnName("AllocationFundPayable");
			this.Property(t => t.TaxPayable).HasColumnName("TaxPayable");
			this.Property(t => t.BondDistributionPayable).HasColumnName("BondDistributionPayable");
			this.Property(t => t.InterestPayable).HasColumnName("InterestPayable");
			this.Property(t => t.OtherPayable).HasColumnName("OtherPayable");
			this.Property(t => t.SoldRepoSecuProceeds).HasColumnName("SoldRepoSecuProceeds");
			this.Property(t => t.ShortTermLoan).HasColumnName("ShortTermLoan");
			this.Property(t => t.AccruedExpense).HasColumnName("AccruedExpense");
			this.Property(t => t.OtherDebts).HasColumnName("OtherDebts");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.Capital).HasColumnName("Capital");
			this.Property(t => t.UnrealizedProfit).HasColumnName("UnrealizedProfit");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.OtherEquity).HasColumnName("OtherEquity");
			this.Property(t => t.TotalShareHolderEquity).HasColumnName("TotalShareHolderEquity");
			this.Property(t => t.TotalLiabilityAndEquity).HasColumnName("TotalLiabilityAndEquity");
			this.Property(t => t.UnitNV).HasColumnName("UnitNV");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.WarrantInvestMarketValue).HasColumnName("WarrantInvestMarketValue");
			this.Property(t => t.WarrantInvestCost).HasColumnName("WarrantInvestCost");
			this.Property(t => t.WarrantInvestValueAdded).HasColumnName("WarrantInvestValueAdded");
			this.Property(t => t.SaleFeePayable).HasColumnName("SaleFeePayable");
		}
	}
}

