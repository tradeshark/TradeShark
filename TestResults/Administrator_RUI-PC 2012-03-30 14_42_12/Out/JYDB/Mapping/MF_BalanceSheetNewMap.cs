using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_BalanceSheetNewMap : EntityTypeConfiguration<MF_BalanceSheetNew>
	{
		public MF_BalanceSheetNewMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("MF_BalanceSheetNew");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.Deposit).HasColumnName("Deposit");
			this.Property(t => t.SettlementProvi).HasColumnName("SettlementProvi");
			this.Property(t => t.RefundableDeposit).HasColumnName("RefundableDeposit");
			this.Property(t => t.TradingAssets).HasColumnName("TradingAssets");
			this.Property(t => t.StockInvestment).HasColumnName("StockInvestment");
			this.Property(t => t.BondInvestment).HasColumnName("BondInvestment");
			this.Property(t => t.ABSInvestment).HasColumnName("ABSInvestment");
			this.Property(t => t.FundInvestment).HasColumnName("FundInvestment");
			this.Property(t => t.WarrentInvestment).HasColumnName("WarrentInvestment");
			this.Property(t => t.DerivativeAssets).HasColumnName("DerivativeAssets");
			this.Property(t => t.BoughtSellbackAssets).HasColumnName("BoughtSellbackAssets");
			this.Property(t => t.SecuSettlementReceivables).HasColumnName("SecuSettlementReceivables");
			this.Property(t => t.InterestReceivables).HasColumnName("InterestReceivables");
			this.Property(t => t.DividendReceivables).HasColumnName("DividendReceivables");
			this.Property(t => t.ApplyingReceivables).HasColumnName("ApplyingReceivables");
			this.Property(t => t.AccountReceivables).HasColumnName("AccountReceivables");
			this.Property(t => t.OtherReceivables).HasColumnName("OtherReceivables");
			this.Property(t => t.DeferrredExpense).HasColumnName("DeferrredExpense");
			this.Property(t => t.OtherAssets).HasColumnName("OtherAssets");
			this.Property(t => t.AExceptionalItems).HasColumnName("AExceptionalItems");
			this.Property(t => t.AAdjustmentItems).HasColumnName("AAdjustmentItems");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.ShortTermLoan).HasColumnName("ShortTermLoan");
			this.Property(t => t.TradingLiability).HasColumnName("TradingLiability");
			this.Property(t => t.DerivativeLiability).HasColumnName("DerivativeLiability");
			this.Property(t => t.SoldBuybackSecuProceeds).HasColumnName("SoldBuybackSecuProceeds");
			this.Property(t => t.SecuSettlementPayables).HasColumnName("SecuSettlementPayables");
			this.Property(t => t.RedemptionMoneyPayable).HasColumnName("RedemptionMoneyPayable");
			this.Property(t => t.RedemptionFeePayable).HasColumnName("RedemptionFeePayable");
			this.Property(t => t.ManagementFeePayable).HasColumnName("ManagementFeePayable");
			this.Property(t => t.TrustFeePayable).HasColumnName("TrustFeePayable");
			this.Property(t => t.SalesFeePayable).HasColumnName("SalesFeePayable");
			this.Property(t => t.TransactionFeePayable).HasColumnName("TransactionFeePayable");
			this.Property(t => t.TaxsPayable).HasColumnName("TaxsPayable");
			this.Property(t => t.InterestPayable).HasColumnName("InterestPayable");
			this.Property(t => t.ProfitPayable).HasColumnName("ProfitPayable");
			this.Property(t => t.AccountPayable).HasColumnName("AccountPayable");
			this.Property(t => t.OtherPayable).HasColumnName("OtherPayable");
			this.Property(t => t.AccruedExpense).HasColumnName("AccruedExpense");
			this.Property(t => t.OtherLiability).HasColumnName("OtherLiability");
			this.Property(t => t.LExceptionalItems).HasColumnName("LExceptionalItems");
			this.Property(t => t.LAdjustmentItems).HasColumnName("LAdjustmentItems");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.PaidInCapital).HasColumnName("PaidInCapital");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.OtherEquity).HasColumnName("OtherEquity");
			this.Property(t => t.SEExceptionalItems).HasColumnName("SEExceptionalItems");
			this.Property(t => t.SEAdjustmentItems).HasColumnName("SEAdjustmentItems");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.LEExceptionalItems).HasColumnName("LEExceptionalItems");
			this.Property(t => t.LEAdjustmentItems).HasColumnName("LEAdjustmentItems");
			this.Property(t => t.TotalLiabilityAndEquity).HasColumnName("TotalLiabilityAndEquity");
			this.Property(t => t.TotalFundShares).HasColumnName("TotalFundShares");
			this.Property(t => t.UnitNV).HasColumnName("UnitNV");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.DeferredTaxAssets).HasColumnName("DeferredTaxAssets");
			this.Property(t => t.DeferredTaxLiability).HasColumnName("DeferredTaxLiability");
		}
	}
}

