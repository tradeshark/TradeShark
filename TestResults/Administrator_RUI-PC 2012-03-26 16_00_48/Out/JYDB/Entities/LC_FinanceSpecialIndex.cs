using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_FinanceSpecialIndex
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public int DataType { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> TotalDeposit { get; set; }
		public Nullable<decimal> LDepositAndIBorrowing { get; set; }
		public Nullable<decimal> LongtermDeposit { get; set; }
		public Nullable<decimal> InterbankBorrowing { get; set; }
		public Nullable<decimal> TotalLoan { get; set; }
		public Nullable<decimal> ShortTermLoan { get; set; }
		public Nullable<decimal> ImOutportForeiCurrReserv { get; set; }
		public Nullable<decimal> Discount { get; set; }
		public Nullable<decimal> MidLongtermLoan { get; set; }
		public Nullable<decimal> OverrideLoan { get; set; }
		public Nullable<decimal> NonAccrualLoan { get; set; }
		public Nullable<decimal> BadLoan { get; set; }
		public Nullable<decimal> DeadLoan { get; set; }
		public Nullable<decimal> CoreCapital { get; set; }
		public Nullable<decimal> SupplementaryCapital { get; set; }
		public Nullable<decimal> CapitalAdequacyRatio { get; set; }
		public Nullable<decimal> CurrentRatioRMB { get; set; }
		public Nullable<decimal> CurrentRatioFC { get; set; }
		public Nullable<decimal> DepositLoanRatioRMB { get; set; }
		public Nullable<decimal> DepositLoanRatioFC { get; set; }
		public Nullable<decimal> MidLongtermLoanRatioRMB { get; set; }
		public Nullable<decimal> MidLongtermLoanRatioFC { get; set; }
		public Nullable<decimal> BorrowingRatio { get; set; }
		public Nullable<decimal> LendOutRatio { get; set; }
		public Nullable<decimal> IBusinessBorrowingRatio { get; set; }
		public Nullable<decimal> NonPerformingRatio { get; set; }
		public Nullable<decimal> IntrerestCollectionRatio { get; set; }
		public Nullable<decimal> Single1stLoanRatio { get; set; }
		public Nullable<decimal> SingleBig10LoanRatio { get; set; }
		public Nullable<decimal> NormalCredit { get; set; }
		public Nullable<decimal> NormalLoan { get; set; }
		public Nullable<decimal> NormalDiscount { get; set; }
		public Nullable<decimal> AttentionCredit { get; set; }
		public Nullable<decimal> SubstandardCredit { get; set; }
		public Nullable<decimal> DoubtfulCredit { get; set; }
		public Nullable<decimal> LossCredit { get; set; }
		public Nullable<decimal> CurrentAsset { get; set; }
		public Nullable<decimal> ProxySecu { get; set; }
		public Nullable<decimal> TrustCapital { get; set; }
		public Nullable<decimal> CurrentLiability { get; set; }
		public Nullable<decimal> NetCapital { get; set; }
		public Nullable<decimal> OperatingIncome { get; set; }
		public Nullable<decimal> CommissionIncome { get; set; }
		public Nullable<decimal> SelfSecuSpreadIncome { get; set; }
		public Nullable<decimal> SecuIssueSpreadIncome { get; set; }
		public Nullable<decimal> OperatingExpense { get; set; }
		public Nullable<decimal> ROE { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> BadAccountReserve { get; set; }
		public Nullable<decimal> DefaultLoan { get; set; }
		public Nullable<decimal> SingleBig10Loan { get; set; }
		public Nullable<decimal> NormalCreditProportion { get; set; }
		public Nullable<decimal> AttentionCreditProp { get; set; }
		public Nullable<decimal> SubstandardCreditProp { get; set; }
		public Nullable<decimal> DoubtfulCreditProp { get; set; }
		public Nullable<decimal> LossCreditProp { get; set; }
		public Nullable<decimal> CoreCapitalAdequacyRatio { get; set; }
		public Nullable<decimal> DepositLoanRatioRMBFC { get; set; }
		public Nullable<decimal> OperateBTBFundRatio { get; set; }
		public Nullable<decimal> BadAssetRatio { get; set; }
		public Nullable<decimal> BLoanCoverRatio { get; set; }
		public Nullable<decimal> OverReserveRateRMB { get; set; }
		public Nullable<decimal> NetCapitalBank { get; set; }
		public Nullable<decimal> WeightedRiskNetAssets { get; set; }
		public Nullable<decimal> LiquidityGap90 { get; set; }
		public Nullable<decimal> InvestmentTARatio { get; set; }
		public Nullable<decimal> LoanTARatio { get; set; }
		public Nullable<decimal> OperateAssetTARatio { get; set; }
		public Nullable<decimal> ProfitAssetTARatio { get; set; }
		public Nullable<decimal> ROA { get; set; }
		public Nullable<decimal> ROEBank { get; set; }
		public Nullable<decimal> LoanInterestTERatio { get; set; }
		public Nullable<decimal> DepInterestTCRatio { get; set; }
		public Nullable<decimal> CostEarningRatio { get; set; }
		public Nullable<decimal> InterestEarningAssets { get; set; }
		public Nullable<decimal> AvgInterestFromAS { get; set; }
		public Nullable<decimal> AvgInterestFromIL { get; set; }
		public Nullable<decimal> InterestAvAcAssetRatio { get; set; }
		public Nullable<decimal> AvgAnnLoanInterest { get; set; }
		public Nullable<decimal> AvgAnnDepoInterest { get; set; }
		public Nullable<decimal> AvgDLInterestSpread { get; set; }
		public Nullable<decimal> NetInterestSpreadReturn { get; set; }
		public Nullable<decimal> AvgBalanceShortTermLoan { get; set; }
		public Nullable<decimal> AvgIRateShortTermLoan { get; set; }
		public Nullable<decimal> AvgBalanceLongTermLoan { get; set; }
		public Nullable<decimal> AvgIRateLongTermLoan { get; set; }
		public Nullable<decimal> AvgBalanceEDemandDeposit { get; set; }
		public Nullable<decimal> AvgIRateEDemandDeposit { get; set; }
		public Nullable<decimal> AvgBalanceEFixedDeposit { get; set; }
		public Nullable<decimal> AvgIRateEFixedDeposit { get; set; }
		public Nullable<decimal> AvgBalaEnterpriseDeposit { get; set; }
		public Nullable<decimal> AvgIREnterpriseDeposit { get; set; }
		public Nullable<decimal> AvgBalanceCurrentDeposit { get; set; }
		public Nullable<decimal> AvgIRateCurrentDeposit { get; set; }
		public Nullable<decimal> AvgBalanceTimeDeposit { get; set; }
		public Nullable<decimal> AvgIRateTimetDeposit { get; set; }
		public Nullable<decimal> AvgBalanceSavingsDeposit { get; set; }
		public Nullable<decimal> AvgIRateSavingsDeposit { get; set; }
		public Nullable<decimal> InterestBearingLiability { get; set; }
		public Nullable<decimal> IBLsToTotalLiabilities { get; set; }
		public Nullable<int> Mark { get; set; }
		public Nullable<decimal> OnOffAassetsWithin90D { get; set; }
	}
}

