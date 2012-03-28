using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_QFinancialIndexMap : EntityTypeConfiguration<LC_QFinancialIndex>
	{
		public LC_QFinancialIndexMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_QFinancialIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.OperCashInToDueDebt).HasColumnName("OperCashInToDueDebt");
			this.Property(t => t.OperCashInToCurrentDebt).HasColumnName("OperCashInToCurrentDebt");
			this.Property(t => t.OperCashInToTotalDebt).HasColumnName("OperCashInToTotalDebt");
			this.Property(t => t.NetProfitCut).HasColumnName("NetProfitCut");
			this.Property(t => t.NetProfitRatio).HasColumnName("NetProfitRatio");
			this.Property(t => t.GrossIncomeRatio).HasColumnName("GrossIncomeRatio");
			this.Property(t => t.TaxRatio).HasColumnName("TaxRatio");
			this.Property(t => t.CostRatio).HasColumnName("CostRatio");
			this.Property(t => t.ExpenseRatio).HasColumnName("ExpenseRatio");
			this.Property(t => t.ROA).HasColumnName("ROA");
			this.Property(t => t.ROE).HasColumnName("ROE");
			this.Property(t => t.ROECut).HasColumnName("ROECut");
			this.Property(t => t.MainOperaProfitRatio).HasColumnName("MainOperaProfitRatio");
			this.Property(t => t.OperatingProfitRatio).HasColumnName("OperatingProfitRatio");
			this.Property(t => t.TotalProfitCostRatio).HasColumnName("TotalProfitCostRatio");
			this.Property(t => t.NonRecurringGLProportion).HasColumnName("NonRecurringGLProportion");
			this.Property(t => t.CashRateOfSales).HasColumnName("CashRateOfSales");
			this.Property(t => t.OperCashInToAsset).HasColumnName("OperCashInToAsset");
			this.Property(t => t.CashToReinvest).HasColumnName("CashToReinvest");
			this.Property(t => t.NetEarningWorkingIndex).HasColumnName("NetEarningWorkingIndex");
			this.Property(t => t.CashWorkingIndex).HasColumnName("CashWorkingIndex");
			this.Property(t => t.NetProfitCashCover).HasColumnName("NetProfitCashCover");
			this.Property(t => t.MainIncomeCashCover).HasColumnName("MainIncomeCashCover");
			this.Property(t => t.ForcedCashPayRatio).HasColumnName("ForcedCashPayRatio");
			this.Property(t => t.ExternalFinanceRatio).HasColumnName("ExternalFinanceRatio");
			this.Property(t => t.CashPayStaffRatio).HasColumnName("CashPayStaffRatio");
			this.Property(t => t.OperCashStability).HasColumnName("OperCashStability");
			this.Property(t => t.NetProfitGrowRate).HasColumnName("NetProfitGrowRate");
			this.Property(t => t.MainIncomeGrowRate).HasColumnName("MainIncomeGrowRate");
			this.Property(t => t.GrossProfitGrowRate).HasColumnName("GrossProfitGrowRate");
			this.Property(t => t.OperProfitGrowRate).HasColumnName("OperProfitGrowRate");
			this.Property(t => t.TotalProfeiGrowRate).HasColumnName("TotalProfeiGrowRate");
			this.Property(t => t.ARTRGrowRate).HasColumnName("ARTRGrowRate");
			this.Property(t => t.FATRGrowRate).HasColumnName("FATRGrowRate");
			this.Property(t => t.CapitalItemKeepRate).HasColumnName("CapitalItemKeepRate");
			this.Property(t => t.InventoryTRGrowRate).HasColumnName("InventoryTRGrowRate");
			this.Property(t => t.OperCashPSGrowRate).HasColumnName("OperCashPSGrowRate");
			this.Property(t => t.OperCycle).HasColumnName("OperCycle");
			this.Property(t => t.InventoryTRate).HasColumnName("InventoryTRate");
			this.Property(t => t.InventoryTDays).HasColumnName("InventoryTDays");
			this.Property(t => t.ARTRate).HasColumnName("ARTRate");
			this.Property(t => t.ARTDays).HasColumnName("ARTDays");
			this.Property(t => t.CreditTRate).HasColumnName("CreditTRate");
			this.Property(t => t.CurrentTRate).HasColumnName("CurrentTRate");
			this.Property(t => t.TotalAssetTRate).HasColumnName("TotalAssetTRate");
			this.Property(t => t.FixedAssetTRate).HasColumnName("FixedAssetTRate");
			this.Property(t => t.EquityTRate).HasColumnName("EquityTRate");
			this.Property(t => t.AccruedPayableTRate).HasColumnName("AccruedPayableTRate");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.EPSCut).HasColumnName("EPSCut");
			this.Property(t => t.OperCashFlowPS).HasColumnName("OperCashFlowPS");
			this.Property(t => t.OperProfitPS).HasColumnName("OperProfitPS");
			this.Property(t => t.MainOperProfitPS).HasColumnName("MainOperProfitPS");
			this.Property(t => t.MainIncomePS).HasColumnName("MainIncomePS");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

