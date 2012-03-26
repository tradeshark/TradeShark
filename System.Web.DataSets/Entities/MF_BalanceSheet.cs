using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_BalanceSheet
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<decimal> Cash { get; set; }
		public Nullable<decimal> Deposit { get; set; }
		public Nullable<decimal> SettlementproviDealCover { get; set; }
		public Nullable<decimal> Settlementprovi { get; set; }
		public Nullable<decimal> DealCover { get; set; }
		public Nullable<decimal> SecuSettlementReceivables { get; set; }
		public Nullable<decimal> DividendReceivables { get; set; }
		public Nullable<decimal> Receivables { get; set; }
		public Nullable<decimal> InterestReceivables { get; set; }
		public Nullable<decimal> ApplyingReceivables { get; set; }
		public Nullable<decimal> OtherReceivables { get; set; }
		public Nullable<decimal> StockInvestMarketValue { get; set; }
		public Nullable<decimal> StockInvestCost { get; set; }
		public Nullable<decimal> ShareInvestValueAdded { get; set; }
		public Nullable<decimal> BondInvestMarketValue { get; set; }
		public Nullable<decimal> BondInvestCost { get; set; }
		public Nullable<decimal> BondInvestValueAdded { get; set; }
		public Nullable<decimal> OtherInvestMarketValue { get; set; }
		public Nullable<decimal> OtherInvestCost { get; set; }
		public Nullable<decimal> OtherInvestValueAdded { get; set; }
		public Nullable<decimal> StockOption { get; set; }
		public Nullable<decimal> BoughtSellbackSecu { get; set; }
		public Nullable<decimal> DeferredExpense { get; set; }
		public Nullable<decimal> OtherAsset { get; set; }
		public Nullable<decimal> TotalAsset { get; set; }
		public Nullable<decimal> SecuSettlementPayables { get; set; }
		public Nullable<decimal> RedemptionMoneyPayable { get; set; }
		public Nullable<decimal> RedemptionFeePayable { get; set; }
		public Nullable<decimal> ManagementFeePayable { get; set; }
		public Nullable<decimal> TrustFeePayable { get; set; }
		public Nullable<decimal> PerformancePayment { get; set; }
		public Nullable<decimal> ProfitPayable { get; set; }
		public Nullable<decimal> AccountPayable { get; set; }
		public Nullable<decimal> CommisionPayable { get; set; }
		public Nullable<decimal> AllocationFundPayable { get; set; }
		public Nullable<decimal> TaxPayable { get; set; }
		public Nullable<decimal> BondDistributionPayable { get; set; }
		public Nullable<decimal> InterestPayable { get; set; }
		public Nullable<decimal> OtherPayable { get; set; }
		public Nullable<decimal> SoldRepoSecuProceeds { get; set; }
		public Nullable<decimal> ShortTermLoan { get; set; }
		public Nullable<decimal> AccruedExpense { get; set; }
		public Nullable<decimal> OtherDebts { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> Capital { get; set; }
		public Nullable<decimal> UnrealizedProfit { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> OtherEquity { get; set; }
		public Nullable<decimal> TotalShareHolderEquity { get; set; }
		public Nullable<decimal> TotalLiabilityAndEquity { get; set; }
		public Nullable<decimal> UnitNV { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> WarrantInvestMarketValue { get; set; }
		public Nullable<decimal> WarrantInvestCost { get; set; }
		public Nullable<decimal> WarrantInvestValueAdded { get; set; }
		public Nullable<decimal> SaleFeePayable { get; set; }
	}
}

