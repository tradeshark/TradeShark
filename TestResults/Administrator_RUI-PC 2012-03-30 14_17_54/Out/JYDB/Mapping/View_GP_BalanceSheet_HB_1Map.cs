using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_BalanceSheet_HB_1Map : EntityTypeConfiguration<View_GP_BalanceSheet_HB_1>
	{
		public View_GP_BalanceSheet_HB_1Map()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_IfMerged)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfAdjusted)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_GP_BalanceSheet_HB_1");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.N_IfAdjusted).HasColumnName("N_IfAdjusted");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.CashEquivalents).HasColumnName("CashEquivalents");
			this.Property(t => t.ShortTermInvest).HasColumnName("ShortTermInvest");
			this.Property(t => t.ShortTermInvestDevalProvi).HasColumnName("ShortTermInvestDevalProvi");
			this.Property(t => t.ShorttermInvestNetVal).HasColumnName("ShorttermInvestNetVal");
			this.Property(t => t.NotesReceivable).HasColumnName("NotesReceivable");
			this.Property(t => t.DividendReceivable).HasColumnName("DividendReceivable");
			this.Property(t => t.InterestReceivable).HasColumnName("InterestReceivable");
			this.Property(t => t.AccountsReceivables).HasColumnName("AccountsReceivables");
			this.Property(t => t.NetAccountsReceivables).HasColumnName("NetAccountsReceivables");
			this.Property(t => t.OtherReceivables).HasColumnName("OtherReceivables");
			this.Property(t => t.NetOtherReceivables).HasColumnName("NetOtherReceivables");
			this.Property(t => t.BadDebtProvision).HasColumnName("BadDebtProvision");
			this.Property(t => t.NetReceivables).HasColumnName("NetReceivables");
			this.Property(t => t.AdvancePayment).HasColumnName("AdvancePayment");
			this.Property(t => t.SubsidyReceivable).HasColumnName("SubsidyReceivable");
			this.Property(t => t.FutureMargin).HasColumnName("FutureMargin");
			this.Property(t => t.SeatFeeReceivable).HasColumnName("SeatFeeReceivable");
			this.Property(t => t.Inventory).HasColumnName("Inventory");
			this.Property(t => t.ConstructionProject).HasColumnName("ConstructionProject");
			this.Property(t => t.InventoryDevalProvision).HasColumnName("InventoryDevalProvision");
			this.Property(t => t.NetInventory).HasColumnName("NetInventory");
			this.Property(t => t.InterdepartmentalAccounts).HasColumnName("InterdepartmentalAccounts");
			this.Property(t => t.DeferredExpense).HasColumnName("DeferredExpense");
			this.Property(t => t.NetLossOfCurrentAssetToDeal).HasColumnName("NetLossOfCurrentAssetToDeal");
			this.Property(t => t.LongtermInvestBondsDueIn1Year).HasColumnName("LongtermInvestBondsDueIn1Year");
			this.Property(t => t.OtherCurrentAsset).HasColumnName("OtherCurrentAsset");
			this.Property(t => t.TotalCurrentAsset).HasColumnName("TotalCurrentAsset");
			this.Property(t => t.LongtermEquityInvest).HasColumnName("LongtermEquityInvest");
			this.Property(t => t.LongtermCreditInvest).HasColumnName("LongtermCreditInvest");
			this.Property(t => t.OtherLongtermInvest).HasColumnName("OtherLongtermInvest");
			this.Property(t => t.TotalLongtermInvest).HasColumnName("TotalLongtermInvest");
			this.Property(t => t.LongtermInvestDevalProvi).HasColumnName("LongtermInvestDevalProvi");
			this.Property(t => t.LongtermInvestNetVal).HasColumnName("LongtermInvestNetVal");
			this.Property(t => t.MergingPriceDiffirence).HasColumnName("MergingPriceDiffirence");
			this.Property(t => t.EquityInvestDiff).HasColumnName("EquityInvestDiff");
			this.Property(t => t.FixedAssetsCost).HasColumnName("FixedAssetsCost");
			this.Property(t => t.AccumulatedDepreciation).HasColumnName("AccumulatedDepreciation");
			this.Property(t => t.NetFixedAssetsVal).HasColumnName("NetFixedAssetsVal");
			this.Property(t => t.FixedAssetsDevalProvi).HasColumnName("FixedAssetsDevalProvi");
			this.Property(t => t.NetFixedAssetsMarketVal).HasColumnName("NetFixedAssetsMarketVal");
			this.Property(t => t.ConstructionMaterials).HasColumnName("ConstructionMaterials");
			this.Property(t => t.ConstruInProcess).HasColumnName("ConstruInProcess");
			this.Property(t => t.ConstruInProcessDevalProvi).HasColumnName("ConstruInProcessDevalProvi");
			this.Property(t => t.FixedAssetsLiquidation).HasColumnName("FixedAssetsLiquidation");
			this.Property(t => t.NetLossOfFixedAssetToDeal).HasColumnName("NetLossOfFixedAssetToDeal");
			this.Property(t => t.TotalFixedAssets).HasColumnName("TotalFixedAssets");
			this.Property(t => t.IntangibleAssets).HasColumnName("IntangibleAssets");
			this.Property(t => t.DeferredAssets).HasColumnName("DeferredAssets");
			this.Property(t => t.PreoperateEexpense).HasColumnName("PreoperateEexpense");
			this.Property(t => t.LongDeferredExpense).HasColumnName("LongDeferredExpense");
			this.Property(t => t.OtherLongtermAssets).HasColumnName("OtherLongtermAssets");
			this.Property(t => t.NetTempFacility).HasColumnName("NetTempFacility");
			this.Property(t => t.TotalIntangiAndOtherAssets).HasColumnName("TotalIntangiAndOtherAssets");
			this.Property(t => t.DeferredTaxDebit).HasColumnName("DeferredTaxDebit");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.ShortTermLoan).HasColumnName("ShortTermLoan");
			this.Property(t => t.NotesPayable).HasColumnName("NotesPayable");
			this.Property(t => t.AccountsPayable).HasColumnName("AccountsPayable");
			this.Property(t => t.AdvanceReceipts).HasColumnName("AdvanceReceipts");
			this.Property(t => t.ConsignedGoodAccounts).HasColumnName("ConsignedGoodAccounts");
			this.Property(t => t.WagesPayable).HasColumnName("WagesPayable");
			this.Property(t => t.WelfarePayable).HasColumnName("WelfarePayable");
			this.Property(t => t.DividendsPayable).HasColumnName("DividendsPayable");
			this.Property(t => t.TaxsPayable).HasColumnName("TaxsPayable");
			this.Property(t => t.OthersPayable).HasColumnName("OthersPayable");
			this.Property(t => t.OtherAccountsPayable).HasColumnName("OtherAccountsPayable");
			this.Property(t => t.AccruedExpense).HasColumnName("AccruedExpense");
			this.Property(t => t.EstimateLiability).HasColumnName("EstimateLiability");
			this.Property(t => t.LongtermLiabilityDueIn1Year).HasColumnName("LongtermLiabilityDueIn1Year");
			this.Property(t => t.OtherCurrentLiability).HasColumnName("OtherCurrentLiability");
			this.Property(t => t.TotalCurrentLiability).HasColumnName("TotalCurrentLiability");
			this.Property(t => t.LongtermLoan).HasColumnName("LongtermLoan");
			this.Property(t => t.BondsPayable).HasColumnName("BondsPayable");
			this.Property(t => t.LongtermAccountPayable).HasColumnName("LongtermAccountPayable");
			this.Property(t => t.SpecificAccountPayable).HasColumnName("SpecificAccountPayable");
			this.Property(t => t.HouseTurnoverFund).HasColumnName("HouseTurnoverFund");
			this.Property(t => t.OtherLongtermLiability).HasColumnName("OtherLongtermLiability");
			this.Property(t => t.TotalLongtermLiability).HasColumnName("TotalLongtermLiability");
			this.Property(t => t.DeferredTaxCredit).HasColumnName("DeferredTaxCredit");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.MinorityInterests).HasColumnName("MinorityInterests");
			this.Property(t => t.OthersLiabilityAndEquity).HasColumnName("OthersLiabilityAndEquity");
			this.Property(t => t.ShareCapital).HasColumnName("ShareCapital");
			this.Property(t => t.RetiredCapital).HasColumnName("RetiredCapital");
			this.Property(t => t.NetShareCapital).HasColumnName("NetShareCapital");
			this.Property(t => t.CapitalReserveFund).HasColumnName("CapitalReserveFund");
			this.Property(t => t.AddedCurrentCapital).HasColumnName("AddedCurrentCapital");
			this.Property(t => t.SurplusReserveFund).HasColumnName("SurplusReserveFund");
			this.Property(t => t.CommonwealFund).HasColumnName("CommonwealFund");
			this.Property(t => t.UnrecognisedInvestLoss).HasColumnName("UnrecognisedInvestLoss");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.ForeignCurrencyReportConvDiff).HasColumnName("ForeignCurrencyReportConvDiff");
			this.Property(t => t.CapitalExchangeDiffAdjust).HasColumnName("CapitalExchangeDiffAdjust");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.TotalLiabilityAndEquity).HasColumnName("TotalLiabilityAndEquity");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ShortTermBondPayable).HasColumnName("ShortTermBondPayable");
		}
	}
}

