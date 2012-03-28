using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Merger
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> PreSchemePublDate { get; set; }
		public Nullable<System.DateTime> AnouncementPublDate { get; set; }
		public string MergedParty { get; set; }
		public Nullable<System.DateTime> FoundedDate { get; set; }
		public Nullable<decimal> RegiCapital { get; set; }
		public string MainBusinesses { get; set; }
		public Nullable<int> Industry { get; set; }
		public Nullable<System.DateTime> MergeBaseDate { get; set; }
		public Nullable<System.DateTime> AgreementDate { get; set; }
		public Nullable<double> ExchangeRateNumerator { get; set; }
		public Nullable<double> ExchangeRateDenominator { get; set; }
		public Nullable<decimal> ContraShares { get; set; }
		public Nullable<decimal> IssueShares { get; set; }
		public Nullable<decimal> StateSharesAdded { get; set; }
		public Nullable<decimal> LegalPersonSharesAdded { get; set; }
		public Nullable<decimal> IndividualSharesAdded { get; set; }
		public Nullable<decimal> ISharesAddedHoldingPeriod { get; set; }
		public Nullable<System.DateTime> ShareExchangeBeginDate { get; set; }
		public Nullable<System.DateTime> ShareExchangeEndDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<decimal> TotalAsset { get; set; }
		public Nullable<decimal> ShareholderEquity { get; set; }
		public Nullable<decimal> MainBusinessIncome { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<System.DateTime> ShareChangePublDate { get; set; }
		public Nullable<decimal> ShareCapitalBeforeMerge { get; set; }
		public Nullable<System.DateTime> ShareCustodyDate { get; set; }
		public Nullable<System.DateTime> ICChangeRegiDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public string ChangeStatement { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public Nullable<int> MergedCompanyCode { get; set; }
		public Nullable<int> MergedInnerCode { get; set; }
		public Nullable<System.DateTime> ExchangeRightRegDate { get; set; }
		public Nullable<System.DateTime> ShareListDate { get; set; }
	}
}

