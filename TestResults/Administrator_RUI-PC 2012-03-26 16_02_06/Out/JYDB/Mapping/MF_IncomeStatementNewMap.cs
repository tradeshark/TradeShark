using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_IncomeStatementNewMap : EntityTypeConfiguration<MF_IncomeStatementNew>
	{
		public MF_IncomeStatementNewMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("MF_IncomeStatementNew");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.InterestIncome).HasColumnName("InterestIncome");
			this.Property(t => t.DepositInterestIncome).HasColumnName("DepositInterestIncome");
			this.Property(t => t.BondInterestIncome).HasColumnName("BondInterestIncome");
			this.Property(t => t.ABSInterestIncome).HasColumnName("ABSInterestIncome");
			this.Property(t => t.SellbackAssetsIncome).HasColumnName("SellbackAssetsIncome");
			this.Property(t => t.OtherInterestIncome).HasColumnName("OtherInterestIncome");
			this.Property(t => t.InvestmentIncome).HasColumnName("InvestmentIncome");
			this.Property(t => t.StockInvestmentIncome).HasColumnName("StockInvestmentIncome");
			this.Property(t => t.BondInvestmentIncome).HasColumnName("BondInvestmentIncome");
			this.Property(t => t.ABSInvestmentIncome).HasColumnName("ABSInvestmentIncome");
			this.Property(t => t.DerivativeInvestIncome).HasColumnName("DerivativeInvestIncome");
			this.Property(t => t.DividendIncome).HasColumnName("DividendIncome");
			this.Property(t => t.OtherInvestmentIncome).HasColumnName("OtherInvestmentIncome");
			this.Property(t => t.FairValueChangeIncome).HasColumnName("FairValueChangeIncome");
			this.Property(t => t.OtherIncome).HasColumnName("OtherIncome");
			this.Property(t => t.IncomeExceptionalItems).HasColumnName("IncomeExceptionalItems");
			this.Property(t => t.IncomeAdjustmentItems).HasColumnName("IncomeAdjustmentItems");
			this.Property(t => t.TotalRevenue).HasColumnName("TotalRevenue");
			this.Property(t => t.MangementExpense).HasColumnName("MangementExpense");
			this.Property(t => t.TrusteeExpense).HasColumnName("TrusteeExpense");
			this.Property(t => t.SaleExpense).HasColumnName("SaleExpense");
			this.Property(t => t.TransactionExpense).HasColumnName("TransactionExpense");
			this.Property(t => t.InterestExpense).HasColumnName("InterestExpense");
			this.Property(t => t.SoldRepoSecuExpense).HasColumnName("SoldRepoSecuExpense");
			this.Property(t => t.OtherExpense).HasColumnName("OtherExpense");
			this.Property(t => t.ExpenseExceptionalItems).HasColumnName("ExpenseExceptionalItems");
			this.Property(t => t.ExpenseAdjustmentItems).HasColumnName("ExpenseAdjustmentItems");
			this.Property(t => t.TotalExpense).HasColumnName("TotalExpense");
			this.Property(t => t.PastProfitAndLoss).HasColumnName("PastProfitAndLoss");
			this.Property(t => t.ProfitExceptionalItems).HasColumnName("ProfitExceptionalItems");
			this.Property(t => t.ProfitAdjustmentItems).HasColumnName("ProfitAdjustmentItems");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.StartDate).HasColumnName("StartDate");
		}
	}
}

