using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_FinancialIndexMap : EntityTypeConfiguration<MF_FinancialIndex>
	{
		public MF_FinancialIndexMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_FinancialIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.UnitNetProfit).HasColumnName("UnitNetProfit");
			this.Property(t => t.UnitDistributableProfit).HasColumnName("UnitDistributableProfit");
			this.Property(t => t.UnitRetainedProfit).HasColumnName("UnitRetainedProfit");
			this.Property(t => t.UnitNV).HasColumnName("UnitNV");
			this.Property(t => t.UnitAccumulatedNV).HasColumnName("UnitAccumulatedNV");
			this.Property(t => t.DiscountRatio).HasColumnName("DiscountRatio");
			this.Property(t => t.TotalAsset).HasColumnName("TotalAsset");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.UnrealizedProfit).HasColumnName("UnrealizedProfit");
			this.Property(t => t.TotalNetAsset).HasColumnName("TotalNetAsset");
			this.Property(t => t.TotalShares).HasColumnName("TotalShares");
			this.Property(t => t.TotalIncome).HasColumnName("TotalIncome");
			this.Property(t => t.SecuSpreadIncome).HasColumnName("SecuSpreadIncome");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.Performance).HasColumnName("Performance");
			this.Property(t => t.RealizedProfitRatio).HasColumnName("RealizedProfitRatio");
			this.Property(t => t.MainIncomeRatio).HasColumnName("MainIncomeRatio");
			this.Property(t => t.StockInvestIncomeRatio).HasColumnName("StockInvestIncomeRatio");
			this.Property(t => t.BondInvestIncomeRatio).HasColumnName("BondInvestIncomeRatio");
			this.Property(t => t.ManagementFeeProportion).HasColumnName("ManagementFeeProportion");
			this.Property(t => t.TrustFeeProportion).HasColumnName("TrustFeeProportion");
			this.Property(t => t.TradeExpenseProportion).HasColumnName("TradeExpenseProportion");
			this.Property(t => t.OtherExpenseProportion).HasColumnName("OtherExpenseProportion");
			this.Property(t => t.ManagementFeeProfitRatio).HasColumnName("ManagementFeeProfitRatio");
			this.Property(t => t.TrustFeeProfitRatio).HasColumnName("TrustFeeProfitRatio");
			this.Property(t => t.TradeExpenseProfitRatio).HasColumnName("TradeExpenseProfitRatio");
			this.Property(t => t.OtherExpenseProfitRatio).HasColumnName("OtherExpenseProfitRatio");
			this.Property(t => t.TotalExpenseProfitRatio).HasColumnName("TotalExpenseProfitRatio");
			this.Property(t => t.NVYield).HasColumnName("NVYield");
			this.Property(t => t.PerformanceGrowthRate).HasColumnName("PerformanceGrowthRate");
			this.Property(t => t.NVGrowthRate).HasColumnName("NVGrowthRate");
			this.Property(t => t.AccumulatedNVGrowthRate).HasColumnName("AccumulatedNVGrowthRate");
			this.Property(t => t.TotalAssetGrowthRate).HasColumnName("TotalAssetGrowthRate");
			this.Property(t => t.UnrealizedProfitRatio).HasColumnName("UnrealizedProfitRatio");
			this.Property(t => t.StockTradeYield).HasColumnName("StockTradeYield");
			this.Property(t => t.DividendRatio).HasColumnName("DividendRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

