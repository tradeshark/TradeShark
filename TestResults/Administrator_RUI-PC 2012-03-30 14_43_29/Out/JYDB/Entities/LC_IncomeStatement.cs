using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_IncomeStatement
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> SalesRevenue { get; set; }
		public Nullable<decimal> SalesDiscountsAllowances { get; set; }
		public Nullable<decimal> NetSalesRevenue { get; set; }
		public Nullable<decimal> SalesCost { get; set; }
		public Nullable<decimal> SalesTaxAndSurcharges { get; set; }
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
		public Nullable<decimal> MergeAndAcquisitionProfit { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> RetainedProfitFromBegin { get; set; }
		public Nullable<decimal> RPforReduceRegCapital { get; set; }
		public Nullable<decimal> ProfitForSponsor { get; set; }
		public Nullable<decimal> ProfitSwitchFromSurplus { get; set; }
		public Nullable<decimal> ConversionMargin { get; set; }
		public Nullable<decimal> DistributableProfit { get; set; }
		public Nullable<decimal> StatutorySurplusReserve { get; set; }
		public Nullable<decimal> StatutoryCommonWealFund { get; set; }
		public Nullable<decimal> StaffBonusAndWelfareFund { get; set; }
		public Nullable<decimal> ForeignCapitalReserve { get; set; }
		public Nullable<decimal> ReserveFundProvision { get; set; }
		public Nullable<decimal> DevelopProvision { get; set; }
		public Nullable<decimal> ProfitRefundInvest { get; set; }
		public Nullable<decimal> ProfitFromMerging { get; set; }
		public Nullable<decimal> ProfitforShareholder { get; set; }
		public Nullable<decimal> PreferredStockDividend { get; set; }
		public Nullable<decimal> DiscretionarySurplusFund { get; set; }
		public Nullable<decimal> CommonDividendPayable { get; set; }
		public Nullable<decimal> CommonDiviChangeToCapital { get; set; }
		public Nullable<decimal> AccumulatedLossOffset { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> DepartmentSettlement { get; set; }
		public Nullable<decimal> DisasterLoss { get; set; }
		public Nullable<decimal> AccountingPolicyChange { get; set; }
		public Nullable<decimal> OtherSpecialItems { get; set; }
		public Nullable<int> IfAdjusted { get; set; }
		public Nullable<int> IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

