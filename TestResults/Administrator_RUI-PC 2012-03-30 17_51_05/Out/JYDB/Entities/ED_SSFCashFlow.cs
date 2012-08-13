using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_SSFCashFlow
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public int IfAdjusted { get; set; }
		public Nullable<decimal> CashFromBondInv { get; set; }
		public Nullable<decimal> CashFromEntrustInv { get; set; }
		public Nullable<decimal> CashDividendReceived { get; set; }
		public Nullable<decimal> CashFromEntrustInvIncome { get; set; }
		public Nullable<decimal> CouponFromBondInv { get; set; }
		public Nullable<decimal> BankSavings { get; set; }
		public Nullable<decimal> TaxReimbursement { get; set; }
		public Nullable<decimal> CashFromOtherOperRelated { get; set; }
		public Nullable<decimal> TotalCashInOper { get; set; }
		public Nullable<decimal> CashPaidBondInvestment { get; set; }
		public Nullable<decimal> CashPaidEntrustInv { get; set; }
		public Nullable<decimal> CashPaidApplyingNewShares { get; set; }
		public Nullable<decimal> CashPaidOtherOperRelated { get; set; }
		public Nullable<decimal> TotalCashOutOper { get; set; }
		public Nullable<decimal> NetCashFlowOper { get; set; }
		public Nullable<decimal> CashFromFinaAppropriation { get; set; }
		public Nullable<decimal> ReduStateStockholdings { get; set; }
		public Nullable<decimal> CashFromLottoryIssuance { get; set; }
		public Nullable<decimal> CashBankBorrowings { get; set; }
		public Nullable<decimal> CashFromOtherFinaRelated { get; set; }
		public Nullable<decimal> TotalCashInFina { get; set; }
		public Nullable<decimal> CashPaidBySSF { get; set; }
		public Nullable<decimal> ReturnBankBorrowings { get; set; }
		public Nullable<decimal> InterestsPaidtoBanks { get; set; }
		public Nullable<decimal> CashPaidOtherFinaRelated { get; set; }
		public Nullable<decimal> TotalCashOutFina { get; set; }
		public Nullable<decimal> NetCashFlowFina { get; set; }
		public Nullable<decimal> ImpactExchangeRateChange { get; set; }
		public Nullable<decimal> ImpactOtherFactors { get; set; }
		public Nullable<decimal> NetIncrCashAndEquivalent { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

