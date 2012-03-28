using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_IncomeStatementNew
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
		public Nullable<decimal> InterestIncome { get; set; }
		public Nullable<decimal> DepositInterestIncome { get; set; }
		public Nullable<decimal> BondInterestIncome { get; set; }
		public Nullable<decimal> ABSInterestIncome { get; set; }
		public Nullable<decimal> SellbackAssetsIncome { get; set; }
		public Nullable<decimal> OtherInterestIncome { get; set; }
		public Nullable<decimal> InvestmentIncome { get; set; }
		public Nullable<decimal> StockInvestmentIncome { get; set; }
		public Nullable<decimal> BondInvestmentIncome { get; set; }
		public Nullable<decimal> ABSInvestmentIncome { get; set; }
		public Nullable<decimal> DerivativeInvestIncome { get; set; }
		public Nullable<decimal> DividendIncome { get; set; }
		public Nullable<decimal> OtherInvestmentIncome { get; set; }
		public Nullable<decimal> FairValueChangeIncome { get; set; }
		public Nullable<decimal> OtherIncome { get; set; }
		public Nullable<decimal> IncomeExceptionalItems { get; set; }
		public Nullable<decimal> IncomeAdjustmentItems { get; set; }
		public Nullable<decimal> TotalRevenue { get; set; }
		public Nullable<decimal> MangementExpense { get; set; }
		public Nullable<decimal> TrusteeExpense { get; set; }
		public Nullable<decimal> SaleExpense { get; set; }
		public Nullable<decimal> TransactionExpense { get; set; }
		public Nullable<decimal> InterestExpense { get; set; }
		public Nullable<decimal> SoldRepoSecuExpense { get; set; }
		public Nullable<decimal> OtherExpense { get; set; }
		public Nullable<decimal> ExpenseExceptionalItems { get; set; }
		public Nullable<decimal> ExpenseAdjustmentItems { get; set; }
		public Nullable<decimal> TotalExpense { get; set; }
		public Nullable<decimal> PastProfitAndLoss { get; set; }
		public Nullable<decimal> ProfitExceptionalItems { get; set; }
		public Nullable<decimal> ProfitAdjustmentItems { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public string SpecialFieldRemark { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
	}
}

