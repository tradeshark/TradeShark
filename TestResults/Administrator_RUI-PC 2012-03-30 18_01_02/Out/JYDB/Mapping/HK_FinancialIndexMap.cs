using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class HK_FinancialIndexMap : EntityTypeConfiguration<HK_FinancialIndex>
	{
		public HK_FinancialIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("HK_FinancialIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AbstrPublDate).HasColumnName("AbstrPublDate");
			this.Property(t => t.PerformancePublDate).HasColumnName("PerformancePublDate");
			this.Property(t => t.PeriodicReportPublDate).HasColumnName("PeriodicReportPublDate");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.PeriodMark).HasColumnName("PeriodMark");
			this.Property(t => t.FinancialYear).HasColumnName("FinancialYear");
			this.Property(t => t.Currency).HasColumnName("Currency");
			this.Property(t => t.OpinionType).HasColumnName("OpinionType");
			this.Property(t => t.EPSBasic).HasColumnName("EPSBasic");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.NoncurrentAssets).HasColumnName("NoncurrentAssets");
			this.Property(t => t.CurrentAssets).HasColumnName("CurrentAssets");
			this.Property(t => t.CurrentLiability).HasColumnName("CurrentLiability");
			this.Property(t => t.NonurrentLiability).HasColumnName("NonurrentLiability");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.MinorityInterests).HasColumnName("MinorityInterests");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.ShareCapital).HasColumnName("ShareCapital");
			this.Property(t => t.Reserves).HasColumnName("Reserves");
			this.Property(t => t.OperatingIncome).HasColumnName("OperatingIncome");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.AffiliatedComapnyprofit).HasColumnName("AffiliatedComapnyprofit");
			this.Property(t => t.CooperateBusinessProfit).HasColumnName("CooperateBusinessProfit");
			this.Property(t => t.EarningBeforeTax).HasColumnName("EarningBeforeTax");
			this.Property(t => t.TaxExpense).HasColumnName("TaxExpense");
			this.Property(t => t.EarningAfterTax).HasColumnName("EarningAfterTax");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.ProfitToShareholders).HasColumnName("ProfitToShareholders");
			this.Property(t => t.GrowthRate).HasColumnName("GrowthRate");
			this.Property(t => t.Dividend).HasColumnName("Dividend");
			this.Property(t => t.SpecialItemProfit).HasColumnName("SpecialItemProfit");
			this.Property(t => t.ProfitExSpecialItem).HasColumnName("ProfitExSpecialItem");
			this.Property(t => t.NetOperateCashFlow).HasColumnName("NetOperateCashFlow");
			this.Property(t => t.NetInvestCashFlow).HasColumnName("NetInvestCashFlow");
			this.Property(t => t.NetFinanceCashFlow).HasColumnName("NetFinanceCashFlow");
			this.Property(t => t.NetCashFlow).HasColumnName("NetCashFlow");
			this.Property(t => t.CashEquivalentBeginPer).HasColumnName("CashEquivalentBeginPer");
			this.Property(t => t.EffectOfFERChanges).HasColumnName("EffectOfFERChanges");
			this.Property(t => t.CashEquivalentEndPer).HasColumnName("CashEquivalentEndPer");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

