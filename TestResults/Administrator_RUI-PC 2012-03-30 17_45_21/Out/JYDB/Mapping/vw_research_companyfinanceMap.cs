using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class vw_research_companyfinanceMap : EntityTypeConfiguration<vw_research_companyfinance>
	{
		public vw_research_companyfinanceMap()
		{
			// Primary Key
			this.HasKey(t => t.endDate);

			// Properties
			this.Property(t => t.secucode)
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("vw_research_companyfinance");
			this.Property(t => t.endDate).HasColumnName("endDate");
			this.Property(t => t.secucode).HasColumnName("secucode");
			this.Property(t => t.OperatingRevenue).HasColumnName("OperatingRevenue");
			this.Property(t => t.MainOperatingProfit).HasColumnName("MainOperatingProfit");
			this.Property(t => t.OperatingExpense).HasColumnName("OperatingExpense");
			this.Property(t => t.AdministrationExpense).HasColumnName("AdministrationExpense");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.NonoperatingProfit).HasColumnName("NonoperatingProfit");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.IncomeTaxCost).HasColumnName("IncomeTaxCost");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.BasicEPS).HasColumnName("BasicEPS");
			this.Property(t => t.ROE).HasColumnName("ROE");
			this.Property(t => t.CashEquivalents).HasColumnName("CashEquivalents");
			this.Property(t => t.TotalCurrentAssets).HasColumnName("TotalCurrentAssets");
			this.Property(t => t.LongtermInvest).HasColumnName("LongtermInvest");
			this.Property(t => t.FixedAssets).HasColumnName("FixedAssets");
			this.Property(t => t.OperatingRevenueGrowRate).HasColumnName("OperatingRevenueGrowRate");
			this.Property(t => t.NetProfitGrowRate).HasColumnName("NetProfitGrowRate");
			this.Property(t => t.NetProfitRatio).HasColumnName("NetProfitRatio");
			this.Property(t => t.TotalProfitCostRatio).HasColumnName("TotalProfitCostRatio");
			this.Property(t => t.GrossIncomeRatio).HasColumnName("GrossIncomeRatio");
			this.Property(t => t.BasicEPSYOY).HasColumnName("BasicEPSYOY");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.SEWithoutMI).HasColumnName("SEWithoutMI");
			this.Property(t => t.NetOperateCashFlow).HasColumnName("NetOperateCashFlow");
			this.Property(t => t.NetInvestCashFlow).HasColumnName("NetInvestCashFlow");
			this.Property(t => t.NetFinanceCashFlow).HasColumnName("NetFinanceCashFlow");
			this.Property(t => t.EndPeriodCashEquivalent).HasColumnName("EndPeriodCashEquivalent");
		}
	}
}

