using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class vw_research_reportfinanceMap : EntityTypeConfiguration<vw_research_reportfinance>
	{
		public vw_research_reportfinanceMap()
		{
			// Primary Key
			this.HasKey(t => new { t.endDate, t.companytype });

			// Properties
			this.Property(t => t.secucode)
				.HasMaxLength(10);
				
			this.Property(t => t.companytype)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.xvalue)
				.HasMaxLength(33);
				
			// Table & Column Mappings
			this.ToTable("vw_research_reportfinance");
			this.Property(t => t.endDate).HasColumnName("endDate");
			this.Property(t => t.secucode).HasColumnName("secucode");
			this.Property(t => t.companytype).HasColumnName("companytype");
			this.Property(t => t.xvalue).HasColumnName("xvalue");
			this.Property(t => t.OperatingRevenue).HasColumnName("OperatingRevenue");
			this.Property(t => t.OperatingCost).HasColumnName("OperatingCost");
			this.Property(t => t.GrossIncomeRatio).HasColumnName("GrossIncomeRatio");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.NetProfitRatio).HasColumnName("NetProfitRatio");
			this.Property(t => t.OperatingRevenueGrowRate).HasColumnName("OperatingRevenueGrowRate");
			this.Property(t => t.NetProfitGrowRate).HasColumnName("NetProfitGrowRate");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.NonoperatingIncome).HasColumnName("NonoperatingIncome");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.NetInterestIncome).HasColumnName("NetInterestIncome");
			this.Property(t => t.NetCommissionIncome).HasColumnName("NetCommissionIncome");
			this.Property(t => t.OtherOperatingIncome).HasColumnName("OtherOperatingIncome");
			this.Property(t => t.TotalProfitCostRatio).HasColumnName("TotalProfitCostRatio");
			this.Property(t => t.OperatingExpense).HasColumnName("OperatingExpense");
			this.Property(t => t.AdministrationExpense).HasColumnName("AdministrationExpense");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.OperatingAndAdminExpense).HasColumnName("OperatingAndAdminExpense");
			this.Property(t => t.OperatingTaxAndSurcharges).HasColumnName("OperatingTaxAndSurcharges");
			this.Property(t => t.AssetImpairmentLoss).HasColumnName("AssetImpairmentLoss");
			this.Property(t => t.TotalCurrentAssets).HasColumnName("TotalCurrentAssets");
			this.Property(t => t.LongtermInvest).HasColumnName("LongtermInvest");
			this.Property(t => t.FixedAssets).HasColumnName("FixedAssets");
			this.Property(t => t.ConstruInProcess).HasColumnName("ConstruInProcess");
			this.Property(t => t.IntangibleAssets).HasColumnName("IntangibleAssets");
			this.Property(t => t.ROE).HasColumnName("ROE");
			this.Property(t => t.Reserve).HasColumnName("Reserve");
			this.Property(t => t.LendCapital).HasColumnName("LendCapital");
			this.Property(t => t.Loan).HasColumnName("Loan");
			this.Property(t => t.Invest).HasColumnName("Invest");
			this.Property(t => t.CoreCapitalAdequacyRatio).HasColumnName("CoreCapitalAdequacyRatio");
			this.Property(t => t.BasicEPS).HasColumnName("BasicEPS");
			this.Property(t => t.NetAssetPS).HasColumnName("NetAssetPS");
			this.Property(t => t.MainIncomePS).HasColumnName("MainIncomePS");
			this.Property(t => t.CashFlowPS).HasColumnName("CashFlowPS");
		}
	}
}

