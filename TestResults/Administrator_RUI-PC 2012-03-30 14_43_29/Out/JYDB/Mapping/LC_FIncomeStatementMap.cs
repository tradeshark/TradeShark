using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_FIncomeStatementMap : EntityTypeConfiguration<LC_FIncomeStatement>
	{
		public LC_FIncomeStatementMap()
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
			this.ToTable("LC_FIncomeStatement");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.OperatingIncome).HasColumnName("OperatingIncome");
			this.Property(t => t.InterestIncome).HasColumnName("InterestIncome");
			this.Property(t => t.FinanceCoTurnoverIncome).HasColumnName("FinanceCoTurnoverIncome");
			this.Property(t => t.InSystemTurnoverIncome).HasColumnName("InSystemTurnoverIncome");
			this.Property(t => t.AssociateTurnoverIncome).HasColumnName("AssociateTurnoverIncome");
			this.Property(t => t.CommissionIncome).HasColumnName("CommissionIncome");
			this.Property(t => t.DiscountInterestIncome).HasColumnName("DiscountInterestIncome");
			this.Property(t => t.SecuSpreadIncome).HasColumnName("SecuSpreadIncome");
			this.Property(t => t.SecuIssueSpreadIncome).HasColumnName("SecuIssueSpreadIncome");
			this.Property(t => t.TrustIncome).HasColumnName("TrustIncome");
			this.Property(t => t.BoughtSellbackSecuIncome).HasColumnName("BoughtSellbackSecuIncome");
			this.Property(t => t.LeaseoutIncome).HasColumnName("LeaseoutIncome");
			this.Property(t => t.ExchangeIncome).HasColumnName("ExchangeIncome");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.OtherOperatingIncome).HasColumnName("OtherOperatingIncome");
			this.Property(t => t.OperatingPayout).HasColumnName("OperatingPayout");
			this.Property(t => t.InterestExpense).HasColumnName("InterestExpense");
			this.Property(t => t.FinanceCoTurnoverExpense).HasColumnName("FinanceCoTurnoverExpense");
			this.Property(t => t.InSystemTurnoverExpense).HasColumnName("InSystemTurnoverExpense");
			this.Property(t => t.AssociateTurnoverExpense).HasColumnName("AssociateTurnoverExpense");
			this.Property(t => t.CommissionExpense).HasColumnName("CommissionExpense");
			this.Property(t => t.SelfSecuDevalLoss).HasColumnName("SelfSecuDevalLoss");
			this.Property(t => t.InventoryDevalProvision).HasColumnName("InventoryDevalProvision");
			this.Property(t => t.SoldBuybackSecuExpense).HasColumnName("SoldBuybackSecuExpense");
			this.Property(t => t.ExchangeLoss).HasColumnName("ExchangeLoss");
			this.Property(t => t.AdministrationExpense).HasColumnName("AdministrationExpense");
			this.Property(t => t.OperatingExpense).HasColumnName("OperatingExpense");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.OtherOperatingExpense).HasColumnName("OtherOperatingExpense");
			this.Property(t => t.OperatingTaxAndSurcharges).HasColumnName("OperatingTaxAndSurcharges");
			this.Property(t => t.NetInvestIncome).HasColumnName("NetInvestIncome");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.OtherBizProfit).HasColumnName("OtherBizProfit");
			this.Property(t => t.NonOperatingInvestIncome).HasColumnName("NonOperatingInvestIncome");
			this.Property(t => t.SubsidyIncome).HasColumnName("SubsidyIncome");
			this.Property(t => t.NonoperatingIncome).HasColumnName("NonoperatingIncome");
			this.Property(t => t.NonoperatingExpense).HasColumnName("NonoperatingExpense");
			this.Property(t => t.PriorYearProfitAdjust).HasColumnName("PriorYearProfitAdjust");
			this.Property(t => t.AssetLossReserve).HasColumnName("AssetLossReserve");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.IncomeTax).HasColumnName("IncomeTax");
			this.Property(t => t.FinanceRefund).HasColumnName("FinanceRefund");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.UnrecognisedInvestLoss).HasColumnName("UnrecognisedInvestLoss");
			this.Property(t => t.MergeAndAcquisitionProfit).HasColumnName("MergeAndAcquisitionProfit");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.RetainedProfitFromBegin).HasColumnName("RetainedProfitFromBegin");
			this.Property(t => t.RPforReduceRegCapital).HasColumnName("RPforReduceRegCapital");
			this.Property(t => t.ProfitSwitchFromSurplus).HasColumnName("ProfitSwitchFromSurplus");
			this.Property(t => t.ConversionMargin).HasColumnName("ConversionMargin");
			this.Property(t => t.DistributableProfit).HasColumnName("DistributableProfit");
			this.Property(t => t.StatutorySurplusReserve).HasColumnName("StatutorySurplusReserve");
			this.Property(t => t.StatutoryCommonWealFund).HasColumnName("StatutoryCommonWealFund");
			this.Property(t => t.StaffBonusAndWelfareFund).HasColumnName("StaffBonusAndWelfareFund");
			this.Property(t => t.ForeignCapitalReserve).HasColumnName("ForeignCapitalReserve");
			this.Property(t => t.OrdinaryRiskReserve).HasColumnName("OrdinaryRiskReserve");
			this.Property(t => t.ProfitforShareholder).HasColumnName("ProfitforShareholder");
			this.Property(t => t.PreferredStockDividend).HasColumnName("PreferredStockDividend");
			this.Property(t => t.DiscretionarySurplusFund).HasColumnName("DiscretionarySurplusFund");
			this.Property(t => t.CommonDividendPayable).HasColumnName("CommonDividendPayable");
			this.Property(t => t.CommonDiviChangeToCapital).HasColumnName("CommonDiviChangeToCapital");
			this.Property(t => t.ProfitFromMerging).HasColumnName("ProfitFromMerging");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

