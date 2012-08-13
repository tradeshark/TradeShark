using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_IncomeStatement_MGS_NewMap : EntityTypeConfiguration<View_GP_IncomeStatement_MGS_New>
	{
		public View_GP_IncomeStatement_MGS_NewMap()
		{
			// Primary Key
			this.HasKey(t => new { t.XGRQ, t.ID, t.CompanyCode, t.EndDate, t.Mark, t.AccountingStandards, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.N_BulletinType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_AccountingStandards)
				.HasMaxLength(10);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Mark)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AccountingStandards)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("View_GP_IncomeStatement_MGS_New");
			this.Property(t => t.N_BulletinType).HasColumnName("N_BulletinType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.N_AccountingStandards).HasColumnName("N_AccountingStandards");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.OperatingRevenue).HasColumnName("OperatingRevenue");
			this.Property(t => t.OperatingCost).HasColumnName("OperatingCost");
			this.Property(t => t.OperatingTaxSurcharges).HasColumnName("OperatingTaxSurcharges");
			this.Property(t => t.OperatingExpense).HasColumnName("OperatingExpense");
			this.Property(t => t.AdministrationExpense).HasColumnName("AdministrationExpense");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.AssetImpairmentLoss).HasColumnName("AssetImpairmentLoss");
			this.Property(t => t.FairValueChangeIncome).HasColumnName("FairValueChangeIncome");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.InvestIncomeAssociates).HasColumnName("InvestIncomeAssociates");
			this.Property(t => t.OtherItemsEffectingOP).HasColumnName("OtherItemsEffectingOP");
			this.Property(t => t.AdjustedItemsEffectingOP).HasColumnName("AdjustedItemsEffectingOP");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.NonoperatingIncome).HasColumnName("NonoperatingIncome");
			this.Property(t => t.NonoperatingExpense).HasColumnName("NonoperatingExpense");
			this.Property(t => t.NonCurrentAssetssDealLoss).HasColumnName("NonCurrentAssetssDealLoss");
			this.Property(t => t.OtherItemsEffectingTP).HasColumnName("OtherItemsEffectingTP");
			this.Property(t => t.AdjustedItemsEffectingTP).HasColumnName("AdjustedItemsEffectingTP");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.IncomeTaxCost).HasColumnName("IncomeTaxCost");
			this.Property(t => t.OtherItemsEffectingNP).HasColumnName("OtherItemsEffectingNP");
			this.Property(t => t.AdjustedItemsEffectingNP).HasColumnName("AdjustedItemsEffectingNP");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.NPParentCompanyOwners).HasColumnName("NPParentCompanyOwners");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.BasicEPS).HasColumnName("BasicEPS");
			this.Property(t => t.DilutedEPS).HasColumnName("DilutedEPS");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.UncertainedInvestmentLosses).HasColumnName("UncertainedInvestmentLosses");
			this.Property(t => t.TotalOperatingRevenue).HasColumnName("TotalOperatingRevenue");
			this.Property(t => t.OtherOperatingRevenue).HasColumnName("OtherOperatingRevenue");
			this.Property(t => t.TotalOperatingCost).HasColumnName("TotalOperatingCost");
			this.Property(t => t.OtherOperatingCost).HasColumnName("OtherOperatingCost");
		}
	}
}

