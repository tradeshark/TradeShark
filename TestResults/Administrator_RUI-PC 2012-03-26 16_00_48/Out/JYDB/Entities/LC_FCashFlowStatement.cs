using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_FCashFlowStatement
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> MLTermLoanPrincipalReceived { get; set; }
		public Nullable<decimal> STermLoanPrincipalReceived { get; set; }
		public Nullable<decimal> InterestReceived { get; set; }
		public Nullable<decimal> NetDepositIncrease { get; set; }
		public Nullable<decimal> CurrentDepositCash { get; set; }
		public Nullable<decimal> NonCurrentDepositCash { get; set; }
		public Nullable<decimal> NetDepositOfInterbankSystem { get; set; }
		public Nullable<decimal> NetBorrowingFromInterbank { get; set; }
		public Nullable<decimal> NetBorrowingFromFinanceCo { get; set; }
		public Nullable<decimal> LendCapitalRepayment { get; set; }
		public Nullable<decimal> FinanceCoTurnoverCashIn { get; set; }
		public Nullable<decimal> CBTurnoverCashIncrease { get; set; }
		public Nullable<decimal> InterbankTurnoverIncome { get; set; }
		public Nullable<decimal> CommissionCashIn { get; set; }
		public Nullable<decimal> OperBondInvestIncomeCashIn { get; set; }
		public Nullable<decimal> NetExchangeIncomeCashIn { get; set; }
		public Nullable<decimal> TrustBusinessNetCashIn { get; set; }
		public Nullable<decimal> WrittenOffReceiveBack { get; set; }
		public Nullable<decimal> NetClientBail { get; set; }
		public Nullable<decimal> SelfSecuCashIn { get; set; }
		public Nullable<decimal> ProxySecuCashIn { get; set; }
		public Nullable<decimal> SubIssueSecuCashIn { get; set; }
		public Nullable<decimal> SubHonorSecuCashIn { get; set; }
		public Nullable<decimal> SoldBuybackSecuCashIn { get; set; }
		public Nullable<decimal> SoldSellbackSecuCashIn { get; set; }
		public Nullable<decimal> SecuSpreadIncomeCashIn { get; set; }
		public Nullable<decimal> SecuIssueSpreadIncomeCashIn { get; set; }
		public Nullable<decimal> TrustAssetCashIn { get; set; }
		public Nullable<decimal> OtherSecuBizCashIn { get; set; }
		public Nullable<decimal> RentalReceived { get; set; }
		public Nullable<decimal> GoodsSaleServiceRenderCash { get; set; }
		public Nullable<decimal> ReceivedRent { get; set; }
		public Nullable<decimal> OtherOperateCashReceived { get; set; }
		public Nullable<decimal> TaxesReceived { get; set; }
		public Nullable<decimal> VATReceivedAndRefunded { get; set; }
		public Nullable<decimal> OtherTaxLevyRefund { get; set; }
		public Nullable<decimal> OtherCashInRelatedOperate { get; set; }
		public Nullable<decimal> SubtotalOperateCashInflow { get; set; }
		public Nullable<decimal> NetLoanIncrease { get; set; }
		public Nullable<decimal> STermLoan { get; set; }
		public Nullable<decimal> MLTermLoan { get; set; }
		public Nullable<decimal> SubLoan { get; set; }
		public Nullable<decimal> CurrentDepositWithdrawal { get; set; }
		public Nullable<decimal> MLTermDepositWithdrawal { get; set; }
		public Nullable<decimal> IncreasedDiscountCashOut { get; set; }
		public Nullable<decimal> NetDepositInInterbankSystem { get; set; }
		public Nullable<decimal> DepositInCentralBank { get; set; }
		public Nullable<decimal> NetCommonDepositReserve { get; set; }
		public Nullable<decimal> NetLoanToInterbank { get; set; }
		public Nullable<decimal> NetLoanToFinanceCo { get; set; }
		public Nullable<decimal> NetNoteFinance { get; set; }
		public Nullable<decimal> TurnoverCashOut { get; set; }
		public Nullable<decimal> TrustBusinessCashOut { get; set; }
		public Nullable<decimal> DebtRepayment { get; set; }
		public Nullable<decimal> InterestExpenseCashOut { get; set; }
		public Nullable<decimal> InterbankTurnoverExpense { get; set; }
		public Nullable<decimal> CommissionCashOut { get; set; }
		public Nullable<decimal> OperBondInvestCashOut { get; set; }
		public Nullable<decimal> SelfSecuCashOut { get; set; }
		public Nullable<decimal> ProxySecuCashOut { get; set; }
		public Nullable<decimal> SubIssueSecuCashOut { get; set; }
		public Nullable<decimal> SubHonorSecuCashOut { get; set; }
		public Nullable<decimal> BoughtSellbackSecuCashOut { get; set; }
		public Nullable<decimal> BoughtBuybackSecuCashOut { get; set; }
		public Nullable<decimal> TrustAssetCashOut { get; set; }
		public Nullable<decimal> OperateLeasesCashPaid { get; set; }
		public Nullable<decimal> GoodsServicesCashPaid { get; set; }
		public Nullable<decimal> OtherOperateCashOut { get; set; }
		public Nullable<decimal> StaffBehalfPaid { get; set; }
		public Nullable<decimal> OperateExpenseCashPaid { get; set; }
		public Nullable<decimal> TaxesPaid { get; set; }
		public Nullable<decimal> OperateTaxSurchargesPaid { get; set; }
		public Nullable<decimal> VATPaid { get; set; }
		public Nullable<decimal> IncomeTaxPaid { get; set; }
		public Nullable<decimal> OtherTaxesPaid { get; set; }
		public Nullable<decimal> OtherOperateCashPaid { get; set; }
		public Nullable<decimal> SubtotalOperateCashOutflow { get; set; }
		public Nullable<decimal> NetOperateCashFlow1 { get; set; }
		public Nullable<decimal> InvestWithdrawalCash { get; set; }
		public Nullable<decimal> FinanceLeasePrincipalBack { get; set; }
		public Nullable<decimal> FinanceLeaseRentalReceived { get; set; }
		public Nullable<decimal> DividendAndProfitReceived { get; set; }
		public Nullable<decimal> BondInterestIncome { get; set; }
		public Nullable<decimal> FixIntanOtherAssetDispoCash { get; set; }
		public Nullable<decimal> SellSubCompanyCashIn { get; set; }
		public Nullable<decimal> OtherCashFromInvestAct { get; set; }
		public Nullable<decimal> SubtotalInvestCashInflow { get; set; }
		public Nullable<decimal> FixIntanOtherAssetAcquiCash { get; set; }
		public Nullable<decimal> EquityInvestCashPaid { get; set; }
		public Nullable<decimal> DebtInvestCashPaid { get; set; }
		public Nullable<decimal> OtherCashToInvestAct { get; set; }
		public Nullable<decimal> SubtotalInvestCashOutflow { get; set; }
		public Nullable<decimal> NetInvestCashFlow { get; set; }
		public Nullable<decimal> IssueShareproceeds { get; set; }
		public Nullable<decimal> IssueBondProceed { get; set; }
		public Nullable<decimal> BorrowingProceed { get; set; }
		public Nullable<decimal> OtherFinanceActProceed { get; set; }
		public Nullable<decimal> SubtotalFinanceCashInflow { get; set; }
		public Nullable<decimal> BorrowingRepayment { get; set; }
		public Nullable<decimal> BondRedemptionCashPaid { get; set; }
		public Nullable<decimal> FinanceActPayment { get; set; }
		public Nullable<decimal> DividendProfitDistribPayment { get; set; }
		public Nullable<decimal> InterestPayment { get; set; }
		public Nullable<decimal> MLTermBondInterestPaid { get; set; }
		public Nullable<decimal> FinanceLeasePayment { get; set; }
		public Nullable<decimal> RegCapitalReductionPayment { get; set; }
		public Nullable<decimal> OtherFinanceActPayment { get; set; }
		public Nullable<decimal> SubtotalFinanceCashOutflow { get; set; }
		public Nullable<decimal> NetFinanceCashFlow { get; set; }
		public Nullable<decimal> ExchangeRateChangeEffect { get; set; }
		public Nullable<decimal> CashEquivalentIncrease1 { get; set; }
		public Nullable<decimal> FixedAssetTransRepayment { get; set; }
		public Nullable<decimal> InvestTransRepayment { get; set; }
		public Nullable<decimal> FixedAssetTransInvest { get; set; }
		public Nullable<decimal> InventoryTransRepayment { get; set; }
		public Nullable<decimal> FinanceLeaseFixedAssets { get; set; }
		public Nullable<decimal> NonCashEndowment { get; set; }
		public Nullable<decimal> InvestTransLoan { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> MinorityProfit { get; set; }
		public Nullable<decimal> UnrecognisedInvestLoss { get; set; }
		public Nullable<decimal> BadDebtWrittenOffProvision { get; set; }
		public Nullable<decimal> RiskReserve { get; set; }
		public Nullable<decimal> SelfSecuLossReserve { get; set; }
		public Nullable<decimal> BadLoanProvision { get; set; }
		public Nullable<decimal> InvestLossReserve { get; set; }
		public Nullable<decimal> InventoryDevalProvision { get; set; }
		public Nullable<decimal> OtherAssetLossReserve { get; set; }
		public Nullable<decimal> FixedAssetDepreciation { get; set; }
		public Nullable<decimal> SeatFeeAmort { get; set; }
		public Nullable<decimal> PreoperateEexpenseAmort { get; set; }
		public Nullable<decimal> DeferredExpenseAmort { get; set; }
		public Nullable<decimal> IntangiDeferredAssetAmort { get; set; }
		public Nullable<decimal> DeferredExpenseDecreased { get; set; }
		public Nullable<decimal> AccruedExpenseAdded { get; set; }
		public Nullable<decimal> FixIntanOtherAssetDispoLoss { get; set; }
		public Nullable<decimal> FixedAssetScrapLoss { get; set; }
		public Nullable<decimal> FinancialExpense { get; set; }
		public Nullable<decimal> InvestLoss { get; set; }
		public Nullable<decimal> InveFinaActExchGainOrLoss { get; set; }
		public Nullable<decimal> NetDeferedTaxCredit { get; set; }
		public Nullable<decimal> InventoryDecr { get; set; }
		public Nullable<decimal> LendCapitalDecr { get; set; }
		public Nullable<decimal> STermLoanInvestDecr { get; set; }
		public Nullable<decimal> SubLoanDecr { get; set; }
		public Nullable<decimal> SecuAssetDecr { get; set; }
		public Nullable<decimal> TradeBailDecr { get; set; }
		public Nullable<decimal> ReceivablesDecr { get; set; }
		public Nullable<decimal> TrustAssetDecr { get; set; }
		public Nullable<decimal> SelfSecuDecr { get; set; }
		public Nullable<decimal> BoughtSellbackSecuDecr { get; set; }
		public Nullable<decimal> ProxySecuDecr { get; set; }
		public Nullable<decimal> SubIssueSecuDecr { get; set; }
		public Nullable<decimal> SubHonorSecuDecr { get; set; }
		public Nullable<decimal> IssueExpenseToTransDecr { get; set; }
		public Nullable<decimal> OperReceivablesDecr { get; set; }
		public Nullable<decimal> TrustDepositIncr { get; set; }
		public Nullable<decimal> BorrowingsIncr { get; set; }
		public Nullable<decimal> SecuDebtIncr { get; set; }
		public Nullable<decimal> PledgeBorrowingIncr { get; set; }
		public Nullable<decimal> TrustCapitalIncr { get; set; }
		public Nullable<decimal> AgentSecuPayableIncr { get; set; }
		public Nullable<decimal> ProxySecuProceedsIncr { get; set; }
		public Nullable<decimal> SubIssueSecuProceedsIncr { get; set; }
		public Nullable<decimal> SubHonorSecuProceedsIncr { get; set; }
		public Nullable<decimal> SoldBuybackSecuProcIncr { get; set; }
		public Nullable<decimal> PayablesIncr { get; set; }
		public Nullable<decimal> WagePayableIncr { get; set; }
		public Nullable<decimal> WelfarePayableIncr { get; set; }
		public Nullable<decimal> TaxSurchargesPayableIncr { get; set; }
		public Nullable<decimal> OperPayablesIncr { get; set; }
		public Nullable<decimal> NetVATIncr { get; set; }
		public Nullable<decimal> OtherNonCashExpenseOrLoss { get; set; }
		public Nullable<decimal> NetOperateCashFlow2 { get; set; }
		public Nullable<decimal> EndPeriodCashEquivalent { get; set; }
		public Nullable<decimal> EndPeriodEquivalent { get; set; }
		public Nullable<decimal> EndPeriodCash { get; set; }
		public Nullable<decimal> BeginPeriodCashEquivalent { get; set; }
		public Nullable<decimal> BeginPeriodEquivalent { get; set; }
		public Nullable<decimal> BeginPeriodCash { get; set; }
		public Nullable<decimal> CashEquivalentIncrease2 { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

