using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_FinancialIndex
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> AbstrPublDate { get; set; }
		public Nullable<System.DateTime> PerformancePublDate { get; set; }
		public Nullable<System.DateTime> PeriodicReportPublDate { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public Nullable<int> IfAdjusted { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> PeriodMark { get; set; }
		public Nullable<System.DateTime> FinancialYear { get; set; }
		public Nullable<int> Currency { get; set; }
		public Nullable<int> OpinionType { get; set; }
		public Nullable<decimal> EPSBasic { get; set; }
		public Nullable<decimal> EPS { get; set; }
		public Nullable<decimal> TotalAssets { get; set; }
		public Nullable<decimal> NoncurrentAssets { get; set; }
		public Nullable<decimal> CurrentAssets { get; set; }
		public Nullable<decimal> CurrentLiability { get; set; }
		public Nullable<decimal> NonurrentLiability { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> MinorityInterests { get; set; }
		public Nullable<decimal> TotalShareholderEquity { get; set; }
		public Nullable<decimal> ShareCapital { get; set; }
		public Nullable<decimal> Reserves { get; set; }
		public Nullable<decimal> OperatingIncome { get; set; }
		public Nullable<decimal> OperatingProfit { get; set; }
		public Nullable<decimal> FinancialExpense { get; set; }
		public Nullable<decimal> AffiliatedComapnyprofit { get; set; }
		public Nullable<decimal> CooperateBusinessProfit { get; set; }
		public Nullable<decimal> EarningBeforeTax { get; set; }
		public Nullable<decimal> TaxExpense { get; set; }
		public Nullable<decimal> EarningAfterTax { get; set; }
		public Nullable<decimal> MinorityProfit { get; set; }
		public Nullable<decimal> ProfitToShareholders { get; set; }
		public Nullable<decimal> GrowthRate { get; set; }
		public Nullable<decimal> Dividend { get; set; }
		public Nullable<decimal> SpecialItemProfit { get; set; }
		public Nullable<decimal> ProfitExSpecialItem { get; set; }
		public Nullable<decimal> NetOperateCashFlow { get; set; }
		public Nullable<decimal> NetInvestCashFlow { get; set; }
		public Nullable<decimal> NetFinanceCashFlow { get; set; }
		public Nullable<decimal> NetCashFlow { get; set; }
		public Nullable<decimal> CashEquivalentBeginPer { get; set; }
		public Nullable<decimal> EffectOfFERChanges { get; set; }
		public Nullable<decimal> CashEquivalentEndPer { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

