using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_PerformanceDistribution
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<decimal> SecurityApreadIncome { get; set; }
		public Nullable<decimal> StockSpreadIncome { get; set; }
		public Nullable<decimal> BondSpreadIncome { get; set; }
		public Nullable<decimal> ConvertibleSpreadIncome { get; set; }
		public Nullable<decimal> OtherSpreadIncome { get; set; }
		public Nullable<decimal> InvestmentIncome { get; set; }
		public Nullable<decimal> BondInterestIncome { get; set; }
		public Nullable<decimal> ConvertibleInterestIncome { get; set; }
		public Nullable<decimal> DepositInterestIncome { get; set; }
		public Nullable<decimal> DividendIncome { get; set; }
		public Nullable<decimal> BoughtSellbackSecuIncome { get; set; }
		public Nullable<decimal> OtherInvestmentIncome { get; set; }
		public Nullable<decimal> OtherIncome { get; set; }
		public Nullable<decimal> IssuanceFareBalance { get; set; }
		public Nullable<decimal> TotalIncome { get; set; }
		public Nullable<decimal> MangementFee { get; set; }
		public Nullable<decimal> PerformanceFee { get; set; }
		public Nullable<decimal> TrustFee { get; set; }
		public Nullable<decimal> SoldRepoSecuExpense { get; set; }
		public Nullable<decimal> InterestExpense { get; set; }
		public Nullable<decimal> OtherExpense { get; set; }
		public Nullable<decimal> AnnualListingFee { get; set; }
		public Nullable<decimal> InfoDisclosureFee { get; set; }
		public Nullable<decimal> AuditFee { get; set; }
		public Nullable<decimal> TotalExpense { get; set; }
		public Nullable<decimal> PastProfitAndLoss { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> UnrealizedProfitChange { get; set; }
		public Nullable<decimal> Performance { get; set; }
		public Nullable<decimal> RetainedNetProfitAtBegin { get; set; }
		public Nullable<decimal> RetainedProfitBeforeTrans { get; set; }
		public Nullable<decimal> RetainedProfitAtBegin { get; set; }
		public Nullable<decimal> ApplyingBufferMoney { get; set; }
		public Nullable<decimal> ProfitAndLossBufferMoney { get; set; }
		public Nullable<decimal> RedemptionBufferMoney { get; set; }
		public Nullable<decimal> DistributableNetProfit { get; set; }
		public Nullable<decimal> DistributedNetProfit { get; set; }
		public Nullable<decimal> Others { get; set; }
		public Nullable<decimal> ProfitDistribution { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> WarrantSpreadIncome { get; set; }
		public Nullable<decimal> SaleExpense { get; set; }
	}
}

