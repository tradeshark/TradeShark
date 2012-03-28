using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_FinancialExpenseMap : EntityTypeConfiguration<LC_FinancialExpense>
	{
		public LC_FinancialExpenseMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_FinancialExpense");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.InterestExpense).HasColumnName("InterestExpense");
			this.Property(t => t.CapitalOccupationExpense).HasColumnName("CapitalOccupationExpense");
			this.Property(t => t.InterestExpenseOfDiscount).HasColumnName("InterestExpenseOfDiscount");
			this.Property(t => t.InterestExpenseCapitalized).HasColumnName("InterestExpenseCapitalized");
			this.Property(t => t.InterestIncome).HasColumnName("InterestIncome");
			this.Property(t => t.CapitalOccupationIncome).HasColumnName("CapitalOccupationIncome");
			this.Property(t => t.InterestSubsidyIncome).HasColumnName("InterestSubsidyIncome");
			this.Property(t => t.ExchangeLoss).HasColumnName("ExchangeLoss");
			this.Property(t => t.ExchangeLossCapitalized).HasColumnName("ExchangeLossCapitalized");
			this.Property(t => t.ExchangeIncome).HasColumnName("ExchangeIncome");
			this.Property(t => t.CashDiscount).HasColumnName("CashDiscount");
			this.Property(t => t.OtherFinancialIncome).HasColumnName("OtherFinancialIncome");
			this.Property(t => t.Commission).HasColumnName("Commission");
			this.Property(t => t.SecurityExpense).HasColumnName("SecurityExpense");
			this.Property(t => t.OtherFinancialExpense).HasColumnName("OtherFinancialExpense");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

