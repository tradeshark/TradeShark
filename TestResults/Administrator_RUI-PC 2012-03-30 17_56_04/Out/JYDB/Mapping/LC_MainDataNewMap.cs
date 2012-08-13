using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_MainDataNewMap : EntityTypeConfiguration<LC_MainDataNew>
	{
		public LC_MainDataNewMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.BulletinType)
				.HasMaxLength(30);
				
			this.Property(t => t.DiidendFinancing)
				.HasMaxLength(200);
				
			this.Property(t => t.ModifiedAuditOpinion)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("LC_MainDataNew");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.Mark).HasColumnName("Mark");
			this.Property(t => t.BasicEPS).HasColumnName("BasicEPS");
			this.Property(t => t.DilutedEPS).HasColumnName("DilutedEPS");
			this.Property(t => t.BasicEPSCut).HasColumnName("BasicEPSCut");
			this.Property(t => t.DilutedEPSCut).HasColumnName("DilutedEPSCut");
			this.Property(t => t.EPS).HasColumnName("EPS");
			this.Property(t => t.ROEByReport).HasColumnName("ROEByReport");
			this.Property(t => t.ROE).HasColumnName("ROE");
			this.Property(t => t.ROECut).HasColumnName("ROECut");
			this.Property(t => t.WROE).HasColumnName("WROE");
			this.Property(t => t.WROECut).HasColumnName("WROECut");
			this.Property(t => t.OperatingReenue).HasColumnName("OperatingReenue");
			this.Property(t => t.NPFromParentCompanyOwners).HasColumnName("NPFromParentCompanyOwners");
			this.Property(t => t.NetProfitCut).HasColumnName("NetProfitCut");
			this.Property(t => t.ProfitatISA).HasColumnName("ProfitatISA");
			this.Property(t => t.MarginIntoOutStatement).HasColumnName("MarginIntoOutStatement");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.NetOperateCashFlow).HasColumnName("NetOperateCashFlow");
			this.Property(t => t.NetOperateCashFlowPS).HasColumnName("NetOperateCashFlowPS");
			this.Property(t => t.CashEquialentIncrease).HasColumnName("CashEquialentIncrease");
			this.Property(t => t.CashEquialents).HasColumnName("CashEquialents");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.SEWithoutMI).HasColumnName("SEWithoutMI");
			this.Property(t => t.NetAssetISA).HasColumnName("NetAssetISA");
			this.Property(t => t.NAPSByReport).HasColumnName("NAPSByReport");
			this.Property(t => t.NAPS).HasColumnName("NAPS");
			this.Property(t => t.NAPSAdjusted).HasColumnName("NAPSAdjusted");
			this.Property(t => t.CapitalResereFund).HasColumnName("CapitalResereFund");
			this.Property(t => t.TotalShares).HasColumnName("TotalShares");
			this.Property(t => t.DiidendFinancing).HasColumnName("DiidendFinancing");
			this.Property(t => t.TotalRecompense).HasColumnName("TotalRecompense");
			this.Property(t => t.FeeForAccountantOffice).HasColumnName("FeeForAccountantOffice");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.OperatingProfit).HasColumnName("OperatingProfit");
			this.Property(t => t.TotalProfit).HasColumnName("TotalProfit");
			this.Property(t => t.ModifiedAuditOpinion).HasColumnName("ModifiedAuditOpinion");
			this.Property(t => t.FairValueChangeIncome).HasColumnName("FairValueChangeIncome");
			this.Property(t => t.NonoperatingIncome).HasColumnName("NonoperatingIncome");
			this.Property(t => t.NonoperatingExpense).HasColumnName("NonoperatingExpense");
			this.Property(t => t.IncomeTaxCost).HasColumnName("IncomeTaxCost");
			this.Property(t => t.UncertainedInvestmentLosses).HasColumnName("UncertainedInvestmentLosses");
			this.Property(t => t.MinorityProfit).HasColumnName("MinorityProfit");
			this.Property(t => t.NetProfit).HasColumnName("NetProfit");
			this.Property(t => t.NetInvestCashFlow).HasColumnName("NetInvestCashFlow");
			this.Property(t => t.NetFinanceCashFlow).HasColumnName("NetFinanceCashFlow");
			this.Property(t => t.ExchanRateChangeEffect).HasColumnName("ExchanRateChangeEffect");
			this.Property(t => t.EndPeriodCashEquivalent).HasColumnName("EndPeriodCashEquivalent");
			this.Property(t => t.TradingAssets).HasColumnName("TradingAssets");
			this.Property(t => t.InterestReceivables).HasColumnName("InterestReceivables");
			this.Property(t => t.DividendReceivables).HasColumnName("DividendReceivables");
			this.Property(t => t.AccountReceivables).HasColumnName("AccountReceivables");
			this.Property(t => t.OtherReceivable).HasColumnName("OtherReceivable");
			this.Property(t => t.Inventories).HasColumnName("Inventories");
			this.Property(t => t.TotalCurrentAssets).HasColumnName("TotalCurrentAssets");
			this.Property(t => t.HoldForSaleAssets).HasColumnName("HoldForSaleAssets");
			this.Property(t => t.HoldToMaturityInvestments).HasColumnName("HoldToMaturityInvestments");
			this.Property(t => t.InvestmentProperty).HasColumnName("InvestmentProperty");
			this.Property(t => t.LongtermEquityInvest).HasColumnName("LongtermEquityInvest");
			this.Property(t => t.IntangibleAssets).HasColumnName("IntangibleAssets");
			this.Property(t => t.TotalNonCurrentAssets).HasColumnName("TotalNonCurrentAssets");
			this.Property(t => t.ShortTermLoan).HasColumnName("ShortTermLoan");
			this.Property(t => t.TradingLiability).HasColumnName("TradingLiability");
			this.Property(t => t.SalariesPayable).HasColumnName("SalariesPayable");
			this.Property(t => t.DividendPayable).HasColumnName("DividendPayable");
			this.Property(t => t.TaxsPayable).HasColumnName("TaxsPayable");
			this.Property(t => t.InterestPayable).HasColumnName("InterestPayable");
			this.Property(t => t.OtherPayable).HasColumnName("OtherPayable");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.PaidInCapital).HasColumnName("PaidInCapital");
			this.Property(t => t.SurplusReserveFund).HasColumnName("SurplusReserveFund");
			this.Property(t => t.MinorityInterests).HasColumnName("MinorityInterests");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.TotalLiabilityAndEquity).HasColumnName("TotalLiabilityAndEquity");
			this.Property(t => t.TotalCurrentLiability).HasColumnName("TotalCurrentLiability");
			this.Property(t => t.FinancialExpense).HasColumnName("FinancialExpense");
			this.Property(t => t.InvestIncome).HasColumnName("InvestIncome");
			this.Property(t => t.TotalNonCurrentLiability).HasColumnName("TotalNonCurrentLiability");
			this.Property(t => t.NonCurrentLiabilityIn1Year).HasColumnName("NonCurrentLiabilityIn1Year");
			this.Property(t => t.NonRecurringProfitLoss).HasColumnName("NonRecurringProfitLoss");
		}
	}
}

