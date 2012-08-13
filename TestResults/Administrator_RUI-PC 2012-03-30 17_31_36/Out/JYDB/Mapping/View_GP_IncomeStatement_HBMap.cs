using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_GP_IncomeStatement_HBMap : EntityTypeConfiguration<View_GP_IncomeStatement_HB>
	{
		public View_GP_IncomeStatement_HBMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.N_IfMerged)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfAdjusted)
				.HasMaxLength(300);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_GP_IncomeStatement_HB");
			this.Property(t => t.N_IfMerged).HasColumnName("N_IfMerged");
			this.Property(t => t.N_IfAdjusted).HasColumnName("N_IfAdjusted");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.SalesRevenue).HasColumnName("SalesRevenue");
			this.Property(t => t.SalesDiscountsAllowances).HasColumnName("SalesDiscountsAllowances");
			this.Property(t => t.NetSalesRevenue).HasColumnName("NetSalesRevenue");
			this.Property(t => t.SalesCost).HasColumnName("SalesCost");
			this.Property(t => t.SalesTaxAndSurcharges).HasColumnName("SalesTaxAndSurcharges");
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
			this.Property(t => t.MergeAndAcquisitionProfit).HasColumnName("MergeAndAcquisitionProfit");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.RetainedProfitFromBegin).HasColumnName("RetainedProfitFromBegin");
			this.Property(t => t.RPforReduceRegCapital).HasColumnName("RPforReduceRegCapital");
			this.Property(t => t.ProfitForSponsor).HasColumnName("ProfitForSponsor");
			this.Property(t => t.ProfitSwitchFromSurplus).HasColumnName("ProfitSwitchFromSurplus");
			this.Property(t => t.ConversionMargin).HasColumnName("ConversionMargin");
			this.Property(t => t.DistributableProfit).HasColumnName("DistributableProfit");
			this.Property(t => t.StatutorySurplusReserve).HasColumnName("StatutorySurplusReserve");
			this.Property(t => t.StatutoryCommonWealFund).HasColumnName("StatutoryCommonWealFund");
			this.Property(t => t.StaffBonusAndWelfareFund).HasColumnName("StaffBonusAndWelfareFund");
			this.Property(t => t.ForeignCapitalReserve).HasColumnName("ForeignCapitalReserve");
			this.Property(t => t.ReserveFundProvision).HasColumnName("ReserveFundProvision");
			this.Property(t => t.DevelopProvision).HasColumnName("DevelopProvision");
			this.Property(t => t.ProfitRefundInvest).HasColumnName("ProfitRefundInvest");
			this.Property(t => t.ProfitFromMerging).HasColumnName("ProfitFromMerging");
			this.Property(t => t.ProfitforShareholder).HasColumnName("ProfitforShareholder");
			this.Property(t => t.PreferredStockDividend).HasColumnName("PreferredStockDividend");
			this.Property(t => t.DiscretionarySurplusFund).HasColumnName("DiscretionarySurplusFund");
			this.Property(t => t.CommonDividendPayable).HasColumnName("CommonDividendPayable");
			this.Property(t => t.CommonDiviChangeToCapital).HasColumnName("CommonDiviChangeToCapital");
			this.Property(t => t.AccumulatedLossOffset).HasColumnName("AccumulatedLossOffset");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.DepartmentSettlement).HasColumnName("DepartmentSettlement");
			this.Property(t => t.DisasterLoss).HasColumnName("DisasterLoss");
			this.Property(t => t.AccountingPolicyChange).HasColumnName("AccountingPolicyChange");
			this.Property(t => t.OtherSpecialItems).HasColumnName("OtherSpecialItems");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

