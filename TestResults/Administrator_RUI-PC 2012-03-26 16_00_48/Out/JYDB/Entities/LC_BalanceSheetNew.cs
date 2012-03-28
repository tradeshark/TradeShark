using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_BalanceSheetNew
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public int Mark { get; set; }
		public int AccountingStandards { get; set; }
		public Nullable<decimal> CashEquivalents { get; set; }
		public Nullable<decimal> TradingAssets { get; set; }
		public Nullable<decimal> BillReceivable { get; set; }
		public Nullable<decimal> DividendReceivable { get; set; }
		public Nullable<decimal> InterestReceivable { get; set; }
		public Nullable<decimal> AccountReceivable { get; set; }
		public Nullable<decimal> OtherReceivable { get; set; }
		public Nullable<decimal> AdvancePayment { get; set; }
		public Nullable<decimal> Inventories { get; set; }
		public Nullable<decimal> BearerBiologicalAssets { get; set; }
		public Nullable<decimal> DeferredExpense { get; set; }
		public Nullable<decimal> NonCurrentAssetIn1Year { get; set; }
		public Nullable<decimal> OtherCurrentAssets { get; set; }
		public Nullable<decimal> CAExceptionalItems { get; set; }
		public Nullable<decimal> CAAdjustmentItems { get; set; }
		public Nullable<decimal> TotalCurrentAssets { get; set; }
		public Nullable<decimal> HoldForSaleAssets { get; set; }
		public Nullable<decimal> HoldToMaturityInvestments { get; set; }
		public Nullable<decimal> InvestmentProperty { get; set; }
		public Nullable<decimal> LongtermEquityInvest { get; set; }
		public Nullable<decimal> LongtermReceivableAccount { get; set; }
		public Nullable<decimal> FixedAssets { get; set; }
		public Nullable<decimal> ConstructionMaterials { get; set; }
		public Nullable<decimal> ConstruInProcess { get; set; }
		public Nullable<decimal> FixedAssetsLiquidation { get; set; }
		public Nullable<decimal> BiologicalAssets { get; set; }
		public Nullable<decimal> OilGasAssets { get; set; }
		public Nullable<decimal> IntangibleAssets { get; set; }
		public Nullable<decimal> DevelopmentExpenditure { get; set; }
		public Nullable<decimal> GoodWill { get; set; }
		public Nullable<decimal> LongDeferredExpense { get; set; }
		public Nullable<decimal> DeferredTaxAssets { get; set; }
		public Nullable<decimal> OtherNonCurrentAssets { get; set; }
		public Nullable<decimal> NCAExceptionalItems { get; set; }
		public Nullable<decimal> NCAAdjustmentItems { get; set; }
		public Nullable<decimal> TotalNonCurrentAssets { get; set; }
		public Nullable<decimal> AExceptionalItems { get; set; }
		public Nullable<decimal> AAdjustmentItems { get; set; }
		public Nullable<decimal> TotalAssets { get; set; }
		public Nullable<decimal> ShortTermLoan { get; set; }
		public Nullable<decimal> ImpawnedLoan { get; set; }
		public Nullable<decimal> TradingLiability { get; set; }
		public Nullable<decimal> NotesPayable { get; set; }
		public Nullable<decimal> AccountsPayable { get; set; }
		public Nullable<decimal> AdvanceReceipts { get; set; }
		public Nullable<decimal> SalariesPayable { get; set; }
		public Nullable<decimal> DividendPayable { get; set; }
		public Nullable<decimal> TaxsPayable { get; set; }
		public Nullable<decimal> InterestPayable { get; set; }
		public Nullable<decimal> OtherPayable { get; set; }
		public Nullable<decimal> AccruedExpense { get; set; }
		public Nullable<decimal> EstimateLiability { get; set; }
		public Nullable<decimal> DeferredProceeds { get; set; }
		public Nullable<decimal> NonCurrentLiabilityIn1Year { get; set; }
		public Nullable<decimal> OtherCurrentLiability { get; set; }
		public Nullable<decimal> CLExceptionalItems { get; set; }
		public Nullable<decimal> CLAdjustmentItems { get; set; }
		public Nullable<decimal> TotalCurrentLiability { get; set; }
		public Nullable<decimal> LongtermLoan { get; set; }
		public Nullable<decimal> BondsPayable { get; set; }
		public Nullable<decimal> LongtermAccountPayable { get; set; }
		public Nullable<decimal> SpecificAccountPayable { get; set; }
		public Nullable<decimal> DeferredTaxLiability { get; set; }
		public Nullable<decimal> OtherNonCurrentLiability { get; set; }
		public Nullable<decimal> NCLExceptionalItems { get; set; }
		public Nullable<decimal> NCLAdjustmentItems { get; set; }
		public Nullable<decimal> TotalNonCurrentLiability { get; set; }
		public Nullable<decimal> LExceptionalItems { get; set; }
		public Nullable<decimal> LAdjustmentItems { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> PaidInCapital { get; set; }
		public Nullable<decimal> CapitalReserveFund { get; set; }
		public Nullable<decimal> SurplusReserveFund { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> TreasuryStock { get; set; }
		public Nullable<decimal> ForeignCurrencyReportConvDiff { get; set; }
		public Nullable<decimal> MinorityInterests { get; set; }
		public Nullable<decimal> OtherItemsEffectingSE { get; set; }
		public Nullable<decimal> SEExceptionalItems { get; set; }
		public Nullable<decimal> SEAdjustmentItems { get; set; }
		public Nullable<decimal> TotalShareholderEquity { get; set; }
		public Nullable<decimal> SEWithoutMI { get; set; }
		public Nullable<decimal> LEExceptionalItems { get; set; }
		public Nullable<decimal> LEAdjustmentItems { get; set; }
		public Nullable<decimal> TotalLiabilityAndEquity { get; set; }
		public string SpecialFieldRemark { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> STBondsPayable { get; set; }
		public Nullable<decimal> UncertainedInvestmentLoss { get; set; }
		public Nullable<decimal> OtherReserves { get; set; }
		public Nullable<decimal> OrdinaryRiskReserveFund { get; set; }
		public Nullable<decimal> SpecificReserves { get; set; }
	}
}

