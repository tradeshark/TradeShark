using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_QIncomeStatementMap : EntityTypeConfiguration<LC_QIncomeStatement>
	{
		public LC_QIncomeStatementMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_QIncomeStatement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.SalesRevenue).HasColumnName("SalesRevenue");
			this.Property(t => t.SalesDiscountsAllowances).HasColumnName("SalesDiscountsAllowances");
			this.Property(t => t.NetSalesRevenue).HasColumnName("NetSalesRevenue");
			this.Property(t => t.SalesCost).HasColumnName("SalesCost");
			this.Property(t => t.salesTaxAndSurcharges).HasColumnName("salesTaxAndSurcharges");
			this.Property(t => t.GrossProfit).HasColumnName("GrossProfit");
			this.Property(t => t.OtherBizProfit).HasColumnName("OtherBizProfit");
			this.Property(t => t.InventoryDevalLoss).HasColumnName("InventoryDevalLoss");
			this.Property(t => t.OperatingExpense).HasColumnName("OperatingExpense");
			this.Property(t => t.AdministrationExpense).HasColumnName("AdministrationExpense");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.OtherExpenses).HasColumnName("OtherExpenses");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.FuturesInvestIncome).HasColumnName("FuturesInvestIncome");
			this.Property(t => t.SubsidyIncome).HasColumnName("SubsidyIncome");
			this.Property(t => t.NonoperatingIncome).HasColumnName("NonoperatingIncome");
			this.Property(t => t.NonoperatingExpense).HasColumnName("NonoperatingExpense");
			this.Property(t => t.PriorYearProfitAdjust).HasColumnName("PriorYearProfitAdjust");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.IncomeTax).HasColumnName("IncomeTax");
			this.Property(t => t.FinanceRefund).HasColumnName("FinanceRefund");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.UnrecognisedInvestLoss).HasColumnName("UnrecognisedInvestLoss");
			this.Property(t => t.MergeAndAcquisitionAProfit).HasColumnName("MergeAndAcquisitionAProfit");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

