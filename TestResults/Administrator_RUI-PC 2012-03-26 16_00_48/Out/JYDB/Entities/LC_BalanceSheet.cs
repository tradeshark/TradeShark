using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_BalanceSheet
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> CashEquivalents { get; set; }
		public Nullable<decimal> ShortTermInvest { get; set; }
		public Nullable<decimal> ShortTermInvestDevalProvi { get; set; }
		public Nullable<decimal> ShorttermInvestNetVal { get; set; }
		public Nullable<decimal> NotesReceivable { get; set; }
		public Nullable<decimal> DividendReceivable { get; set; }
		public Nullable<decimal> InterestReceivable { get; set; }
		public Nullable<decimal> AccountsReceivables { get; set; }
		public Nullable<decimal> NetAccountsReceivables { get; set; }
		public Nullable<decimal> OtherReceivables { get; set; }
		public Nullable<decimal> NetOtherReceivables { get; set; }
		public Nullable<decimal> BadDebtProvision { get; set; }
		public Nullable<decimal> NetReceivables { get; set; }
		public Nullable<decimal> AdvancePayment { get; set; }
		public Nullable<decimal> SubsidyReceivable { get; set; }
		public Nullable<decimal> FutureMargin { get; set; }
		public Nullable<decimal> SeatFeeReceivable { get; set; }
		public Nullable<decimal> Inventory { get; set; }
		public Nullable<decimal> ConstructionProject { get; set; }
		public Nullable<decimal> InventoryDevalProvision { get; set; }
		public Nullable<decimal> NetInventory { get; set; }
		public Nullable<decimal> InterdepartmentalAccounts { get; set; }
		public Nullable<decimal> DeferredExpense { get; set; }
		public Nullable<decimal> NetLossOfCurrentAssetToDeal { get; set; }
		public Nullable<decimal> LongtermInvestBondsDueIn1Year { get; set; }
		public Nullable<decimal> OtherCurrentAsset { get; set; }
		public Nullable<decimal> TotalCurrentAsset { get; set; }
		public Nullable<decimal> LongtermEquityInvest { get; set; }
		public Nullable<decimal> LongtermCreditInvest { get; set; }
		public Nullable<decimal> OtherLongtermInvest { get; set; }
		public Nullable<decimal> TotalLongtermInvest { get; set; }
		public Nullable<decimal> LongtermInvestDevalProvi { get; set; }
		public Nullable<decimal> LongtermInvestNetVal { get; set; }
		public Nullable<decimal> MergingPriceDiffirence { get; set; }
		public Nullable<decimal> EquityInvestDiff { get; set; }
		public Nullable<decimal> FixedAssetsCost { get; set; }
		public Nullable<decimal> AccumulatedDepreciation { get; set; }
		public Nullable<decimal> NetFixedAssetsVal { get; set; }
		public Nullable<decimal> FixedAssetsDevalProvi { get; set; }
		public Nullable<decimal> NetFixedAssetsMarketVal { get; set; }
		public Nullable<decimal> ConstructionMaterials { get; set; }
		public Nullable<decimal> ConstruInProcess { get; set; }
		public Nullable<decimal> ConstruInProcessDevalProvi { get; set; }
		public Nullable<decimal> FixedAssetsLiquidation { get; set; }
		public Nullable<decimal> NetLossOfFixedAssetToDeal { get; set; }
		public Nullable<decimal> TotalFixedAssets { get; set; }
		public Nullable<decimal> IntangibleAssets { get; set; }
		public Nullable<decimal> DeferredAssets { get; set; }
		public Nullable<decimal> PreoperateEexpense { get; set; }
		public Nullable<decimal> LongDeferredExpense { get; set; }
		public Nullable<decimal> OtherLongtermAssets { get; set; }
		public Nullable<decimal> NetTempFacility { get; set; }
		public Nullable<decimal> TotalIntangiAndOtherAssets { get; set; }
		public Nullable<decimal> DeferredTaxDebit { get; set; }
		public Nullable<decimal> TotalAsset { get; set; }
		public Nullable<decimal> ShortTermLoan { get; set; }
		public Nullable<decimal> NotesPayable { get; set; }
		public Nullable<decimal> AccountsPayable { get; set; }
		public Nullable<decimal> AdvanceReceipts { get; set; }
		public Nullable<decimal> ConsignedGoodAccounts { get; set; }
		public Nullable<decimal> WagesPayable { get; set; }
		public Nullable<decimal> WelfarePayable { get; set; }
		public Nullable<decimal> DividendsPayable { get; set; }
		public Nullable<decimal> TaxsPayable { get; set; }
		public Nullable<decimal> OthersPayable { get; set; }
		public Nullable<decimal> OtherAccountsPayable { get; set; }
		public Nullable<decimal> AccruedExpense { get; set; }
		public Nullable<decimal> EstimateLiability { get; set; }
		public Nullable<decimal> LongtermLiabilityDueIn1Year { get; set; }
		public Nullable<decimal> OtherCurrentLiability { get; set; }
		public Nullable<decimal> TotalCurrentLiability { get; set; }
		public Nullable<decimal> LongtermLoan { get; set; }
		public Nullable<decimal> BondsPayable { get; set; }
		public Nullable<decimal> LongtermAccountPayable { get; set; }
		public Nullable<decimal> SpecificAccountPayable { get; set; }
		public Nullable<decimal> HouseTurnoverFund { get; set; }
		public Nullable<decimal> OtherLongtermLiability { get; set; }
		public Nullable<decimal> TotalLongtermLiability { get; set; }
		public Nullable<decimal> DeferredTaxCredit { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public Nullable<decimal> MinorityInterests { get; set; }
		public Nullable<decimal> OthersLiabilityAndEquity { get; set; }
		public Nullable<decimal> ShareCapital { get; set; }
		public Nullable<decimal> RetiredCapital { get; set; }
		public Nullable<decimal> NetShareCapital { get; set; }
		public Nullable<decimal> CapitalReserveFund { get; set; }
		public Nullable<decimal> AddedCurrentCapital { get; set; }
		public Nullable<decimal> SurplusReserveFund { get; set; }
		public Nullable<decimal> CommonwealFund { get; set; }
		public Nullable<decimal> UnrecognisedInvestLoss { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> ForeignCurrencyReportConvDiff { get; set; }
		public Nullable<decimal> CapitalExchangeDiffAdjust { get; set; }
		public Nullable<decimal> TotalShareholderEquity { get; set; }
		public Nullable<decimal> TotalLiabilityAndEquity { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public Nullable<decimal> ShortTermBondPayable { get; set; }
	}
}

