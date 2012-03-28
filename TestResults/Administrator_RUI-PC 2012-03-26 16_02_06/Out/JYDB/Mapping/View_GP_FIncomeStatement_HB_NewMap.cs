using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_FIncomeStatement_HB_NewMap : EntityTypeConfiguration<View_GP_FIncomeStatement_HB_New>
	{
		public View_GP_FIncomeStatement_HB_NewMap()
		{
			// Primary Key
			this.HasKey(t => new { t.XGRQ, t.ID, t.CompanyCode, t.EndDate, t.Mark, t.AccountingStandards, t.EnterpriseType, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.N_BulletinType)
				.HasMaxLength(300);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Mark)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AccountingStandards)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.EnterpriseType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("View_GP_FIncomeStatement_HB_New");
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
			this.Property(t => t.EnterpriseType).HasColumnName("EnterpriseType");
			this.Property(t => t.OperatingRevenue).HasColumnName("OperatingRevenue");
			this.Property(t => t.NetInterestIncome).HasColumnName("NetInterestIncome");
			this.Property(t => t.InterestIncome).HasColumnName("InterestIncome");
			this.Property(t => t.InterestExpense).HasColumnName("InterestExpense");
			this.Property(t => t.NetCommissionIncome).HasColumnName("NetCommissionIncome");
			this.Property(t => t.CommissionIncome).HasColumnName("CommissionIncome");
			this.Property(t => t.CommissionExpense).HasColumnName("CommissionExpense");
			this.Property(t => t.NetProxySecuIncome).HasColumnName("NetProxySecuIncome");
			this.Property(t => t.NetSubIssueSecuIncome).HasColumnName("NetSubIssueSecuIncome");
			this.Property(t => t.NetTrustIncome).HasColumnName("NetTrustIncome");
			this.Property(t => t.PremiumsEarned).HasColumnName("PremiumsEarned");
			this.Property(t => t.PremiumsIncome).HasColumnName("PremiumsIncome");
			this.Property(t => t.ReinsuranceIncome).HasColumnName("ReinsuranceIncome");
			this.Property(t => t.Reinsurance).HasColumnName("Reinsurance");
			this.Property(t => t.UnearnedPremiumReserve).HasColumnName("UnearnedPremiumReserve");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.InvestIncomeFromAssociates).HasColumnName("InvestIncomeFromAssociates");
			this.Property(t => t.FairValueChangeIncome).HasColumnName("FairValueChangeIncome");
			this.Property(t => t.ExchangeIncome).HasColumnName("ExchangeIncome");
			this.Property(t => t.OtherOperatingIncome).HasColumnName("OtherOperatingIncome");
			this.Property(t => t.SpecialItemsOR).HasColumnName("SpecialItemsOR");
			this.Property(t => t.AdjustmentItemsOR).HasColumnName("AdjustmentItemsOR");
			this.Property(t => t.OperatingPayout).HasColumnName("OperatingPayout");
			this.Property(t => t.RefundedPremiums).HasColumnName("RefundedPremiums");
			this.Property(t => t.CompensationExpense).HasColumnName("CompensationExpense");
			this.Property(t => t.AmortizationExpense).HasColumnName("AmortizationExpense");
			this.Property(t => t.PremiumReserve).HasColumnName("PremiumReserve");
			this.Property(t => t.AmortizationPremiumReserve).HasColumnName("AmortizationPremiumReserve");
			this.Property(t => t.PolicyDividendPayout).HasColumnName("PolicyDividendPayout");
			this.Property(t => t.ReinsuranceCost).HasColumnName("ReinsuranceCost");
			this.Property(t => t.AmortizationReinsuranceCost).HasColumnName("AmortizationReinsuranceCost");
			this.Property(t => t.InsuranceCommissionExpense).HasColumnName("InsuranceCommissionExpense");
			this.Property(t => t.OperatingTaxAndSurcharges).HasColumnName("OperatingTaxAndSurcharges");
			this.Property(t => t.OperatingAndAdminExpense).HasColumnName("OperatingAndAdminExpense");
			this.Property(t => t.AssetImpairmentLoss).HasColumnName("AssetImpairmentLoss");
			this.Property(t => t.OtherOperatingCost).HasColumnName("OtherOperatingCost");
			this.Property(t => t.SpecialItemsOP).HasColumnName("SpecialItemsOP");
			this.Property(t => t.AdjustmentItemsOP).HasColumnName("AdjustmentItemsOP");
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
			this.Property(t => t.NPFromParentCompanyOwners).HasColumnName("NPFromParentCompanyOwners");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.BasicEPS).HasColumnName("BasicEPS");
			this.Property(t => t.DilutedEPS).HasColumnName("DilutedEPS");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.UncertainedInvestmentLosses).HasColumnName("UncertainedInvestmentLosses");
		}
	}
}

