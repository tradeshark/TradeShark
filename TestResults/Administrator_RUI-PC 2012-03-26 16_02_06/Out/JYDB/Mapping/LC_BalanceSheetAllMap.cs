using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_BalanceSheetAllMap : EntityTypeConfiguration<LC_BalanceSheetAll>
	{
		public LC_BalanceSheetAllMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InfoPublDate, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.AccountingStandards, t.EnterpriseType, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.AccountingStandards)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.EnterpriseType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SpecialFieldRemark)
				.HasMaxLength(1000);
				
			// Table & Column Mappings
			this.ToTable("LC_BalanceSheetAll");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.BulletinType).HasColumnName("BulletinType");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.AccountingStandards).HasColumnName("AccountingStandards");
			this.Property(t => t.EnterpriseType).HasColumnName("EnterpriseType");
			this.Property(t => t.CashEquivalents).HasColumnName("CashEquivalents");
			this.Property(t => t.ClientDeposit).HasColumnName("ClientDeposit");
			this.Property(t => t.TradingAssets).HasColumnName("TradingAssets");
			this.Property(t => t.BillReceivable).HasColumnName("BillReceivable");
			this.Property(t => t.DividendReceivable).HasColumnName("DividendReceivable");
			this.Property(t => t.InterestReceivable).HasColumnName("InterestReceivable");
			this.Property(t => t.AccountReceivable).HasColumnName("AccountReceivable");
			this.Property(t => t.OtherReceivable).HasColumnName("OtherReceivable");
			this.Property(t => t.AdvancePayment).HasColumnName("AdvancePayment");
			this.Property(t => t.Inventories).HasColumnName("Inventories");
			this.Property(t => t.BearerBiologicalAssets).HasColumnName("BearerBiologicalAssets");
			this.Property(t => t.DeferredExpense).HasColumnName("DeferredExpense");
			this.Property(t => t.NonCurrentAssetIn1Year).HasColumnName("NonCurrentAssetIn1Year");
			this.Property(t => t.OtherCurrentAssets).HasColumnName("OtherCurrentAssets");
			this.Property(t => t.CAExceptionalItems).HasColumnName("CAExceptionalItems");
			this.Property(t => t.CAAdjustmentItems).HasColumnName("CAAdjustmentItems");
			this.Property(t => t.TotalCurrentAssets).HasColumnName("TotalCurrentAssets");
			this.Property(t => t.HoldForSaleAssets).HasColumnName("HoldForSaleAssets");
			this.Property(t => t.HoldToMaturityInvestments).HasColumnName("HoldToMaturityInvestments");
			this.Property(t => t.InvestmentProperty).HasColumnName("InvestmentProperty");
			this.Property(t => t.LongtermEquityInvest).HasColumnName("LongtermEquityInvest");
			this.Property(t => t.LongtermReceivableAccount).HasColumnName("LongtermReceivableAccount");
			this.Property(t => t.FixedAssets).HasColumnName("FixedAssets");
			this.Property(t => t.ConstructionMaterials).HasColumnName("ConstructionMaterials");
			this.Property(t => t.ConstruInProcess).HasColumnName("ConstruInProcess");
			this.Property(t => t.FixedAssetsLiquidation).HasColumnName("FixedAssetsLiquidation");
			this.Property(t => t.BiologicalAssets).HasColumnName("BiologicalAssets");
			this.Property(t => t.OilGasAssets).HasColumnName("OilGasAssets");
			this.Property(t => t.IntangibleAssets).HasColumnName("IntangibleAssets");
			this.Property(t => t.SeatCosts).HasColumnName("SeatCosts");
			this.Property(t => t.DevelopmentExpenditure).HasColumnName("DevelopmentExpenditure");
			this.Property(t => t.GoodWill).HasColumnName("GoodWill");
			this.Property(t => t.LongDeferredExpense).HasColumnName("LongDeferredExpense");
			this.Property(t => t.DeferredTaxAssets).HasColumnName("DeferredTaxAssets");
			this.Property(t => t.OtherNonCurrentAssets).HasColumnName("OtherNonCurrentAssets");
			this.Property(t => t.NCAExceptionalItems).HasColumnName("NCAExceptionalItems");
			this.Property(t => t.NCAAdjustmentItems).HasColumnName("NCAAdjustmentItems");
			this.Property(t => t.TotalNonCurrentAssets).HasColumnName("TotalNonCurrentAssets");
			this.Property(t => t.LoanAndAccountReceivables).HasColumnName("LoanAndAccountReceivables");
			this.Property(t => t.SettlementProvi).HasColumnName("SettlementProvi");
			this.Property(t => t.ClientProvi).HasColumnName("ClientProvi");
			this.Property(t => t.DepositInInterbank).HasColumnName("DepositInInterbank");
			this.Property(t => t.RMetal).HasColumnName("RMetal");
			this.Property(t => t.LendCapital).HasColumnName("LendCapital");
			this.Property(t => t.DerivativeAssets).HasColumnName("DerivativeAssets");
			this.Property(t => t.BoughtSellbackAssets).HasColumnName("BoughtSellbackAssets");
			this.Property(t => t.LoanAndAdvance).HasColumnName("LoanAndAdvance");
			this.Property(t => t.InsuranceReceivables).HasColumnName("InsuranceReceivables");
			this.Property(t => t.ReceivableSubrogationFee).HasColumnName("ReceivableSubrogationFee");
			this.Property(t => t.ReinsuranceReceivables).HasColumnName("ReinsuranceReceivables");
			this.Property(t => t.ReceivableUnearnedR).HasColumnName("ReceivableUnearnedR");
			this.Property(t => t.ReceivableClaimsR).HasColumnName("ReceivableClaimsR");
			this.Property(t => t.ReceivableLifeR).HasColumnName("ReceivableLifeR");
			this.Property(t => t.ReceivableLTHealthR).HasColumnName("ReceivableLTHealthR");
			this.Property(t => t.InsurerImpawnLoan).HasColumnName("InsurerImpawnLoan");
			this.Property(t => t.FixedDeposit).HasColumnName("FixedDeposit");
			this.Property(t => t.RefundableDeposit).HasColumnName("RefundableDeposit");
			this.Property(t => t.RefundableCapitalDeposit).HasColumnName("RefundableCapitalDeposit");
			this.Property(t => t.IndependenceAccountAssets).HasColumnName("IndependenceAccountAssets");
			this.Property(t => t.OtherAssets).HasColumnName("OtherAssets");
			this.Property(t => t.AExceptionalItems).HasColumnName("AExceptionalItems");
			this.Property(t => t.AAdjustmentItems).HasColumnName("AAdjustmentItems");
			this.Property(t => t.TotalAssets).HasColumnName("TotalAssets");
			this.Property(t => t.ShortTermLoan).HasColumnName("ShortTermLoan");
			this.Property(t => t.ImpawnedLoan).HasColumnName("ImpawnedLoan");
			this.Property(t => t.TradingLiability).HasColumnName("TradingLiability");
			this.Property(t => t.NotesPayable).HasColumnName("NotesPayable");
			this.Property(t => t.AccountsPayable).HasColumnName("AccountsPayable");
			this.Property(t => t.STBondsPayable).HasColumnName("STBondsPayable");
			this.Property(t => t.AdvanceReceipts).HasColumnName("AdvanceReceipts");
			this.Property(t => t.SalariesPayable).HasColumnName("SalariesPayable");
			this.Property(t => t.DividendPayable).HasColumnName("DividendPayable");
			this.Property(t => t.TaxsPayable).HasColumnName("TaxsPayable");
			this.Property(t => t.InterestPayable).HasColumnName("InterestPayable");
			this.Property(t => t.OtherPayable).HasColumnName("OtherPayable");
			this.Property(t => t.AccruedExpense).HasColumnName("AccruedExpense");
			this.Property(t => t.DeferredProceeds).HasColumnName("DeferredProceeds");
			this.Property(t => t.NonCurrentLiabilityIn1Year).HasColumnName("NonCurrentLiabilityIn1Year");
			this.Property(t => t.OtherCurrentLiability).HasColumnName("OtherCurrentLiability");
			this.Property(t => t.CLExceptionalItems).HasColumnName("CLExceptionalItems");
			this.Property(t => t.CLAdjustmentItems).HasColumnName("CLAdjustmentItems");
			this.Property(t => t.TotalCurrentLiability).HasColumnName("TotalCurrentLiability");
			this.Property(t => t.LongtermLoan).HasColumnName("LongtermLoan");
			this.Property(t => t.BondsPayable).HasColumnName("BondsPayable");
			this.Property(t => t.LongtermAccountPayable).HasColumnName("LongtermAccountPayable");
			this.Property(t => t.SpecificAccountPayable).HasColumnName("SpecificAccountPayable");
			this.Property(t => t.EstimateLiability).HasColumnName("EstimateLiability");
			this.Property(t => t.DeferredTaxLiability).HasColumnName("DeferredTaxLiability");
			this.Property(t => t.OtherNonCurrentLiability).HasColumnName("OtherNonCurrentLiability");
			this.Property(t => t.NCLExceptionalItems).HasColumnName("NCLExceptionalItems");
			this.Property(t => t.NCLAdjustmentItems).HasColumnName("NCLAdjustmentItems");
			this.Property(t => t.TotalNonCurrentLiability).HasColumnName("TotalNonCurrentLiability");
			this.Property(t => t.BorrowingFromCentralBank).HasColumnName("BorrowingFromCentralBank");
			this.Property(t => t.DepositOfInterbank).HasColumnName("DepositOfInterbank");
			this.Property(t => t.BorrowingCapital).HasColumnName("BorrowingCapital");
			this.Property(t => t.DerivativeLiability).HasColumnName("DerivativeLiability");
			this.Property(t => t.SoldBuybackSecuProceeds).HasColumnName("SoldBuybackSecuProceeds");
			this.Property(t => t.Deposit).HasColumnName("Deposit");
			this.Property(t => t.ProxySecuProceeds).HasColumnName("ProxySecuProceeds");
			this.Property(t => t.SubIssueSecuProceeds).HasColumnName("SubIssueSecuProceeds");
			this.Property(t => t.DepositsReceived).HasColumnName("DepositsReceived");
			this.Property(t => t.AdvanceInsurance).HasColumnName("AdvanceInsurance");
			this.Property(t => t.CommissionPayable).HasColumnName("CommissionPayable");
			this.Property(t => t.ReinsurancePayables).HasColumnName("ReinsurancePayables");
			this.Property(t => t.CompensationPayable).HasColumnName("CompensationPayable");
			this.Property(t => t.PolicyDividendPayable).HasColumnName("PolicyDividendPayable");
			this.Property(t => t.InsurerDepositInvestment).HasColumnName("InsurerDepositInvestment");
			this.Property(t => t.UnearnedPremiumReserve).HasColumnName("UnearnedPremiumReserve");
			this.Property(t => t.OutstandingClaimReserve).HasColumnName("OutstandingClaimReserve");
			this.Property(t => t.LifeInsuranceReserve).HasColumnName("LifeInsuranceReserve");
			this.Property(t => t.LTHealthInsuranceLR).HasColumnName("LTHealthInsuranceLR");
			this.Property(t => t.IndependenceLiability).HasColumnName("IndependenceLiability");
			this.Property(t => t.OtherLiability).HasColumnName("OtherLiability");
			this.Property(t => t.LExceptionalItems).HasColumnName("LExceptionalItems");
			this.Property(t => t.LAdjustmentItems).HasColumnName("LAdjustmentItems");
			this.Property(t => t.TotalLiability).HasColumnName("TotalLiability");
			this.Property(t => t.PaidInCapital).HasColumnName("PaidInCapital");
			this.Property(t => t.CapitalReserveFund).HasColumnName("CapitalReserveFund");
			this.Property(t => t.SurplusReserveFund).HasColumnName("SurplusReserveFund");
			this.Property(t => t.RetainedProfit).HasColumnName("RetainedProfit");
			this.Property(t => t.TreasuryStock).HasColumnName("TreasuryStock");
			this.Property(t => t.OrdinaryRiskReserveFund).HasColumnName("OrdinaryRiskReserveFund");
			this.Property(t => t.ForeignCurrencyReportConvDiff).HasColumnName("ForeignCurrencyReportConvDiff");
			this.Property(t => t.UncertainedInvestmentLoss).HasColumnName("UncertainedInvestmentLoss");
			this.Property(t => t.OtherReserves).HasColumnName("OtherReserves");
			this.Property(t => t.SpecificReserves).HasColumnName("SpecificReserves");
			this.Property(t => t.SEExceptionalItems).HasColumnName("SEExceptionalItems");
			this.Property(t => t.SEAdjustmentItems).HasColumnName("SEAdjustmentItems");
			this.Property(t => t.SEWithoutMI).HasColumnName("SEWithoutMI");
			this.Property(t => t.MinorityInterests).HasColumnName("MinorityInterests");
			this.Property(t => t.OtherItemsEffectingSE).HasColumnName("OtherItemsEffectingSE");
			this.Property(t => t.TotalShareholderEquity).HasColumnName("TotalShareholderEquity");
			this.Property(t => t.LEExceptionalItems).HasColumnName("LEExceptionalItems");
			this.Property(t => t.LEAdjustmentItems).HasColumnName("LEAdjustmentItems");
			this.Property(t => t.TotalLiabilityAndEquity).HasColumnName("TotalLiabilityAndEquity");
			this.Property(t => t.SpecialFieldRemark).HasColumnName("SpecialFieldRemark");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

