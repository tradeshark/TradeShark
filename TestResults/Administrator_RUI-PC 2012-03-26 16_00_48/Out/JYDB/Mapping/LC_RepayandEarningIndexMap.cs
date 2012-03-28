using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_RepayandEarningIndexMap : EntityTypeConfiguration<LC_RepayandEarningIndex>
	{
		public LC_RepayandEarningIndexMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_RepayandEarningIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.CurrentRatio).HasColumnName("CurrentRatio");
			this.Property(t => t.QuickRatio).HasColumnName("QuickRatio");
			this.Property(t => t.SuperQuickRatio).HasColumnName("SuperQuickRatio");
			this.Property(t => t.WorkingCapitalAssetRatio).HasColumnName("WorkingCapitalAssetRatio");
			this.Property(t => t.InterestCover).HasColumnName("InterestCover");
			this.Property(t => t.RepaymentCover).HasColumnName("RepaymentCover");
			this.Property(t => t.DebtAssetsRatio).HasColumnName("DebtAssetsRatio");
			this.Property(t => t.LongDebtToWorkingCapital).HasColumnName("LongDebtToWorkingCapital");
			this.Property(t => t.CashToCurrentDebt).HasColumnName("CashToCurrentDebt");
			this.Property(t => t.DebtEquityRatio).HasColumnName("DebtEquityRatio");
			this.Property(t => t.DebtTangibleEquityRatio).HasColumnName("DebtTangibleEquityRatio");
			this.Property(t => t.OperCashInToDueDebt).HasColumnName("OperCashInToDueDebt");
			this.Property(t => t.OperCashInToCurrentDebt).HasColumnName("OperCashInToCurrentDebt");
			this.Property(t => t.OperCashInToTotalDebt).HasColumnName("OperCashInToTotalDebt");
			this.Property(t => t.NetProfitCut).HasColumnName("NetProfitCut");
			this.Property(t => t.EBIT).HasColumnName("EBIT");
			this.Property(t => t.EBIAT).HasColumnName("EBIAT");
			this.Property(t => t.EBITAssetRatio).HasColumnName("EBITAssetRatio");
			this.Property(t => t.EBITDA).HasColumnName("EBITDA");
			this.Property(t => t.NetProfitRatio).HasColumnName("NetProfitRatio");
			this.Property(t => t.GrossIncomeRatio).HasColumnName("GrossIncomeRatio");
			this.Property(t => t.TaxRatio).HasColumnName("TaxRatio");
			this.Property(t => t.CostRatio).HasColumnName("CostRatio");
			this.Property(t => t.ExpenseRatio).HasColumnName("ExpenseRatio");
			this.Property(t => t.ROA).HasColumnName("ROA");
			this.Property(t => t.CapitalReturn).HasColumnName("CapitalReturn");
			this.Property(t => t.ROE).HasColumnName("ROE");
			this.Property(t => t.ROEWeighted).HasColumnName("ROEWeighted");
			this.Property(t => t.ROECut).HasColumnName("ROECut");
			this.Property(t => t.ROECutWeighted).HasColumnName("ROECutWeighted");
			this.Property(t => t.MainOperaProfitRatio).HasColumnName("MainOperaProfitRatio");
			this.Property(t => t.OperatingProfitRatio).HasColumnName("OperatingProfitRatio");
			this.Property(t => t.TotalProfitCostRatio).HasColumnName("TotalProfitCostRatio");
			this.Property(t => t.EquityGrowRate).HasColumnName("EquityGrowRate");
			this.Property(t => t.RetainedEarningAssetRatio).HasColumnName("RetainedEarningAssetRatio");
			this.Property(t => t.MainProfitProportion).HasColumnName("MainProfitProportion");
			this.Property(t => t.NonRecurringGLProportion).HasColumnName("NonRecurringGLProportion");
			this.Property(t => t.ProfitatISA).HasColumnName("ProfitatISA");
			this.Property(t => t.MarginIntoOut).HasColumnName("MarginIntoOut");
			this.Property(t => t.IncomeTaxProfitRatio).HasColumnName("IncomeTaxProfitRatio");
			this.Property(t => t.CashEquivalentPS).HasColumnName("CashEquivalentPS");
			this.Property(t => t.OperCashPS).HasColumnName("OperCashPS");
			this.Property(t => t.UndividedProfit).HasColumnName("UndividedProfit");
			this.Property(t => t.AccumulationFundPS).HasColumnName("AccumulationFundPS");
			this.Property(t => t.DividendPS).HasColumnName("DividendPS");
			this.Property(t => t.DividendCover).HasColumnName("DividendCover");
			this.Property(t => t.DividendPaidRatio).HasColumnName("DividendPaidRatio");
			this.Property(t => t.RetainedEarningRatio).HasColumnName("RetainedEarningRatio");
			this.Property(t => t.CashDividendCover).HasColumnName("CashDividendCover");
			this.Property(t => t.Dividend).HasColumnName("Dividend");
			this.Property(t => t.FreeCashFlow).HasColumnName("FreeCashFlow");
			this.Property(t => t.CashRateOfSales).HasColumnName("CashRateOfSales");
			this.Property(t => t.OperCashInToAsset).HasColumnName("OperCashInToAsset");
			this.Property(t => t.CashToMeetInvestNeeds).HasColumnName("CashToMeetInvestNeeds");
			this.Property(t => t.CashToReinvest).HasColumnName("CashToReinvest");
			this.Property(t => t.NetEarningWorkingIndex).HasColumnName("NetEarningWorkingIndex");
			this.Property(t => t.CashWorkingIndex).HasColumnName("CashWorkingIndex");
			this.Property(t => t.NetProfitCashCover).HasColumnName("NetProfitCashCover");
			this.Property(t => t.MainIncomeCashCover).HasColumnName("MainIncomeCashCover");
			this.Property(t => t.ForcedCashPayRatio).HasColumnName("ForcedCashPayRatio");
			this.Property(t => t.ExternalFinanceRatio).HasColumnName("ExternalFinanceRatio");
			this.Property(t => t.CashPayStaffRatio).HasColumnName("CashPayStaffRatio");
			this.Property(t => t.OperCashStability).HasColumnName("OperCashStability");
			this.Property(t => t.MarginOperCashtoProfit).HasColumnName("MarginOperCashtoProfit");
			this.Property(t => t.FinancingCashGrowRate).HasColumnName("FinancingCashGrowRate");
			this.Property(t => t.OperCashGrowRate).HasColumnName("OperCashGrowRate");
			this.Property(t => t.InvestCashGrowRate).HasColumnName("InvestCashGrowRate");
			this.Property(t => t.WorkingCapital).HasColumnName("WorkingCapital");
			this.Property(t => t.LongDebtToAsset).HasColumnName("LongDebtToAsset");
			this.Property(t => t.BondsPayableToAsset).HasColumnName("BondsPayableToAsset");
			this.Property(t => t.EquityToAsset).HasColumnName("EquityToAsset");
			this.Property(t => t.LongDebtToEquity).HasColumnName("LongDebtToEquity");
			this.Property(t => t.LongAssetFitRate).HasColumnName("LongAssetFitRate");
			this.Property(t => t.FixAssetRatio).HasColumnName("FixAssetRatio");
			this.Property(t => t.IntangibleAssetRatio).HasColumnName("IntangibleAssetRatio");
			this.Property(t => t.EquityMultipler).HasColumnName("EquityMultipler");
			this.Property(t => t.EquityFixedAssetRatio).HasColumnName("EquityFixedAssetRatio");
			this.Property(t => t.WorkCapitalLoanRatio).HasColumnName("WorkCapitalLoanRatio");
			this.Property(t => t.DebtGrowth).HasColumnName("DebtGrowth");
			this.Property(t => t.CapitalStockGrowth).HasColumnName("CapitalStockGrowth");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

