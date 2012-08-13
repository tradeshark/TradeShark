using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_PerformanceDistributionMap : EntityTypeConfiguration<MF_PerformanceDistribution>
	{
		public MF_PerformanceDistributionMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("MF_PerformanceDistribution");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.SecurityApreadIncome).HasColumnName("SecurityApreadIncome");
			this.Property(t => t.StockSpreadIncome).HasColumnName("StockSpreadIncome");
			this.Property(t => t.BondSpreadIncome).HasColumnName("BondSpreadIncome");
			this.Property(t => t.ConvertibleSpreadIncome).HasColumnName("ConvertibleSpreadIncome");
			this.Property(t => t.OtherSpreadIncome).HasColumnName("OtherSpreadIncome");
			this.Property(t => t.InvestmentIncome).HasColumnName("InvestmentIncome");
			this.Property(t => t.BondInterestIncome).HasColumnName("BondInterestIncome");
			this.Property(t => t.ConvertibleInterestIncome).HasColumnName("ConvertibleInterestIncome");
			this.Property(t => t.DepositInterestIncome).HasColumnName("DepositInterestIncome");
			this.Property(t => t.DividendIncome).HasColumnName("DividendIncome");
			this.Property(t => t.BoughtSellbackSecuIncome).HasColumnName("BoughtSellbackSecuIncome");
			this.Property(t => t.OtherInvestmentIncome).HasColumnName("OtherInvestmentIncome");
			this.Property(t => t.OtherIncome).HasColumnName("OtherIncome");
			this.Property(t => t.IssuanceFareBalance).HasColumnName("IssuanceFareBalance");
			this.Property(t => t.TotalIncome).HasColumnName("TotalIncome");
			this.Property(t => t.MangementFee).HasColumnName("MangementFee");
			this.Property(t => t.PerformanceFee).HasColumnName("PerformanceFee");
			this.Property(t => t.TrustFee).HasColumnName("TrustFee");
			this.Property(t => t.SoldRepoSecuExpense).HasColumnName("SoldRepoSecuExpense");
			this.Property(t => t.InterestExpense).HasColumnName("InterestExpense");
			this.Property(t => t.OtherExpense).HasColumnName("OtherExpense");
			this.Property(t => t.AnnualListingFee).HasColumnName("AnnualListingFee");
			this.Property(t => t.InfoDisclosureFee).HasColumnName("InfoDisclosureFee");
			this.Property(t => t.AuditFee).HasColumnName("AuditFee");
			this.Property(t => t.TotalExpense).HasColumnName("TotalExpense");
			this.Property(t => t.PastProfitAndLoss).HasColumnName("PastProfitAndLoss");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.UnrealizedProfitChange).HasColumnName("UnrealizedProfitChange");
			this.Property(t => t.Performance).HasColumnName("Performance");
			this.Property(t => t.RetainedNetProfitAtBegin).HasColumnName("RetainedNetProfitAtBegin");
			this.Property(t => t.RetainedProfitBeforeTrans).HasColumnName("RetainedProfitBeforeTrans");
			this.Property(t => t.RetainedProfitAtBegin).HasColumnName("RetainedProfitAtBegin");
			this.Property(t => t.ApplyingBufferMoney).HasColumnName("ApplyingBufferMoney");
			this.Property(t => t.ProfitAndLossBufferMoney).HasColumnName("ProfitAndLossBufferMoney");
			this.Property(t => t.RedemptionBufferMoney).HasColumnName("RedemptionBufferMoney");
			this.Property(t => t.DistributableNetProfit).HasColumnName("DistributableNetProfit");
			this.Property(t => t.DistributedNetProfit).HasColumnName("DistributedNetProfit");
			this.Property(t => t.Others).HasColumnName("Others");
			this.Property(t => t.ProfitDistribution).HasColumnName("ProfitDistribution");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.WarrantSpreadIncome).HasColumnName("WarrantSpreadIncome");
			this.Property(t => t.SaleExpense).HasColumnName("SaleExpense");
		}
	}
}

