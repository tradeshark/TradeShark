using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class vw_research_companyfinance_FMap : EntityTypeConfiguration<vw_research_companyfinance_F>
	{
		public vw_research_companyfinance_FMap()
		{
			// Primary Key
			this.HasKey(t => t.endDate);

			// Properties
			this.Property(t => t.secucode)
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("vw_research_companyfinance_F");
			this.Property(t => t.endDate).HasColumnName("endDate");
			this.Property(t => t.secucode).HasColumnName("secucode");
			this.Property(t => t.OperatingRevenue).HasColumnName("OperatingRevenue");
			this.Property(t => t.NetInterestIncome).HasColumnName("NetInterestIncome");
			this.Property(t => t.NetCommissionIncome).HasColumnName("NetCommissionIncome");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.Others).HasColumnName("Others");
			this.Property(t => t.OperatingPayout).HasColumnName("OperatingPayout");
			this.Property(t => t.OperatingTaxAndSurcharges).HasColumnName("OperatingTaxAndSurcharges");
			this.Property(t => t.OperatingAndAdminExpense).HasColumnName("OperatingAndAdminExpense");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.NonoperatingProfit).HasColumnName("NonoperatingProfit");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.IncomeTaxCost).HasColumnName("IncomeTaxCost");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.BasicEPS).HasColumnName("BasicEPS");
			this.Property(t => t.ROE).HasColumnName("ROE");
			this.Property(t => t.Reserve).HasColumnName("Reserve");
			this.Property(t => t.LendCapital).HasColumnName("LendCapital");
			this.Property(t => t.Loan).HasColumnName("Loan");
			this.Property(t => t.Invest).HasColumnName("Invest");
			this.Property(t => t.OperatingRevenueGrowRate).HasColumnName("OperatingRevenueGrowRate");
			this.Property(t => t.NetProfitGrowRate).HasColumnName("NetProfitGrowRate");
			this.Property(t => t.CapitalAdequacyRatio).HasColumnName("CapitalAdequacyRatio");
			this.Property(t => t.CoreCapitalAdequacyRatio).HasColumnName("CoreCapitalAdequacyRatio");
			this.Property(t => t.NonPerformingRatio).HasColumnName("NonPerformingRatio");
			this.Property(t => t.ProfitAssetTARatio).HasColumnName("ProfitAssetTARatio");
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

