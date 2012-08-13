using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_FinancialIndex
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<decimal> UnitNetProfit { get; set; }
		public Nullable<decimal> UnitDistributableProfit { get; set; }
		public Nullable<decimal> UnitRetainedProfit { get; set; }
		public Nullable<decimal> UnitNV { get; set; }
		public Nullable<decimal> UnitAccumulatedNV { get; set; }
		public Nullable<decimal> DiscountRatio { get; set; }
		public Nullable<decimal> TotalAsset { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> UnrealizedProfit { get; set; }
		public Nullable<decimal> TotalNetAsset { get; set; }
		public Nullable<decimal> TotalShares { get; set; }
		public Nullable<decimal> TotalIncome { get; set; }
		public Nullable<decimal> SecuSpreadIncome { get; set; }
		public Nullable<decimal> InvestIncome { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> Performance { get; set; }
		public Nullable<decimal> RealizedProfitRatio { get; set; }
		public Nullable<decimal> MainIncomeRatio { get; set; }
		public Nullable<decimal> StockInvestIncomeRatio { get; set; }
		public Nullable<decimal> BondInvestIncomeRatio { get; set; }
		public Nullable<decimal> ManagementFeeProportion { get; set; }
		public Nullable<decimal> TrustFeeProportion { get; set; }
		public Nullable<decimal> TradeExpenseProportion { get; set; }
		public Nullable<decimal> OtherExpenseProportion { get; set; }
		public Nullable<decimal> ManagementFeeProfitRatio { get; set; }
		public Nullable<decimal> TrustFeeProfitRatio { get; set; }
		public Nullable<decimal> TradeExpenseProfitRatio { get; set; }
		public Nullable<decimal> OtherExpenseProfitRatio { get; set; }
		public Nullable<decimal> TotalExpenseProfitRatio { get; set; }
		public Nullable<decimal> NVYield { get; set; }
		public Nullable<decimal> PerformanceGrowthRate { get; set; }
		public Nullable<decimal> NVGrowthRate { get; set; }
		public Nullable<decimal> AccumulatedNVGrowthRate { get; set; }
		public Nullable<decimal> TotalAssetGrowthRate { get; set; }
		public Nullable<decimal> UnrealizedProfitRatio { get; set; }
		public Nullable<decimal> StockTradeYield { get; set; }
		public Nullable<decimal> DividendRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

