using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_QFinancialIndex
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> OperCashInToDueDebt { get; set; }
		public Nullable<decimal> OperCashInToCurrentDebt { get; set; }
		public Nullable<decimal> OperCashInToTotalDebt { get; set; }
		public Nullable<decimal> NetProfitCut { get; set; }
		public Nullable<decimal> NetProfitRatio { get; set; }
		public Nullable<decimal> GrossIncomeRatio { get; set; }
		public Nullable<decimal> TaxRatio { get; set; }
		public Nullable<decimal> CostRatio { get; set; }
		public Nullable<decimal> ExpenseRatio { get; set; }
		public Nullable<decimal> ROA { get; set; }
		public Nullable<decimal> ROE { get; set; }
		public Nullable<decimal> ROECut { get; set; }
		public Nullable<decimal> MainOperaProfitRatio { get; set; }
		public Nullable<decimal> OperatingProfitRatio { get; set; }
		public Nullable<decimal> TotalProfitCostRatio { get; set; }
		public Nullable<decimal> NonRecurringGLProportion { get; set; }
		public Nullable<decimal> CashRateOfSales { get; set; }
		public Nullable<decimal> OperCashInToAsset { get; set; }
		public Nullable<decimal> CashToReinvest { get; set; }
		public Nullable<decimal> NetEarningWorkingIndex { get; set; }
		public Nullable<decimal> CashWorkingIndex { get; set; }
		public Nullable<decimal> NetProfitCashCover { get; set; }
		public Nullable<decimal> MainIncomeCashCover { get; set; }
		public Nullable<decimal> ForcedCashPayRatio { get; set; }
		public Nullable<decimal> ExternalFinanceRatio { get; set; }
		public Nullable<decimal> CashPayStaffRatio { get; set; }
		public Nullable<decimal> OperCashStability { get; set; }
		public Nullable<decimal> NetProfitGrowRate { get; set; }
		public Nullable<decimal> MainIncomeGrowRate { get; set; }
		public Nullable<decimal> GrossProfitGrowRate { get; set; }
		public Nullable<decimal> OperProfitGrowRate { get; set; }
		public Nullable<decimal> TotalProfeiGrowRate { get; set; }
		public Nullable<decimal> ARTRGrowRate { get; set; }
		public Nullable<decimal> FATRGrowRate { get; set; }
		public Nullable<decimal> CapitalItemKeepRate { get; set; }
		public Nullable<decimal> InventoryTRGrowRate { get; set; }
		public Nullable<decimal> OperCashPSGrowRate { get; set; }
		public Nullable<decimal> OperCycle { get; set; }
		public Nullable<decimal> InventoryTRate { get; set; }
		public Nullable<decimal> InventoryTDays { get; set; }
		public Nullable<decimal> ARTRate { get; set; }
		public Nullable<decimal> ARTDays { get; set; }
		public Nullable<decimal> CreditTRate { get; set; }
		public Nullable<decimal> CurrentTRate { get; set; }
		public Nullable<decimal> TotalAssetTRate { get; set; }
		public Nullable<decimal> FixedAssetTRate { get; set; }
		public Nullable<decimal> EquityTRate { get; set; }
		public Nullable<decimal> AccruedPayableTRate { get; set; }
		public Nullable<decimal> EPS { get; set; }
		public Nullable<decimal> EPSCut { get; set; }
		public Nullable<decimal> OperCashFlowPS { get; set; }
		public Nullable<decimal> OperProfitPS { get; set; }
		public Nullable<decimal> MainOperProfitPS { get; set; }
		public Nullable<decimal> MainIncomePS { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

