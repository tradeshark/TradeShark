using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_FIncomeStatement
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> OperatingIncome { get; set; }
		public Nullable<decimal> InterestIncome { get; set; }
		public Nullable<decimal> FinanceCoTurnoverIncome { get; set; }
		public Nullable<decimal> InSystemTurnoverIncome { get; set; }
		public Nullable<decimal> AssociateTurnoverIncome { get; set; }
		public Nullable<decimal> CommissionIncome { get; set; }
		public Nullable<decimal> DiscountInterestIncome { get; set; }
		public Nullable<decimal> SecuSpreadIncome { get; set; }
		public Nullable<decimal> SecuIssueSpreadIncome { get; set; }
		public Nullable<decimal> TrustIncome { get; set; }
		public Nullable<decimal> BoughtSellbackSecuIncome { get; set; }
		public Nullable<decimal> LeaseoutIncome { get; set; }
		public Nullable<decimal> ExchangeIncome { get; set; }
		public Nullable<decimal> InvestIncome { get; set; }
		public Nullable<decimal> OtherOperatingIncome { get; set; }
		public Nullable<decimal> OperatingPayout { get; set; }
		public Nullable<decimal> InterestExpense { get; set; }
		public Nullable<decimal> FinanceCoTurnoverExpense { get; set; }
		public Nullable<decimal> InSystemTurnoverExpense { get; set; }
		public Nullable<decimal> AssociateTurnoverExpense { get; set; }
		public Nullable<decimal> CommissionExpense { get; set; }
		public Nullable<decimal> SelfSecuDevalLoss { get; set; }
		public Nullable<decimal> InventoryDevalProvision { get; set; }
		public Nullable<decimal> SoldBuybackSecuExpense { get; set; }
		public Nullable<decimal> ExchangeLoss { get; set; }
		public Nullable<decimal> AdministrationExpense { get; set; }
		public Nullable<decimal> OperatingExpense { get; set; }
		public Nullable<decimal> FinancialExpense { get; set; }
		public Nullable<decimal> OtherOperatingExpense { get; set; }
		public Nullable<decimal> OperatingTaxAndSurcharges { get; set; }
		public Nullable<decimal> NetInvestIncome { get; set; }
		public Nullable<decimal> OperatingProfit { get; set; }
		public Nullable<decimal> OtherBizProfit { get; set; }
		public Nullable<decimal> NonOperatingInvestIncome { get; set; }
		public Nullable<decimal> SubsidyIncome { get; set; }
		public Nullable<decimal> NonoperatingIncome { get; set; }
		public Nullable<decimal> NonoperatingExpense { get; set; }
		public Nullable<decimal> PriorYearProfitAdjust { get; set; }
		public Nullable<decimal> AssetLossReserve { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public Nullable<decimal> IncomeTax { get; set; }
		public Nullable<decimal> FinanceRefund { get; set; }
		public Nullable<decimal> MinorityProfit { get; set; }
		public Nullable<decimal> UnrecognisedInvestLoss { get; set; }
		public Nullable<decimal> MergeAndAcquisitionProfit { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> RetainedProfitFromBegin { get; set; }
		public Nullable<decimal> RPforReduceRegCapital { get; set; }
		public Nullable<decimal> ProfitSwitchFromSurplus { get; set; }
		public Nullable<decimal> ConversionMargin { get; set; }
		public Nullable<decimal> DistributableProfit { get; set; }
		public Nullable<decimal> StatutorySurplusReserve { get; set; }
		public Nullable<decimal> StatutoryCommonWealFund { get; set; }
		public Nullable<decimal> StaffBonusAndWelfareFund { get; set; }
		public Nullable<decimal> ForeignCapitalReserve { get; set; }
		public Nullable<decimal> OrdinaryRiskReserve { get; set; }
		public Nullable<decimal> ProfitforShareholder { get; set; }
		public Nullable<decimal> PreferredStockDividend { get; set; }
		public Nullable<decimal> DiscretionarySurplusFund { get; set; }
		public Nullable<decimal> CommonDividendPayable { get; set; }
		public Nullable<decimal> CommonDiviChangeToCapital { get; set; }
		public Nullable<decimal> ProfitFromMerging { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

