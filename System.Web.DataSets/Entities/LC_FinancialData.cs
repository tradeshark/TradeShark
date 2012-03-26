using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_FinancialData
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> SalesCost { get; set; }
		public Nullable<decimal> GrossProfit { get; set; }
		public Nullable<decimal> SalesRevenue { get; set; }
		public Nullable<decimal> OtherBizProfit { get; set; }
		public Nullable<decimal> OperatingProfit { get; set; }
		public Nullable<decimal> InvestIncome { get; set; }
		public Nullable<decimal> SubsidyIncome { get; set; }
		public Nullable<decimal> NetNonoperating { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> ProfitatISA { get; set; }
		public Nullable<decimal> MarginIntoOut { get; set; }
		public string MarginIntoOutStatement { get; set; }
		public Nullable<decimal> NetProfitCut { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> CashEquivalentIncrease { get; set; }
		public Nullable<decimal> NetOperateCashFlow { get; set; }
		public Nullable<decimal> GoodsSaleServiceRenderCash { get; set; }
		public Nullable<decimal> MarginOperCashtoProfit { get; set; }
		public Nullable<decimal> NetProfitCashCover { get; set; }
		public Nullable<decimal> MainIncomeCashCover { get; set; }
		public Nullable<decimal> TotalAsset { get; set; }
		public Nullable<decimal> CashEquivalents { get; set; }
		public Nullable<decimal> Deposit { get; set; }
		public Nullable<decimal> WorkingCapital { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> TotalShareholderEquity { get; set; }
		public Nullable<decimal> CapitalReserveFund { get; set; }
		public Nullable<decimal> SurplusReserveFund { get; set; }
		public Nullable<decimal> TotalShares { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

