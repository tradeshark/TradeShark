using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_FBalanceSheetMap : EntityTypeConfiguration<LC_FBalanceSheet>
	{
		public LC_FBalanceSheetMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_FBalanceSheet");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.CashDeposit).HasColumnName("CashDeposit");
			this.Property(t => t.Cash).HasColumnName("Cash");
			this.Property(t => t.ClientDeposit).HasColumnName("ClientDeposit");
			this.Property(t => t.TrustDeposit).HasColumnName("TrustDeposit");
			this.Property(t => t.RMetal).HasColumnName("RMetal");
			this.Property(t => t.Settlementprovi).HasColumnName("Settlementprovi");
			this.Property(t => t.BrokerBusiprovi).HasColumnName("BrokerBusiprovi");
			this.Property(t => t.TrustBusiprovi).HasColumnName("TrustBusiprovi");
			this.Property(t => t.DealCover).HasColumnName("DealCover");
			this.Property(t => t.DepositInCentralBank).HasColumnName("DepositInCentralBank");
			this.Property(t => t.DepositInInterbank).HasColumnName("DepositInInterbank");
			this.Property(t => t.DepositInAssociate).HasColumnName("DepositInAssociate");
			this.Property(t => t.DepositInSystem).HasColumnName("DepositInSystem");
			this.Property(t => t.LendCapital).HasColumnName("LendCapital");
			this.Property(t => t.LendToAssociate).HasColumnName("LendToAssociate");
			this.Property(t => t.LendToInterbank).HasColumnName("LendToInterbank");
			this.Property(t => t.LendToFinanceCo).HasColumnName("LendToFinanceCo");
			this.Property(t => t.ShortTermLoan).HasColumnName("ShortTermLoan");
			this.Property(t => t.Mortgage).HasColumnName("Mortgage");
			this.Property(t => t.ImOutportForeiCurrReserv).HasColumnName("ImOutportForeiCurrReserv");
			this.Property(t => t.DividendReceivables).HasColumnName("DividendReceivables");
			this.Property(t => t.InterestReceivables).HasColumnName("InterestReceivables");
			this.Property(t => t.AccountReceivables).HasColumnName("AccountReceivables");
			this.Property(t => t.NetAccountReceivables).HasColumnName("NetAccountReceivables");
			this.Property(t => t.OtherReceivables).HasColumnName("OtherReceivables");
			this.Property(t => t.NetOtherReceivables).HasColumnName("NetOtherReceivables");
			this.Property(t => t.BadDebtprovision).HasColumnName("BadDebtprovision");
			this.Property(t => t.NetReceivables).HasColumnName("NetReceivables");
			this.Property(t => t.Prepays).HasColumnName("Prepays");
			this.Property(t => t.Discount).HasColumnName("Discount");
			this.Property(t => t.STermInvest).HasColumnName("STermInvest");
			this.Property(t => t.STermInvestDevalProvi).HasColumnName("STermInvestDevalProvi");
			this.Property(t => t.NetShortTermInvest).HasColumnName("NetShortTermInvest");
			this.Property(t => t.InterdepartmentalAccounts).HasColumnName("InterdepartmentalAccounts");
			this.Property(t => t.TrustLoanAndInvest).HasColumnName("TrustLoanAndInvest");
			this.Property(t => t.TrustAsset).HasColumnName("TrustAsset");
			this.Property(t => t.SelfSecu).HasColumnName("SelfSecu");
			this.Property(t => t.SelfSecuDevalprovi).HasColumnName("SelfSecuDevalprovi");
			this.Property(t => t.NetSelfSecu).HasColumnName("NetSelfSecu");
			this.Property(t => t.AgentSecu).HasColumnName("AgentSecu");
			this.Property(t => t.ProxySecu).HasColumnName("ProxySecu");
			this.Property(t => t.SubIssueSecu).HasColumnName("SubIssueSecu");
			this.Property(t => t.SubHonorBond).HasColumnName("SubHonorBond");
			this.Property(t => t.IssueExpenseToTransfer).HasColumnName("IssueExpenseToTransfer");
			this.Property(t => t.BoughtSellbackSecu).HasColumnName("BoughtSellbackSecu");
			this.Property(t => t.Inventory).HasColumnName("Inventory");
			this.Property(t => t.InventoryDevalprovi).HasColumnName("InventoryDevalprovi");
			this.Property(t => t.NetInventory).HasColumnName("NetInventory");
			this.Property(t => t.DeferrredExpense).HasColumnName("DeferrredExpense");
			this.Property(t => t.CurrentAssetToDealNetLoss).HasColumnName("CurrentAssetToDealNetLoss");
			this.Property(t => t.LongInvestDueIn1Year).HasColumnName("LongInvestDueIn1Year");
			this.Property(t => t.OtherCurrentAsset).HasColumnName("OtherCurrentAsset");
			this.Property(t => t.TotalCurrentAsset).HasColumnName("TotalCurrentAsset");
			this.Property(t => t.MidLongtermLoan).HasColumnName("MidLongtermLoan");
			this.Property(t => t.OverrideLoan).HasColumnName("OverrideLoan");
			this.Property(t => t.BadLoan).HasColumnName("BadLoan");
			this.Property(t => t.DeadLoan).HasColumnName("DeadLoan");
			this.Property(t => t.BadLoanprovision).HasColumnName("BadLoanprovision");
			this.Property(t => t.RentalReceivable).HasColumnName("RentalReceivable");
			this.Property(t => t.RentIncomeUnReceived).HasColumnName("RentIncomeUnReceived");
			this.Property(t => t.SubRentReceivable).HasColumnName("SubRentReceivable");
			this.Property(t => t.RentAsset).HasColumnName("RentAsset");
			this.Property(t => t.RentAssetToTransfer).HasColumnName("RentAssetToTransfer");
			this.Property(t => t.OperRentAsset).HasColumnName("OperRentAsset");
			this.Property(t => t.OperRentAssetDepreciation).HasColumnName("OperRentAssetDepreciation");
			this.Property(t => t.LongTermEquityInvest).HasColumnName("LongTermEquityInvest");
			this.Property(t => t.LongTermDebtInvest).HasColumnName("LongTermDebtInvest");
			this.Property(t => t.OtherLongTermInvest).HasColumnName("OtherLongTermInvest");
			this.Property(t => t.TotalLongTermInvest).HasColumnName("TotalLongTermInvest");
			this.Property(t => t.LongTermInvestDevalprovi).HasColumnName("LongTermInvestDevalprovi");
			this.Property(t => t.NetLongTermInvest).HasColumnName("NetLongTermInvest");
			this.Property(t => t.MergingPriceDiffirence).HasColumnName("MergingPriceDiffirence");
			this.Property(t => t.EquityInvestDiffirence).HasColumnName("EquityInvestDiffirence");
			this.Property(t => t.FixedAssetsCost).HasColumnName("FixedAssetsCost");
			this.Property(t => t.AccumulatedDepreciation).HasColumnName("AccumulatedDepreciation");
			this.Property(t => t.NetFixedAssets).HasColumnName("NetFixedAssets");
			this.Property(t => t.FixedAssetsDevalprovi).HasColumnName("FixedAssetsDevalprovi");
			this.Property(t => t.FixedAssetsMarketValue).HasColumnName("FixedAssetsMarketValue");
			this.Property(t => t.ConstruInProcess).HasColumnName("ConstruInProcess");
			this.Property(t => t.ConstruInProcessDevalprovi).HasColumnName("ConstruInProcessDevalprovi");
			this.Property(t => t.NetConstruInProcess).HasColumnName("NetConstruInProcess");
			this.Property(t => t.FixedAssetLiquidation).HasColumnName("FixedAssetLiquidation");
			this.Property(t => t.LossOfFixedAssetToDeal).HasColumnName("LossOfFixedAssetToDeal");
			this.Property(t => t.TotalFixedAsset).HasColumnName("TotalFixedAsset");
			this.Property(t => t.TotalLongTermAssets).HasColumnName("TotalLongTermAssets");
			this.Property(t => t.IntangibleAssets).HasColumnName("IntangibleAssets");
			this.Property(t => t.DeferredAssets).HasColumnName("DeferredAssets");
			this.Property(t => t.PreoperateEexpense).HasColumnName("PreoperateEexpense");
			this.Property(t => t.SeatCosts).HasColumnName("SeatCosts");
			this.Property(t => t.DeferredExpense).HasColumnName("DeferredExpense");
			this.Property(t => t.AssetToDealForDebt).HasColumnName("AssetToDealForDebt");
			this.Property(t => t.OtherLongTermAssets).HasColumnName("OtherLongTermAssets");
			this.Property(t => t.TotalIntanAndOtherAssets).HasColumnName("TotalIntanAndOtherAssets");
			this.Property(t => t.DeferredTaxDebit).HasColumnName("DeferredTaxDebit");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.ShortTermDeposit).HasColumnName("ShortTermDeposit");
			this.Property(t => t.ShortTermSaveDeposit).HasColumnName("ShortTermSaveDeposit");
			this.Property(t => t.FinanceDeposit).HasColumnName("FinanceDeposit");
			this.Property(t => t.CentralBankBorrowing).HasColumnName("CentralBankBorrowing");
			this.Property(t => t.NoteFinace).HasColumnName("NoteFinace");
			this.Property(t => t.DebitofInterbank).HasColumnName("DebitofInterbank");
			this.Property(t => t.DebitofAssociate).HasColumnName("DebitofAssociate");
			this.Property(t => t.DebitofSystem).HasColumnName("DebitofSystem");
			this.Property(t => t.ShortTermBorrowing).HasColumnName("ShortTermBorrowing");
			this.Property(t => t.PledgeBorrowing).HasColumnName("PledgeBorrowing");
			this.Property(t => t.BorrowingCapital).HasColumnName("BorrowingCapital");
			this.Property(t => t.InterbankBorrowing).HasColumnName("InterbankBorrowing");
			this.Property(t => t.FinanceCoBorrowing).HasColumnName("FinanceCoBorrowing");
			this.Property(t => t.ShortTermBailDeposit).HasColumnName("ShortTermBailDeposit");
			this.Property(t => t.RemittanceToTransfer).HasColumnName("RemittanceToTransfer");
			this.Property(t => t.OutwardRemittance).HasColumnName("OutwardRemittance");
			this.Property(t => t.TrustedDeposit).HasColumnName("TrustedDeposit");
			this.Property(t => t.EntrustedDeposit).HasColumnName("EntrustedDeposit");
			this.Property(t => t.AgentSecuProceedsPayable).HasColumnName("AgentSecuProceedsPayable");
			this.Property(t => t.ProxySecuProceedsPayable).HasColumnName("ProxySecuProceedsPayable");
			this.Property(t => t.SubIssueSecuProceeds).HasColumnName("SubIssueSecuProceeds");
			this.Property(t => t.SubHonorBondProceeds).HasColumnName("SubHonorBondProceeds");
			this.Property(t => t.SoldBuybackSecuProceeds).HasColumnName("SoldBuybackSecuProceeds");
			this.Property(t => t.NotesPayable).HasColumnName("NotesPayable");
			this.Property(t => t.AccountsPayable).HasColumnName("AccountsPayable");
			this.Property(t => t.AdvanceReceipts).HasColumnName("AdvanceReceipts");
			this.Property(t => t.InterestPayable).HasColumnName("InterestPayable");
			this.Property(t => t.WagesPayable).HasColumnName("WagesPayable");
			this.Property(t => t.WelfarePayable).HasColumnName("WelfarePayable");
			this.Property(t => t.TaxPayable).HasColumnName("TaxPayable");
			this.Property(t => t.OtherPayable).HasColumnName("OtherPayable");
			this.Property(t => t.DividendPayable).HasColumnName("DividendPayable");
			this.Property(t => t.OtherAccrued).HasColumnName("OtherAccrued");
			this.Property(t => t.AccruedExpense).HasColumnName("AccruedExpense");
			this.Property(t => t.DeferredIncome).HasColumnName("DeferredIncome");
			this.Property(t => t.IssuedShortTermBond).HasColumnName("IssuedShortTermBond");
			this.Property(t => t.LongTermDebtDueIn1Year).HasColumnName("LongTermDebtDueIn1Year");
			this.Property(t => t.EstimateLiability).HasColumnName("EstimateLiability");
			this.Property(t => t.OtherCurrentLiability).HasColumnName("OtherCurrentLiability");
			this.Property(t => t.TotalCurrentLiability).HasColumnName("TotalCurrentLiability");
			this.Property(t => t.LongTermDeposit).HasColumnName("LongTermDeposit");
			this.Property(t => t.LongTermSaveDeposit).HasColumnName("LongTermSaveDeposit");
			this.Property(t => t.LongTermBailDeposit).HasColumnName("LongTermBailDeposit");
			this.Property(t => t.SubLoanFund).HasColumnName("SubLoanFund");
			this.Property(t => t.SubRentPayable).HasColumnName("SubRentPayable");
			this.Property(t => t.IssuedLongTermBond).HasColumnName("IssuedLongTermBond");
			this.Property(t => t.LongTermBorrowing).HasColumnName("LongTermBorrowing");
			this.Property(t => t.LongTermAccountPayable).HasColumnName("LongTermAccountPayable");
			this.Property(t => t.BondPayable).HasColumnName("BondPayable");
			this.Property(t => t.OtherLongTermLiability).HasColumnName("OtherLongTermLiability");
			this.Property(t => t.HouseTurnoverFund).HasColumnName("HouseTurnoverFund");
			this.Property(t => t.TotalLongtermLiability).HasColumnName("TotalLongtermLiability");
			this.Property(t => t.OtherLiability).HasColumnName("OtherLiability");
			this.Property(t => t.DeferredTaxCredit).HasColumnName("DeferredTaxCredit");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.MinorityInterests).HasColumnName("MinorityInterests");
			this.Property(t => t.ShareCapital).HasColumnName("ShareCapital");
			this.Property(t => t.ForeignCapitalReserveFund).HasColumnName("ForeignCapitalReserveFund");
			this.Property(t => t.OrdinaryRiskReserveFund).HasColumnName("OrdinaryRiskReserveFund");
			this.Property(t => t.CapitalReserveFund).HasColumnName("CapitalReserveFund");
			this.Property(t => t.SurplusReserveFund).HasColumnName("SurplusReserveFund");
			this.Property(t => t.CommonwealFund).HasColumnName("CommonwealFund");
			this.Property(t => t.UnrecognisedInvestLoss).HasColumnName("UnrecognisedInvestLoss");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.ForeignCurrencyReportConvDiff).HasColumnName("ForeignCurrencyReportConvDiff");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.TotalLiabilityAndEquity).HasColumnName("TotalLiabilityAndEquity");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

