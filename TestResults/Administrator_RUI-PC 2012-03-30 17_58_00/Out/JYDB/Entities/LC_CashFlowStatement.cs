using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_CashFlowStatement
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> GoodsSaleServiceRenderCash { get; set; }
		public Nullable<decimal> RentalReceived { get; set; }
		public Nullable<decimal> VATReceivedAndRefunded { get; set; }
		public Nullable<decimal> OtherTaxLevyRefund { get; set; }
		public Nullable<decimal> TaxLevyRefund { get; set; }
		public Nullable<decimal> OtherCashInRelatedOperate { get; set; }
		public Nullable<decimal> SubtotalOperateCashInflow { get; set; }
		public Nullable<decimal> GoodsServicesCashPaid { get; set; }
		public Nullable<decimal> OperateLeasesCashPaid { get; set; }
		public Nullable<decimal> StaffBehalfPaid { get; set; }
		public Nullable<decimal> VATPaid { get; set; }
		public Nullable<decimal> IncomeTaxPaid { get; set; }
		public Nullable<decimal> OtherTaxPaid { get; set; }
		public Nullable<decimal> AllTaxesPaid { get; set; }
		public Nullable<decimal> OtherOperateCashPaid { get; set; }
		public Nullable<decimal> SubtotalOperateCashOutflow { get; set; }
		public Nullable<decimal> NetOperateCashFlow { get; set; }
		public Nullable<decimal> InvestWithdrawalCash { get; set; }
		public Nullable<decimal> DividendAndProfitReceived { get; set; }
		public Nullable<decimal> BondInterestIncome { get; set; }
		public Nullable<decimal> FixIntanOtherAssetDispoCash { get; set; }
		public Nullable<decimal> OtherCashFromInvestAct { get; set; }
		public Nullable<decimal> SubtotalInvestCashInflow { get; set; }
		public Nullable<decimal> FixIntanOtherAssetAcquiCash { get; set; }
		public Nullable<decimal> EquityInvestCashPaid { get; set; }
		public Nullable<decimal> DebtInvestCashPaid { get; set; }
		public Nullable<decimal> OtherCashToInvestAct { get; set; }
		public Nullable<decimal> SubtotalInvestCashOutflow { get; set; }
		public Nullable<decimal> NetInvestCashFlow { get; set; }
		public Nullable<decimal> IssueShareproceeds { get; set; }
		public Nullable<decimal> MinorityInvestproceeds { get; set; }
		public Nullable<decimal> IssueBondproceeds { get; set; }
		public Nullable<decimal> Borrowingproceeds { get; set; }
		public Nullable<decimal> OtherFinanceActproceeds { get; set; }
		public Nullable<decimal> SubtotalFinanceCashInflow { get; set; }
		public Nullable<decimal> BorrowingRepayment { get; set; }
		public Nullable<decimal> FinanceActPayment { get; set; }
		public Nullable<decimal> DividendProfitDistribPayment { get; set; }
		public Nullable<decimal> SubCompanyPaidDiviToMino { get; set; }
		public Nullable<decimal> InterestPayment { get; set; }
		public Nullable<decimal> FinanceLeasePayment { get; set; }
		public Nullable<decimal> RegCapitalReductionPayment { get; set; }
		public Nullable<decimal> SubCompanyCapiReduPaidMino { get; set; }
		public Nullable<decimal> OtherFinanceActPayment { get; set; }
		public Nullable<decimal> SubtotalFinanceCashOutflow { get; set; }
		public Nullable<decimal> NetFinanceCashFlow { get; set; }
		public Nullable<decimal> ExchanRateChangeEffect { get; set; }
		public Nullable<decimal> CashEquivalentIncrease { get; set; }
		public Nullable<decimal> FixedAssetTransRepayment { get; set; }
		public Nullable<decimal> InvestTransRepayment { get; set; }
		public Nullable<decimal> FixedAssetFormInvest { get; set; }
		public Nullable<decimal> InventoryTransRepayment { get; set; }
		public Nullable<decimal> FinanceLeaseFixedAssets { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> MinorityProfit { get; set; }
		public Nullable<decimal> MergeAcquisitionProfit { get; set; }
		public Nullable<decimal> UnrecognisedInvestLoss { get; set; }
		public Nullable<decimal> BadDebtWrittenOffProvision { get; set; }
		public Nullable<decimal> FixedAssetDepreciation { get; set; }
		public Nullable<decimal> IntangibleAssetAmortization { get; set; }
		public Nullable<decimal> PreoperateEexpenseAmort { get; set; }
		public Nullable<decimal> DeferredExpenseAmort { get; set; }
		public Nullable<decimal> DeferredExpenseDecreased { get; set; }
		public Nullable<decimal> AccruedExpenseAdded { get; set; }
		public Nullable<decimal> FixIntanOtherAssetDispoLoss { get; set; }
		public Nullable<decimal> FixedAssetScrapLoss { get; set; }
		public Nullable<decimal> FinancialExpense { get; set; }
		public Nullable<decimal> InvestLoss { get; set; }
		public Nullable<decimal> NetDeferedTaxCredit { get; set; }
		public Nullable<decimal> InventoryDecrease { get; set; }
		public Nullable<decimal> InventoryDevalProvision { get; set; }
		public Nullable<decimal> OperateReceivableDecrease { get; set; }
		public Nullable<decimal> OperatePayableDecrease { get; set; }
		public Nullable<decimal> VATNetIncrease { get; set; }
		public Nullable<decimal> Others { get; set; }
		public Nullable<decimal> NetOperateCashFlowNotes { get; set; }
		public Nullable<decimal> EndPeriodCash { get; set; }
		public Nullable<decimal> BeginPeriodCash { get; set; }
		public Nullable<decimal> EndPeriodCashEquivalent { get; set; }
		public Nullable<decimal> BeginPeriodCashEquivalent { get; set; }
		public Nullable<decimal> CashEquivalentIncreaseNotes { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

