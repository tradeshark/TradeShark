using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_FCashFlowStatement_HBMap : EntityTypeConfiguration<View_GP_FCashFlowStatement_HB>
	{
		public View_GP_FCashFlowStatement_HBMap()
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
			this.ToTable("View_GP_FCashFlowStatement_HB");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.N_IfAdjusted).HasColumnName("N_IfAdjusted");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.MLTermLoanPrincipalReceived).HasColumnName("MLTermLoanPrincipalReceived");
			this.Property(t => t.STermLoanPrincipalReceived).HasColumnName("STermLoanPrincipalReceived");
			this.Property(t => t.InterestReceived).HasColumnName("InterestReceived");
			this.Property(t => t.NetDepositIncrease).HasColumnName("NetDepositIncrease");
			this.Property(t => t.CurrentDepositCash).HasColumnName("CurrentDepositCash");
			this.Property(t => t.NonCurrentDepositCash).HasColumnName("NonCurrentDepositCash");
			this.Property(t => t.NetDepositOfInterbankSystem).HasColumnName("NetDepositOfInterbankSystem");
			this.Property(t => t.NetBorrowingFromInterbank).HasColumnName("NetBorrowingFromInterbank");
			this.Property(t => t.NetBorrowingFromFinanceCo).HasColumnName("NetBorrowingFromFinanceCo");
			this.Property(t => t.LendCapitalRepayment).HasColumnName("LendCapitalRepayment");
			this.Property(t => t.FinanceCoTurnoverCashIn).HasColumnName("FinanceCoTurnoverCashIn");
			this.Property(t => t.CBTurnoverCashIncrease).HasColumnName("CBTurnoverCashIncrease");
			this.Property(t => t.InterbankTurnoverIncome).HasColumnName("InterbankTurnoverIncome");
			this.Property(t => t.CommissionCashIn).HasColumnName("CommissionCashIn");
			this.Property(t => t.OperBondInvestIncomeCashIn).HasColumnName("OperBondInvestIncomeCashIn");
			this.Property(t => t.NetExchangeIncomeCashIn).HasColumnName("NetExchangeIncomeCashIn");
			this.Property(t => t.TrustBusinessNetCashIn).HasColumnName("TrustBusinessNetCashIn");
			this.Property(t => t.WrittenOffReceiveBack).HasColumnName("WrittenOffReceiveBack");
			this.Property(t => t.NetClientBail).HasColumnName("NetClientBail");
			this.Property(t => t.SelfSecuCashIn).HasColumnName("SelfSecuCashIn");
			this.Property(t => t.ProxySecuCashIn).HasColumnName("ProxySecuCashIn");
			this.Property(t => t.SubIssueSecuCashIn).HasColumnName("SubIssueSecuCashIn");
			this.Property(t => t.SubHonorSecuCashIn).HasColumnName("SubHonorSecuCashIn");
			this.Property(t => t.SoldBuybackSecuCashIn).HasColumnName("SoldBuybackSecuCashIn");
			this.Property(t => t.SoldSellbackSecuCashIn).HasColumnName("SoldSellbackSecuCashIn");
			this.Property(t => t.SecuSpreadIncomeCashIn).HasColumnName("SecuSpreadIncomeCashIn");
			this.Property(t => t.SecuIssueSpreadIncomeCashIn).HasColumnName("SecuIssueSpreadIncomeCashIn");
			this.Property(t => t.TrustAssetCashIn).HasColumnName("TrustAssetCashIn");
			this.Property(t => t.OtherSecuBizCashIn).HasColumnName("OtherSecuBizCashIn");
			this.Property(t => t.RentalReceived).HasColumnName("RentalReceived");
			this.Property(t => t.GoodsSaleServiceRenderCash).HasColumnName("GoodsSaleServiceRenderCash");
			this.Property(t => t.ReceivedRent).HasColumnName("ReceivedRent");
			this.Property(t => t.OtherOperateCashReceived).HasColumnName("OtherOperateCashReceived");
			this.Property(t => t.TaxesReceived).HasColumnName("TaxesReceived");
			this.Property(t => t.VATReceivedAndRefunded).HasColumnName("VATReceivedAndRefunded");
			this.Property(t => t.OtherTaxLevyRefund).HasColumnName("OtherTaxLevyRefund");
			this.Property(t => t.OtherCashInRelatedOperate).HasColumnName("OtherCashInRelatedOperate");
			this.Property(t => t.SubtotalOperateCashInflow).HasColumnName("SubtotalOperateCashInflow");
			this.Property(t => t.NetLoanIncrease).HasColumnName("NetLoanIncrease");
			this.Property(t => t.STermLoan).HasColumnName("STermLoan");
			this.Property(t => t.MLTermLoan).HasColumnName("MLTermLoan");
			this.Property(t => t.SubLoan).HasColumnName("SubLoan");
			this.Property(t => t.CurrentDepositWithdrawal).HasColumnName("CurrentDepositWithdrawal");
			this.Property(t => t.MLTermDepositWithdrawal).HasColumnName("MLTermDepositWithdrawal");
			this.Property(t => t.IncreasedDiscountCashOut).HasColumnName("IncreasedDiscountCashOut");
			this.Property(t => t.NetDepositInInterbankSystem).HasColumnName("NetDepositInInterbankSystem");
			this.Property(t => t.DepositInCentralBank).HasColumnName("DepositInCentralBank");
			this.Property(t => t.NetCommonDepositReserve).HasColumnName("NetCommonDepositReserve");
			this.Property(t => t.NetLoanToInterbank).HasColumnName("NetLoanToInterbank");
			this.Property(t => t.NetLoanToFinanceCo).HasColumnName("NetLoanToFinanceCo");
			this.Property(t => t.NetNoteFinance).HasColumnName("NetNoteFinance");
			this.Property(t => t.TurnoverCashOut).HasColumnName("TurnoverCashOut");
			this.Property(t => t.TrustBusinessCashOut).HasColumnName("TrustBusinessCashOut");
			this.Property(t => t.DebtRepayment).HasColumnName("DebtRepayment");
			this.Property(t => t.InterestExpenseCashOut).HasColumnName("InterestExpenseCashOut");
			this.Property(t => t.InterbankTurnoverExpense).HasColumnName("InterbankTurnoverExpense");
			this.Property(t => t.CommissionCashOut).HasColumnName("CommissionCashOut");
			this.Property(t => t.OperBondInvestCashOut).HasColumnName("OperBondInvestCashOut");
			this.Property(t => t.SelfSecuCashOut).HasColumnName("SelfSecuCashOut");
			this.Property(t => t.ProxySecuCashOut).HasColumnName("ProxySecuCashOut");
			this.Property(t => t.SubIssueSecuCashOut).HasColumnName("SubIssueSecuCashOut");
			this.Property(t => t.SubHonorSecuCashOut).HasColumnName("SubHonorSecuCashOut");
			this.Property(t => t.BoughtSellbackSecuCashOut).HasColumnName("BoughtSellbackSecuCashOut");
			this.Property(t => t.BoughtBuybackSecuCashOut).HasColumnName("BoughtBuybackSecuCashOut");
			this.Property(t => t.TrustAssetCashOut).HasColumnName("TrustAssetCashOut");
			this.Property(t => t.OperateLeasesCashPaid).HasColumnName("OperateLeasesCashPaid");
			this.Property(t => t.GoodsServicesCashPaid).HasColumnName("GoodsServicesCashPaid");
			this.Property(t => t.OtherOperateCashOut).HasColumnName("OtherOperateCashOut");
			this.Property(t => t.StaffBehalfPaid).HasColumnName("StaffBehalfPaid");
			this.Property(t => t.OperateExpenseCashPaid).HasColumnName("OperateExpenseCashPaid");
			this.Property(t => t.TaxesPaid).HasColumnName("TaxesPaid");
			this.Property(t => t.OperateTaxSurchargesPaid).HasColumnName("OperateTaxSurchargesPaid");
			this.Property(t => t.VATPaid).HasColumnName("VATPaid");
			this.Property(t => t.IncomeTaxPaid).HasColumnName("IncomeTaxPaid");
			this.Property(t => t.OtherTaxesPaid).HasColumnName("OtherTaxesPaid");
			this.Property(t => t.OtherOperateCashPaid).HasColumnName("OtherOperateCashPaid");
			this.Property(t => t.SubtotalOperateCashOutflow).HasColumnName("SubtotalOperateCashOutflow");
			this.Property(t => t.NetOperateCashFlow1).HasColumnName("NetOperateCashFlow1");
			this.Property(t => t.InvestWithdrawalCash).HasColumnName("InvestWithdrawalCash");
			this.Property(t => t.FinanceLeasePrincipalBack).HasColumnName("FinanceLeasePrincipalBack");
			this.Property(t => t.FinanceLeaseRentalReceived).HasColumnName("FinanceLeaseRentalReceived");
			this.Property(t => t.DividendAndProfitReceived).HasColumnName("DividendAndProfitReceived");
			this.Property(t => t.BondInterestIncome).HasColumnName("BondInterestIncome");
			this.Property(t => t.FixIntanOtherAssetDispoCash).HasColumnName("FixIntanOtherAssetDispoCash");
			this.Property(t => t.SellSubCompanyCashIn).HasColumnName("SellSubCompanyCashIn");
			this.Property(t => t.OtherCashFromInvestAct).HasColumnName("OtherCashFromInvestAct");
			this.Property(t => t.SubtotalInvestCashInflow).HasColumnName("SubtotalInvestCashInflow");
			this.Property(t => t.FixIntanOtherAssetAcquiCash).HasColumnName("FixIntanOtherAssetAcquiCash");
			this.Property(t => t.EquityInvestCashPaid).HasColumnName("EquityInvestCashPaid");
			this.Property(t => t.DebtInvestCashPaid).HasColumnName("DebtInvestCashPaid");
			this.Property(t => t.OtherCashToInvestAct).HasColumnName("OtherCashToInvestAct");
			this.Property(t => t.SubtotalInvestCashOutflow).HasColumnName("SubtotalInvestCashOutflow");
			this.Property(t => t.NetInvestCashFlow).HasColumnName("NetInvestCashFlow");
			this.Property(t => t.IssueShareproceeds).HasColumnName("IssueShareproceeds");
			this.Property(t => t.IssueBondProceed).HasColumnName("IssueBondProceed");
			this.Property(t => t.BorrowingProceed).HasColumnName("BorrowingProceed");
			this.Property(t => t.OtherFinanceActProceed).HasColumnName("OtherFinanceActProceed");
			this.Property(t => t.SubtotalFinanceCashInflow).HasColumnName("SubtotalFinanceCashInflow");
			this.Property(t => t.BorrowingRepayment).HasColumnName("BorrowingRepayment");
			this.Property(t => t.BondRedemptionCashPaid).HasColumnName("BondRedemptionCashPaid");
			this.Property(t => t.FinanceActPayment).HasColumnName("FinanceActPayment");
			this.Property(t => t.DividendProfitDistribPayment).HasColumnName("DividendProfitDistribPayment");
			this.Property(t => t.InterestPayment).HasColumnName("InterestPayment");
			this.Property(t => t.MLTermBondInterestPaid).HasColumnName("MLTermBondInterestPaid");
			this.Property(t => t.FinanceLeasePayment).HasColumnName("FinanceLeasePayment");
			this.Property(t => t.RegCapitalReductionPayment).HasColumnName("RegCapitalReductionPayment");
			this.Property(t => t.OtherFinanceActPayment).HasColumnName("OtherFinanceActPayment");
			this.Property(t => t.SubtotalFinanceCashOutflow).HasColumnName("SubtotalFinanceCashOutflow");
			this.Property(t => t.NetFinanceCashFlow).HasColumnName("NetFinanceCashFlow");
			this.Property(t => t.ExchangeRateChangeEffect).HasColumnName("ExchangeRateChangeEffect");
			this.Property(t => t.CashEquivalentIncrease1).HasColumnName("CashEquivalentIncrease1");
			this.Property(t => t.FixedAssetTransRepayment).HasColumnName("FixedAssetTransRepayment");
			this.Property(t => t.InvestTransRepayment).HasColumnName("InvestTransRepayment");
			this.Property(t => t.FixedAssetTransInvest).HasColumnName("FixedAssetTransInvest");
			this.Property(t => t.InventoryTransRepayment).HasColumnName("InventoryTransRepayment");
			this.Property(t => t.FinanceLeaseFixedAssets).HasColumnName("FinanceLeaseFixedAssets");
			this.Property(t => t.NonCashEndowment).HasColumnName("NonCashEndowment");
			this.Property(t => t.InvestTransLoan).HasColumnName("InvestTransLoan");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.UnrecognisedInvestLoss).HasColumnName("UnrecognisedInvestLoss");
			this.Property(t => t.BadDebtWrittenOffProvision).HasColumnName("BadDebtWrittenOffProvision");
			this.Property(t => t.RiskReserve).HasColumnName("RiskReserve");
			this.Property(t => t.SelfSecuLossReserve).HasColumnName("SelfSecuLossReserve");
			this.Property(t => t.BadLoanProvision).HasColumnName("BadLoanProvision");
			this.Property(t => t.InvestLossReserve).HasColumnName("InvestLossReserve");
			this.Property(t => t.InventoryDevalProvision).HasColumnName("InventoryDevalProvision");
			this.Property(t => t.OtherAssetLossReserve).HasColumnName("OtherAssetLossReserve");
			this.Property(t => t.FixedAssetDepreciation).HasColumnName("FixedAssetDepreciation");
			this.Property(t => t.SeatFeeAmort).HasColumnName("SeatFeeAmort");
			this.Property(t => t.PreoperateEexpenseAmort).HasColumnName("PreoperateEexpenseAmort");
			this.Property(t => t.DeferredExpenseAmort).HasColumnName("DeferredExpenseAmort");
			this.Property(t => t.IntangiDeferredAssetAmort).HasColumnName("IntangiDeferredAssetAmort");
			this.Property(t => t.DeferredExpenseDecreased).HasColumnName("DeferredExpenseDecreased");
			this.Property(t => t.AccruedExpenseAdded).HasColumnName("AccruedExpenseAdded");
			this.Property(t => t.FixIntanOtherAssetDispoLoss).HasColumnName("FixIntanOtherAssetDispoLoss");
			this.Property(t => t.FixedAssetScrapLoss).HasColumnName("FixedAssetScrapLoss");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.InvestLoss).HasColumnName("InvestLoss");
			this.Property(t => t.InveFinaActExchGainOrLoss).HasColumnName("InveFinaActExchGainOrLoss");
			this.Property(t => t.NetDeferedTaxCredit).HasColumnName("NetDeferedTaxCredit");
			this.Property(t => t.InventoryDecr).HasColumnName("InventoryDecr");
			this.Property(t => t.LendCapitalDecr).HasColumnName("LendCapitalDecr");
			this.Property(t => t.STermLoanInvestDecr).HasColumnName("STermLoanInvestDecr");
			this.Property(t => t.SubLoanDecr).HasColumnName("SubLoanDecr");
			this.Property(t => t.SecuAssetDecr).HasColumnName("SecuAssetDecr");
			this.Property(t => t.TradeBailDecr).HasColumnName("TradeBailDecr");
			this.Property(t => t.ReceivablesDecr).HasColumnName("ReceivablesDecr");
			this.Property(t => t.TrustAssetDecr).HasColumnName("TrustAssetDecr");
			this.Property(t => t.SelfSecuDecr).HasColumnName("SelfSecuDecr");
			this.Property(t => t.BoughtSellbackSecuDecr).HasColumnName("BoughtSellbackSecuDecr");
			this.Property(t => t.ProxySecuDecr).HasColumnName("ProxySecuDecr");
			this.Property(t => t.SubIssueSecuDecr).HasColumnName("SubIssueSecuDecr");
			this.Property(t => t.SubHonorSecuDecr).HasColumnName("SubHonorSecuDecr");
			this.Property(t => t.IssueExpenseToTransDecr).HasColumnName("IssueExpenseToTransDecr");
			this.Property(t => t.OperReceivablesDecr).HasColumnName("OperReceivablesDecr");
			this.Property(t => t.TrustDepositIncr).HasColumnName("TrustDepositIncr");
			this.Property(t => t.BorrowingsIncr).HasColumnName("BorrowingsIncr");
			this.Property(t => t.SecuDebtIncr).HasColumnName("SecuDebtIncr");
			this.Property(t => t.PledgeBorrowingIncr).HasColumnName("PledgeBorrowingIncr");
			this.Property(t => t.TrustCapitalIncr).HasColumnName("TrustCapitalIncr");
			this.Property(t => t.AgentSecuPayableIncr).HasColumnName("AgentSecuPayableIncr");
			this.Property(t => t.ProxySecuProceedsIncr).HasColumnName("ProxySecuProceedsIncr");
			this.Property(t => t.SubIssueSecuProceedsIncr).HasColumnName("SubIssueSecuProceedsIncr");
			this.Property(t => t.SubHonorSecuProceedsIncr).HasColumnName("SubHonorSecuProceedsIncr");
			this.Property(t => t.SoldBuybackSecuProcIncr).HasColumnName("SoldBuybackSecuProcIncr");
			this.Property(t => t.PayablesIncr).HasColumnName("PayablesIncr");
			this.Property(t => t.WagePayableIncr).HasColumnName("WagePayableIncr");
			this.Property(t => t.WelfarePayableIncr).HasColumnName("WelfarePayableIncr");
			this.Property(t => t.TaxSurchargesPayableIncr).HasColumnName("TaxSurchargesPayableIncr");
			this.Property(t => t.OperPayablesIncr).HasColumnName("OperPayablesIncr");
			this.Property(t => t.NetVATIncr).HasColumnName("NetVATIncr");
			this.Property(t => t.OtherNonCashExpenseOrLoss).HasColumnName("OtherNonCashExpenseOrLoss");
			this.Property(t => t.NetOperateCashFlow2).HasColumnName("NetOperateCashFlow2");
			this.Property(t => t.EndPeriodCashEquivalent).HasColumnName("EndPeriodCashEquivalent");
			this.Property(t => t.EndPeriodEquivalent).HasColumnName("EndPeriodEquivalent");
			this.Property(t => t.EndPeriodCash).HasColumnName("EndPeriodCash");
			this.Property(t => t.BeginPeriodCashEquivalent).HasColumnName("BeginPeriodCashEquivalent");
			this.Property(t => t.BeginPeriodEquivalent).HasColumnName("BeginPeriodEquivalent");
			this.Property(t => t.BeginPeriodCash).HasColumnName("BeginPeriodCash");
			this.Property(t => t.CashEquivalentIncrease2).HasColumnName("CashEquivalentIncrease2");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

