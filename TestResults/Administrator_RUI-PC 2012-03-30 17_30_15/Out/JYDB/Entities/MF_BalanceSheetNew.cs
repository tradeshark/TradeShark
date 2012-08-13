using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class MF_BalanceSheetNew
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public int InnerCode { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public int Mark { get; set; }
		public Nullable<int> AccountingStandards { get; set; }
		public Nullable<decimal> Deposit { get; set; }
		public Nullable<decimal> SettlementProvi { get; set; }
		public Nullable<decimal> RefundableDeposit { get; set; }
		public Nullable<decimal> TradingAssets { get; set; }
		public Nullable<decimal> StockInvestment { get; set; }
		public Nullable<decimal> BondInvestment { get; set; }
		public Nullable<decimal> ABSInvestment { get; set; }
		public Nullable<decimal> FundInvestment { get; set; }
		public Nullable<decimal> WarrentInvestment { get; set; }
		public Nullable<decimal> DerivativeAssets { get; set; }
		public Nullable<decimal> BoughtSellbackAssets { get; set; }
		public Nullable<decimal> SecuSettlementReceivables { get; set; }
		public Nullable<decimal> InterestReceivables { get; set; }
		public Nullable<decimal> DividendReceivables { get; set; }
		public Nullable<decimal> ApplyingReceivables { get; set; }
		public Nullable<decimal> AccountReceivables { get; set; }
		public Nullable<decimal> OtherReceivables { get; set; }
		public Nullable<decimal> DeferrredExpense { get; set; }
		public Nullable<decimal> OtherAssets { get; set; }
		public Nullable<decimal> AExceptionalItems { get; set; }
		public Nullable<decimal> AAdjustmentItems { get; set; }
		public Nullable<decimal> TotalAssets { get; set; }
		public Nullable<decimal> ShortTermLoan { get; set; }
		public Nullable<decimal> TradingLiability { get; set; }
		public Nullable<decimal> DerivativeLiability { get; set; }
		public Nullable<decimal> SoldBuybackSecuProceeds { get; set; }
		public Nullable<decimal> SecuSettlementPayables { get; set; }
		public Nullable<decimal> RedemptionMoneyPayable { get; set; }
		public Nullable<decimal> RedemptionFeePayable { get; set; }
		public Nullable<decimal> ManagementFeePayable { get; set; }
		public Nullable<decimal> TrustFeePayable { get; set; }
		public Nullable<decimal> SalesFeePayable { get; set; }
		public Nullable<decimal> TransactionFeePayable { get; set; }
		public Nullable<decimal> TaxsPayable { get; set; }
		public Nullable<decimal> InterestPayable { get; set; }
		public Nullable<decimal> ProfitPayable { get; set; }
		public Nullable<decimal> AccountPayable { get; set; }
		public Nullable<decimal> OtherPayable { get; set; }
		public Nullable<decimal> AccruedExpense { get; set; }
		public Nullable<decimal> OtherLiability { get; set; }
		public Nullable<decimal> LExceptionalItems { get; set; }
		public Nullable<decimal> LAdjustmentItems { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> PaidInCapital { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> OtherEquity { get; set; }
		public Nullable<decimal> SEExceptionalItems { get; set; }
		public Nullable<decimal> SEAdjustmentItems { get; set; }
		public Nullable<decimal> TotalShareholderEquity { get; set; }
		public Nullable<decimal> LEExceptionalItems { get; set; }
		public Nullable<decimal> LEAdjustmentItems { get; set; }
		public Nullable<decimal> TotalLiabilityAndEquity { get; set; }
		public Nullable<decimal> TotalFundShares { get; set; }
		public Nullable<decimal> UnitNV { get; set; }
		public string SpecialFieldRemark { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> DeferredTaxAssets { get; set; }
		public Nullable<decimal> DeferredTaxLiability { get; set; }
	}
}

