using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_QIncomeStatement
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> SalesRevenue { get; set; }
		public Nullable<decimal> SalesDiscountsAllowances { get; set; }
		public Nullable<decimal> NetSalesRevenue { get; set; }
		public Nullable<decimal> SalesCost { get; set; }
		public Nullable<decimal> salesTaxAndSurcharges { get; set; }
		public Nullable<decimal> GrossProfit { get; set; }
		public Nullable<decimal> OtherBizProfit { get; set; }
		public Nullable<decimal> InventoryDevalLoss { get; set; }
		public Nullable<decimal> OperatingExpense { get; set; }
		public Nullable<decimal> AdministrationExpense { get; set; }
		public Nullable<decimal> FinancialExpense { get; set; }
		public Nullable<decimal> OtherExpenses { get; set; }
		public Nullable<decimal> OperatingProfit { get; set; }
		public Nullable<decimal> InvestIncome { get; set; }
		public Nullable<decimal> FuturesInvestIncome { get; set; }
		public Nullable<decimal> SubsidyIncome { get; set; }
		public Nullable<decimal> NonoperatingIncome { get; set; }
		public Nullable<decimal> NonoperatingExpense { get; set; }
		public Nullable<decimal> PriorYearProfitAdjust { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public Nullable<decimal> IncomeTax { get; set; }
		public Nullable<decimal> FinanceRefund { get; set; }
		public Nullable<decimal> MinorityProfit { get; set; }
		public Nullable<decimal> UnrecognisedInvestLoss { get; set; }
		public Nullable<decimal> MergeAndAcquisitionAProfit { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

