using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_IncomeStatementAll
	{
		public long ID { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public int AccountingStandards { get; set; }
		public int EnterpriseType { get; set; }
		public Nullable<decimal> TotalOperatingRevenue { get; set; }
		public Nullable<decimal> OperatingRevenue { get; set; }
		public Nullable<decimal> NetInterestIncome { get; set; }
		public Nullable<decimal> InterestIncome { get; set; }
		public Nullable<decimal> InterestExpense { get; set; }
		public Nullable<decimal> NetCommissionIncome { get; set; }
		public Nullable<decimal> CommissionIncome { get; set; }
		public Nullable<decimal> CommissionExpense { get; set; }
		public Nullable<decimal> NetProxySecuIncome { get; set; }
		public Nullable<decimal> NetSubIssueSecuIncome { get; set; }
		public Nullable<decimal> NetTrustIncome { get; set; }
		public Nullable<decimal> PremiumsEarned { get; set; }
		public Nullable<decimal> PremiumsIncome { get; set; }
		public Nullable<decimal> ReinsuranceIncome { get; set; }
		public Nullable<decimal> Reinsurance { get; set; }
		public Nullable<decimal> UnearnedPremiumReserve { get; set; }
		public Nullable<decimal> OtherOperatingRevenue { get; set; }
		public Nullable<decimal> SpecialItemsOR { get; set; }
		public Nullable<decimal> AdjustmentItemsOR { get; set; }
		public Nullable<decimal> TotalOperatingCost { get; set; }
		public Nullable<decimal> OperatingPayout { get; set; }
		public Nullable<decimal> RefundedPremiums { get; set; }
		public Nullable<decimal> CompensationExpense { get; set; }
		public Nullable<decimal> AmortizationExpense { get; set; }
		public Nullable<decimal> PremiumReserve { get; set; }
		public Nullable<decimal> AmortizationPremiumReserve { get; set; }
		public Nullable<decimal> PolicyDividendPayout { get; set; }
		public Nullable<decimal> ReinsuranceCost { get; set; }
		public Nullable<decimal> OperatingAndAdminExpense { get; set; }
		public Nullable<decimal> AmortizationReinsuranceCost { get; set; }
		public Nullable<decimal> InsuranceCommissionExpense { get; set; }
		public Nullable<decimal> OtherOperatingCost { get; set; }
		public Nullable<decimal> OperatingCost { get; set; }
		public Nullable<decimal> OperatingTaxSurcharges { get; set; }
		public Nullable<decimal> OperatingExpense { get; set; }
		public Nullable<decimal> AdministrationExpense { get; set; }
		public Nullable<decimal> FinancialExpense { get; set; }
		public Nullable<decimal> AssetImpairmentLoss { get; set; }
		public Nullable<decimal> SpecialItemsTOC { get; set; }
		public Nullable<decimal> AdjustmentItemsTOC { get; set; }
		public Nullable<decimal> OtherNetRevenue { get; set; }
		public Nullable<decimal> FairValueChangeIncome { get; set; }
		public Nullable<decimal> InvestIncome { get; set; }
		public Nullable<decimal> InvestIncomeAssociates { get; set; }
		public Nullable<decimal> ExchangeIncome { get; set; }
		public Nullable<decimal> OtherItemsEffectingOP { get; set; }
		public Nullable<decimal> AdjustedItemsEffectingOP { get; set; }
		public Nullable<decimal> OperatingProfit { get; set; }
		public Nullable<decimal> NonoperatingIncome { get; set; }
		public Nullable<decimal> NonoperatingExpense { get; set; }
		public Nullable<decimal> NonCurrentAssetssDealLoss { get; set; }
		public Nullable<decimal> OtherItemsEffectingTP { get; set; }
		public Nullable<decimal> AdjustedItemsEffectingTP { get; set; }
		public Nullable<decimal> TotalProfit { get; set; }
		public Nullable<decimal> IncomeTaxCost { get; set; }
		public Nullable<decimal> UncertainedInvestmentLosses { get; set; }
		public Nullable<decimal> OtherItemsEffectingNP { get; set; }
		public Nullable<decimal> AdjustedItemsEffectingNP { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> NPParentCompanyOwners { get; set; }
		public Nullable<decimal> MinorityProfit { get; set; }
		public Nullable<decimal> OtherItemsEffectingNPP { get; set; }
		public Nullable<decimal> AdjustedItemsEffectingNPP { get; set; }
		public Nullable<decimal> OtherCompositeIncome { get; set; }
		public Nullable<decimal> AdjustedItemsEffectingCI { get; set; }
		public Nullable<decimal> TotalCompositeIncome { get; set; }
		public Nullable<decimal> CIParentCompanyOwners { get; set; }
		public Nullable<decimal> CIMinorityOwners { get; set; }
		public Nullable<decimal> AdjustedItemsEffectingPCI { get; set; }
		public Nullable<decimal> BasicEPS { get; set; }
		public Nullable<decimal> DilutedEPS { get; set; }
		public string SpecialFieldRemark { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

